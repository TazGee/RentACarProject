using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace RentACar.Klase
{
    [Table("Korisnici")]
    public class Korisnik : BaseModel
    {

        [PrimaryKey("IDKorisnika", false)]
        public int id { get; set; }

        [Column("ImeiPrezime")]
        public string ime { get; set; }

        [Column("Lozinka")]
        public string lozinka { get; set; }

        [Column("Pozicija")]
        public string pozicija { get; set; }

        [Column("ProfilnaSlika")]
        public string slikaPath { get; set; }


        public Korisnik()
        {

        }

        public Korisnik(string ime, string lozinka, string pozicija, string slikaPath)
        {
            this.ime = ime;
            this.lozinka = lozinka;
            this.pozicija = pozicija;
            this.slikaPath = slikaPath;
        }

        public Korisnik(int id, string ime, string lozinka, string pozicija, string slikaPath)
        {
            this.id = id;
            this.ime = ime;
            this.lozinka = lozinka;
            this.pozicija = pozicija;
            this.slikaPath = slikaPath;
        }
    }
}
