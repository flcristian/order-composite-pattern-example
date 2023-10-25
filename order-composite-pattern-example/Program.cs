namespace order_composite_pattern_example;

internal class Program
{
    public static void Main(string[] args)
    {
        IProduct product1 = new Medicine("Nurofen", 25, "15+");
        IProduct product2 = new Toy("Doll", 20, "Wood");

        IProduct order = new Order(new List<IProduct> { product1, product2 });
        order.ApplyDiscount(50);
        order.Display();
    }
}