using System;
using static System.Console;


namespace Robber
{
    public class PlayRockPaperScissor
    {

        public void Game()
        {
            var illustrations = new Illustrations(); // Instansiera klassen Illustrations
            var robberDen = new RobberDen();    // Instansiera klassen robberden
            var writeMenu = new WriteMenu(); // Instansiera klassen writemenu

            illustrations.RockPaperScissor(); // Anropa och hämta Rockpaperscissors header

            WriteLine();
            WriteLine(" Det är dags för den årliga prestigefyllda tävlingen Sten Sax Påse.");
            WriteLine(" Kan du slå förra årets vinnare Ås-pelle?");
            WriteLine(" Bäst av tre!");
            writeMenu.WriteEndOfGameMenu(); // Hämta och skriv ut input val
            WriteLine();

            bool round = true; // Sätt en bool till true för en loop
            int playerCount = 0; // Sätt till 0
            int computerCount = 0; // Sätt till 0

            while (round) // Loop så längee som round = true
            {

                CursorVisible = true; // Visa cursor
                WriteLine();
                Write(" Sten sax eller påse? ");

                string userInput = Console.ReadLine().ToLower();  // spara input i variabel, gör om till gemener 

                if (userInput == "sten" || userInput == "sax" || userInput == "påse") // Om input är som det ska
                {
                    Random randomNr = new Random();  // Använd slumpade nummer, instansiera klassen
                    string[] hands = { "sten", "sax", "påse" }; // stringarray med händerna
                    int randomNumber = randomNr.Next(0, 3); // Låt datorn slumpa ett nummer mellan 1 och 3
                    string computerHand = hands[randomNumber]; // gör om till string

                    Clear();
                    WriteLine();
                    WriteLine($" Ås-Pelle spelade {computerHand}");
                    WriteLine();

                    if (computerHand == userInput) // Om datorhand och input är samma
                    {
                        Points(playerCount, computerCount); // Skriv ut poängtavla
                        WriteLine(" Det blev lika!");
                    }
                    else if (
                    computerHand == "sten" && userInput == "sax" ||
                    computerHand == "sax" && userInput == "påse" ||
                    computerHand == "påse" && userInput == "sten") // Om datorhand vinner
                    {
                        computerCount += 1; // Lägg till ett poäng
                        Points(playerCount, computerCount); // Skriv ut poängtavla
                        WriteLine(" Ett poäng till Ås-pelle..");
                    }
                    else
                    {
                        playerCount += 1; // Lägg till ett poäng
                        Points(playerCount, computerCount); // Skriv ut poängtavla
                        WriteLine(" Bra! Ett poäng!");
                    }

                    if (playerCount >= 3 && playerCount > computerCount) // player har mer än 3 poäng och mer än ås-pelle
                    {
                        illustrations.Chief(); // Hämta och skriv ut chief
                        round = false; // Hoppa ur loopen
                    }
                    else if (computerCount >= 3 && playerCount < computerCount) // Om ås-pelle har mer än 3 poäng och mer än player
                    {
                        WriteLine();
                        WriteLine(" Du förlorade.. Typiskt! Ett år till med Ås-pelle på tronen.");
                        round = false; // Hoppa ur loopen
                    }
                }
            } // slut på while

            writeMenu.WriteEndOfGameMenu(); // Hämta och skriv ut input val
            Game(); // Starta spelet igen

        }
        static void Points(int playerCount, int computerCount) // Funktion för att skriva ut poängtavla, skickar med poängen
        {
            ForegroundColor = ConsoleColor.Magenta; // Ändra färg
            WriteLine(" | Du     | Ås-pelle |");
            WriteLine($" | {playerCount}      | {computerCount}        |");
            ForegroundColor = ConsoleColor.White;
            WriteLine();

        }


    }
}