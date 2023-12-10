public class Order
{
    private double _subtotal;
    private Customer _customer;
    private Address _address;
    private Product _product;
    private List<Product> _products;
    public Order(Customer customer, Address address, List<Product> products)
    {
        _customer = customer;
        _products = products;
        _address = address;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void addProduct(Product product)
    {
        _products.Add(product);
    }
    public void setProducts(List<Product> productList)
    {
        _products = productList;
    }
    public void CalculateCost()
    {
        foreach (Product p in _products)
        {
            _subtotal += p.getPrice();
        }
    }
    public int ShippingCost(bool usa)
    {
        if (usa == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void PackingLabel()
    {
        double totalCost = 0;
        foreach(Product p in _products)
        {
            Console.WriteLine($"{p.getName(), -12} {p.getQuantity(), -3}, {p.getID(), -8}, {p.getPrice():C2}");
            totalCost += p.getPrice();
        }
        Console.WriteLine($"Subtotal:   {totalCost:C2}");
        Console.WriteLine($"Shipping:   {ShippingCost(_address.isUSA()):C2}");
        totalCost += ShippingCost(_address.isUSA());
        Console.WriteLine($"Total Cost: {totalCost:C2}");
    }
    public void shippingLabel()
    {
        Console.WriteLine($"\n{_customer.getCustomerName()}");
        Console.WriteLine(_address.address());
        ShippingCost(_customer.getUSA());
    }
}