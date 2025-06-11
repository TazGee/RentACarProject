using System;
using System.Windows.Forms;
using RentACar.Properties;
using RentACar.Klase;

namespace RentACar
{
    public partial class AuthForm: Form
    {
        DatabaseHandler handler;
        bool visibility;

        public AuthForm()
        {
            InitializeComponent();
            ErrorText.Text = "";

            KeyPreview = true;
            KeyDown += new KeyEventHandler(StisnutiDugmici);

            FormClosed += FormaZatvorena;

            visibility = false;

            handler = new DatabaseHandler();
        }

        void FormaZatvorena(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StisnutiDugmici(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.N)
            {
                KreiranjeNaloga novaForma = new KreiranjeNaloga(handler, this);
                novaForma.Show();
                Hide();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        void Login()
        {
            if (CheckIfEmpty()) return;

            Korisnik k = handler.CheckUsername(Username.Text);
            if (k == null) { ErrorMessage("Uneto ime i prezime ne postoje u sistemu!"); Password.Clear(); return; }
            if (!handler.CheckPassword(k, Password.Text)) { ErrorMessage("Uneta sifra nije ispravna!"); Password.Clear(); return; }

            handler.MigrateData(k);
            handler.UspesanLogin();
            OpenMainMenu();
        }

        void OpenMainMenu()
        {
            MainMenu mainMenuForm = new MainMenu(this, handler);
            mainMenuForm.Show();
            Hide();
        }

        public void ClearInput()
        {
            Username.Clear();
            Password.Clear();
        }

        bool CheckIfEmpty()
        {
            if (Username.Text == "") { Password.Clear(); ErrorMessage("Polje za ime i prezime mora biti popunjeno!"); return true; }
            if (Password.Text == "") { Password.Clear(); ErrorMessage("Polje za lozinku mora biti popunjeno!"); return true; }
            ClearErrorMessage();
            return false;
        }
        void ErrorMessage(string message)
        {
            ErrorText.Text = message;
        }
        void ClearErrorMessage()
        {
            ErrorText.Text = "";
        }

        private void seePW_Click(object sender, EventArgs e)
        {
            ChangeVisibilityState();
        }
        void ChangeVisibilityState()
        {
            if(!visibility)
            {
                seePW.BackgroundImage = Resources.skrivenoOko;
                Password.UseSystemPasswordChar = false;
                visibility = true;
            }
            else
            {
                seePW.BackgroundImage = Resources.oko;
                Password.UseSystemPasswordChar = true;
                visibility = false;
            }
        }
    }
}
