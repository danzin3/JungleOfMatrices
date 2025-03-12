﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** List of List 
 *  Variable both rows and columns
 *  Slowest performance (Boxed storage, GC overhead)
 *  High memory usage (overhead for objects, pointers)
 *  Easy to sort and order by
 *  Used in dynamic tables, CSV processing among others
 */

namespace JungleOfMatrices
{
    public static class ListMatrix
    {
        public static void RowWise(List<List<int>> listMatrix)
        {
            Console.WriteLine("\n\nRow-wise traversal\nFrom left to right (traditional traversal)");

            for (int i = 0; i < listMatrix.Count; i++)
            {
                for (int j = 0; j < listMatrix[i].Count; j++)
                {
                    Console.Write($"{listMatrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
