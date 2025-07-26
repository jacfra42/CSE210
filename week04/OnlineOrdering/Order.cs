public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public float GetTotalCost()
    {
        float totalCost = 0.0F;
        foreach (Product product in _products)
        {
            totalCost += product.GetCost();
        }
        if (_customer.InUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }
    public string GetPackingLabel()
    {
        string packingText = "";
        foreach (Product product in _products)
        {
            packingText += product.GetDisplayText() + "\n";
        }
        return packingText;
    }
    public string GetShippingLabel()
    {
        return _customer.GetDisplayText();
    }

}