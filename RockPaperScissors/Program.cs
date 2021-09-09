using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program that plays Rock-paper-scissors game. (Scissor cuts paper, rock breaks scissor, paper covers rock.) The program randomly generates a number 0, 1, 2 representing rock = 0, paper = 1, scissor = 2. The program then prompts the user to enter a 0, 1, 2 and displays a message indicating whether the user or the computer wins, loses, or draws.
            
            Example output
                rock(0), paper(1), scissor(2): 0 (enter)
                The computer is scissor. You are rock. You won.
            */
            int pcPoints = 0;
            int userPoints = 0;
            Random randomObject = new Random();
            string[] rockPaperScissorsArray = { "Rock", "Paper", "Scissors" };

            Console.WriteLine("This is a game of rock, paper, scissors, to the death.....kidding, just best of 5");
            while (userPoints != 3 && pcPoints != 3)
            {
                int rockPaperScissors = randomObject.Next(0, 2);

                Console.Write("Choose your weapon: \n" +
                    "rock(0), paper(1), scissor(2): \n");

                string stringPick = Console.ReadLine();

                int userPick = int.Parse(stringPick);
                Console.Clear();

                string pickFromArray = rockPaperScissorsArray[userPick];
                string computerPickFromArray = rockPaperScissorsArray[rockPaperScissors];

                if (rockPaperScissors == userPick)
                {
                    Console.WriteLine($"Both players picked {pickFromArray}, it's a tie");
                    continue;
                }
                else if (rockPaperScissors == 0)
                {
                    Console.WriteLine($"The computer picked {computerPickFromArray}");
                    if (userPick == 1)
                    {
                        Console.WriteLine($"You picked {pickFromArray}\n\n" +
                        $"You win");
                        userPoints++;
                    }
                    else
                    {
                        Console.WriteLine($"You picked {pickFromArray}\n\n" +
                            $"You lose");
                        pcPoints++;
                    }
                }
                else if (rockPaperScissors == 1)
                {
                    Console.WriteLine($"The computer picked {computerPickFromArray}");
                    if (userPick == 0)
                    {
                        Console.WriteLine($"You picked {pickFromArray} \n\n" +
                            $"You lose");
                        pcPoints++;
                    }
                    else
                    {
                        Console.WriteLine($"You picked {pickFromArray}\n\n" +
                        $"You win");
                        userPoints++;
                    }
                }
                else if (rockPaperScissors == 2)
                {
                    Console.WriteLine($"The computer picked {computerPickFromArray}");
                    if (userPick == 0)
                    {
                        Console.WriteLine($"You picked {pickFromArray} \n\n" +
                            $"You win");
                        userPoints++;
                    }
                    else
                    {
                        Console.WriteLine($"You picked {pickFromArray}\n\n" +
                        $"You lose");
                        pcPoints++;
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong, try again \n");
                    continue;
                }

                Console.WriteLine($"The score is User: {userPoints}, Computer: {pcPoints} \n");
            }

            if (userPoints == 3)
            {
                Console.WriteLine("you win!!");
            }
            else if (pcPoints == 3)
            {
                Console.WriteLine("you lose....wa wa waaaa");
            }
            Console.ReadLine();

        }
    }
}
