using RentACar.Klase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Supabase.Postgrest.Constants;
using System.Text.Json;

namespace RentACar
{
    public class DatabaseHandler
    {
        public List<Vozilo> listaVozila = new List<Vozilo>();
        public List<Racun> listaRacuna = new List<Racun>();
        public List<Korisnik> listaKorisnika = new List<Korisnik>();

        Korisnik trenutniKorisnik;
        Uploading uploading;

        string supabaseUrl = "";
        string supabaseKey = "";

        Supabase.Client client;

        public DatabaseHandler()
        {
            InicijalizujInfoFormu();

            string json = File.ReadAllText("Supabase.json");
            SupabaseCFG config = JsonSerializer.Deserialize<SupabaseCFG>(json);

            supabaseUrl = config.SUPABASE_URL;
            supabaseKey = config.SUPABASE_API_KEY;

            PovezivanjeOnlineServisa();
            if (uploading != null) uploading.SetInfoText("Učitavanje podataka iz baze podataka...");
            Application.DoEvents();
            UcitavanjeKorisnika();
            UspesnaInicijalizacijaBaze();
        }

        public void UcitavanjeFormShow(string naslov, string info)
        {
            if (uploading != null)
            {
                uploading.Show();
                uploading.SetMainText(naslov);
                uploading.SetInfoText(info);
            }
            Application.DoEvents();
        }

        public void UcitavanjeFormHide()
        {
            if (uploading != null)
            {
                uploading.Hide();
            }
            Application.DoEvents();
        }

        public void UspesanLogin()
        {
            uploading.Show();
            uploading.SetMainText("Učitavanje...");
            uploading.SetInfoText("Učitavanje vozila i računa iz baze podataka...");
            Application.DoEvents();

            UcitajIzDatabaze();

            uploading.SetMainText("Uspešno!");
            uploading.SetInfoText("Svi podaci su uspešno učitani!");
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            uploading.Hide();
        }

        void InicijalizujInfoFormu()
        {
            uploading = new Uploading();
            uploading.Show();
            Application.DoEvents();
        }

        void PovezivanjeOnlineServisa()
        {
            if (uploading != null) uploading.SetInfoText("Povezivanje sa bazom podataka i inicijalizacija klijenta...");
            Application.DoEvents();
            PoveziSeSaBazom();
        }

        async void UcitavanjeKorisnika()
        {
            await UcitajKorisnike();
        }

        void UspesnaInicijalizacijaBaze()
        {
            if (uploading != null) { uploading.SetInfoText("Preusmeravamo vas u aplikaciju..."); uploading.SetMainText("Uspešno!"); }
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            uploading.Hide();
        }

        async void UcitajIzDatabaze()
        {
            await UcitajVozila("", true, true);
            await UcitajRacune("", "", false);
        }

        public string GetIme()
        { return trenutniKorisnik.ime; }
        public string GetSlikaPath()
        { return trenutniKorisnik.slikaPath; }
        public string GetLozinka()
        { return trenutniKorisnik.lozinka; }
        public string GetPozicija()
        { return trenutniKorisnik.pozicija; }
        public int GetID()
        { return trenutniKorisnik.id; }

