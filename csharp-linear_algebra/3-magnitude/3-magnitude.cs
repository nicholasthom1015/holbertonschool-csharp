using System;

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
}