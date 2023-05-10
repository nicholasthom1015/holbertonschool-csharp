using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        int res = Math.Abs(number % 10);
        Console.Write(res);
        return res;
    }
}