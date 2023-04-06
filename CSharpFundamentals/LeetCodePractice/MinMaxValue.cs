using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.LeetCodePractice
{
    public class MinMaxValue
    {
        public int minValue(int[] arr)
        {
            int min = arr[0];
            for( int i = 0; i < arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public int maxValue(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
