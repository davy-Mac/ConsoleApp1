using System;
using Console = System.Console;
using ConsoleColor = System.ConsoleColor;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            TellTheUserAboutTheGame();
            Console.ForegroundColor = oldColor;

            int guessCount = 0;
            int guessLimit = 3;

            bool outOfLuck = false;
            string correctAnswer = "cow";
            string guess = "";
            
                while (guess != correctAnswer && !outOfLuck)
                {
                    if (guessCount < guessLimit)
                    {
                        Thread.Sleep(1000);
                        if (guessCount > 0)
                        {
                            Console.WriteLine("Umm nah.. Please try again");
                            guess = Console.ReadLine().ToLower();
                            guessCount += 1;
                    }
                        else
                        {
                        Console.WriteLine("Enter your guess: ");
                        guess = Console.ReadLine().ToLower();
                        guessCount += 1;
                    }
                        
                    }
                    else
                    {
                        outOfLuck = true;
                    }
                }

                if (outOfLuck)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You lost!! you tried {guessCount} times");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You got it!! it only took you: {guessCount} tries");
                }
                Console.ReadLine();
            }
            
        
        static void TellTheUserAboutTheGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Guess the Animal Game" 
                              + Environment.NewLine + "Please enter a guess e.g. bear" 
                              + Environment.NewLine + "If wrong enter again, you have 3 tries");
        }
    }
}
