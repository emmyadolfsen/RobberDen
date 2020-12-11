using System;
using static System.Console;

namespace Robber
{
    public class Login
    {
        public static readonly string Heading =
        @" ___ ___ ___ " + '\n' +
        @"|__ \__ \__ \" + '\n' +
        @"  /_/ /_/ /_/" + '\n' +
        @" (_) (_) (_) ";
        public static void LoginTry()
        {
            var illustrations = new Illustrations();
            string Password = "";
            
            Clear();
            WriteLine(Heading);
            WriteLine();
        
            while (Password != "ronja")
            {
                Write("Skriv in lösenord för att passera:\n");
                Password = ReadLine();
                if (Password != "ronja")
                {
                    Clear();
                    WriteLine("Fel lösenord");
                }
            }
            Clear();
            var robberDen = new RobberDen();    // Instansiera klassen writemenu
            robberDen.MainMenu();



        }
    }
}