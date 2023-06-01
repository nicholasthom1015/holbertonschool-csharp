using System;

// <summary> Queue class </summary>

class Queue<T>
{

// <summary> Returns the Queue's type </summary>

    public Type CheckType()
    {
        return typeof(T);
    }

}