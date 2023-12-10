public class Address
{
    protected string _addressLine1;
    protected string _addressLine2;
    protected string _city;
    protected string _postalCode;
    protected string _stateProvince;

    public void setAddress(string streetAddress, string apartmentNumber, string city, string zipCode, string state)
    {
        _addressLine1 = streetAddress;
        _addressLine2 = apartmentNumber;
        _city = city;
        _postalCode = zipCode;
        _stateProvince = state;
    }
    public string address()
    {
        if (_addressLine2 == "")
        {
            return $"{_addressLine1}\n{_city}, {_stateProvince}, {_postalCode}";
        }
        else
        {
            return $"{_addressLine1} {_addressLine2}\n{_city}, {_stateProvince}, {_postalCode}";
        }
    }
}