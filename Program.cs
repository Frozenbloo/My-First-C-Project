using System;

namespace My_First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the apperance

            Console.Title = "Cyberpunk 2077";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
            
            //Get a Conversation Going

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine();

            Console.WriteLine("My name is RX-900. \nI'm an AI sent from the Future to Destroy Mankind");
            Console.WriteLine("What's your favourite colour?");

            Console.ReadLine();

            Console.WriteLine("Cool, mine is destruction!");
            
            Console.ReadKey();
        }
    }
}
