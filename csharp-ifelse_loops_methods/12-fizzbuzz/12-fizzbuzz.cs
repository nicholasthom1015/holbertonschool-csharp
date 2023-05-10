using System;

public class FIZZBUZZ
{
    public static void Main(string[] args)
    {
        string res = null;
        for(int i = 1; i <= 100; i++, res = null)
        {
            if( i % 3 == 0)
            {
                res += "Fizz";
            }
            if( i % 5 == 0)
                res += "Buzz";
            if (res==null)
                res = i.ToString("0");
            Console.Write("{0}{1}", res, i == 100 ? "\n" : " ");
        }
    }
}