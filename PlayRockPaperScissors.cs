using System;
using static System.Console;


namespace Robber
{
    public class PlayRockPaperScissors
    {
        public static readonly string Heading =
    @" ___ _              ___             ___              " + '\n' +
    @"/ __| |_ ___ _ _   / __| __ ___ __ | _ \__ _ ___ ___ " + '\n' +
    @"\__ \  _/ -_) ' \  \__ \/ _` \ \ / |  _/ _` (_-</ -_)" + '\n' +
    @"|___/\__\___|_||_| |___/\__,_/_\_\ |_| \__,_/__/\___|";

        public void Game()
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(Heading);
            ResetColor();
            WriteLine();
            WriteLine("Det är dags för den årliga prestigefyllda tävlingen Sten Sax Påse.");
            WriteLine("Kan du slå förra årets vinnare Ås-pelle?");
            WriteLine();

            bool round = true;
            int playerCount = 0;
            int computerCount = 0;

            while (round)
            {

                WriteLine("Sten sax eller påse?"); // Skriv ut
                string userInput = Console.ReadLine().ToLower();  // spara input i variabel, gör om till gemener 
                if (userInput == "sten" || userInput == "sax" || userInput == "påse")
                {
                Random randomNr = new Random();  // Använd slumpade nummer, instansiera klassen
                string[] hands = { "sten", "sax", "påse" }; // array med händerna
                int randomNumber = randomNr.Next(0, 3); // Låt datorn slumpa ett nummer mellan 1 och 3
                string computerHand = hands[randomNumber]; // gör om till string

                Clear();
                WriteLine($"Ås-Pelle spelade {computerHand}");

                if (computerHand == userInput) // Om datorhand och input är samma
                {
                    WriteLine("| Du     | Ås-pelle |");
                    WriteLine($"| {playerCount}      | {computerCount}        |");
                    WriteLine();
                    WriteLine("Det blev lika!");

                }
                else if (
                computerHand == "sten" && userInput == "sax" ||
                computerHand == "sax" && userInput == "påse" ||
                computerHand == "påse" && userInput == "sten") // Om datorhand vinner
                {

                    computerCount += 1;
                    WriteLine("| Du     | Ås-pelle |");
                    WriteLine($"| {playerCount}      | {computerCount}        |");
                    WriteLine();
                    WriteLine("Ett poäng till Ås-pelle..");
                    WriteLine();
                }
                else
                {
                    playerCount += 1;
                    WriteLine("| Du     | Ås-pelle |");
                    WriteLine($"| {playerCount}      | {computerCount}        |");
                    WriteLine();
                    WriteLine("Bra! Ett poäng!");
                    WriteLine();

                }

                if (playerCount >= 3 && playerCount > computerCount)
                {
                    Clear();
                    WriteLine("Du vann!");
                    WriteLine();
                    WriteLine(
                    @"       \\\|||///       " + '\n' +
                    @"     .  =======        " + '\n' +
                    @"    / \| O   O |       " + '\n' +
                    @"    \ / \`___'/        " + '\n' +
                    @"     #   _| |_         " + '\n' +
                    @"     (#) (     )       " + '\n' +
                    @"     #\//|* *|\\       " + '\n' +
                    @"     #\/(  *  )/       " + '\n' +
                    @"     #   =====         " + '\n' +
                    @"     #   ( U )         " + '\n' +
                    @"     #   || ||         " + '\n' +
                    @"    .#---'| |`----.    " + '\n' +
                    @"    `#----' `-----'    ");
                    WriteLine();
                    round = false;
                }
                else if (computerCount >= 3 && playerCount < computerCount)
                {
                    Clear();
                    WriteLine("Typiskt! Ett år till med Ås-pelle på tronen.");
                    userInput = "sten";
                    round = false;
                }
                }

            } // end of while

            WriteLine();
            WriteLine("Spela igen [enter], eller gå tillbaks [escape]?");
            var robberDen = new RobberDen();    // Instansiera klassen robberden

            switch (ReadKey(true).Key)
            {
                case ConsoleKey.Enter:
                    Clear();
                    Game();
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