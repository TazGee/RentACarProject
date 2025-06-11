using RentACar.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class PromenaLozinke: Form
    {
        DatabaseHandler database;
        ProfileForm forma;
        bool visibility1;
        bool visibility2;
        bool visibility3;

        public PromenaLozinke(DatabaseHandler database, ProfileForm forma)
        {
            InitializeComponent();

            this.database = database;
            errorText.Text = "";
            this.forma = forma;

            visibility1 = false;
            visibility2 = false;
            visibility3 = false;

            KeyPreview = true;
            KeyDown += new KeyEventHandler(StisnutiDugmici);

            FormClosed += FormaZatvorena;
        }

        private void FormaZatvorena(object sender, EventArgs e)
        {
            forma.Show();
        }

        private async void StisnutiDugmici(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await PromeniSifru();
            }
        }

        async Task PromeniSifru()
        {
            if (CheckInput()) return;

            bool uspesno = await database.PromeniLozinku(newPW.Text);

            if (uspesno)
            {
                MessageBox.Show("Lozinka je uspešno promenjena, ponovo se ulogujte sa novom lozinkom!", "Uspešna promena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                forma.LogOUT();
                await database.UcitajKorisnike();
                Close();
            }
        }

        private async void promeni_Click(object sender, EventArgs e)
        {
            await PromeniSifru();
        }

        bool CheckInput()
        {
            if (oldPW.Text == "") { errorText.Text = "Morate uneti staru lozinku!"; return true; }
            if (newPW.Text == "") { errorText.Text = "Morate uneti lozinku!"; return true; }
            if (repPW.Text == "") { errorText.Text = "Morate ponoviti lozinku!"; return true; }
            if (sigurnosniKOD.Text == "") { errorText.Text = "Morate uneti sigurnosni kod!"; return true; }

            if (oldPW.Text != database.GetLozinka()) { errorText.Text = "Uneta stara lozinka nije tačna!"; return true; }
            if (newPW.Text.Length < 8) { errorText.Text = "Nova lozinka mora biti duga bar 8 karaktera!"; return true; }
            if (oldPW.Text == newPW.Text) { errorText.Text = "Nova lozinka ne sme biti ista kao stara!"; return true; }
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

        private void seePW3_Click(object sender, EventArgs e)
        {
            ChangeVisibilityState3();
        }
        void ChangeVisibilityState3()
        {
            if (!visibility3)
            {
                seePW3.BackgroundImage = Resources.skrivenoOko;
                oldPW.UseSystemPasswordChar = false;
                visibility3 = true;
            }
            else
            {
                seePW3.BackgroundImage = Resources.oko;
                oldPW.UseSystemPasswordChar = true;
                visibility3 = false;
            }
        }
    }
}
