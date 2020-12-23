using System;
using static System.Console;

namespace Robber
{
    public class Translate
    {
        public void RobberLanguage()
        {
            var robberDen = new RobberDen();    // Instansiera klassen Robberden
            var illustrations = new Illustrations();
            var writeMenu = new WriteMenu(); // Instansiera klassen writemenu

            illustrations.Rovarspraket();
            CursorVisible = true; // Visa cursor
            WriteLine();
            Write(" Skriv in det du vill översätta till rövarspråket: ");
            string input = Console.ReadLine().ToLower(); // gör om input till gemener
            char[] charArray = input.ToCharArray(); // gör om string till chararray
            string parsedChar = string.Empty;

            foreach (char var in charArray)
            {
                // Om bokstäverna är konsonanter..
                if (var != ' ')
                {
                    if (var == 'q' || var == 'w' || var == 'r' || var == 't' || var == 'p' || var == 's' ||
                                  var == 'd' || var == 'f' || var == 'g' || var == 'h' || var == 'j' || var == 'k' ||
                                  var == 'l' || var == 'z' || var == 'x' || var == 'c' || var == 'v' || var == 'b' ||
                                  var == 'n' || var == 'm')
                    {
                        parsedChar += var.ToString() + "o"; // .. lägg till o 
                    }
                }
                parsedChar += var.ToString();
            }

            Console.WriteLine("\n RÖVARSPRÅKET:");
            WriteLine();
            Console.WriteLine(' ' + parsedChar);

            writeMenu.WriteEndOfGameMenu(); // Hämta och skriv ut input val
            RobberLanguage(); // Starta spelet igen

        }
    }
}