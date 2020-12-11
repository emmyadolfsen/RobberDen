using System;
using static System.Console;

namespace Robber
{

    public class PlayHitRightRobber
    {

        public static readonly string Heading =
            @" _  _ _ _     ___ _      _   _     ___     _    _             " + '\n' +
            @"| || (_) |_  | _ (_)__ _| |_| |_  | _ \___| |__| |__  ___ _ _ " + '\n' +
            @"| __ | |  _| |   / / _` | ' \  _| |   / _ \ '_ \ '_ \/ -_) '_|" + '\n' +
            @"|_||_|_|\__| |_|_\_\__, |_||_\__| |_|_\___/_.__/_.__/\___|_|  " + '\n' +
            @"                   |___/                                      ";


        public void Main()
        {

            
            var robberDen = new RobberDen();    // Instansiera klassen robberden

            while (true)
            {
                Clear();
                ForegroundColor = ConsoleColor.Red;
                WriteLine(Heading);
                ResetColor();
                WriteLine("Ett annat rövarband härjar i våra skogar.. ");
                WriteLine($"Du har {(int)playTime.TotalSeconds}sekunder på dig att träffa så många rövare du kan");
                WriteLine("Använd dina snabba fingrar för att matcha bokstäverna.. och skicka rövaren ut ur skogen!");
                WriteLine();
                WriteLine("Spela [enter], eller gå tillbaks [escape]?");

                switch (ReadKey(true).Key)
                {
                    case ConsoleKey.Enter:
                        Play();
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

        static readonly TimeSpan playTime = TimeSpan.FromSeconds(15);

        static void Play()
        {
            Clear();
            WriteLine(Heading);
            WriteLine();

            DateTime start = DateTime.Now;
            int score = 0;


            CursorVisible = false;
            while (DateTime.Now - start < playTime)
            {
                Clear();
                Random random = new Random();
                char moleLocation = (char)random.Next('a','z');
                WriteLine(moleLocation);
                char input;
                
                input = ReadKey().KeyChar;
                if (moleLocation == input)
                {
                    score++;
                }
            }

            CursorVisible = true;
            Clear();
            WriteLine(Heading);
            if (score < 1)
            {
                WriteLine("Vad är det här? Har du gått över till det andra rövarbandet?");
                WriteLine("Du skickade iväg " + score + " rövare från skogen..");
            }
            if (score > 1 && score < 5)
            {
                WriteLine("Du behöver öva mer på dina skills. Du skickade bara iväg " + score + " rövare från skogen..");
            }
            if (score > 10 && score < 20)
            {
                WriteLine("Snyggt! Du skickade iväg " + score + " rövare från skogen!");
            }
            if (score > 20)
            {
                WriteLine("Du skickade iväg " + score + " rövare från skogen!");
                WriteLine("Bara en hövding kan ha såna skills!");
            }
            

            WriteLine("Spela igen? [enter] Eller gå till menyn [escape]");

            var robberDen = new RobberDen();    // Instansiera klassen robberden
            switch (ReadKey(true).Key)
                {
                    case ConsoleKey.Enter:
                        Play();
                        break;
                    case ConsoleKey.Escape:
                        Clear();
                        robberDen.MainMenu();   // Gå till menyn
                        break;
                    default:
                        Clear();
                        robberDen.MainMenu();   // Gå till menyn
                        break;
                }
        }


    }
}