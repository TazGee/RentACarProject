using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentACar
{
    public partial class DodajVozilo: Form
    {
        DatabaseHandler database;
        string slikaPath = "";
        ListaVozila lista;

        public DodajVozilo(DatabaseHandler database, ListaVozila lista)
        {
            InitializeComponent();
            this.database = database;
            this.lista = lista;
            errorText.Text = "";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (nazivVozila.Text == "") { errorText.Text = "Naziv mora biti popunjen!"; return; }
            if (brojVrata.Text == "") { errorText.Text = "Broj vrata mora biti popunjen!"; return; }
            if (brojSedista.Text == "") { errorText.Text = "Broj sedista mora biti popunjen!"; return; }
            if (kubikaza.Text == "") { errorText.Text = "Kubikaza mora biti popunjena!"; return; }
            if (tipGoriva.Text == "") { errorText.Text = "Tip goriva mora biti popunjen!"; return; }
            if (tipMenjaca.Text == "") { errorText.Text = "Tip menjaca mora biti popunjen!"; return; }
            if (cena.Text == "") { errorText.Text = "Cena mora biti popunjena!"; return; }
            if (slikaPath == "") { errorText.Text = "Slika mora biti postavljena!"; return; }
            
            if (tablice.Text == "") { errorText.Text = "Polje sa tablice mora biti popunjeno!"; return; }
            Vozilo vozilo = new Vozilo(int.Parse(brojSedista.Text), int.Parse(brojVrata.Text), nazivVozila.Text, textBox1.Text, tipGoriva.Text, tipMenjaca.Text, int.Parse(cena.Text), tablice.Text, slikaPath, 0);
            database.UbaciVozilo(vozilo);
            await database.UcitajVozila("", true, true);
            lista.PrikaziVozila();
            
            MessageBox.Show("Vozilo je uspesno dodato u bazu podataka!", "Uspešno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private async void slikaAuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;
                string fileName = "Vozilo" + DateTime.Now.Ticks.ToString();

                var success = await database.UploadSlikaAsync(sourcePath, fileName);

                if (success)
                    MessageBox.Show("Slika uspešno postavljena!");
                else
                    MessageBox.Show("Greška prilikom postavljanja slike.");

                string downloadString = "https://zhyrpdzlexnrbpfefibu.supabase.co/storage/v1/object/public/slike/" + fileName;

                slikaAuta.BackgroundImage = Image.FromFile(sourcePath);
                slikaPath = downloadString;
                slikaAuta.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
