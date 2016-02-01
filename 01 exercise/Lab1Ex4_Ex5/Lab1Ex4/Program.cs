using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to the Hi-Lo game ***");
            Console.WriteLine("Game 1: Player guesses a number.");
            Console.WriteLine("Game 2: Computer guesses a number.");
            Console.WriteLine("Input 1 or 2! ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("you have cosen to guess a number..");
                    Console.WriteLine("Computer is generating a number...");
                    System.Threading.Thread.Sleep(2000);    //LOLzz
                    Random rnd = new Random();
                    int numberToGuess = rnd.Next(1, 100);

                    Console.WriteLine("Computer has generated a number.. input your first guess..");

                    while (true)
                    {
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == numberToGuess)
                        {
                            Console.WriteLine("Winner!");
                            return;
                        }

                        if (guess < numberToGuess)
                        {
                            Console.WriteLine("Nope! The number is more than that..");
                        }

                        else if (guess > numberToGuess)
                        {
                            Console.WriteLine("Nope! The number is less than that..");
                        }
                    }
                case 2:
                    Console.WriteLine("Computer guesses a number..");
                    Console.WriteLine("Think of a number between 1 and 100, and i will guess it with my evil algorithm!");
                    Console.WriteLine("If my guess is higher than that number, press H.");
                    Console.WriteLine("If my guess is lower than that number, press L ");
                    Console.WriteLine("If im right, press E");

                    int tooHigh = 100;
                    int tooLow = 1;

                    Console.Write("My guess is: ");
                    Random myRandom = new Random();
                    int myGuess = myRandom.Next(tooLow, tooHigh);
                    while (true)
                    {
                        Console.Write(myGuess);
                        char response = char.Parse(Console.ReadLine());

                        if (response == 'e')
                        {
                            Console.WriteLine("YES! i Won!!");
                            return;
                        }

                        if (response == 'h')
                        {

                            tooHigh = myGuess;
                            myGuess = myRandom.Next(tooLow, tooHigh);
                            Console.WriteLine("I will go lower then..");
                        }

                        if (response == 'l')
                        {
                            tooLow = myGuess;
                            myGuess = myRandom.Next(tooLow, tooHigh);
                            Console.WriteLine("I will go higher then..");
                        }
                    }
            }

        }
    }
}
