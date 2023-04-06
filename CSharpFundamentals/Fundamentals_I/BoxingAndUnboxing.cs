using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals.Fundamentals_I
{
    public class BoxingAndUnboxing
    {
        public void SafeUnboxing()
        {
            //Box some string data into a variable
            object BoxedData = "This is clearly a string";
            //Make sure it is the type you need before proceeding
            if (BoxedData is int)
            {
                //This shouldn't run
                Console.WriteLine("I guess we have an integer value in this box?");
            }
            if (BoxedData is string)
            {
                Console.WriteLine("It is totally a string in the box!");
            }

        }

        public void SafeExplicitCasting()
        {
            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string;

            // THIS WON'T WORK!!
            object ActuallyInt = 256;
            //int ExplicitInt = ActuallyInt as int;

        }

        /// <summary>
        /// Create an empty List of type object
        /// Add the following values to the list: 7, 28, -1, true, "chair"
        /// Loop through the list and print all the values
        /// Add all values that are int type together and output the sum
        /// Hint: Type Inference (var) might help here
        /// </summary>
        public void mixList()
        {
            List<object> mixObject = new List<object>();
            mixObject.Add(7);
            mixObject.Add(28);
            mixObject.Add(-1);
            mixObject.Add(true);
            mixObject.Add("chair");
           

            foreach(var allMix in mixObject)
            {
                Console.WriteLine( allMix);               
               
            }
            var sum = mixObject.OfType<int>().Sum();
            Console.WriteLine($"The sum of only int type values is {sum}");
           

        }
    }

}
