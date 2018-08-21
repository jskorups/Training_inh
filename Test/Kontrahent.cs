using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Kontrahent
    {
        public Kontrahent(string nazwa, string nip, Adres adresPodstawowy)
        {
            this.nazwa = nazwa;
            this.nip = nip;
            this.adres = adresPodstawowy;
        }
        public string nazwa;
        public string nip;
        public Adres adres;
        public Adres adresDodatkowy;
    }
}
