using inheiratance;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dog d = new Dog("Luna", 4, "Havenese", "Brrr!!!");
            d.dosomething();
            d.makesound();

            Console.WriteLine("Hello");
        }
    }

}
