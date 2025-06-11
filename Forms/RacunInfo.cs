using RentACar.Klase;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;
using System.Net;
using System.Diagnostics;

namespace RentACar
{
    public partial class RacunInfo: Form
    {
        DatabaseHandler database;
        Racun racun;
        IstorijaRacuna racuni;

        public RacunInfo(DatabaseHandler database, Racun racun, IstorijaRacuna racuni)
        {
            InitializeComponent();
            this.database = database;
            this.racun = racun;
            this.racuni = racuni;
            HandleUI();
            FormClosed += ZatvaranjeForme;
        }
        void ZatvaranjeForme(object sender, EventArgs e)
        {
            FormClosed -= ZatvaranjeForme;
            print.Click -= print_Click; 

            if (slika.BackgroundImage != null)
                slika.BackgroundImage.Dispose();

            if (slikaAuta.BackgroundImage != null)
                slikaAuta.BackgroundImage.Dispose();

            racuni.ClearRacunInfo();

            database = null;
            racun = null;
            racuni = null;

            Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        Vozilo PronadjiVozilo(int id)
        {
            Vozilo v = null;
            for (int i = 0; i < database.listaVozila.Count; i++)
            {
                if (database.listaVozila[i].id == id)
                {
                    v = database.listaVozila[i];
                    break;
                }
            }
            return v;
        }

        Korisnik PronadjiKorisnika(int id)
        {
            Korisnik k = null;
            for (int i = 0; i < database.listaKorisnika.Count; i++)
            {
                if (database.listaKorisnika[i].id == id)
                {
                    k = database.listaKorisnika[i];
                    break;
                }
            }
            return k;
        }

        public void HandleUI()
        {
            DateTimeHandler handler = new DateTimeHandler();

            Vozilo v = PronadjiVozilo(racun.vozilo);
            Korisnik k = PronadjiKorisnika(racun.izdavac);
            
            if (v == null || k == null)
            {
                MessageBox.Show("Ovaj račun nije validan! U databazi ne postoji\nnijedan automobil ili nalog vezan za ovaj račun!", "Greška računa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
            izdavacLabel.Text = "Ime i Prezime: " + k.ime + "\nPozicija: " + k.pozicija + "\nDatum i vreme: " + handler.FormirajDatum(racun.datum) + " " + handler.FormirajVreme(racun.vreme);

            byte[] data;

            using (var client = new WebClient())
            {
                data = client.DownloadData(k.slikaPath);
                using (var stream = new MemoryStream(data))
                {
                    var img = Image.FromStream(stream);
                    slika.BackgroundImage = new Bitmap(img);
                    img.Dispose();
                }
            }

            imeKorisnika.Text = racun.ime;
            telefonKorisnika.Text = racun.telefon;
            emailKorisnika.Text = racun.email;

            using (var client = new WebClient())
            {
                data = client.DownloadData(v.slikaPath);
                using (var stream = new MemoryStream(data))
                {
                    var img = Image.FromStream(stream);
                    slikaAuta.BackgroundImage = new Bitmap(img);
                    img.Dispose();
                }
            }

            brojSedista.Text = v.brojSedista.ToString();
            brojVrata.Text = v.brojVrata.ToString();
            cena.Text = v.cena.ToString();
            kubikaza.Text = v.kubikaza;
            tipGoriva.Text = v.tipGoriva;
            tipMenjaca.Text = v.tipMenjaca;

            vremeIznajmljivanja.Text = handler.FormirajDatum(racun.pocetak) + " - " + handler.FormirajDatum(racun.kraj) + ".";
            cenaiznajmljivanja.Text = "Konačna cena: " + racun.cena + "€";

            label5.Text = "Vozilo: " + v.naziv;

            idracuna.Text = "ID Računa: " + racun.id;
        }

        private void print_Click(object sender, System.EventArgs e)
        {
            PrintHandler print = new PrintHandler(racun, database);
            print.OdstampajRacun();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
