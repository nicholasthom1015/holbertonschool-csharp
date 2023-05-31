public class Inventory : BaseClass
{
    public string User_Id { get; set; }
    public string Item_Id { get; set; }
    private int _quantity;

    public int Quantity
    {
        get { return _quantity; }
        set
        {
            if (value >= 0)
            {
                _quantity = value;
            }
            else
            {
                _quantity = 1;
            }
        }
    }

    public Inventory(string user_id, string item_id)
    {
        User_Id = user_id;
        Item_Id = item_id;
        Quantity = 1;
    }
}
