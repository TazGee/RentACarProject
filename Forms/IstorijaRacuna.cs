using RentACar.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using RentACar.Klase;

namespace RentACar
{
    public partial class IstorijaRacuna: Form
    {
        DatabaseHandler database;
        List<object> listaSvihObjekata = new List<object>();
        MainMenu menu;

        List<PictureBox> listaSlika = new List<PictureBox>();

        public IstorijaRacuna(DatabaseHandler database, MainMenu menu)
        {
            InitializeComponent();
            this.database = database;

            glavniPanelZaRacune.RowStyles.Add(new RowStyle());
            glavniPanelZaRacune.RowStyles[0].Height = 65;
            glavniPanelZaRacune.RowStyles[0].SizeType = SizeType.Absolute;

            PrikaziRacune();
            Resize += FormResize;
            FormClosed += ZatvaranjeForme;
            this.menu = menu;
        }

        async void PrikaziRacune()
        {
            await database.UcitajVozila("", true, true);

            foreach (object o in listaSvihObjekata)
            {
                if (o is Control control)
                {
                    control.Parent?.Controls.Remove(control);
                    control.Dispose();
                }
            }

            listaSvihObjekata.Clear();
            listaSlika.Clear();

            if (database.listaRacuna.Count == 0) return;

            foreach (Racun r in database.listaRacuna)
            {
                HandleUI(r);
            }
        }

        void HandleUI(Racun r)
        {
            // - KREIRANJE PANELA - //
            FlowLayoutPanel glavniPanel = CreateFlowPanel(BorderStyle.FixedSingle, FlowDirection.LeftToRight, 100, 955);
            glavniPanel.Anchor = AnchorStyles.Top;
            listaRacunaPanel.Controls.Add(glavniPanel);

            // - KREIRANJE SLIKE - //
            PictureBox slika = CreateImage();
            glavniPanel.Controls.Add(slika);
            slika.Click += new EventHandler(PrikaziRacunInfo);

            // - KREIRANJE NOVOG PANELA ZA OSTALE PODATKE - //
            TableLayoutPanel mainInfoPanel = CreateTablePanel(BorderStyle.None, 2, 1);
            glavniPanel.Controls.Add(mainInfoPanel);
            mainInfoPanel.Dock = DockStyle.Fill;

            // - GORNJI PANEL - //
            FlowLayoutPanel gornjiPanel = CreateFlowPanel(BorderStyle.FixedSingle, FlowDirection.LeftToRight, 70, 800);
            gornjiPanel.Anchor = AnchorStyles.Top;
            mainInfoPanel.Controls.Add(gornjiPanel, 0, 0);
            gornjiPanel.BorderStyle = BorderStyle.None;
            gornjiPanel.Padding = new Padding(0);

            // - NAZIV RACUNA - //
            Label naziv = CreateNaziv("Broj računa: " + r.id, 300);
            gornjiPanel.Controls.Add(naziv);
            naziv.Font = new Font(naziv.Font.FontFamily, 16, FontStyle.Bold);

            // - AKTIVNOST RACUNA - //
            if (r.IzracunajAktivnost())
            {
                Label aktivnost = CreateNaziv("Aktivan", 200);
                gornjiPanel.Controls.Add(aktivnost);
                aktivnost.Font = new Font(aktivnost.Font.FontFamily, 16, FontStyle.Bold);
                aktivnost.ForeColor = Color.Green;
            }

            // - INFO RACUNA - //
            string imeVozila = "Nepoznato";
            foreach (Vozilo v in database.listaVozila)
            {
                if (v.id == r.vozilo)
                {
                    imeVozila = v.naziv;
                    break;
                }
            }
            string date = FormirajDatum(r.pocetak) + " - " + FormirajDatum(r.kraj) + ".";
            Label info = CreateNaziv("    Korisnik: " + r.ime + "   Vozilo: " + imeVozila + "   Iznajmljen(od-do): " + date, 700);
            mainInfoPanel.Controls.Add(info, 0, 1);
            info.Font = new Font(info.Font.FontFamily, 11, info.Font.Style);
        }

        void PrikaziRacunInfo(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listaSlika.Count; i++)
            {
                if (sender == listaSlika[i]) break;
            }

            database.UcitavanjeFormShow("Učitavanje informacija", "Učitavanje informacija o računu...");
            new RacunInfo(database, database.listaRacuna[i], this).Show();
            database.UcitavanjeFormHide();

            Hide();
        }

        public void ClearRacunInfo()
        {
            Show();
        }

        async void ZatvaranjeForme(object sender, EventArgs e)
        {
            await database.UcitajRacune("", "", false);
            menu.ClearIstorija();
        }
        void FormResize(object sender, EventArgs e)
        {
            glavniPanelZaRacune.Height = Height;
        }
        string FormirajDatum(int datum)
        {
            int dan, mesec, godina;
            dan = (datum - datum / 100 * 100);
            mesec = (datum - datum / 10000 * 10000) / 100;
            godina = datum / 10000;
            if (dan < 10) { dan = int.Parse("0" + dan); }
            if (mesec < 10) { mesec = int.Parse("0" + mesec); }
            string str = dan+ "." + mesec + "." + godina;
            return str;
        }

        public Label CreateNaziv(string str, int width)
        {
            Label naziv = new Label();
            naziv.Text = str;
            naziv.AutoSize = false;
            naziv.Width = width;
            naziv.Height = 40;
            naziv.TextAlign = ContentAlignment.MiddleLeft;
            listaSvihObjekata.Add(naziv);
            return naziv;
        }
        public FlowLayoutPanel CreateFlowPanel(BorderStyle b, FlowDirection f, int height, int width)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Width = width;
            panel.Height = height;
            panel.Padding = new Padding(5);
            panel.BorderStyle = b;
            panel.FlowDirection = f;
            panel.BackColor = Color.WhiteSmoke;
            panel.AutoSize = false;
            listaSvihObjekata.Add(panel);
            return panel;
        }

        public TableLayoutPanel CreateTablePanel(BorderStyle b, int r, int c)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.AutoSize = false;
            panel.RowCount = r;
            panel.ColumnCount = c;
            panel.Width = listaRacunaPanel.Width - 155;
            panel.Height = 85;
            panel.Margin = new Padding(5);
            panel.BorderStyle = b;
            panel.RowStyles.Add(new RowStyle());
            panel.RowStyles[0].Height = 42;
            panel.RowStyles[0].SizeType = SizeType.Absolute;
            listaSvihObjekata.Add(panel);
            return panel;
        }

        public PictureBox CreateImage()
        {
            PictureBox slika = new PictureBox();
            slika.Width = 85;
            slika.Height = 85;
            slika.SizeMode = PictureBoxSizeMode.StretchImage;
            slika.Anchor = AnchorStyles.Left;
            slika.Image = Resources.dokument;
            slika.BackColor = Color.Transparent;
            listaSvihObjekata.Add(slika);
            listaSlika.Add(slika);
            return slika;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await database.UcitajRacune(imeText.Text, nazivVozila.Text, aktivni.Checked);
            PrikaziRacune();
        }
    }
}
