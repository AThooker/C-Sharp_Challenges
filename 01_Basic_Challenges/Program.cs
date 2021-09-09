using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic_Challenges
{
    class Program
    {
        public string Name { get; set; }
        static void Main(string[] args)
        {
            //Sum of numbers from an int
            //Console.WriteLine("Input a number(integer): ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //while(n != 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine("Sum of the digits: " + sum);
            //Console.ReadLine();

            //Reversing words of a sentence

            //Console.WriteLine("Enter a string and I will return it in reverse order");
            //string sampleString = Console.ReadLine();
            //string result = "";
            //List<string> wordList = new List<string>();
            //string[] listOfStrings = sampleString.Split(new[] { " " }, StringSplitOptions.None);
            //for(int i = listOfStrings.Length - 1; i >= 0; i--)
            //{
            //    result += listOfStrings[i] + " ";
            //}
            //wordList.Add(result);
            //foreach(string word in wordList)
            //{
            //    Console.WriteLine(word);
            //}

            //Finding size of file in bytes....wild
            //FileInfo f = new FileInfo("C:/Users/17654/Desktop/EFA-LA/SD102/ProblemSolving/ProblemSolving.sln");
            //Console.WriteLine("Size of the file: " + f.Length.ToString());


            //Convert a Hexidecimal string to decimal value
            //Console.WriteLine("Give me a string and I will show you the decimal value");
            //string hex = Console.ReadLine();
            //int decimalValue = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine("String you gave me: " + hex);
            //Console.WriteLine("Converted to decimal: " + decimalValue);


            //Get the product of multiplying integers from one array to integers from another in their corresponding index values
            //int[] firstArray = new int[] { 1, 2, 3, 4 };
            //int[] secondArray = new int[] { 1, 2, 3, 4 };
            //int[] thirdArray = new int[4];
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    thirdArray[i] = firstArray[i] * secondArray[i];
            //}
            //foreach (int number in thirdArray)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine(TripleSum(3,3));
            //Console.WriteLine(AbsoluteDiff(41));
            int[] nums = { 2,3,4,5};
            Console.WriteLine(SumOfArray(nums));

            Console.ReadLine();
        }
        //Write a C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum
        public static int TripleSum(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
            //if(a == b)
            //{
            //    return (a + b) * 3;
            //}
            //return a + b;
        }

        //Write a C# Sharp program to get the absolute difference between n and 51.
        //If n is greater than 51 return triple the absolute difference
        public static int AbsoluteDiff(int x)
        {
            int y = Math.Abs(51 - x);

            return x > 51 ? y * 3 : y;
        }

        //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
        //If the string already begins with 'if', return the string unchanged.
        public static string AddingIf(string testString)
        {
            if (testString.StartsWith("if"))
            {
                return testString;
            }
            else
            {
                return "if " + testString;
            }
        }

        //Write a C# Sharp program to remove the character in a given position of a given string.
        //The given position will be in the range 0.. string length -1 inclusive.
        public static string RemoveCharacter(int x, string testString)
        {
            return testString.Remove(x, 1);
        }
        //Write a C# Sharp program to exchange the
        //first and last characters in a given string and return the new string.
        public static string SwitchFirstAndLast(string testString)
        {
            int length = testString.Length;
            return testString[length - 1] + testString.Substring(1, length - 2) + testString[0];
        }
        //Create a console app that will take an input from the user for their name(at least four (4) characters) long.
        //Prompt for two(2) numbers
        //Prompt for operation
        //Perform operation indicated on the two(2) numbers and return something like: "Hi {name}, here is the answer to your equation. {x} {+} {y} = {answer}"


        //Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
        //If the given string length is less than 2 return the original string. 

        public static string CopyCharacters(string original)
        {
            if(original.Length < 2)
            {
                return original;
            }
            return original.Substring(0,2) + original.Substring(0,2) + original.Substring(0,2) + original.Substring(0,2);
        }
        //Write a C# Sharp program to create a new string with the
        //last char added at the front and back of a given string of length 1 or more
        public string AddLastchar(string stringAgain)
        {
            int len = stringAgain.Length - 1;
            return stringAgain.Length >= 1 ? stringAgain[len] + stringAgain + stringAgain[len] : "No characters added";
        }

        //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
        public static bool IsMultiple(int number)
        {
            return (number % 3 == 0) || (number % 7 == 0) ? true : false;
        }

        //Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there

        public static string GetFirstThreeChar(string testString)
        {
            if(testString.Length < 3)
            {
                return testString + testString + testString;
            }
            string frontOfString = testString.Substring(0, 3);
            return frontOfString + testString + frontOfString;
        }


        //Write a C# Sharp program to check if a given string starts with 'C#' or not.
        public static bool CheckForStart(string testString)
        {
            if (testString.StartsWith("C#"))
            {
                return true;
            }
            return false;
        }

        //Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character

        public static bool CheckForZValue(string testString)
        {
            int counter = 0;
            for(int i = 0; i < testString.Length; i++)
            {
                if(testString[i] == 'z')
                {
                    counter++;
                }
            }
            return counter >= 2 && counter <= 4;
            //if(counter >= 2 && counter <= 4)
            //{
            //    return true;
            //}
            //return false;
        }

        //Write a C# Sharp program to check if two given non-negative integers have the same last digit.

        public static bool CheckSameLastDigit(int x, int y)
        {
            //string newXString = x.ToString();
            //int len = newXString.Length - 1;
            //string newYString = y.ToString();
            //int length = newYString.Length - 1;
            //return newXString[len] == newYString[length] ? true : false;
            return Math.Abs(x % 10) == Math.Abs(y % 10);
        }

        //Write a C# Sharp program to convert the last 3 characters of a given string in upper case. If the length of the string has less than 3 then uppercase all the characters

        public static string ConvertLastThree(string testString)
        {
            if(testString.Length <= 3)
            {
                return testString.ToUpper();
            }
            return testString.Remove(testString.Length - 3) + testString.Substring(testString.Length - 3).ToUpper();
        }

        //Celcius to Fahrenheit
        public static double ConvertFromCelsToFahr(double celcius)
        {
            double fahrenheit = (celcius * 9 / 5) + 32; 
            return fahrenheit;
        }

        //Elementary Arithmetic
        public static string ElementaryOperations(int x, int y)
        {
            int add = x + y;
            int sub = x - y;
            int mult = x * y;
            int div = x / y;
            return $"{add}, {sub}, {mult}, {div}";
        }

        //IsArithmeticResultSame
        public static bool IsResultSame(double x, double y)
        {
            return x == y;
        }
        //CheckDuplicatesInArray
        public static int CheckDuplicatesInArray(int[] intArray, int x)
        {
            return intArray.Count(n => n == x);
        }

        //SumOfElements
        public static int SumOfArray(int[] nums)
        {
            int count = 0;
            foreach(int number in nums)
            {
                count += number;
            }
            return count;
        }

    }
}
