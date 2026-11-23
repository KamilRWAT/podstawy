using System;
using System.Collections.Generic;
using System.Text;

namespace podstawy
{
    public class Pilkarz
    {
        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko { get; set; }
        public int Numer_Zawodnika { get; set; }
        public string Klub { get; set; }
        public int Rok_Urodzenia { get; set; }
        public DateTime Data_Ostatniego_Transferu { get; set; }
        public double Wynagrodzenie { get; set; }

        public Pilkarz()
        {
            
        }
        public Pilkarz(string imie, string nazwisko, int numer_Zawodnika, string klub, int rok_Urodzenia, DateTime data_Ostatniego_Transferu, double wynagrodzenie)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Numer_Zawodnika = numer_Zawodnika;
            Klub = klub;
            Rok_Urodzenia = rok_Urodzenia;
            Data_Ostatniego_Transferu = data_Ostatniego_Transferu;
            Wynagrodzenie = wynagrodzenie;
        }
    }
}
