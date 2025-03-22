#pragma warning disable IDE0300 // Simplify collection initialization
using System;
using JungleOfMatrices;

int[,] matrix = MatrixUtils.BuildSquare2DMatrix(3);
Square2DMatrix.RowWise(matrix);


int[][] jaggedArray = MatrixUtils.BuildJaggedArrayMatrix([3, 2, 4]);
JaggedMatrix.RowWise(jaggedArray);


var listMatrix = MatrixUtils.BuildListMatrix(3, 3);
ListMatrix.RowWise(listMatrix);
ListMatrix.ColumnWise(listMatrix);
