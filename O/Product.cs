namespace O;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }

    public virtual double GetDiscount()
    {
        return 0;
    }
}
