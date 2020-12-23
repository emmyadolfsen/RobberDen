using System;
using static System.Console;

namespace Robber
{

    public class PlayHitRightRobber
    {

        static readonly TimeSpan playTime = TimeSpan.FromSeconds(15); // Sätt tiden till 15 s

        public void Play()
        {
            var illustrations = new Illustrations(); // Instansiera klassen illustrations
            var robberDen = new RobberDen();    // Instansiera klassen robberden
            var writeMenu = new WriteMenu(); // Instansiera klassen writemenu


            Random random = new Random(); // Instansiera system klassen random

            illustrations.HitRightRobber(); // Hämta och skriv ut rubrik

            WriteLine(" Ett annat rövarband härjar i våra skogar.. ");
            WriteLine($" Du har {(int)playTime.TotalSeconds}sekunder på dig att träffa så många rövare du kan");
            WriteLine(" Använd dina snabba fingrar för att matcha bokstäverna.. och skicka rövaren ut ur skogen!");

            writeMenu.WriteEndOfGameMenu(); // Hämta och skriv ut input val

            DateTime start = DateTime.Now; // Starttiden

            int score = 0; // Sätt score till 0

            while (DateTime.Now - start < playTime) // Loop körs så länge tiden är kortare än 15 s
            {
                Clear();
                char robberLocation = (char)random.Next('a', 'z'); // Slumpa fram en bokstav
                WriteLine();
                WriteLine();
                WriteLine(" " + " " + robberLocation);

                char input;
                input = ReadKey().KeyChar;
                if (robberLocation == input) // Om input och slumpad bokstav är lika
                {
                    score++; // Lägg till ett poäng
                }
            }

            illustrations.HitRightRobber(); // Hämta och skriv ut rubrik

            if (score < 1) // Om poängen är 0
            {
                WriteLine(" Vad är det här? Har du gått över till det andra rövarbandet?");
                WriteLine(" Du skickade iväg " + score + " rövare från skogen..");
            }
            if (score > 0 && score < 11) // Om poängen är från 1 till 10
            {
                WriteLine(" Du behöver öva mer på dina skills. Du skickade bara iväg " + score + " rövare från skogen..");
            }
            if (score > 10 && score < 20) // Om poängen är från 11 till 19
            {
                WriteLine(" Snyggt! Du skickade iväg " + score + " rövare från skogen!");
            }
            if (score > 19) // Om poängen är från 19 och uppåt
            {
                WriteLine(" Du skickade iväg " + score + " rövare från skogen!");
                WriteLine(" Bara en hövding kan ha såna skills!");
            }

            writeMenu.WriteEndOfGameMenu(); // Hämta och skriv ut input val
            Play(); // Start spelet igen

        }

    }
}