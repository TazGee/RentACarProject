using System;

namespace RentACar.Klase
{
    class DateTimeHandler
    {
        public DateTime CalculateDate(int datum)
        {
            DateTime date = new DateTime(datum / 10000, (datum - datum / 10000 * 10000) / 100, (datum - datum / 100 * 100), 0, 0, 0);
            return date;
        }
        public string FormirajDatum(int datum)
        {
            int dan, mesec, godina;
            string d, m;

            dan = (datum - datum / 100 * 100);
            mesec = (datum - datum / 10000 * 10000) / 100;
            godina = datum / 10000;

            if (dan < 10)       { d = "0" + dan; }      else { d = dan.ToString(); }
            if (mesec < 10)     { m = "0" + mesec; }    else { m = mesec.ToString(); }

            string str = dan + "." + mesec + "." + godina;
            return str;
        }
        public string FormirajVreme(int vreme)
        {
            int minut, sat;
            string m, s;

            minut = (vreme % 100);
            sat = ((vreme - vreme / 10000 * 10000) / 100) % 100;

            if (minut < 10)     { m = "0" + minut; }    else m = minut.ToString();
            if (sat < 10)       { s = "0" + sat; }      else s = sat.ToString();

            string str = s + ":" + m;
            return str;
        }
        public int DatumUInt(DateTime datum)
        {
            int date;
            date = datum.Year * 10000 + datum.Month * 100 + datum.Day;
            return date;
        }
    }
}
