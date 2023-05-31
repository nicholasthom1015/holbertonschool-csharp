using System

///<summary>Interface called IInteractive</summary>
public interface IInteractive
{
    ///<summary>Method Interact</summary>
    void Interact();
}

///<summary>Interface called IBreakable</summary>
public interface IBreakable
{
    ///<summary>Property durability</summary>
    int durability { get; set; }

    ///<summary>Method Break</summary>
    void Break();
}

///<summary>Interface called ICollectable</summary>
public interface ICollectable
{
    ///<summary>Property isCollected</summary>
    bool isCollected { get; set; }

    ///<summary>Method Collect</summary>
    void Collect();
}