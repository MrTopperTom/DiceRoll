using System;
//made by TopperTom
namespace TomsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display
            Console.Title = "DICEROLL";
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Welcome
            Console.WriteLine("Welcome to Dice Roll\nMade by Tom Harrison!\nTry roll a 6\n");

            Random numberGen = new Random();
            int roll = 0;
            int attemps = 0;

            Console.WriteLine("Press enter to roll the dice.");
           
           while (roll != 6)
           {
               Console.ReadKey();
               roll = numberGen.Next(1, 7);
               Console.WriteLine("You roled a " + roll);
               attemps++;
           }

           Console.WriteLine("\nIt took you " + attemps + " attemps to roll a 6");

            //Wait before close
            Console.ReadKey();
        }
    }
}
