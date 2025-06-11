using RentACar.Klase;
using RentACar.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RentACar
{
    public partial class ListaVozila: Form
    {
        DatabaseHandler databaza;
        List<PictureBox> listaSlika = new List<PictureBox>();
        List<object> listaSvihObjekata = new List<object>();
        MainMenu menu;
        ListaVozilaUIHandler uiHandler;
        bool zaIzbor;
        IznajmiVozilo iznajmi;

        public ListaVozila(MainMenu menu, DatabaseHandler database)
        {
            InitializeComponent();

            // - PRIKAZIVANJE VOZILA - //
            //PretraziVozila("");
            databaza = database;

            // - ZA VELICINU REDOVA - //
            glavniPanel1.RowStyles.Add(new RowStyle());
            glavniPanel1.RowStyles[0].Height = 65;
            glavniPanel1.RowStyles[0].SizeType = SizeType.Absolute;

            this.menu = menu;
            FormClosed += ZatvaranjeForme;
            Resize += FormResize;
            zaIzbor = false;

            PrikaziVozila();
        }

        public ListaVozila(DatabaseHandler database, IznajmiVozilo iznajmi)
        {
            InitializeComponent();

            // - PRIKAZIVANJE VOZILA - //
            databaza = database;

            // - ZA VELICINU REDOVA - //
            glavniPanel1.RowStyles.Add(new RowStyle());
            glavniPanel1.RowStyles[0].Height = 65;
            glavniPanel1.RowStyles[0].SizeType = SizeType.Absolute;

            FormClosed += ZatvaranjeForme;
            Resize += FormResize;
            zaIzbor = true;
            this.iznajmi = iznajmi;

            PrikaziVozila();
        }

        public void PrikaziVozila()
        {
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
            if (databaza.listaVozila.Count == 0) { Debug.WriteLine($"Nema vozila u listi vozila! {databaza.listaVozila.Count}"); return; }

            uiHandler = new ListaVozilaUIHandler(listaSvihObjekata, listaVozilaPanel);

            foreach (Vozilo v in databaza.listaVozila)
            {
                Debug.WriteLine($"Ucitano vozilo: {v.naziv}, {v.obrisano}");
                HandleUI(v);
            }
        }

        void HandleUI(Vozilo v)
        {
            // - KREIRANJE PANELA - //
            FlowLayoutPanel glavniPanel;
            if (v.obrisano == 1) { glavniPanel = uiHandler.CreateFlowPanel(BorderStyle.FixedSingle, FlowDirection.LeftToRight, 0); }
            else { glavniPanel = uiHandler.CreateFlowPanel(BorderStyle.FixedSingle, FlowDirection.LeftToRight, 200); }
            glavniPanel.Anchor = AnchorStyles.Top;
            listaVozilaPanel.Controls.Add(glavniPanel);

            // - KREIRANJE SLIKE - //
            PictureBox slika = uiHandler.CreateImage(v);
            glavniPanel.Controls.Add(slika);
            listaSlika.Add(slika);
            slika.Click += new EventHandler(PrikaziVoziloInfo);

            if (v.obrisano == 1) return;

            // - KREIRANJE NOVOG PANELA ZA OSTALE PODATKE - //
            TableLayoutPanel mainInfoPanel = uiHandler.CreateTablePanel(BorderStyle.None, 2, 1);
            glavniPanel.Controls.Add(mainInfoPanel);
            mainInfoPanel.Dock = DockStyle.Fill;

            // - NAZIV VOZILA - //
            Label naziv = uiHandler.CreateNaziv(v);
            mainInfoPanel.Controls.Add(naziv, 0, 0);
            naziv.Font = new Font(naziv.Font.FontFamily, 24, FontStyle.Bold);

            // - FLOW LAYOUT PANEL - //
            FlowLayoutPanel carInfoPanel = uiHandler.CreateFlowPanel(BorderStyle.None, FlowDirection.LeftToRight, 100);
            mainInfoPanel.Controls.Add(carInfoPanel, 0, 1);
            carInfoPanel.WrapContents = true;

            // - BROJ SEDISTA - //
            uiHandler.DodajSeparator(carInfoPanel, 20);
            uiHandler.CreateIcon(Resources.coveculjak, carInfoPanel);
            uiHandler.CreateIconText(v.brojSedista.ToString(), carInfoPanel, 50);

            // - BROJ VRATA - //
            uiHandler.DodajSeparator(carInfoPanel, 20);
            uiHandler.CreateIcon(Resources.vrata, carInfoPanel);
            uiHandler.CreateIconText(v.brojVrata.ToString(), carInfoPanel, 50);

            // - KUBIKAZA - //
            uiHandler.DodajSeparator(carInfoPanel, 20);
            uiHandler.CreateIcon(Resources.motor, carInfoPanel);
            uiHandler.CreateIconText(v.kubikaza, carInfoPanel, v.kubikaza.Length * 13);

            // - TIP GORIVA - //
            uiHandler.DodajSeparator(carInfoPanel, 20);
            uiHandler.CreateIcon(Resources.kanister, carInfoPanel);
            uiHandler.CreateIconText(v.tipGoriva, carInfoPanel, v.tipGoriva.Length * 13);

            listaSvihObjekata.Add(uiHandler.listaSvihObjekata);
        }

        void FormResize(object sender, EventArgs e)
        {
            glavniPanel1.Height = this.Height;
        }

        void ZatvaranjeForme(object sender, EventArgs e)
        {
            if (zaIzbor) return;
            menu.ClearLista();
        }

        void PrikaziVoziloInfo(object sender, EventArgs e)
        {
            int i;
            for(i = 0; i < listaSlika.Count; i++)
            {
                if (sender == listaSlika[i]) break;
            }

            if (zaIzbor) { iznajmi.SetVozilo(databaza.listaVozila[i]); Close(); return; }

            new VoziloInfo(databaza, databaza.listaVozila[i], this).Show();

            Hide();
        }

        private void dodajVozilo_Click_1(object sender, EventArgs e)
        {
            DodajVozilo dodajVozilo = new DodajVozilo(databaza, this);
            dodajVozilo.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await databaza.UcitajVozila(search.Text, manuelni.Checked, automatski.Checked);
            PrikaziVozila();
        }
    }
}
