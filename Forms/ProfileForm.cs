using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace RentACar
{
    public partial class ProfileForm: Form
    {
        MainMenu meni;
        AuthForm authForm;
        DatabaseHandler databaza;

        public ProfileForm(DatabaseHandler database, MainMenu menu, AuthForm authForma)
        {
            meni = menu;
            authForm = authForma;
            databaza = database;
            InitializeComponent();
            ImeiPrezimeLabel.Text = databaza.GetIme();
            UcitajProfilnuSliku();
            if (database.GetPozicija() != "") pozicijaLabel.Text = database.GetPozicija(); else pozicijaLabel.Text = "Nepoznato";
            FormClosed += FormaSeZatvorila;
        }

        void UcitajProfilnuSliku()
        {
            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(databaza.GetSlikaPath());
                using (var stream = new MemoryStream(data))
                {
                    changeImage.BackgroundImage = Image.FromStream(stream);
                }
            }
        }
        private void FormaSeZatvorila(object sender, EventArgs e)
        {
            meni.gledaProfil = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LogOUT();
        }

        public void LogOUT()
        {
            meni.Close();
            authForm.Show();
            authForm.ClearInput();
            Close();
        }

        private async void changeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;
                string fileName = DateTime.Now.Ticks.ToString() + databaza.GetIme();

                var success = await databaza.UploadSlikaAsync(sourcePath, fileName);

                if (success)
                    MessageBox.Show("Slika uspešno postavljena!");
                else
                    MessageBox.Show("Greška prilikom postavljanja slike.");

                string downloadString = "https://zhyrpdzlexnrbpfefibu.supabase.co/storage/v1/object/public/slike/" + fileName;

                using (var client = new WebClient())
                {
                    byte[] data = client.DownloadData(downloadString);
                    using (var stream = new MemoryStream(data))
                    {
                        changeImage.BackgroundImage = Image.FromStream(stream);
                    }
                }
                meni.UpdateProfilePhoto(downloadString); 

                await databaza.SetSlikaPath(downloadString);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void promenaLozinke_Click(object sender, EventArgs e)
        {
            PromenaLozinke promenaForm = new PromenaLozinke(databaza, this);
            promenaForm.Show();
            Hide();
        }
    }
}
