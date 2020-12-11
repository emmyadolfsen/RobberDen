using System;
using static System.Console;

namespace Robber
{
    public class RobberDen
    {
        
        public void MainMenu()
        {
            var writeMenu = new WriteMenu();    // Instansiera klassen WriteMenu
            var translate = new Translate();    // Instansiera klassen Translate
            var playRockPaperScissors = new PlayRockPaperScissors(); // Instansiera klassen PlayRockPaperScissors
            var playHitRightRobber = new PlayHitRightRobber();  // Instansiera klassen PlayHitRightRobber
            writeMenu.WriteDenMenu();   // Skriv ut meny

            // en switch för att läsa ut de olika input-valen i menyn
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.D1:                   // vid input 1
                    Clear();
                    translate.RobberLanguage();
                    break;

                case ConsoleKey.D2:                   // vid input 2
                    Clear();
                    playRockPaperScissors.Game();
                    break;

                case ConsoleKey.D3:                   // vid input 3
                    playHitRightRobber.Main();
                    break;

                case ConsoleKey.Escape:                   // vid input esc
                    Clear();
                    WriteLine("\nTack för idag!\n");
                    Environment.Exit(0);
                    break;

                default:                    // vid annan input
                    Clear();
                    ForegroundColor = ConsoleColor.Yellow;  // ändra textfärg
                    WriteLine("- Du måste välja något av alternativen. - \n");
                    ForegroundColor = ConsoleColor.Gray;
                    MainMenu();
                    break;

            }



        }

    }
}