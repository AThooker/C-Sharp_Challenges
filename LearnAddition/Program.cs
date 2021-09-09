using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program that generates two integers under 100 and prompts the user to enter the sum of these two integers. The program then reports TRUE if the answer is correct, FALSE otherwise. 
            */
            Random randomObject = new Random();
            int firstRandNum = randomObject.Next(0, 100);
            int secondRandNum = randomObject.Next(0, 100);
            int sum = firstRandNum + secondRandNum;

            while (true)
            {
                Console.WriteLine("What is the sum of these two integers?: \n" +
                    firstRandNum + " + " + secondRandNum + " = ?");

                int answer = int.Parse(Console.ReadLine());
                if (sum == answer)
                {
                    Console.WriteLine("TRUE");
                    break;
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            Console.ReadKey();
        }
    }
}
