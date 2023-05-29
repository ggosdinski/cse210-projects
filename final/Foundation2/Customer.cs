public class Customer 
{
    private string _customerName;
    private Address _customerAddress;
    // method: does the csutomer live in US? : (Hint this should call a method on the address to find this.) : verba
    public Customer(string customerName, Address customerAddress) {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }
    public string GetCustomerName() {
        return _customerName;
    }
}
