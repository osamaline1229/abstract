using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheiratance
{
    internal abstract class Animals
    {
        public string Name;
        public int Age;
        //efewrwe
        public Animals(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void dosomething()
        {
            Console.WriteLine("Animal - doSomething");
        }

        public abstract void makesound();
    }

    internal class Dog : Animals
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

        public override void dosomething()
        {
            Console.WriteLine("child do something");
        }

        public override void makesound()
        {
            Console.WriteLine("sound of Dog");
        }




    }

}