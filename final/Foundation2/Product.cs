public class Product
{
    private string _productName;
    private int _productID;
    private double _singlePrice;
    private int _quantity;
    public Product(string product, int ID, double pricing, int amount)
    {
        _productName = product;
        _productID = ID;
        _singlePrice = pricing;
        _quantity = amount;
    }
    public double getPrice()
    {
        return _singlePrice * _quantity;;
    }
    public int getQuantity()
    {
        return _quantity;
    }
    public string getName()
    {
        return _productName;
    }
    public int getID()
    {
        return _productID;
    }
}