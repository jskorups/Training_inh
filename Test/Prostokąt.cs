using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Prostokat : Figura
    {

        // pola klasy
        private int _bokA;
        private int _bokB;

        // konstruktor z wartosciami zerowymi wymagany przed klase kwadrat
        public Prostokat()
        {
            _bokA = 0;
            _bokB = 0;
        }
        // konstruktor dla klasy prostokat
        public Prostokat(int bokA, int bokB)
        {
            _bokA = bokA;
            _bokB = bokB;
        }
        // metoda  przypisania roznych boków 
        //uzycie modyfikatora dostepu protected tak aby byl dostepny dla klasy dziedziczacej, ale nie byl dostepny w innym miejscu,  np po inicjalizacji obiektu
        protected void UstawBoki(int a, int b)
        {
            _bokA = a;
            _bokB = b;
        }
        // metoda obliczania pola poprzez przeslonienie metody Pole z klasy figura
        public override decimal Pole()
        {
            return _bokA * _bokB;
        }
        // metoda obliczania pola poprzez przeslonienie metody Pole z klasy figura
        public override decimal Obwod()
        {
            return 2 * _bokA + 2 * _bokB;
        }
    }
}
