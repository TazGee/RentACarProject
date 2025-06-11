using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.Diagnostics;

namespace RentACar
{
    [Table("Vozila")]
    public class Vozilo : BaseModel
    {

        [PrimaryKey("IDVozila", false)]
        public int id { get; set; }

        [Column("BrojSedista")]
        public int brojSedista { get; set; }

        [Column("BrojVrata")]
        public int brojVrata { get; set; }

        [Column("Cena")]
        public int cena { get; set; }

        [Column("VoziloObrisano")]
        public int obrisano { get; set; }

        [Column("NazivVozila")]
        public string naziv { get; set; }

        [Column("Kubikaza")]
        public string kubikaza { get; set; }

        [Column("TipGoriva")]
        public string tipGoriva { get; set; }

        [Column("TipMenjaca")]
        public string tipMenjaca { get; set; }

        [Column("Tablice")]
        public string tablice { get; set; }

        [Column("SlikaPath")]
        public string slikaPath { get; set; }


        public Vozilo()
        {

        }
        public Vozilo(int brojSedista, int brojVrata, string naziv, string kubikaza, string tipGoriva, string tipMenjaca, int cena, string tablice, string slikaPath, int obrisano)
        {
            this.brojSedista = brojSedista;
            this.brojVrata = brojVrata;
            this.naziv = naziv;
            this.kubikaza = kubikaza;
            this.tipGoriva = tipGoriva;
            this.tipMenjaca = tipMenjaca;
            this.cena = cena;
            this.tablice = tablice;
            this.slikaPath = slikaPath;
            this.obrisano = obrisano;
        }
        public Vozilo(int id, int brojSedista, int brojVrata, string naziv, string kubikaza, string tipGoriva, string tipMenjaca, int cena, string tablice, string slikaPath, int obrisano)
        {
            this.id = id;
            this.brojSedista = brojSedista;
            this.brojVrata = brojVrata;
            this.naziv = naziv;
            this.kubikaza = kubikaza;
            this.tipGoriva = tipGoriva;
            this.tipMenjaca = tipMenjaca;
            this.cena = cena;
            this.tablice = tablice;
            this.slikaPath = slikaPath;
            this.obrisano = obrisano;
        }

        public void Prikazi()
        {
            Debug.WriteLine(id + " " + brojSedista + " " + brojVrata + " " + naziv + " " + kubikaza + " " + tipGoriva + " " + tipMenjaca + " " + cena + " " + slikaPath);
        }
    }
}
