using System;
using static System.Console;

namespace Robber
{
    public class Illustrations
    {

        public void DenHeading()
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(
            @"  _____ _          ___     _    _               ___            " + '\n' +
            @" |_   _| |_  ___  | _ \___| |__| |__  ___ _ _  |   \ ___ _ _   " + '\n' +
            @"   | | | ' \/ -_) |   / _ \ '_ \ '_ \/ -_) '_| | |) / -_) ' \  " + '\n' +
            @"   |_| |_||_\___| |_|_\___/_.__/_.__/\___|_|   |___/\___|_||_| ");
            ForegroundColor = ConsoleColor.White;
        }

        public void LoginHeading()
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(
            @"  ___ ___ ___ " + '\n' +
            @" |__ \__ \__ \" + '\n' +
            @"   /_/ /_/ /_/" + '\n' +
            @"  (_) (_) (_) ");
            ForegroundColor  = ConsoleColor.White;
            WriteLine();
        }

        public void HitRightRobber()
        {
            Clear();
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            WriteLine(
            @"  _  _ _ _     ___ _      _   _     ___     _    _             " + '\n' +
            @" | || (_) |_  | _ (_)__ _| |_| |_  | _ \___| |__| |__  ___ _ _ " + '\n' +
            @" | __ | |  _| |   / / _` | ' \  _| |   / _ \ '_ \ '_ \/ -_) '_|" + '\n' +
            @" |_||_|_|\__| |_|_\_\__, |_||_\__| |_|_\___/_.__/_.__/\___|_|  " + '\n' +
            @"                    |___/                                      ");
            ForegroundColor  = ConsoleColor.White;
            WriteLine();
        }

        public void RockPaperScissor()
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(
            @"  ___ _              ___             ___              " + '\n' +
            @" / __| |_ ___ _ _   / __| __ ___ __ | _ \__ _ ___ ___ " + '\n' +
            @" \__ \  _/ -_) ' \  \__ \/ _` \ \ / |  _/ _` (_-</ -_)" + '\n' +
            @" |___/\__\___|_||_| |___/\__,_/_\_\ |_| \__,_/__/\___|");
            ForegroundColor  = ConsoleColor.White;
        }

        public void Chief()
        {
            WriteLine("Grattis! Du vann!");
            WriteLine();
            ForegroundColor = ConsoleColor.DarkCyan;
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
            ForegroundColor  = ConsoleColor.White;
            WriteLine();
        }

        public void Rovarspraket()
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine(
            @"  ___                                   _       _   " + '\n' +
            @" | _ \_____ ____ _ _ _ ____ __ _ _ __ _| |_____| |  " + '\n' +
            @" |   / _ \ V / _` | '_(_-< '_ \ '_/ _` | / / -_)  _|" + '\n' +
            @" |_|_\___/\_/\__,_|_| /__/ .__/_| \__,_|_\_\___|\__|" + '\n' +
            @"                         |_|                        ");
            ForegroundColor  = ConsoleColor.White;
        }
    }

}