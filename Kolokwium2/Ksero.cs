using System;

namespace Kolokwium2
{
    public class Ksero : Drukarka
    {
        public string Skanuj()
        {
            Console.WriteLine("Podaj tekst do zeskanowania :)");
            var text = Console.ReadLine();
            return text;
        }

        public void Kseruj()
        {
            var zm =Skanuj();
            base.Drukuj(zm);
        }
    }
}