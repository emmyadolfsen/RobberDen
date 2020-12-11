using System;
using static System.Console;

namespace Robber
{
    public class WriteMenu
    {
        public void WriteDenMenu()
        {
            var illustrations = new Illustrations(); // Instansiera Illustrations klassen
            illustrations.DenHeading(); // Anropa denHeading som skriver ut rubrik

            // Skriv ut meny
            WriteLine();
            WriteLine("Välkommen in i Rövarkulan\n");
            WriteLine("Vad vill du göra?\n");
            WriteLine("1] Rövarspråket");
            WriteLine("2] Spela Sten Sax Påse");
            WriteLine("3] Spela Hit Right Robber");
            WriteLine();
            WriteLine("[Esc] Avsluta\n");

        }

        public void WriteEndOfGameMenu()
        {
            var robberDen = new RobberDen();    // Instansiera klassen robberden

            WriteLine();
            WriteLine("Spela [enter], eller gå tillbaks [escape]?");
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.Enter: // Om input är enter
                    Clear();
                    break; // Gå tillbaks till spelet
                case ConsoleKey.Escape: // om input är esc
                    Clear();
                    robberDen.MainMenu();   // Gå till menyn
                    break;
                default:
                    robberDen.MainMenu();   // Gå till menyn
                    break;
            }
        }
    }
}