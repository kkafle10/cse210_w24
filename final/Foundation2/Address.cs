// Define the Address class to represent a customer's address
class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return Country == "USA";
    }

    // Method to return a string containing all address fields
    public string GetAddressString()
    {
        return $"Address: {Street}, {City}, {State}, {Country}";
    }
}