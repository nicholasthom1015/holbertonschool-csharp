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
        if ((matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 ||
        matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3) ||
        (matrix.GetLength(0) != matrix.GetLength(1)))
            return false;
        return true;
    }

    static bool ValidateMatrix2D(double[,] matrix)
    {
        return (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2);
    }

    ///<summary> Matrix Multiplication Method</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] {{-1}};

        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int Row_A = 0; Row_A < matrix1.GetLength(0); Row_A++)
            for (int Col_B = 0; Col_B < matrix2.GetLength(1); Col_B++)
                for (int Col_A = 0; Col_A < matrix1.GetLength(1); Col_A++)
                    result[Row_A, Col_B] += matrix1[Row_A, Col_A] * matrix2[Col_A, Col_B];
        return result;
    }

    ///<summary> Rotate Matrix Method</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        angle *= -1;
        if (! ValidateMatrix2D(matrix))
            return new double[,] {{-1}};
        double[,] result = new double[2, 2], rotation = new double[2,2] ;
        rotation[0, 0] =  Math.Cos(angle);
        rotation[0, 1] = -1 * Math.Sin(angle);
        rotation[1, 0] = Math.Sin(angle);
        rotation[1, 1] = Math.Cos(angle);
        result = Multiply(matrix, rotation);
        for(int i = 0; i < result.GetLength(0); i++)
            for(int j = 0; j < result.GetLength(1); j++)
                result[i, j] = Math.Round(result[i, j], 2);
        return result;
    }

    ///<summary> Shear Matrix Method</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (! ValidateMatrix2D(matrix))
            return new double[,] {{-1}};
        if (!(direction == 'x' || direction == 'y'))
            return new double[,] {{-1}};
        double[,] shear;
        if (direction == 'y')
            shear = new double[,] {{1, factor}, {0, 1}};
        else
            shear = new double[,] {{1, 0}, {factor, 1}};
        return Multiply(matrix, shear);
    }

    ///<summary> Transpose Matrix Method</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for(int i = 0; i < matrix.GetLength(0); i++)
            for(int j = 0; j < matrix.GetLength(1); j++)
                result[j, i] = matrix[i, j];
        return result;
    }

    ///<summary> Determinant Matrix Method</summary>
    public static double Determinant(double[,] matrix)
    {
        if (!ValidateMatrix(matrix))
            return -1;
        if (ValidateMatrix2D(matrix))
            return  Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
        double result = 0;
        double? temp = null;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = null;
            for(int j = 0; j < matrix.GetLength(1);j++)
                temp = temp.GetValueOrDefault(1) * matrix[j, (i + j) % matrix.GetLength(1)];
            result += temp.GetValueOrDefault(0);
        }
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            temp = null;
            for(int j = 0; j < matrix.GetLength(1);j++)
            {
                temp = temp.GetValueOrDefault(1) * matrix[matrix.GetLength(1) - 1 - j, (i + j) % matrix.GetLength(1)];
            }
            result -= temp.GetValueOrDefault(0);       
        }
        return  Math.Round(result, 2);
    }

}