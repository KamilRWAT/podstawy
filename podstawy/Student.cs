using System;
using System.Collections.Generic;
using System.Text;

namespace podstawy
{
    public class Student
    {
        private bool alkohol;
        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value.ToLower(); }
        }



        private int wiek;

		public int Wiek
		{
			get {
                if( wiek < 18)
                {
                    alkohol = false;
                }
                    int return_wiek = Convert.ToInt16(Math.Round(Convert.ToDouble(wiek)/10)*10);
                    return return_wiek;
                }
			set {
                    wiek = value + 2; 
                }
		}

        public double Waga { get; set; }

        public int Semestr { get; set; }

    }
}
