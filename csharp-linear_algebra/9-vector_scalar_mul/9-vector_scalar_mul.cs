﻿using System;

///<summary>Vector Math class</summary>
public static class VectorMath
{
    ///<summary> Vector Magnitude Method</summary>
    public static double Magnitude(double[] vector)
    {
        if ( vector.Length > 3 || vector.Length < 2)
            return -1;

        double sum = 0;
        foreach (double i in vector)
            sum += i * i;
        return Math.Round(Math.Sqrt(sum), 2);
    }

    ///<summary> Vector Addition Method</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ( vector1.Length != vector2.Length || vector1.Length > 3 || vector1.Length < 2)
            return new double[] {-1};

        double[] sum = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
            sum[i] = vector1[i] + vector2[i];
        return sum;
    }

    ///<summary> Vector Scalar Multiplication Method</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if ( vector.Length > 3 || vector.Length < 2)
            return new double[] {-1};

        double[] product = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            product[i] = vector[i] * scalar;
        return product;
    }
}