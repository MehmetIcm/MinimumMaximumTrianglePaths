using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumMaximumTrianglePaths
{
    class Program
    {
        static int minSumPath(ref List<List<int>> A)
        {
            // For storing the result in a 1-D array, 
            // and at the same time updating the result. 
            int[] myArray = new int[A.Count];
            int n = A.Count - 1;

            // For the bottom row 
            for (int i = 0; i < A[n].Count; i++)
                myArray[i] = A[n][i];

            // Calculation of the remaining rows, 
            // in a bottom up wa. 
            for (int i = A.Count - 2; i >= 0; i--)
                for (int j = 0; j < A[i + 1].Count - 1; j++)
                    myArray[j] = A[i][j] +
                              (int)Math.Min(myArray[j],
                                       myArray[j + 1]);

            // return the top element 
            return myArray[0];
        }
        //We want to short a kind of matrix but it's not a square, it's a triangle. So if we make generic list with lists we can make a triangle
        public static void Main()
        {
            List<List<int>> A = new List<List<int>>();
            A.Add(new List<int> { 7 });
            A.Add(new List<int> { 6, 3 });
            A.Add(new List<int> { 3, 8, 5 });
            A.Add(new List<int> { 11, 2, 10, 9 });
            Console.WriteLine(minSumPath(ref A));
            Console.ReadKey();
        }
    }
}
