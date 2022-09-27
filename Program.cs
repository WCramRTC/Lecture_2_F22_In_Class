using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_F22_In_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ReadLineExample();
            // IntAndMathExamples();


        } // Main

        public static void ParseExample()
        {

            // Parse
            // Asking a user for a number
            try
            {
                Console.Write("Enter your first number: ");
                // Saving the users input
                string userNum1 = Console.ReadLine();
                // Trying to parse ( convert ) users input into a number
                int num1 = int.Parse(userNum1);
                Console.WriteLine();
                Console.Write("Enter your first number: ");
                string userNum2 = Console.ReadLine();
                int num2 = int.Parse(userNum2);

                int total = num1 + num2;

                Console.WriteLine($"The sum of {num1} + {num2} = {total}");


            }
            catch
            {
                Console.WriteLine("You entered in an invalid number");
            }


            Console.ReadKey();

            //Console.WriteLine(num1 + num1);
            //Console.WriteLine(userNum1 + num1);



            // Advanced Mathy Stuff
            //Console.WriteLine((char)('a' - ' '));


        } // ParseExample()

        public static void ReadLineExample()
        {

            // ReadLine
            // Console.ReadLine()
            // It reads what types in and saves it
            Console.Write("Please enter a number: ");

            // This reads the users input
            string userInput = Console.ReadLine();
            // This only displays the string userInput
            Console.WriteLine("userInput");
            // This displays the variable
            // The users number is {userInput}
            Console.WriteLine("The users number is " + userInput);
        } // ReadLineExample()

        public static void IntAndMathExamples()
        {

            // Integer - Intergral - Type - Number - Whole Numbers
            int num1 = 6;
            int num2 = 42;
            int num3 = 3;

            int sum = num1 + num2 + num3;

            // .ToString() to covert numbers into strings
            Console.WriteLine(num1.ToString());

            // Number 1 is {num1}
            // Number 2 is {num2}
            // Number 3 is {num3}
            // The sum is {num1}
            //Console.WriteLine(
            //    "Number 1 is " + num1 + "\n" +
            //    "Number 2 is " + num2 + "\n" +
            //    "Number 3 is " + num3 + "\n" +
            //    "The sum of the 3 numbers is " + sum);

            // String Literal
            Console.WriteLine($"Number 1 is {num1}\n" +
                $"Number 2 is {num2}\n" +
                $"Number 3 is {num3}\n" +
                $"The sum of the 3 numbers is {sum}");

            // Math Operators
            // Plus +
            sum = num1 + num2 + num3;
            // Minus - 
            int minus = num3 - num2 - num1;
            // Multiply *
            int multi = num2 * num1 * num3;
            // Divide /
            int divide = num3 / num2 / num1;
            // Modulus - Mod - %
            int mod = num3 % num2 % num1;


            Console.WriteLine(
                $"Plus {sum}\n" +
                $"Minus {minus}\n" +
                $"Multiply {multi}\n" +
                $"Divide {divide}\n" +
                $"Modulus {mod}\n");

            // Divide
            int num4 = 5;
            int num5 = 3;
            int div2 = num4 / num5;
            Console.WriteLine($"{num4} / {num5} = {div2}");

            // Mod
            int mod2 = num4 % num5;
            Console.WriteLine($"{num4} % {num5} = {mod2}");

            // How to find even or odd
            int even = 544;
            int odd = 58347;

            bool isEven = (even % 2) == 0;

            Console.WriteLine($"{even} is an even number - {even % 2 == 0}");
            Console.WriteLine($"{even} is an even number - {even % 2 == 1}");
            Console.WriteLine($"{odd} is an odd number - {odd % 2 == 0}");
            Console.WriteLine($"{odd} is an odd number - {odd % 2 == 1}");

        } // IntAndMathExamples

    } // class
} // namespace
