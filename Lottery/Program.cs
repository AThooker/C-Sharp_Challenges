using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Generate a three-digit lottery number. The program prompts the user to enter a three-digit number and determines whether the user wins according to the following rules:
                1) If the user input matches the lottery number in the exact order, the award is $10,000.
                
                2) If all the digits in the user input match all the digits in the lottery number, the award is $3,000.

                3) If one digit in the user input matches a digit in the lottery number, the award is $1000.

            User should only win one prize (granted they meet one of the rules) so if they meet the $10,000 rule then that's it or if they win the $3,000 that's it as well. 
            */
            int winningAmount = 0;
            Random randomObject = new Random();
            int intLotto = randomObject.Next(100, 999);
            var stringLotto = intLotto.ToString();

            Console.WriteLine("Are you feeling lucky?\n" +

                "It is your turn to win the lottery!!\n" +

                "Or at least try to win by guessing this random 3-digit number!!");

            while (true)
            {
                Console.Write("What is your guess? Remember it must be a 3-digit number: ");
                string stringGuess = Console.ReadLine();
                Console.Clear();
                int numberGuess = Convert.ToInt32(stringGuess);
                //Catch
                if (numberGuess < 100 || numberGuess > 999)
                {
                    Console.WriteLine("Someone isn't following the rules, please keep it between 100 and 999");
                    continue;
                }
                //10,000
                else if (intLotto == numberGuess)
                {
                    Console.Clear();
                    Console.WriteLine("You have done it you son of a gun, you've won $10,000");
                    winningAmount += 10000;
                    break;
                }
                //3,000

                int counter = 0;

                for (int i = 0; i < stringLotto.Length; i++)
                {
                    for (int j = 0; j < stringGuess.Length; j++)
                    {
                        if (stringLotto[i] == stringGuess[j])
                        {
                            counter++;
                        }
                    }
                }
                if (counter == 3)
                {
                    Console.Clear();
                    Console.WriteLine("You have won $3,000!!");
                    winningAmount += 3000;
                    break;
                }

                //1,000
                if (stringLotto.Any(x => stringGuess.Any(y => y == x)))
                {
                    Console.Clear();
                    Console.WriteLine("You have won $1,000");
                    winningAmount += 1000;
                    break;
                }
                Console.WriteLine("Today just wasn't your day, maybe tomorrow!\n");
            }
                Console.WriteLine($"Press enter to collect your winnings");
                Console.ReadLine();
        }
    }
}
