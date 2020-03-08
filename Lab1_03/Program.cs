using System;
using Microsoft.VisualBasic;

namespace Lab1_03
{
    class Program
    {
        const int WIEK_EMERYTALNY = 65;
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie");

            string imie = Interaction.InputBox("Podaj imie:", "Tytuł okienka");
            Console.WriteLine("Podaj imię" + imie);
            string nazwisko = Interaction.InputBox("Podaj nazwisko:", "Tytuł okienka");
            Console.WriteLine("podaj nazwisko" + nazwisko);

            Interaction.MsgBox("Witaj " + imie + " " + nazwisko);
            Interaction.MsgBox(string.Format("Witaj {0} {1}", imie, nazwisko));


            int wiek = Convert.ToInt32(Interaction.InputBox("Podaj wiek", "okienko wiek"));

            if (wiek < WIEK_EMERYTALNY)
            {
                Interaction.MsgBox(" Do emerytury pozostało ci " + (WIEK_EMERYTALNY - wiek) + "lat", MsgBoxStyle.OkOnly |
                    MsgBoxStyle.Information, "Okienko emerytura");
            }
            else
            {
                Interaction.MsgBox(" Jesteś emerytem!", MsgBoxStyle.OkOnly |
                     MsgBoxStyle.Information, "Okienko emerytura");
            }
        }
    }
}
