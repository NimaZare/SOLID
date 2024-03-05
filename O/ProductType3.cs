namespace O;

public class ProductType3 : Product
{
    public override double GetDiscount()
    {
        return (Price / 100) * 15;
    }
}
