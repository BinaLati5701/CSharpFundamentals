using CSharpFundamentals.Fundamentals_I;
using System;

namespace CSharpFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Loops loops = new Loops();
            loops.PrintValues();
            loops.DivisibleByThreeOrFive();
            loops.FizzBuzzWithWhileLoop();
        }
    }
}
