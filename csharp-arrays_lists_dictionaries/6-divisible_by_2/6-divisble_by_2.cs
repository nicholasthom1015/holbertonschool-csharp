using System;
using System.Collections.Generic;
public class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> res = new List<bool>();
        foreach(int i in myList)
            res.Add(i%2==0);
        return res;
    }
}
