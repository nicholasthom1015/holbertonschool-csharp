

///<summary>Abstract class named Base</summary>
public abstract class Base
{
    ///<summary>Public name property</summary>
    public string name;

    ///<summary> ToString override method</summary>
    public override string ToString()
    {
        return string.Format("{0} is a {1}", name, this.GetType().ToString());
    }
}