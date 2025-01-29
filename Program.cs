// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
       
             public static void Main()
        {
            /* Console.WriteLine("Asif");
             Console.WriteLine("CSharp");
             Console.WriteLine("23");
             Console.WriteLine("Reading Islamic Books");*/

            //Console.WriteLine("Sayad Md Asif\nBangla\n23\nReading Islamic Books");

            string name;
            int age;

            Console.WriteLine("enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello! My Name is {name} , I am {age} years old");


        



        /* Console.WriteLine("Enter number 1 to 10");
         string input = Console.ReadLine() ?? "";
         //input = input.Trim().ToLower();

         int result = int.Parse(input);
         while (true)
         {
             if (input == "quit")
             {
                 Console.WriteLine("GoodBuy");
                 break;
             }

             if (!int.TryParse(input, out int result))
             {
                 Console.WriteLine("Your input is invalid, please try valid input");
                 continue;
             }
             if (!(result >= 1 && result <= 10))
             {
                 Console.WriteLine($"Your input in not range");
                 continue;
             }

             int square = result * result;
             Console.WriteLine($"Square of {result} = {square}");


         }*/
    }
        /*
int number1, number2;

    Message();
    Console.WriteLine("Enter first number");
number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Second number");
number2 = Convert.ToInt32(Console.ReadLine());

    Add(number1, number2);
    Sub(number1, number2);
    Mul(number1, number2);
    Div(number1, number2);

    //Console.Read();   */




    }
}

   
     /*   
        public static void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {result}");

        }

        public static void Sub(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {result}");

        }

        public static void Mul(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine($"{number1} * {number2} = {result}");

        }

        public static void Div(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine($"{number1} / {number2} = {result}");

        }

        public static void Message()
        {
            Console.WriteLine("Welcome to Asif,s Calculator");
            Console.WriteLine("Please enter two number");
        }
     */
    