using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    // klasa bazowa
    public class Figura
    {
        // metody wirtualne w klasie bazowej
        // metody wirtualne to takie ktore moga byc przesloniete
        // dodanie nazwy abstarct w nazwie klasy powoduje, ze kompilator pilnuje aby wszytskie metody bylky virtualne
        virtual public decimal Obwod()
        {
            return 0;
        }

        virtual public decimal Pole()
        {
            return 0;
        }
    }
}
