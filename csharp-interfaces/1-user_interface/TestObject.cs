using System;

/// <summary> TestObject class </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary> durability property </summary>
    public int durability { get; set; }
    /// <summary> isCollected property </summary>
    public bool isCollected { get; set; }

    /// <summary> Interact method </summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary> Break method </summary>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary> Collect method </summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}