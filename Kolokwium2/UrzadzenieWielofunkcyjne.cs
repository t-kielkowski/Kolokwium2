//Jeśli tekst z parametru jest pusty, wczytaj tekst od użytkownika metodą Skanuj. Następnie "wyślij faks" wypisując na konsolę numer telefonu urządzenia i  wynik funkcji GetHashCode wywołanej na tekście wiadomości. Stwórz
//     obiekt typu UrządzenieWielofunkcyjne i wywołaj jego wszystkie metody (w tym bazowe).


using System;

namespace Kolokwium2
{
    public class UrzadzenieWielofunkcyjne : Ksero
    {
        public int NrTelefonu;

        public void Faksuj(string text)
        {
            string wczytaj;

            if (text == null || text.Length == 0)
            {
                wczytaj = Skanuj();
                Console.WriteLine(NrTelefonu);
                Console.WriteLine(wczytaj.GetHashCode());
            }

            Console.WriteLine(text.GetHashCode());
        }
    }
}