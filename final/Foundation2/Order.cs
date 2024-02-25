class Order
{
    private List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    // Constructor
    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    // Method to calculate the total cost of the order
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in Products)
        {
            totalCost += product.Price * product.Quantity;
        }
        // Add shipping cost
        totalCost += Customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    // Method to generate a packing label string
    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in Products)
        {
            label += $"Product: {product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    // Method to generate a shipping label string
    public string GenerateShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"Customer: {Customer.Name}\n";
        label += Customer.Address.GetAddressString();
        return label;
    }
}