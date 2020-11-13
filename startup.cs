using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;

namespace Adventure_Game
{
    class startup
    {
        public startup()
        {
            Title = "Cyberspace";
            Introduction();
            AskForName();
        }

        public void Introduction()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Welcome to the whacky world of Cyberspace.");
            ReadKey();
        }
        public void AskForName()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("What is your username?");
            string characterName = ReadLine();
                ForegroundColor = ConsoleColor.White;
                WriteLine($"So your username is {characterName}. Wonderful.");
                ReadKey();
                WriteLine("We hope you enjoy this fantastic journey.");
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Press [Enter] to continue");
                while (ReadKey().Key != ConsoleKey.Enter) //Pulled from https://www.geeksforgeeks.org/console-readkey-method-in-c-sharp/#:~:text=ReadKey()%20Method%20makes%20the,any%20input%20process%20will%20happen).
                {
                }
                Clear();
            new Adventure(characterName); //Silver told me this is where you send in the user-input string inside Adventure.
        }

    }
}