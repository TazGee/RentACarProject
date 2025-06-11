using RentACar.Klase;
using RentACar.Properties;
using System;
using System.Windows.Forms;

namespace RentACar
{
    public partial class KreiranjeNaloga: Form
    {
        DatabaseHandler handler;
        AuthForm authForma;

        bool visibility1;
        bool visibility2;

        public KreiranjeNaloga(DatabaseHandler handler, AuthForm authForma)
        {
            InitializeComponent();

            this.handler = handler;
            errorText.Text = "";
            this.authForma = authForma;

            FormClosed += FormaZatvorena;

            KeyPreview = true;
            KeyDown += new KeyEventHandler(StisnutiDugmici);

            visibility1 = false;
            visibility2 = false;
        }

        private void StisnutiDugmici(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KreirajKorisnika();
            }
        }

        void FormaZatvorena(object sender, EventArgs e)
        {
            authForma.Show();
        }

        private void promeni_Click(object sender, EventArgs e)
        {
            KreirajKorisnika();
        }

        async void KreirajKorisnika()
        {
            if (CheckInput()) return;
            Korisnik k = new Korisnik(imeiprezime.Text, newPW.Text, pozicija.Text, "https://zhyrpdzlexnrbpfefibu.supabase.co/storage/v1/object/public/slike/defaultProfile");
            await handler.DodajKorisnika(k);
            await handler.UcitajKorisnike();
            MessageBox.Show("Uspešno ste se registrovali u sistem, molimo vas da se sada ulogujete!", "Uspešno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        bool CheckInput()
        {
            if (imeiprezime.Text == "") { errorText.Text = "Morate uneti Ime i Prezime!"; return true; }
            if (pozicija.Text == "") { errorText.Text = "Morate uneti poziciju!"; return true; }
            if (newPW.Text == "") { errorText.Text = "Morate uneti lozinku!"; return true; }
            if (repPW.Text == "") { errorText.Text = "Morate ponoviti lozinku!"; return true; }
            if (sigurnosniKOD.Text == "") { errorText.Text = "Morate uneti sigurnosni kod!"; return true; }

            if (newPW.Text.Length < 8) { errorText.Text = "Lozinka mora biti duga bar 8 karaktera!"; return true; }
            if (newPW.Text != repPW.Text) { errorText.Text = "Ponovljena lozinka nije ista kao nova!"; return true; }
            if (sigurnosniKOD.Text != "5657-4231-8890") { errorText.Text = "Sigurnosni kod nije tačan!"; return true; }

            return false;
        }

        private void seePW1_Click(object sender, EventArgs e)
        {
            ChangeVisibilityState1();
        }
        void ChangeVisibilityState1()
        {
            if (!visibility1)
            {
                seePW1.BackgroundImage = Resources.skrivenoOko;
                newPW.UseSystemPasswordChar = false;
                visibility1 = true;
            }
            else
            {
                seePW1.BackgroundImage = Resources.oko;
                newPW.UseSystemPasswordChar = true;
                visibility1 = false;
            }
        }
        void ChangeVisibilityState2()
        {
            if (!visibility2)
            {
                seePW2.BackgroundImage = Resources.skrivenoOko;
                repPW.UseSystemPasswordChar = false;
                visibility2 = true;
            }
            else
            {
                seePW2.BackgroundImage = Resources.oko;
                repPW.UseSystemPasswordChar = true;
                visibility2 = false;
            }
        }

        private void seePW2_Click(object sender, EventArgs e)
        {
            ChangeVisibilityState2();
        }
    }
}
