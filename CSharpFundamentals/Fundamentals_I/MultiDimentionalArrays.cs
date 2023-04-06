using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFundamentals.Fundamentals_I
{
    public class MultiDimentionalArrays
    {
        public void printMultiDimentional()
        {
            // Multidimensional array declaration
            // This example contains 3 arrays -- each of these is length 2 -- all initialized to zeroes.
            int[,] array2D = new int[3, 2];
            // This is equivalent to:
            //  int [,] array2D = new int[3,2]  {  { 0,0 }, { 0,0 }, { 0,0 } }; 
            // This example has 2 large rows that each contain 3 arrays -- and each of those arrays is length 4.
            int[,,] array3D = new int[2, 3, 4]
                {
        {  { 45,1,16,17 }, { 4,47,21,68 }, { 21,28,32,76 }  },
        {  { 11,0,85,42 }, { 9,10,14,96 }, { 66,99,33,12 }  }
                };
            // Directly accessing a multidimensional array
            Console.WriteLine(array2D[0, 1]);   // prints 0
            Console.WriteLine(array3D[1, 0, 3]); // prints 42

        }

        public void jaggedArrays()
        {
            // Jagged array declaration
                int[][] jaggedArray = new int[3][];
                jaggedArray[0] = new int[5];
                jaggedArray[1] = new int[4];
                jaggedArray[2] = new int[2];

                int[][] jaggedArray2 = new int[][] {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
                };
            // Short-hand form
                int[][] jaggedArray3 = {
                new int[] {1,3,5,7,9},
                new int[] {0,2},
                new int[] {11,22,33,44}
                };
            // You can even mix jagged and multi-dimensional arrays
            int[][,] jaggedArray4 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };
            // Working through each array in a jagged array
            foreach (int[] innerArr in jaggedArray)
            {
                Console.WriteLine("Inner array length is {0}", innerArr.Length);
            }
            // Accessing a jagged array
            Console.WriteLine(jaggedArray2[0][1]); // 3
            Console.WriteLine(jaggedArray3[2][3]); // 44


        }



        public void multiDimentionalTable()
        {
            int[,] multi = new int[10,10]
            {       
                 {1,2,3,4,5,6,7,8,9,10},
                 {2,4,6,8,10,12,14,16,18,20},
                 {3,6,9,12,15,18,21,24,27,30},
                 {4,8,12,16,20,24,28,32,36,40},
                 {5,10,15,20,25,30,35,40,45,50},
                 {6,12,18,24,30,36,42,48,54,60},
                 {7,14,21,28,35,42,49,56,63,70},
                 {8,16,24,32,40,48,56,64,72,80},
                 {9,18,27,36,45,54,63,72,81,90},
                 {10,20,30,40,50,60,70,80,90,100}

            };



           
            for (int i = 0; i < 10; i++)
            {              
                
                for (int j = 0; j < 10; j++) 
                {                   
                    Console.Write("{0}, ",  multi[i, j]);
                    
                }
                
                Console.WriteLine();               
            }
            Console.ReadLine();

        }
    }
}
