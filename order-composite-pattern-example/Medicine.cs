namespace order_composite_pattern_example;

public class Medicine : Product
{
    public string Prescription { get; set; }
    
    public Medicine(string name, double price, string prescription) : base(name, price)
    {
        Prescription = prescription;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine(Prescription);
    }
}