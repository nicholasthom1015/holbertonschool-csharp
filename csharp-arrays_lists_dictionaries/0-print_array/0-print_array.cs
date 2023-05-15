using System;

public class Array

{
    public static int[] CreatePrint(int size)
    {
        if(size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] res = new int[size];
        for(int i = 0; i < size; i++)
            Console.WriteLine("{0}{1}",(res[i] = i), i == (size-1)?"":" ");
        Console.WriteLine();
        return yes;
    }
}