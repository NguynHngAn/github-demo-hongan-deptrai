
using System.Threading.Channels;

Animal dog1 = new Dog();
dog1.Speak();


Console.ReadKey();

public abstract class Animal
{
    public abstract void Speak();
}

public class Dog : Animal
{
    public override void Speak() =>
        Console.WriteLine("Gau gau");
}