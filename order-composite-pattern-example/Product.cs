namespace order_composite_pattern_example;

public class Product : IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void ApplyDiscount(int discount)
    {
        Price = (Price * discount) / 100;
    }

    public double GetPrice()
    {
        return Price;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{Name} - {Price}");
    }
}