// Define the Customer class to represent a customer
class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    // Method to check if the customer's address is in the USA
    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}
