using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal  abstract class Animals
    {
        public string Name;
        public int Age;
        //efewrwe
        public Animals(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("Animal - doSomething");
        }

        public abstract  void Eat();
    }

    internal  class  Dog : Animals
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
            Console.WriteLine(this.Name + " " + this.Age + " " + Bread + Sound);
        }

        public override void makeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eat()
        {
            Console.WriteLine("I Eat dog Food");
        }




    }

}