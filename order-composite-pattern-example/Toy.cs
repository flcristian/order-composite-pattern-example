namespace order_composite_pattern_example;

public class Toy : Product
{
    public string Material { get; set; }
    
    public Toy(string name, double price, string material) : base(name, price)
    {
        Material = material;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Material : {Material}");
    }
}