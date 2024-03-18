using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    ///////////////////////////////////////////////////////////Inheritance example 1
    class InheritanceAnimal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    class Dog : InheritanceAnimal
    {
        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }

    class Cat : InheritanceAnimal
    {
        public void Meow()
        {
            Console.WriteLine("Meow meow!");
        }
    }
    ///////////////////////////////////////////////////////////Inheritance example 2
    class InheritanceShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : InheritanceShape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    ///////////////////////////////////////////////////////////Inheritance example 3
    class InheritancePerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public InheritancePerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Parent : InheritancePerson
    {
        public List<Child> Children { get; set; }

        public Parent(string name, int age) : base(name, age)
        {
            Children = new List<Child>();
        }

        public void AddChild(Child child)
        {
            Children.Add(child);
            Console.WriteLine($"{child.Name} is now a child of {Name}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Children:");
            foreach (Child child in Children)
            {
                Console.WriteLine($"- {child.Name}");
            }
        }
    }

    class Child : InheritancePerson
    {
        public Parent Parent { get; set; }

        public Child(string name, int age, Parent parent) : base(name, age)
        {
            Parent = parent;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Parent: {Parent.Name}");
        }
    }
}
