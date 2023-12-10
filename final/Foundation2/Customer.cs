public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address location)
    {
        _name = name;
        _address = location;
    }
    public bool getUSA()
    {
        return _address.isUSA();
    }
    public string getCustomerName()
    {
        return _name;
    }
}