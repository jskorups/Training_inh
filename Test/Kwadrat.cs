using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Kwadrat : Prostokat
    {

        public Kwadrat(int bokA)
        {
            // uzycie metody bazowej z klasy figura
            base.UstawBoki(bokA, bokA);
        }

        
    }
}
