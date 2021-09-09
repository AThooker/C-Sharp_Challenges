using System;
using System.Collections.Generic;

namespace _01_Basic_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            int[] shiftedArray = ShiftArrayLeft(myArray);
            foreach (var number in shiftedArray)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
        //print duplicate characters in string
        public static string RemoveDuplicateCharacters(string testString)
        {
            string table = "";
            string result = "";

            foreach (char letter in testString)
            {
                if (!table.Contains(letter))
                {
                    result += letter;
                    table += letter;
                }
                else
                {
                    table += letter;
                }
            }
            return result;
        }

        //Test if strings are anagrams
        public static bool AnagramTesting(string x, string y)
        {
            char[] a = x.ToLower().ToCharArray();
            char[] b = y.ToLower().ToCharArray();
            Array.Sort(a);
            Array.Sort(b);
            string newStringOne = new string(a);
            string newStringTwo = new string(b);
            if (newStringOne == newStringTwo)
            {
                return true;
            }
            return false;
        }

        //shift array left (front goes to back)
        public static int[] ShiftArrayLeft(int[] intArray)
        {
            int[] newArray = new int[intArray.Length];
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                newArray[i] = intArray[i + 1];
            }
            newArray[intArray.Length - 1] = intArray[0];
            return newArray;
        }
    }
}
