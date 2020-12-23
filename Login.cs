using System;
using static System.Console;

namespace Robber
{
    public class Login
    {

        public static void LoginTry()
        {
            var illustrations = new Illustrations(); // Instansiera klassen illustrations
            var robberDen = new RobberDen();    // Instansiera klassen writemenu
            string Password = "";
            
            
            BackgroundColor = ConsoleColor.Black;
            Clear();
            illustrations.LoginHeading(); // Hämta och skriv ut rubrik
            CursorVisible = true; // Visa cursor
            while (Password != "ronja") // Loopa om fel lösenord skrivs in
            {
                Write(" Skriv in lösenord för att passera: ");
                Password = ReadLine();
                if (Password != "ronja")
                {
                    Clear();
                    WriteLine();
                    WriteLine(" Fel lösenord...");
                }
            }
            Clear();
            robberDen.MainMenu();



        }
    }
}