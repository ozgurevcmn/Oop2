using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    // Base class
    class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    // Derived class Dog inheriting from Animal
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof woof!");
        }
    }

    // Derived class Cat inheriting from Animal
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow meow!");
        }
    }

    // Inheritance class
    class Inheritance1
    {
        static void Main(string[] args)
        {
            // Creating a Dog object
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            Console.WriteLine("Dog's name: " + myDog.Name);
            myDog.Eat();  // Calling method from base class Animal
            myDog.Bark(); // Calling method from Dog class

            // Creating a Cat object
            Cat myCat = new Cat();
            myCat.Name = "Whiskers";
            Console.WriteLine("Cat's name: " + myCat.Name);
            myCat.Eat();  // Calling method from base class Animal
            myCat.Meow(); // Calling method from Cat class
        }
    }
}
