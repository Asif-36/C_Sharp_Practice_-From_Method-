// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            /* string name;
             int age;

             Console.WriteLine("enter your name");
             name = Console.ReadLine();

             Console.WriteLine("Enter your age");
             age = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine($"Hello! My Name is {name} , I am {age} years old"); */






            /* Console.WriteLine("Enter Your desier age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minnor");
            }
            Console.WriteLine("Enter your marks:");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");

            }
            Console.WriteLine("Enter your temp:");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (temperature > 30)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("Cold");
            }
            */





            /* Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 % 2 == 0)
            {
                Console.WriteLine("First number is Even");
            }
            else
            {
                Console.WriteLine("First number is Odd");
            }

            if (number2 % 2 == 0)
            {
                Console.WriteLine("Second number is Even");
            }
            else
            {
                Console.WriteLine("Second number is Odd");
            }

            if (number3 % 2 == 0)
            {
                Console.WriteLine("Third number is Even");
            }
            else
            {
                Console.WriteLine("Third number is Odd");
            }
            */


            /*for (int i = 1; i <= 50; i++)
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            Console.WriteLine("OR");


            for (int i = 1; i <= 50; i=i+2)
                
                {
                    Console.WriteLine(i);
                }
            */


            /*

            string[] myFriends = { "Hasib", "Shamim", "Abid", "Bony" };
            for (int i = 0; i < myFriends.Length; i++)
            {
                Console.WriteLine(myFriends[i]);
            }

            Console.WriteLine("Or");

            string[] mySubjects = { "Airtificial Intellogence", "Database", "Web Application" };
            foreach (string s in mySubjects)
            {
                Console.WriteLine(s);
            }

            */

            Console.WriteLine("List");

            List<string> myFriendsName = new List<string>();    

            myFriendsName.Add("Asif");
            myFriendsName.Add("Abdullah");
            myFriendsName.Add("Shamim");
            myFriendsName.Add("Rakib");
            myFriendsName.Add("Bony");

            foreach (string friendName in myFriendsName)
            {
                Console.WriteLine(friendName);
            }



            Console.WriteLine("Dictionary");

            Dictionary<int,string> student = new Dictionary<int,string>();

            student.Add(763, "Asif");
            student.Add(775, "Shamim");
            student.Add(757, "Abid");

            foreach (KeyValuePair <int, string> KVP in student)
            {
                Console.WriteLine($"Student ID: {KVP.Key} Student Name: {KVP.Value}");
            }

            Console.WriteLine("Stack");



            Stack<string> Books = new Stack<string>();  //Stack Toiri kora

            Books.Push("C# Programming");   //Boi gula list koresi.
            Books.Push("Data Structures");
            Books.Push("Algorithm");

          
            foreach (string book in Books)
            {
                Console.WriteLine(book); //But print hobe stack er Last in first out onuzai. Alg>Data>C#. 
            }

            Console.WriteLine($"Top Books {Books.Pop()}");  //ekhan e arekta kotha, Pop() korar por Algorithm boita next e ar print hobe na ba list e thakbe na





            Console.WriteLine("Queue");



            Queue<string> queue = new Queue<string>();  // Queue তৈরি

            // Queue-তে উপাদান যোগ করা
            queue.Enqueue("Asif");
            queue.Enqueue("Rahim");
            queue.Enqueue("Karim");

            // প্রথম উপাদান বের করা
            Console.WriteLine("First Person: " + queue.Dequeue());  // Output: Asif

            // Queue-এর সব উপাদান দেখানো
            foreach (string person in queue)
            {
                Console.WriteLine(person);
            }


            /*Console.WriteLine("NEXT");
            int j = 0;
            while (j < 101)
            {
                Console.WriteLine(j);
               j = j+2;
            }
            */















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
    