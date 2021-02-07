// Stwórz klasę Drukarka, która posiada metodę Drukuj. Metoda ta powinna wypisać na konsolę tekst przyjęty jako parametr. Stwórz klasę Ksero, która dziedziczy z Drukarki ale dodaje metody Skanuj i Kseruj. Metoda Skanuj powinna wyczytać tekst od
// użytkownika i go zwrócić jako wynik. Metoda Kseruj powinna wywołać Skanuj a następnie "wydrukować" wynik za pomocą metody z klasy bazowej. Stwórz klasę UrzadzenieWielofunkcyjne, które dziedziczy z klasy Ksero. Powinna ona posiadać pole NrTelefonu i metodę
//     Faksuj która przyjmuje parametr tekstowy. Jeśli tekst z parametru jest pusty, wczytaj tekst od użytkownika metodą Skanuj. Następnie "wyślij faks" wypisując na konsolę numer telefonu urządzenia i  wynik funkcji GetHashCode wywołanej na tekście wiadomości. Stwórz
//     obiekt typu UrządzenieWielofunkcyjne i wywołaj jego wszystkie metody (w tym bazowe).

using System;

namespace Kolokwium2
{
    public class Drukarka
    {
        public void Drukuj(string text)
        {
            Console.WriteLine(text);
        }
    }
}