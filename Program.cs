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
            Console.WriteLine("----------------");

            Cat T = new Cat("Luna", 4, "Havenese", "Brrr!!!");
            T.makeNoise();
            T.Eat();
        }
    }

}
