using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Kind = "cобака";
            Cat cat = new Cat();
            cat.Kind = "кошка";
            dog.ShowInfo();
            Console.WriteLine();
            cat.ShowInfo();
            Console.ReadKey();

        }
    }
    abstract class Animal
    {
        public abstract string Kind { get; set; }
        public Animal () { }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine("Я {0}", Kind);
            Say();
        }
    }
    class Dog : Animal
    {
        public string kind;
        public override string Kind
        {
            get
            {
                return kind;
            }
            set
            {
                kind = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав"); 
        }
    }
    class Cat : Animal
    {
        public string kind;
        public override string Kind
        {
            get
            {
                return kind;
            }
            set
            {
                kind = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
