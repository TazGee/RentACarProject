using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using RentACar.Klase;
using System.Net;
using System.Diagnostics;

namespace RentACar
{
    public partial class MainMenu: Form
    {
        string imeprezime;
        AuthForm authForma;
        Timer clockTimer = new Timer();
        int startX = 500, startY = 205, posX = 325;
        DatabaseHandler databaza;

        ListaVozila lista;
        IstorijaRacuna istorija;
        IznajmiVozilo iznajmi;

        public bool gledaProfil;

        public MainMenu()
        {
            imeprezime = "Nepoznato";
            InitializeComponent();
            nameLabel.Text = "\n" + imeprezime;
            FormClosed += Zatvori;

            lista = null;
            istorija = null;
            gledaProfil = false;
            iznajmi = null;
        }

        void Zatvori(object sender, EventArgs e)
        {
            if (!gledaProfil) Application.Exit();
        }

        public MainMenu(AuthForm forma, DatabaseHandler database)
        {
            authForma = forma;
            imeprezime = database.GetIme();
            InitializeComponent();
            nameLabel.Text = "\n" + imeprezime;
            databaza = database;
            Resize += MainMenuResize; // ON RESIZE
            FormClosed += Zatvori;
            profilePicture.Click += UserPanelClick;
            nameLabel.Click += UserPanelClick;

            UpdateProfilePhoto(database.GetSlikaPath());

            // - CLOCK - //
            DateLabel.Text = DateTime.Today.Date.ToString();
            TimeLabel.Text = DateTime.Now.TimeOfDay.ToString();
            clockTimer.Tick += new EventHandler(UpdateClock);
            clockTimer.Interval = 1000;
            clockTimer.Start();

            lista = null;
            istorija = null;
        }

        void MainMenuResize(object sender, EventArgs e)
        {
            logo.Size = new Size(startX + Width - 1200, startY + Height - 759);
            logo.Location = new Point(posX, logo.Location.Y);
        }

        void UpdateClock(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Today.Date.ToString();
            TimeLabel.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void ListVozila_Click(object sender, EventArgs e)
        {
            if (lista == null)
            {
                databaza.UcitavanjeFormShow("Učitavanje vozila", "Učitavanje slika i podataka o vozilima...");
                lista = new ListaVozila(this, databaza);
                databaza.UcitavanjeFormHide();
            }
            else
            {
                MessageBox.Show("Jedna lista vozila je već otvorena!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lista.Show();
        }
        public void ClearLista()
        {
            lista.Dispose();
            lista = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(istorija == null)
            {
                istorija = new IstorijaRacuna(databaza, this);
            }
            else
            {
                MessageBox.Show("Jedna istorija iznajmljivanja je već otvorena!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            istorija.Show();
        }
        public void ClearIstorija()
        {
            istorija.Dispose();
            istorija = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iznajmi == null)
            {
                iznajmi = new IznajmiVozilo(databaza, this);
            }
            else
            {
                MessageBox.Show("Jedna forma za iznajmljivanje je već otvorena!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            iznajmi.Show();
        }
        public void ClearIznajmljivanje()
        {
            iznajmi = null;
        }

        private void UserPanelClick(object sender, EventArgs e)
        {
            if(!gledaProfil) OtvoriProfil();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            BackupHandler bachandler = new BackupHandler();
            bachandler.BackupDB();
        }

        void OtvoriProfil()
        {
            ProfileForm profil = new ProfileForm(databaza, this, authForma);
            profil.Show();
            gledaProfil = true;
        }
        public void UpdateProfilePhoto(string path)
        {
            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(path);
                using (var stream = new MemoryStream(data))
                {
                    profilePicture.BackgroundImage = Image.FromStream(stream);
                }
            }
        }
    }
}
