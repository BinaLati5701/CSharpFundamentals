using CSharpFundamentals.Fundamentals_I;
using CSharpFundamentals.LeetCodePractice;
using System;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Loops loops = new Loops();
            //loops.PrintValues();
            //loops.DivisibleByThreeOrFive();
            //loops.FizzBuzzWithWhileLoop();

            //Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console");
            //// Variable to interpolate
            //string place = "Coding Dojo";
            ////Interpolated string, note the $
            //string message = $"Hello {place}";
            //// Displaying final message
            //Console.WriteLine(message);
            //// We can also do string interpolation like so
            //Console.WriteLine("Hello {0}", place);

            //Random rand = new Random();
            //for (int val = 0; val < 10; val++)
            //{
            //    //Prints the next random value between 2 and 8
            //    Console.WriteLine(rand.Next(2, 8));
            //}

            MultiDimentionalArrays m = new MultiDimentionalArrays();
            //m.printMultiDimentional();
            //m.jaggedArrays();
            //m.multiDimentionalTable();

            //PalindromeString palindrome = new PalindromeString();
            //string s1 = "A man, a plan, a canal: Panama";
            //string s2 = "race a car";
            //string s3 = "";
            //Console.WriteLine(palindrome.IsPalindrome(s1));
            //Console.WriteLine(palindrome.IsPalindrome(s2));
            //Console.WriteLine(palindrome.IsPalindrome(s3));

            //MinMaxValue value = new MinMaxValue();  
            //int [] arr = { 3, 34, 5, 49, -1, 0, 15 };
            //Console.WriteLine(value.minValue(arr));
            //Console.WriteLine(value.maxValue(arr));


            BoxingAndUnboxing bu = new BoxingAndUnboxing();
            bu.mixList();




        }
    }
}
