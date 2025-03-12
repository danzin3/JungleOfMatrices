using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Jagged Array (an array of arrays)
 *  Fixed rows and variable columns
 *  Memory is allocated separately for each row (not continuous)
 *  Access elements using two pair of square brackets: jaggedArray[row][col]
 *  It needs a defined number of rows to be initialized
 *  Slightly slower access due to extra pointer lookups
 *  Used in rectangular matrices, adjacency lists among others
 */

namespace JungleOfMatrices
{
    public static class JaggedMatrix
    {
        public static void RowWise(int[][] jaggedMatrix)
        {
            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < jaggedMatrix.Length; i++)
            {
                for (int j = 0; j < jaggedMatrix[i].Length; j++)
                {
                    Console.Write($"{jaggedMatrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
