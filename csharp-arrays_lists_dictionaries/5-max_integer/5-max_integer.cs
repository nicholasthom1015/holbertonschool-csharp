using System;
using System.Collections.Generic;

public class List
{

    public static int MaxInteger(List<int> myList)
    {
        int? max = null;
        foreach(int i in myList)
            if(!(max >= i))
                max = i;
        if(max==null)
            Console.WriteLine("List is empty");
        return max.GetValueOrDefault(-1);
    }
}