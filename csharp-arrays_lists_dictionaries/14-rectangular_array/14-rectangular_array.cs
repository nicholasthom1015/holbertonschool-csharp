using System;
using System.Collections.Generic;

public class OggBox
{
    public static void Main(String[] args)
    {
        int[,] myArray = new int[5, 5];
        myArray[2, 2] = 1;
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Console.Write(myArray[i, j]);
                if(j < 4)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}