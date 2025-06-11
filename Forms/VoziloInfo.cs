using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Net;
using RentACar.Klase;
using System;

namespace RentACar
{
    public partial class VoziloInfo: Form
    {
        DatabaseHandler database;
        Vozilo vozilo;
        ListaVozila lista;
        public VoziloInfo(DatabaseHandler handler, Vozilo v, ListaVozila lista)
        {
            InitializeComponent();

            database = handler;
            vozilo = v;
            HandleUI();
            this.lista = lista;

            FormClosed += FormaZatvaranje;
        }

        void FormaZatvaranje(object sender, System.EventArgs e)
        {
            FormClosed -= FormaZatvaranje;
            obrisiVozilo.Click -= obrisiVozilo_Click;

            if (slikaAuta.BackgroundImage != null)
                slikaAuta.BackgroundImage.Dispose();

            lista.Show();

            database = null;
            vozilo = null;
            lista = null;

            Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        void HandleUI()
        {
            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(vozilo.slikaPath);
                using (var stream = new MemoryStream(data))
                {
                    var img = Image.FromStream(stream);
                    slikaAuta.BackgroundImage = Image.FromStream(stream);
                    slikaAuta.BackgroundImageLayout = ImageLayout.Stretch;
                    img.Dispose();
                }
            }
            imeVozila.Text = vozilo.naziv;
            brojSedista.Text = vozilo.brojSedista.ToString();
            brojVrata.Text = vozilo.brojVrata.ToString();
            kubikaza.Text = vozilo.kubikaza;
            tipGoriva.Text = vozilo.tipGoriva;
            tipMenjaca.Text = vozilo.tipMenjaca;
            cena.Text = vozilo.cena.ToString() + "€";
            idVozila.Text = "ID Vozila: " + vozilo.id.ToString();
            tablice.Text = vozilo.tablice;
        }

        private async void obrisiVozilo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li stvarno želite da obrišete ovo vozilo iz baze podataka?", "Obrisanje vozila", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                bool uspesno = await database.ObrisiVozilo(vozilo);
                if (uspesno)
                {
                    MessageBox.Show("Vozilo je uspesno obrisano!", "Uspešno!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    database.UcitavanjeFormShow("Učitavanje", "Učitavanje vozila...");

                    await database.UcitajVozila("", true, true);
                    lista.PrikaziVozila();

                    database.UcitavanjeFormHide();

                    Close();
                }
                else
                {
                    MessageBox.Show("Vozilo nije moguce obrisati!", "Neuspešno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
