using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Faktura
    {
        public Faktura(FakturaNaglowek nag, List<ElementFaktury> elementy)
        {
            naglowek = nag;
            listaelementow = elementy;
        }
        public FakturaNaglowek naglowek;
        public List<ElementFaktury> listaelementow;
    }
}
