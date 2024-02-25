// Define the Address class to represent an event address
class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Country { get; set; }

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    // Method to return a string containing all address fields
    public string GetAddressString()
    {
        return $"Address: {Street}, {City}, {State}, {Country}";
    }
}
