using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Fundamentals_I
{
    public class Loops
    {
        public void PrintValues()
        {
            for (int i = 1; i < 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void DivisibleByThreeOrFive()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

        }

        public void FizzBuzzWithWhileLoop()
        {
            int i = 1;
            while(i < 100)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
                i++;
            }
           

        }
    }
}
