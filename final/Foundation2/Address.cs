public class Address
{
    private string _addressLine1;
    private string _addressLine2;
    private string _city;
    private string _postalCode;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string apartmentNumber, string city, string zipCode, string state, string country)
    {
        _addressLine1 = streetAddress;
        _addressLine2 = apartmentNumber;
        _city = city;
        _postalCode = zipCode;
        _stateProvince = state;
        _country = country;
    }
    public bool isUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string address()
    {
        if (_addressLine2 == "")
        {
            return $"{_addressLine1}\n{_city}, {_stateProvince}, {_postalCode}\n{_country}";
        }
        else
        {
            return $"{_addressLine1} {_addressLine2}\n{_city}, {_stateProvince}, {_postalCode}\n{_country}";
        }
    }
}