using System;

namespace ExploreCsharpSeven
{
    static class RefLocalsAndReturns
    {
        #region RefFindMethod
        public static (int i, int j) Find(int[,] matrix, Func<int, bool> predicate)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (predicate(matrix[i, j]))
                        return (i, j);
            return (-1, -1); // Not found
        }
        #endregion

        public static int TestRefFind()
        {
            #region RefTestCode
            int[,] sourceMatrix = new int[10, 10];
            for (int x = 0; x < 10; x++)
                for (int y = 0; y < 10; y++)
                    sourceMatrix[x, y] = x * 10 + y;

            var indices = Find(sourceMatrix, (val) => val == 42);
            Console.WriteLine(indices);
            sourceMatrix[indices.i, indices.j] = 24;
            #endregion
            return 0;
        }
    }
}
