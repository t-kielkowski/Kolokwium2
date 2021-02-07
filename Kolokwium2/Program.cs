using System;


// Stwórz funkcję generującą podpowiedź w wyszukiwarce. Stwórz listę 100 losowych liczb 0-999 i zapisz je jako tekst. Wczytaj od użytkownika dowolną liczbę i wypisz 10 wpisów z listy które najbardziej pasują.

namespace Kolokwium2
{
    class Program
    {
        static int[] Func(string liczba, string[] lista)
        {
            var licznik = 0;
            var licznik2 = 0;
            int[] zblizone = new int[10];
        
            for (int i = 0; i < lista.Length; i++)
            {
                if (string.Compare(lista[i], liczba) == 0)
                {
                    licznik++;
                    zblizone[licznik2] = int.Parse(lista[i]);
                    licznik2++;
                }
        
                if (licznik > 10) break;
        
            }
        
            return zblizone;
        
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 100;
            string[] lista = new string[size];

            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = rnd.Next(0, 999).ToString();
            }

            Console.WriteLine("Podaj dowolna liczbe od 0 do 999");
            string LiczbaUzytkownika = Console.ReadLine();
            var zblizone =Func(LiczbaUzytkownika, lista);

            Sygnalizacja sygnalizacja1 = new Sygnalizacja();
            Sygnalizacja sygnalizacja2 = new Sygnalizacja();
            Przycisk przyciskPiesi = new Przycisk();
            Przycisk przyciskSamochody = new Przycisk();
            przyciskPiesi.Swiatlo = Swiatlo.Zielone;
            przyciskSamochody.Swiatlo = Swiatlo.Czerwone;

            przyciskPiesi.WcisnietoPrzycisk += sygnalizacja1.Cykl;
            przyciskSamochody.WcisnietoPrzycisk += sygnalizacja1.Cykl;
            przyciskPiesi.OnWcisnietoPrzycisk(sygnalizacja1);
            przyciskSamochody.OnWcisnietoPrzycisk(sygnalizacja2);


        }
    }
}