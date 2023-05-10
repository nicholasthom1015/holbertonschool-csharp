using System;

public class HexHex
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 99; i++)
        {
            Console.WriteLine("{0} = 0x{1}", i, i.ToString("x"));
        }
    }
}