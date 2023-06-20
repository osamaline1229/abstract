using inheiratance;

namespace Inheritance
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Dog d = new Dog("Luna", 4, "Havenese", "Brrr!!!");
            d.makeNoise();
            d.Eat();

            Console.WriteLine("Hello");
        }
    }

}
