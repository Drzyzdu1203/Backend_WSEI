using System;

namespace Lab1_01
{
    class Program
    {
        const int WIEK_EMERYTALNY = 65;
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie");

            Console.Write("Podaj imie: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko;
            nazwisko = Console.ReadLine();
            Console.WriteLine("Witaj " + imie + " " + nazwisko);            // konkretentacja napisów(sklejanie)
            Console.WriteLine("Witaj {0} {1}!", imie, nazwisko);           // format string
            Console.WriteLine($"Witaj, {imie} {nazwisko}");               // interpoled string

            Console.Write("Podaj wiek: ");
            // int wiek = Convert.ToInt32(Console.ReadLine());         // rzutowanie typów 
            string napis = Console.ReadLine();                       // drugi typ rzutowania to samo ^
            int wiek = int.Parse(napis);

            if (wiek < WIEK_EMERYTALNY)
            {
                Console.WriteLine(" Do emerytury pozostało ci {0} lat", WIEK_EMERYTALNY - wiek);
            }
            else
            {
                Console.WriteLine(" Jesteś emerytem!");
            }
        }
    }
}