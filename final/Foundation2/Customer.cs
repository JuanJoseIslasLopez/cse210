public class Customer
{
    public string Name;
    public Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public string CustomerInfo()
    {
        return $"Customer: {Name}\nAddress: {Address.AddressInfo()}";
    }
}
