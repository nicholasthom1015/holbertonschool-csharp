using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        foreach(string key in myDict.Keys)
            newDict.Add(key, myDict[key]*2);
        return newDict;
    }

        
}