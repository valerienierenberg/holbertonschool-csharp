﻿using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        var rowCount = matrix.GetLength(0);  
        var colCount = matrix.GetLength(1);  

        if (rowCount != colCount)  
            throw new InvalidOperationException(Properties.Resources.Exception_RequiredSquareMatrix);  

        var newMatrix = ConcatHorizontally(matrix, CreateIdentityMatrix(rowCount));  

        var result = Eliminate(newMatrix, MatrixReductionForm.ReducedRowEchelonForm, rowCount);  
        if (result.Rank != colCount)  
            return null;  

        return result.Solution;  
    }   
}