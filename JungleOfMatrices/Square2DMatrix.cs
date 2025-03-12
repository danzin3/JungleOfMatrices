using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Multidimensional Array (2D array or matrix)
*  Memory is allocated as a single block (continuous memory)
*  Fixed number of rows and columns
*  Access elements using one pair of square brackets: matrix[row, col]
*  Slightly faster access (cache-friendly)
*  Used in chessboard, images, 2D grids among others
*/

namespace JungleOfMatrices
{
    public static class Square2DMatrix
    {
        public static void RowWise(int[,] matrix)
        {
            // Get the number of rows and columns
            int matrixRows = matrix.GetLength(0);
            int matrixCols = matrix.GetLength(1);

            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixCols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
