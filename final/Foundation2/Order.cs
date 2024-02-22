public class Order
{
    private int UsaShippingCost = 5;
    private int InternationalShippingCost = 35;

    public Customer Customer;
    public List<Product> Products;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetOrderTotal()
    {
        decimal total = Products.Sum(product => product.Price * product.Quantity);
        total += Customer.Address.Country == "USA" ? UsaShippingCost : InternationalShippingCost;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = $"Customer: {Customer.Name}\nProducts:\n";
        foreach (Product product in Products)
        {
            label += $"{product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return Customer.Address.AddressInfo();
    }
}
