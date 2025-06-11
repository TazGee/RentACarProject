using RentACar.Klase;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RentACar
{
    public partial class IznajmiVozilo: Form
    {
        DatabaseHandler database;
        public Vozilo v;
        bool pocetnipromenjen, krajnjiPromenjen;
        MainMenu meni;

        public IznajmiVozilo(DatabaseHandler database, MainMenu meni)
        {
            this.database = database;
            this.meni = meni;
            InitializeComponent(); 

            errorText.Text = "";

            pocetnipromenjen = false;
            krajnjiPromenjen = false;

            pocetniDatum.Value = DateTime.Now.AddDays(-3);
            krajDatum.Value = DateTime.Today;
            HideAll();

            KeyPreview = true;
            KeyDown += new KeyEventHandler(StisnutiDugmici);

            FormClosed += FormaZatvorena;
        }

        void FormaZatvorena(object sender, EventArgs e)
        {
            meni.ClearIznajmljivanje();
        }

        private void StisnutiDugmici(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Iznajmi();
            }
        }

        async void Iznajmi()
        {
            DateTimeHandler handler = new DateTimeHandler();

            if (CheckInput()) return;

            Racun r = new Racun(database.GetID(), handler.DatumUInt(DateTime.Today), 10000 + ((DateTime.Now.Hour * 100) + DateTime.Now.Minute), imeMusterije.Text, brojTelefona.Text, emailAdresa.Text, v.id, handler.DatumUInt(pocetniDatum.Value), handler.DatumUInt(krajDatum.Value), int.Parse(konacnaCena.Text));
            await database.Iznajmi(r);
            await database.UcitajRacune("", "", false);

            DialogResult dialogResult = MessageBox.Show("Uspešno ste iznajmili vozilo! Da li želite da odštampate račun?", "Uspešno!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Close();

            if (dialogResult == DialogResult.Yes)
            {
                PrintHandler print = new PrintHandler(database.listaRacuna[0], database);
                print.OdstampajRacun();
            }
        }

        private void iznajmiButton_Click(object sender, EventArgs e)
        {
            Iznajmi();
        }

        bool CheckInput()
        {
            if (imeMusterije.Text == "") { errorText.Text = "Ime i Prezime mušterije moraju biti popunjeni!"; return true; }
            if (brojTelefona.Text == "") { errorText.Text = "Broj telefona mora biti popunjen!"; return true; }
            if (emailAdresa.Text == "") { errorText.Text = "Email mora biti popunjen!"; return true; }
            if (v == null) { errorText.Text = "Morate izabrati vozilo za iznajmljivanje!"; return true; }
            if (!pocetnipromenjen) { errorText.Text = "Morate izabrati pocetni datum!"; return true; }
            if (!krajnjiPromenjen) { errorText.Text = "Morate izabrati krajnji datum!"; return true; }
            if (DateTime.Compare(pocetniDatum.Value, krajDatum.Value) >= 0) { errorText.Text = "Datumi nisu validni!"; return true; }
            if (konacnaCena.Text == "") { errorText.Text = "Morate uneti cenu konačnu cenu!"; return true; }
            return false;
        }

        void HideAll()
        {
            slikaSedista.Hide();
            slikaCena.Hide();
            slikaVrata.Hide();

            brojSedista.Text = "";
            brojVrata.Text = "";
            cena.Text = "";
        }

        void ShowAll()
        {
            slikaSedista.Show();
            slikaCena.Show();
            slikaVrata.Show();
        }

        public void SetVozilo(Vozilo v)
        {
            this.v = v;
            ShowAll();

            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(v.slikaPath);
                using (var stream = new MemoryStream(data))
                {
                    izaberiVozilo.BackgroundImage = Image.FromStream(stream);
                }
            }

            izaberiVozilo.Text = "";

            imeVozila.Text = "  " + v.naziv;

            brojSedista.Text = v.brojSedista.ToString();
            brojVrata.Text = v.brojVrata.ToString();
            cena.Text = v.cena + "€/dan";

            UpdateCena();
        }

        void UpdateCena()
        {
            TimeSpan razlika = krajDatum.Value - pocetniDatum.Value;
            if(v != null) predlozenaCena.Text = ((razlika.Days+1)*v.cena) + "€";
        }

        private void izaberiVozilo_Click(object sender, EventArgs e)
        {
            database.UcitavanjeFormShow("Učitavanje", "Učitavanje liste vozila...");
            ListaVozila lista = new ListaVozila(database, this);
            database.UcitavanjeFormHide();
            lista.TopMost = true;
            lista.Show();
        }

        private void pocetniDatum_ValueChanged(object sender, EventArgs e)
        {
            pocetnipromenjen = true;
            if (krajnjiPromenjen) UpdateCena();
        }

        private void krajDatum_ValueChanged(object sender, EventArgs e)
        {
            krajnjiPromenjen = true;
            if (pocetnipromenjen) UpdateCena();
        }
    }
}
