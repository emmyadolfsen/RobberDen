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
            Write("Skriv in det du vill översätta till rövarspråket: \n");
            string input = Console.ReadLine().ToLower();
            char[] charArray = input.ToCharArray();
            string parsedChar = string.Empty;

            foreach (char var in charArray)
            {
                // Om bokstäverna är konsonanter..
                if (var != ' ') 
                {
                    if (var != 'a' && var != 'e' && var != 'o' && var != 'i' && var != 'u' && var != 'ä' &&
                        var != 'å' && var != 'ö' && var != 'y' && var != ',' && var != '.' && var != '!' && 
                        var != '?' && var != '1' && var != '2' && var != '3' && var != '4' && var != '5' &&
                        var!= '6' && var != '7' && var != '8' && var != '9' && var != '0')
                    {
                        parsedChar += var.ToString() + "o"; // .. lägg till o 
                    }
                } 
                parsedChar += var.ToString(); // och konsonant
            }

            Console.WriteLine("\nRÖVARSPRÅKET:");
            Console.WriteLine(parsedChar);
            
            writeMenu.WriteEndOfGameMenu(); // Hämta och skriv ut input val
            RobberLanguage(); // Starta spelet igen

        }
    }
}