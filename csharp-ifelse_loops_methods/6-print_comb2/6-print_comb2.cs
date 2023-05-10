using System;

public class Comb
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 9; i++)
        {
            for(int j = i + 1; j < 10; j++)
            {
                Console.Write("{0}{1}{2}", i, j, i == 8 ? "\n" : ", ");
            }
            
        }
    }
}