using System;
using static System.Console;

namespace Robber
{
    public class Translate
    {
    public static readonly string Heading =
            @" ___                                   _       _   " + '\n' +
            @"| _ \_____ ____ _ _ _ ____ __ _ _ __ _| |_____| |  " + '\n' +
            @"|   / _ \ V / _` | '_(_-< '_ \ '_/ _` | / / -_)  _|" + '\n' +
            @"|_|_\___/\_/\__,_|_| /__/ .__/_| \__,_|_\_\___|\__|" + '\n' +
            @"                        |_|                        ";
        public void RobberLanguage()
        {
            var robberDen = new RobberDen();    // Instansiera klassen Robberden
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine(Heading);
            ResetColor();
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
            
            WriteLine();
            WriteLine("Ny översättning [enter], eller gå tillbaks [escape]?");
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.Enter:
                    Clear();
                    RobberLanguage(); // Kör igen
                    break;
                case ConsoleKey.Escape:
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