        async void PoveziSeSaBazom()
        {
            try
            {
                client = new Supabase.Client(supabaseUrl, supabaseKey);
                await client.InitializeAsync();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Greška u mrežnoj konekciji:\n" + ex.Message, "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Neočekivana greška:\n" + ex.Message, "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public Korisnik CheckUsername(string username)
        {
            foreach(Korisnik k in listaKorisnika)
            {
                if(k.ime == username)
                {
                    return k;
                }
            }
            return null;
        }

        public bool CheckPassword(Korisnik k, string password)
        {
            if (k.lozinka == password) return true;
            else return false;
        }

        public void MigrateData(Korisnik k)
        {
            trenutniKorisnik = k;
        }

        public async Task<bool> UcitajKorisnike()
        {
            listaKorisnika.Clear();

            var response = await client
                .From<Korisnik>()
                .Get();

            if (response.Models.Any())
            {
                foreach (var user in response.Models)
                {
                    Console.WriteLine($"ID: {user.id}, Ime: {user.ime}, Pozicija: {user.pozicija}");
                    Korisnik k = new Korisnik(user.id, user.ime, user.lozinka, user.pozicija, user.slikaPath);
                    listaKorisnika.Add(k);
                }
                return true;
            }
            else
            {
                Console.WriteLine("Nema korisnika u bazi!");
                return false;
            }
        }

        public async Task<bool> SetSlikaPath(string path)
        {
            try
            {
                trenutniKorisnik.slikaPath = path;

                var updateResponse = await client
                    .From<Korisnik>()
                    .Update(trenutniKorisnik);

                return updateResponse.ResponseMessage.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> PromeniLozinku(string nova)
        {
            try
            {
                trenutniKorisnik.lozinka = nova;

                var updateResponse = await client
                    .From<Korisnik>()
                    .Update(trenutniKorisnik);

                return updateResponse.ResponseMessage.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public async Task<bool> DodajKorisnika(Korisnik k)
        {
            try
            {
                var insertResponse = await client
                    .From<Korisnik>()
                    .Insert(k);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // -- VOZILA -- //

        public async void UbaciVozilo(Vozilo v)
        {
            try
            {
                var insertResponse = await client
                    .From<Vozilo>()
                    .Insert(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task<bool> ObrisiVozilo(Vozilo v)
        {
            try
            {
                v.obrisano = 1;

                var updateResponse = await client
                    .From<Vozilo>()
                    .Update(v);

                return updateResponse.ResponseMessage.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> UcitajVozila(string ime, bool manuelni, bool automatski)
        {
            listaVozila.Clear();

            var response = await client
                .From<Vozilo>()
                .Filter("NazivVozila", Operator.ILike, $"%{ime}%")
                .Get();

            if (response.Models.Any())
            {
                foreach (var auto in response.Models)
                {
                    FiltrirajVozila(auto, ime, manuelni, automatski);
                }
                return true;
            }
            else
            {
                Console.WriteLine("Nema vozila u bazi!");
                return false;
            }
        }

        void FiltrirajVozila(Vozilo auto, string ime, bool manuelni, bool automatski)
        {
            if (!auto.naziv.Contains(ime)) return;
            if (!(automatski == manuelni))
            {
                if (automatski && !auto.tipMenjaca.Contains("utomat")) return;
                else if (manuelni && !auto.tipMenjaca.Contains("anueln")) return;
            }
            listaVozila.Add(new Vozilo(auto.id, auto.brojSedista, auto.brojVrata, auto.naziv, auto.kubikaza, auto.tipGoriva, auto.tipMenjaca, auto.cena, auto.tablice, auto.slikaPath, auto.obrisano));
        }

        // -- RACUNI -- //

        public async Task<bool> Iznajmi(Racun r) 
        {
            try
            {
                var insertResponse = await client
                    .From<Racun>()
                    .Insert(r);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> UcitajRacune(string time, string imeVozila, bool aktivan)
        {
            listaRacuna.Clear();

            var response = await client.From<Racun>().Order("IDRacuna", Ordering.Descending).Filter("ImeKorisnika", Operator.ILike, $"%{time}%").Get();

            if (response.Models.Any())
            {
                foreach (var rac in response.Models)
                {
                    FiltrirajRacune(rac, time, imeVozila, aktivan);
                }
                return true;
            }
            else
            {
                Console.WriteLine("Nema racuna u bazi!");
                return false;
            }
        }

        void FiltrirajRacune(Racun rac, string ime, string imeVozila, bool aktivan)
        {
            if (!rac.ime.Contains(ime)) return;
            if (imeVozila != "" && FindVoziloIDByIme(imeVozila) != rac.vozilo) return;
            if (aktivan && rac.IzracunajAktivnost() == false) return;
            listaRacuna.Add(new Racun(rac.id, rac.izdavac, rac.datum, rac.vreme, rac.ime, rac.telefon, rac.email, rac.vozilo, rac.pocetak, rac.kraj, rac.cena));
        }

        int FindVoziloIDByIme(string ime)
        {
            foreach(Vozilo v in listaVozila)
            {
                if(v.naziv.Contains(ime))
                {
                    return v.id;
                }
            }
            return 0;
        }


        // -- SLIKE -- //

        public async Task<bool> UploadSlikaAsync(string localFilePath, string fileName)
        {
            var bucketName = "slike";

            var client = new Supabase.Client(supabaseUrl, supabaseKey);
            await client.InitializeAsync();

            var bucket = client.Storage.From(bucketName);

            try
            {
                byte[] fileBytes = File.ReadAllBytes(localFilePath);
                var result = await bucket.Upload(fileBytes, fileName);
                return result != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
                return false;
            }
        }
    }
}
