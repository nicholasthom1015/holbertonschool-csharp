using System;

public class alphabt
{
    public static void Main(string[] args)
    {
        for(char i = 'a'; i <= 'z'; i++)
        {
            if (i =='q' || i =='e')
                continue;
            Console.Write(i);
        }
    }
}