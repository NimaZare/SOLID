using O;

ProductType1 productType1 = new()
{
    Name = "New 1",
    Price = 15000
};

Console.WriteLine(productType1.GetDiscount());
