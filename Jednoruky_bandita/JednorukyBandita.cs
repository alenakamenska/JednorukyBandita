using System;
using System.Collections.Generic;
using System.Text;

namespace Jednoruky_bandita
{
    // enum se symboly
    public enum Valec
    {
        sedmicka = 0,
        pomeranc = 1,
        tresne = 2,
        svestky = 3,
        citron = 4,
    }

    // třída JednorukyBandita
    class JednorukyBandita
    {
        private int _konto;
        private int _sazka;
        public Valec Valec1;

        public Valec Valec2;

        public Valec Valec3;

        public int Konto
        {
            get 
            {
                return _konto;
            }
            set
            {
                _konto = value;
            }
        }
        public int Sazka
        {
            get
            {
                return _sazka;
            }
            set
            {
                _sazka = value;
            }
        }
        // metoda na vyhodnoceni výhry/prohry
        public bool Vysledky()
        {
            
            return ((Valec1 == Valec2) && (Valec1 == Valec3)) ;

        }
        // metoda na odecteni z konta při prohře
        public void Odecteni()
        {
            _konto -= _sazka;
        }
        // metoda na pricteni do konta při výhře
        public void Pricteni()
        {
            _konto *= 11;
        }
        
       

    }

}
