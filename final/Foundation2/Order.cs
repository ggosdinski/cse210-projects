public class Order 
{
    // private string _customerName;
    private List<Product> _products = new List<Product>();
    // total price
    // if US shipping = $5, else shipping = $35
    // packing label = foreach(Product product in _products) {print productName, productId}
    // shipping label = _customerName, _customerAddress
    public void AddItem(Product product) {
        _products.Add(product);
    }
    private double CalculateSubtotal() 
    {
        double subtotal = 0;
        foreach (Product p in _products) 
        {
            subtotal += (p.GetPrice() * p.GetQuantity());
        }
        return subtotal;
    }
    private double CalculateShippingCost(Address address)
    {
        double shipping;
        if (address.GetCountry() == "USA") {
            shipping = 5;
        } else {
            shipping = 35;
        }
        return shipping;
    }
    private double CalculateTotalCost(Address address) 
    {
        double subtotal = CalculateSubtotal();
        double shipping = CalculateShippingCost(address);
        return subtotal + shipping;
    }
    public void PrintAllCosts(Address address) 
    {
        Console.WriteLine($"Subtotal: ${Math.Round(CalculateSubtotal(), 2)}");
        Console.WriteLine($"Shipping: ${Math.Round(CalculateShippingCost(address), 2)}");
        Console.WriteLine($"Total: ${Math.Round(CalculateTotalCost(address), 2)}");
    }
    public void PrintTotalCost(Address address) {
        Console.WriteLine($"Total: ${Math.Round(CalculateTotalCost(address), 2)}");
    }
    public void PrintPackingLabel() {
        foreach (Product product in _products) {
            Console.WriteLine($"{product.GetId()} | {product.GetName()}");
        }
    }
    public void PrintShippingLabel(Address address, Customer customer) {
        Console.WriteLine(address.GetShippingAddress(customer));
    }
}