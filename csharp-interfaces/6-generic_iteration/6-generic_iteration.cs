using System;
using System.Collections;
using System.Collections.Generic;

/// <summary> Objs class </summary>
public class Objs<T> : IEnumerable<T>
{
    List<T> objectList = new List<T>();

    /// <summary> Add method </summary>
    public void Add(T obj)
    {
        this.objectList.Add(obj);
    }

    /// <summary> GetEnumerator method </summary>
    public IEnumerator<T> GetEnumerator()
    {
        return this.objectList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}