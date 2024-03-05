namespace L;

public class Cat : Animals, IMeow
{
    public void Meow()
    {
        Console.WriteLine("Meoooow");
    }
}
