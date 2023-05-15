using System;
using System.Collections.Generic;

public class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int i = 0;
        foreach(string key in myDict.Keys)
            i++;
        return i;
    }
}