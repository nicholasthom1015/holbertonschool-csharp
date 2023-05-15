using System;

public class Array
{
    public static int elementAt(int[] array, int index)
    {
        if(index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        return array[index];
    }

    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        try
        {
            array[index] = n;
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range");
        }
        return array;
    }
}