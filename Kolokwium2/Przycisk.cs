// Stwórz klasę Przycisk, która w metodzie publikuje event WcisnietoPrzycisk. Stwórz klasę Sygnalizacja, która reaguje na event WcisnietoPrzycisk i posiada metodę Cykl. Metoda ta powinna wypisywać na konsolę jakie światło jest zapalone na skrzyżowaniu
// dla pieszych i dla pojazdów. Metoda powinna co 120 cykli (2 min) sprawdzać czy ktoś wcisnął przycisk. Jeśli tak, na 15 cykli zatrzymaj samochody i przepuść pieszych. Jeśli nie, utrzymuj ruch dla pojazdów. Stwórz 2 obiekty typu Przycisk i 1 Sygnalizacja. Podłącz
// eventy. Wykonaj 1200 cykli, np. pętlą. W dowolnym momencie aktywuj jeden z przycisków.

using System;

namespace Kolokwium2
{
    public enum Swiatlo
    {
        Zielone,
        Zolte,
        Czerwone
    }
    
    public class Przycisk
    {
        public event EventHandler<WcisnietoPrzyciskEvenArgs> WcisnietoPrzycisk;
        public Swiatlo Swiatlo { get; set; }


        public void OnWcisnietoPrzycisk(Sygnalizacja sygnalizacja)
        {
            WcisnietoPrzycisk?.Invoke(this, new WcisnietoPrzyciskEvenArgs() {Swiatlo = this.Swiatlo});
        }
    }
}