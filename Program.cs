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
        public static void Main(string[] args) { 


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
      
        //Console.Read();
    }

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

    }

}
