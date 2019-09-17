﻿using System;

namespace numbersGuessingGame
{
    class Program
    {
        static public int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;

            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a number guessing game. The higher your score, the worse you did!");

            int max = GetIntegerFromUser("What maximum range would you like?");
            Random rnd = new Random();

            int secretNumber = rnd.Next(1, max + 1);

            int score = 0;
            int guess;

            do
            {
                Console.ResetColor();
                Console.WriteLine("Your current score is " + score);
                guess = GetIntegerFromUser("Please guess a number between 1-" + max + ":");
                if (guess > secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were to high, loser!");
                    score += 1;
                }
                else if (guess < secretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You were too low, loser!");
                    score += 1;
                }
            } while (guess != secretNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finally, you got it! Your score is " + score + "!");
            Console.ResetColor();


        }
    }
}
        