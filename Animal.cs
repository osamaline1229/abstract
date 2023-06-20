using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal abstract class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
           this.Name = name;
            this.Age = age;
            
        }

        public abstract void makeSound();

        public void printSomething()
        {
            Console.WriteLine("printing something");
        }

        public override bool Equals(object? obj)
        {
            Animal animal2 = obj as Animal;
            if (animal2 == null){ return false; }
            return this.Name == ((Animal)obj).Name;
        }

    }

    internal class Dog : Animal
    {
        string Bread;
        string Sound;

        public Dog(string name, int age, string Bread, string Sound) : base(name, age)
        {
            this.Bread = Bread;
            this.Sound = Sound;
        }

        public void getAnimalInfo()
        {
            Console.WriteLine(this.Name+ "" + this.Age + "" + Bread+ "" + Sound);
        }

        public override void makeSound()
        {
            Console.WriteLine("sound of Dog");
        }

        public void abc()
        {
            //functionality
        }
    }
}
