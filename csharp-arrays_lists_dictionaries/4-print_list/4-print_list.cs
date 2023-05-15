using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> res = new List<int>();
        for( int i = 0; i < size; i++)
        {
            res.Add(i);
            Console.Write("{1}{0}", i, i!=0?" ":"");
        }
        Console.WriteLine();
        return res;
    }
}