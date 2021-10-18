using System;
using System.Threading;

namespace PasswortTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Login();

        }


        static void Login()
        {
            Console.Title = "C# Login";
            extras.PrintColor("Bitte gebe das Passwort an", "blue");
            extras.PrintColor("oder Verlasse mit 'exit'", "blue");

            string input = Console.ReadLine();

            if(input == "9978")
            {

                Geschafft();
            } else
            {
                if(input == "exit")
                {
                    Environment.Exit(0);

                } else
                {

                    extras.PrintColor($@"{input} ist nicht das richtige Passwort", "red");
                    extras.PrintColor("bitte gebe das richtige Passwort an", "red");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Login();



                }

            }

        }

        static void Geschafft()
        {

            extras.PrintColor("Du hast es Geschafft", "green");
            Console.ReadKey();


        } 




    }
}
