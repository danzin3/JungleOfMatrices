using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JungleOfMatrices
{
    public static class MatrixUtils
    {
        public static List<List<int>> BuildListMatrix(int rows, int cols)
        {
            var resp = new List<List<int>>();
            int value = 1;
            for (int i = 0; i < rows; i++)
            {
                var line = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    line.Add(value++);
                }
                resp.Add(line);
            }
            return resp;
        }

        public static int[,] BuildSquare2DMatrix(int order)
        {
            var resp = new int[order, order];
            int value = 1;
            for(int i=0; i<order; i++)
            {
                for(int j=0; j<order; j++)
                {
                    resp[i, j] = value++;
                }
            }
            return resp;
        }

        public static int[][] BuildJaggedArrayMatrix(int[] rowSize)
        {
            var resp = new int[rowSize.Length][];
            int value = 1;
            for(int i=0; i<rowSize.Length; i++)
            {
                resp[i] = new int[rowSize[i]];
                for(int j=0; j < rowSize[i]; j++)
                {
                    resp[i][j] = value++;
                }
            }
            return resp;
        }
    }
}
