using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumMaximumTrianglePaths
{
    class Program
    {
        static int minSumPath(ref List<List<int>> A)
        {
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
