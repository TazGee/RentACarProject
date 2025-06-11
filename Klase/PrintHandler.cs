using RentACar.Properties;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RentACar.Klase
{
    public class PrintHandler
    {
        private PrintDocument dokument = new PrintDocument();
        Racun racun;
        DatabaseHandler database;

        public PrintHandler(Racun racun, DatabaseHandler database)
        {
            this.racun = racun;
            this.database = database;
        }

        public void OdstampajRacun()
        {
            dokument.PrintPage -= PagePrintHandler;
            dokument.PrintPage += PagePrintHandler;

            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = dokument;
            dialog.Width = 1000;
            dialog.Height = 700;

            Form formaPrintanja = dialog;
            formaPrintanja.TopMost = true;

            dialog.ShowDialog();
        }

        void PagePrintHandler(object sender, PrintPageEventArgs e)
        {
            DateTimeHandler handler = new DateTimeHandler();

            Graphics g = e.Graphics;
            Font fontMiniNaslova = new Font("Arial", 13, FontStyle.Bold);
            Font fontPodataka = new Font("Arial", 12);
            float y = 40;
            float left = e.MarginBounds.Left;
            int normalSpace = 20, naslovSpace = 70, miniNaslovSpace = 24;

            string naslov = "- RAČUN -";
            Font fontNaslov = new Font("Arial", 30, FontStyle.Bold);
            SizeF tekstVelicina = g.MeasureString(naslov, fontNaslov);
            float xCentar = e.MarginBounds.Left + (e.MarginBounds.Width - tekstVelicina.Width) / 2;
            g.DrawString(naslov, fontNaslov, Brushes.Black, xCentar, y);
            y += 70;

            g.DrawString("Podaci o računu", fontMiniNaslova, Brushes.Black, left, y);
            y += miniNaslovSpace;
            Korisnik k = null;
            for (int i = 0; i < database.listaKorisnika.Count; i++) { if (database.listaKorisnika[i].id == racun.izdavac) { k = database.listaKorisnika[i]; break; } }
            g.DrawString(" - Izdavač računa: " + k.ime, fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - Datum: " + handler.FormirajDatum(racun.datum) + ".", fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - Vreme: " + handler.FormirajVreme(racun.vreme), fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - ID Računa: " + racun.id, fontPodataka, Brushes.Black, left, y);
            y += 45;

            g.DrawString("Podaci o mušteriji", fontMiniNaslova, Brushes.Black, left, y);
            y += miniNaslovSpace;
            g.DrawString(" - Ime i Prezime: " + racun.ime, fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - Broj telefona: " + racun.telefon, fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - E-mail: " + racun.email, fontPodataka, Brushes.Black, left, y);
            y += 45;

            g.DrawString("Podaci o iznajmljivanju", fontMiniNaslova, Brushes.Black, left, y);
            y += miniNaslovSpace;
            Vozilo v = null;
            for(int i = 0; i < database.listaVozila.Count; i++) { if (database.listaVozila[i].id == racun.vozilo) { v = database.listaVozila[i]; break; } }
            g.DrawString(" - Iznajmljeno vozilo: " + v.naziv + ", " + v.tablice + ", " + v.cena + "€/dan", fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - Iznajmljen(od-do): " + handler.FormirajDatum(racun.pocetak) + " - " + handler.FormirajDatum(racun.kraj) + ".", fontPodataka, Brushes.Black, left, y);
            y += normalSpace;
            g.DrawString(" - Konacna cena: " + racun.cena + "€", fontPodataka, Brushes.Black, left, y);
            y += naslovSpace;

            g.DrawString("Slika vozila:", fontMiniNaslova, Brushes.Black, left, y);
            y += miniNaslovSpace;

            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(v.slikaPath);
                using (var stream = new MemoryStream(data))
                {
                    g.DrawImage(Image.FromStream(stream), left, y, (int)(e.MarginBounds.Width), (int)(e.MarginBounds.Width / 3 * 2));
                }
            }

            g.DrawImage(Resources.rent_a_car_talija_logo, e.MarginBounds.Right-180, e.MarginBounds.Bottom-50, 250, 120);

            y += (int)(e.MarginBounds.Width / 3 * 2) + 50;
            g.DrawString("Potpis izdavača:", fontPodataka, Brushes.Black, left, y);
            y += 40;
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, left, y, left + 150, y);
        }
    }
}
