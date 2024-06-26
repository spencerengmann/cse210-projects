public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
    }

    public string ProductId
    {
        get { return productId; }
    }

    public double Price
    {
        get { return price; }
    }

    public int Quantity
    {
        get { return quantity; }
    }
}