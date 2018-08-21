using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    // klasa trojkat dzieczicy po figurze
    public class Trojkat  : Figura
    {
        // inicjalizacja pól klasy
        private int _bokA;
        private int _bokB;
        private int _wysokosc;
        private int _bokC;

        // konstruktor
        public Trojkat(int bokA, int bokB, int bokC, int wys)
        {
            if (bokA + bokB < bokC) throw new Exception("Taki trójkąt nie istnieje");

            // przypisanie prywatnym polom , wartosci podawanych w konstruktorze
            _bokA = bokA;
            _bokB = bokB;
            _bokC = bokC;
            _wysokosc = wys;
        }
        // metoda obliczania pola poprzez przeslonienie metody Pole z klasy figura
        public override decimal Pole()
        {
            decimal res = Convert.ToDecimal(0.5f) * _bokA * _wysokosc;
            return res;
        }
        // metoda obliczenia obwodu poprzez przeslonienie metody Obwod z klasy figura
        public override decimal Obwod()
        {
            return _bokA + _bokB + _bokC;
        }
    }
}
