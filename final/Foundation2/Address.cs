public class Address
{
    public string Street;
    public string City;
    public string StateProvince;
    public string Country;

    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public string AddressInfo()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}