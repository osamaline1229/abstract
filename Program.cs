using inheiratance;

internal class Program
{
    private static void Main(string[] args)
    {
        //Dog d = new Dog("Luna" , 4, "Havenese", "Brrr!!!");
        //Dog d2 = new Dog("Luna" , 4, "Havenese", "Brrr!!!");
        //Console.WriteLine(d.Equals(d2));
        //d.doSomething();
        //d.makeSoung();
        //string abc = d.ToString();
        //Console.WriteLine(d);
        //Console.WriteLine("--------------");
        //Cat cat = new Cat("Bruno", 22);
        // cat.doSomething();
        //cat.makeSound();
        //cat.printSomething();

        Animal a = new Dog("Luna", 4, "Havenese", "Brrr!!!");
        a.makeSound();
        Console.WriteLine("Hello, World!");
    }
}