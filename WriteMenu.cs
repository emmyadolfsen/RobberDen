using System;
using static System.Console;

namespace Robber
{
    public class WriteMenu
    {
     public static readonly string Heading =
        @" _____ _          ___     _    _               ___            " + '\n' +
        @"|_   _| |_  ___  | _ \___| |__| |__  ___ _ _  |   \ ___ _ _   " + '\n' +
        @"  | | | ' \/ -_) |   / _ \ '_ \ '_ \/ -_) '_| | |) / -_) ' \  " + '\n' +
        @"  |_| |_||_\___| |_|_\___/_.__/_.__/\___|_|   |___/\___|_||_| ";
     public void WriteDenMenu()
     {
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine(Heading);
        ResetColor();
        WriteLine();
        WriteLine("Välkommen in i Rövarkulan\n");
        WriteLine("Vad vill du göra?\n");
        WriteLine("1] Rövarspråket");
        WriteLine("2] Spela Sten Sax Påse");
        WriteLine("3] Spela Hit Right Robber");
        WriteLine();
        WriteLine("[Esc] Avsluta\n");

     }
    }
}