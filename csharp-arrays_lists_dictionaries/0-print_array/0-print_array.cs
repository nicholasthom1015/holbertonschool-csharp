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
        var output_string = "";
        for(int i = 0; i < size; i++)
            output_string += "" + (res[i] = i) + (i == (size-1)?"":" ");
        Console.WriteLine(output_string);
        return res;
    }
}