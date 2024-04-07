using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.Price * product.Quantity;
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address}";
    }
}