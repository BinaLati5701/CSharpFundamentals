using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Fundamentals_I
{
    public class Arrays
    {
        // Declaring an array of length 5, initialized by default to all zeroes
        int[] numArray = new int[5];
        // Declaring an array with pre-populated values
        // For Arrays initialized this way, the length is determined by the size of the given data
        int[] numArray2 = { 1, 2, 3, 4, 6 };


        public void PrintArrays()
        {
            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };
            int[] arrayOfInts = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
            Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
            Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
            Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
            Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.

            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine($"The first number of the arr is {arr[0]}");
            arr[0] = 8;
            Console.WriteLine($"The first number of the arr is now {arr[0]}");
            // The array has now changed!

            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx" };
            // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine($"I own a {myCars[idx]}");
            }

            
            foreach (string car in myCars)
            {
                // We no longer need the index, because variable 'car' already represents each indexed value
                Console.WriteLine($"I own a {car}");
            }

 
        }

        /// <summary>
        /// Create an array to hold integer values 0 through 9
        ///  Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        /// Create an array of length 10 that alternates between true and false values, starting with true
        /// </summary>
        public void basicArrays()
        {
            int[] numbers = { 0,1,2,3,4,5,6,7,8,9};
            string[] names = { "Tim", "Martin", "Nikki", "Sara" };
            bool[] vs = { true, false, true, false, true, false, true, false, true, false };
            
        }

    }

}
