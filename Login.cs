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
            
            Clear();
            illustrations.LoginHeading(); // Hämta och skriv ut rubrik
            
            while (Password != "ronja") // Loopa om fel lösenord skrivs in
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
            robberDen.MainMenu();



        }
    }
}