namespace order_composite_pattern_example;

public class Order : IProduct
{
    public List<IProduct> Products { get; set; }

    public Order(List<IProduct> products)
    {
        Products = products;
    }
    
    public void ApplyDiscount(int discount)
    {
        foreach (IProduct product in Products)
        {
            product.ApplyDiscount(discount);
        }
    }

    public double GetPrice()
    {
        double total = 0;
        
        foreach (IProduct product in Products)
        {
            total += product.GetPrice();
        }

        return total;
    }
    
    public void Display()
    {

        foreach (IProduct product in Products)
        {
            product.Display();
            Console.WriteLine();
        }
        
        Console.WriteLine("TOTAL = " + GetPrice());
    }
}