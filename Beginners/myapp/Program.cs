using System;
using System.Collections.Generic;
using System.Linq;
namespace myapp
{
    class Program
    {
        static void Main(string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            switch(region)
            {
                case "intro":
                    Intro();
                    break;
                case "strings":
                    Strings();
                    break;
                case "variables":
                    Variables();
                    break;
                case "interpolation":
                    Interpolation();
                    break;
                case "methods":
                    Methods();
                    break;
                case "collections":
                    Collections();
                    break;
                case "handcoded":
                    PascalsTriangle.HardCoded();
                    break;
                case "handcoded-answer":
                    PascalsTriangle.MoreHardCoded();
                    break;
                case "more-arrays":
                    PascalsTriangle.ArraysOfArrays();
                    break;
                case "initialize-in-loop":
                    PascalsTriangle.InitInLoops();
                    break;
            }
        }
        public static void Intro()
        {
            #region intro
            Console.WriteLine("Hello World!");
            #endregion
        }
        public static void Strings()
        {
            #region strings
            Console.WriteLine("Hello Rain");
            #endregion
        }
        public static void Variables()
        {
            #region variables
            var name = "Rain";
            Console.WriteLine("Hello " + name + "!");
            #endregion
        }
        
        public static void Interpolation()
        {
            #region interpolation
            var name = "Rain";
            Console.WriteLine($"Hello {name}!");
            #endregion
        }
        public static void Methods()
        {
            #region methods
            var name ="Rain";
            Console.WriteLine($"Hello {name.ToUpper()}!");
            #endregion
        }
        public static void Collections()
        {
            #region collections
            var names = new List<string> { "Rain", "Sage", "Lee" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            #endregion
        }

        public static void PascalsTriangleHardCoded()
        {
            #region handcoded
            int[] row0 = new int[] { 1 };
            int[] row1 = new int[] { 1, 1 };
            int[] row2 = new int[] { 1, row1[0] + row1[1], 1 };
            Console.WriteLine(row0[0]);

            foreach (var item in row1)
                Console.Write(item + " ");
            Console.WriteLine();

            foreach (var item in row2)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion
        }

        public static void PascalsTriangleMoreHardCoded()
        {
            #region handcoded-answer
            int[] row0 = new int[] { 1 };
            int[] row1 = new int[] { 1, 1 };
            int[] row2 = new int[] { 1, row1[0] + row1[1], 1 };
            int[] row3 = new int[] { 1, row2[0] + row2[1], row2[1] + row2[2], 1 };
            int[] row4 = new int[] { 1, row3[0] + row3[1], row3[1] + row3[2], row3[2] + row3[3], 1 };
            Console.WriteLine(row0[0]);

            foreach (var item in row1)
                Console.Write(item + " ");
            Console.WriteLine();

            foreach (var item in row2)
                Console.Write(item + " ");
            Console.WriteLine();

            foreach (var item in row3)
                Console.Write(item + " ");
            Console.WriteLine();

            foreach (var item in row4)
                Console.Write(item + " ");
            Console.WriteLine();
            #endregion
        }

        public static void PascalsTriangleArraysOfArrays()
        {
            #region more-arrays
            int[][] triangle = new int[5][];
            triangle[0] = new int[] { 1 };
            triangle[1] = new int[] { 1, 1 };
            triangle[2] = new int[] { 1, triangle[1][0] + triangle[1][1], 1 };
            triangle[3] = new int[] { 1, triangle[2][0] + triangle[2][1], triangle[2][1] + triangle[2][2], 1 };
            triangle[4] = new int[] { 1, triangle[3][0] + triangle[3][1], triangle[3][1] + triangle[3][2], triangle[3][2] + triangle[3][3], 1 };

            foreach (int[] row in triangle)
            {
                foreach (var item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            #endregion
        }

        public static void PascalsTriangleInitInLoops()
        {
            #region initialize-in-loop
            int[][] triangle = new int[5][];
            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                triangle[rowIndex] = new int[rowIndex + 1];
                triangle[rowIndex][0] = 1;

                for (int column = 1; column < rowIndex; column++)
                    triangle[rowIndex][column] = triangle[rowIndex - 1][column - 1] + triangle[rowIndex - 1][column];

                triangle[rowIndex][rowIndex] = 1;
            }
            foreach (int[] row in triangle)
            {
                foreach (var item in row)
                    Console.Write(item + " ");
                Console.WriteLine();
            }
            #endregion
        }

        public static void PascalsTriangleFormattings()
        {
            #region formatting
            const int MaxRows = 5;
            int[][] triangle = new int[MaxRows][];
            for (int rowIndex = 0; rowIndex < MaxRows; rowIndex++)
            {
                triangle[rowIndex] = new int[rowIndex + 1];
                triangle[rowIndex][0] = 1;

                for (int column = 1; column < rowIndex; column++)
                    triangle[rowIndex][column] = triangle[rowIndex - 1][column - 1] + triangle[rowIndex - 1][column];

                triangle[rowIndex][rowIndex] = 1;
                rowIndex++;
            }
            const int fieldWidth = 6;
            foreach (int[] row in triangle)
            {
                int indent = (MaxRows - row.Length) * (fieldWidth / 2);
                Console.Write(new string(' ', indent));
                foreach (var item in row)
                    Console.Write($"{item, fieldWidth}");
                Console.WriteLine();
            }
            #endregion
        }
    }
}
