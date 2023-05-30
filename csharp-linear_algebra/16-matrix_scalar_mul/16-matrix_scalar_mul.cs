using System;

/// <summary> Matrix Math class</summary>
public static class MatrixMath
{
    /// <summary> Matrix Addition Method</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) ||
        matrix1.GetLength(1) != matrix2.GetLength(1) ||
        matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3 ||
        matrix1.GetLength(1) < 2 || matrix1.GetLength(1) > 3)
                return new double[,] {{-1}};

        double[,] sum = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
        return sum;
    }

    /// <summary> Matrix Scalar Multiplication Method</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if(matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
        matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            return new double[,] {{-1}};

        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                 result[i, j] = matrix[i, j] * scalar;
        return result;
    }

    ///<summary> Valiadates a Matrix to be 2D or 3D</summary>
    public static bool ValidateMatrix(double[,] matrix)
    {
        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
        matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
            return false;
        return true;
    }
}