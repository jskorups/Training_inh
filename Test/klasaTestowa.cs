using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Kubek
    {
        private string nazwaKubka; // pola na stracie maja private
        public int pojemnoscKubka;

        public int obwod { get; set; }

        private int _wysokoscKubka;


        public string WysokoscKubka { get{ return _wysokoscKubka+"cm";} set { if (Convert.ToInt32(value) < 1)  throw new Exception("Wysokosc nie moze byc mniejsza od 1"); else _wysokoscKubka = Convert.ToInt32(value); } }

        public int getWysokoscKuba() // get
        {
            return _wysokoscKubka;
        }

        public void setWysokoscKuba(int wysokosc) //set
        {
            _wysokoscKubka = wysokosc;
        }


        public Kubek(int pojemnoscKubka, int wysokoscKubka)
        {
            this.pojemnoscKubka = pojemnoscKubka;
            this.WysokoscKubka = wysokoscKubka.ToString();
        }

        public Kubek(int pojemnoscKubka, int wysokoscKubka, string nazwa)
        {
            this.pojemnoscKubka = pojemnoscKubka;
            this.WysokoscKubka = wysokoscKubka.ToString();
            this.nazwaKubka = nazwa;
        }

        public void NazwijKubek(string nazwa)
        {
            if (nazwaKubka != null && nazwaKubka != "")
            {
                nazwaKubka = nazwa;
            }
        }
        public int policzObjetoscKubka()
        {
            return pojemnoscKubka * _wysokoscKubka;
        }
    }
}
