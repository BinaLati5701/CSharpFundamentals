using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.Fundamentals_I
{
    public class TypeCast
    {
        public void CastIntToDouble()
        {
            int IntegerValue = 65;
            double DoubleValue = IntegerValue;
            Console.WriteLine($"Implicit Casting {DoubleValue}");          

        }

        public void CastDoubleToInt()
        {
            double DoubleValue = 3.14159265358;
            int IntegerValue = (int)DoubleValue;
            // IntegerValue == 3

            Console.WriteLine($"Explicit Casting {IntegerValue}");
        }

        public void CastString()
        {
            double floatNum = 7.76;
            //int num = floatNum;
            //This will cause a compiler type-mismatch error!!
            int num = (int)floatNum;
            //Floating point to integer conversion truncates all numbers after the decimal
            //As such num now evaluated to 7

            //int num = (int)"24";
            // This, however, will not work as strings cannot be type cast to int


        }

        public void ConvertToString()
        {
            //Converting an integer to a string
            int num = 7;
            string numAsString = num.ToString(); //Evaluates as "7"

            Console.WriteLine($"Evaluates as '7' {numAsString}");


        }


    }
}
