using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        Type objectType = myObj.GetType();
        PropertyInfo[] properties = objectType.GetProperties();
        MethodInfo[] methods = objectType.GetMethods();

        Console.WriteLine($"{objectType.Name} Properties:");
        foreach (var property in properties)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine();
        Console.WriteLine($"{objectType.Name} Methods:");
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
