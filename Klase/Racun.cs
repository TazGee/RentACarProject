using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace RentACar.Klase
{
    [Table("Racuni")]
    public class Racun : BaseModel
    {

        [PrimaryKey("IDRacuna", false)]
        public int id { get; set; }

        [Column("IzdavacRacuna")]
        public int izdavac { get; set; }

        [Column("DatumRacuna")]
        public int datum { get; set; }

        [Column("VremeRacuna")]
        public int vreme { get; set; }

        [Column("Vozilo")]
        public int vozilo { get; set; }

        [Column("DatumPocetka")]
        public int pocetak { get; set; }

        [Column("DatumZavrsetka")]
        public int kraj { get; set; }

        [Column("KonacnaCena")]
        public int cena { get; set; }

        [Column("ImeKorisnika")]
        public string ime { get; set; }

        [Column("BrojTelefona")]
        public string telefon { get; set; }

        [Column("Email")]
        public string email { get; set; }

        public Racun()
        { }

        public Racun(int izdavac, int datum, int vreme, string ime, string telefon, string email, int vozilo, int pocetak, int kraj, int cena)
        {
            this.izdavac = izdavac;
            this.datum = datum;
            this.vreme = vreme;
            this.vozilo = vozilo;
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.cena = cena;
            this.ime = ime;
            this.telefon = telefon;
            this.email = email;
        }

        public Racun(int id, int izdavac, int datum, int vreme, string ime, string telefon, string email, int vozilo, int pocetak, int kraj, int cena)
        {
            this.id = id;
            this.izdavac = izdavac;
            this.datum = datum;
            this.vreme = vreme;
            this.vozilo = vozilo;
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.cena = cena;
            this.ime = ime;
            this.telefon = telefon;
            this.email = email;
        }

        public bool IzracunajAktivnost()
        {
            DateTimeHandler handler = new DateTimeHandler();

            DateTime poc = handler.CalculateDate(pocetak);
            DateTime krj = handler.CalculateDate(kraj);

            if (DateTime.Compare(poc, DateTime.Now) <= 0 && DateTime.Compare(DateTime.Now, krj) <= 0) return true;
            return false;
        }

    }
}
