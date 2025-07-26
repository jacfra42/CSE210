public class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public float GetCost()
    {
        return _price * _quantity;
    }
    public string GetDisplayText()
    {
        return $"{_quantity} x {_id}: {_name}";
    }
}