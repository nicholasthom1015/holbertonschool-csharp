using System;

/// <summary> Queue class </summary>
public class Queue<T>
{

    /// <summary> Returns the Queue's type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

}