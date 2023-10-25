namespace order_composite_pattern_example;

public interface IProduct
{
    double GetPrice();
    
    void ApplyDiscount(int discount);

    void Display();
}