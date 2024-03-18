using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    class Oop2examples
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////Polymorphism example 1-2
            Console.WriteLine("-----Polymorphism Example 1-----\n");
            Polymorphism p1 = new Polymorphism();
            p1.greet();
            p1.greet("Tim");

            Console.WriteLine("\n-----Polymorphism Example 2-----\n");
            Polymorphism2 sum1 = new Polymorphism2();
            sum1.totalSum(5, 7);
            sum1.totalSum(53.5, 8.7);

            //////////////////////////////////////////////Inheritance example 1
            Console.WriteLine("\n-----Inheritance Example 1-----\n");
            InheritanceAnimal i1 = new InheritanceAnimal();
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            Console.WriteLine("Dog's name: " + myDog.Name);
            myDog.Eat();
            myDog.Bark();

            Cat myCat = new Cat();
            myCat.Name = "Whiskers";
            Console.WriteLine("\nCat's name: " + myCat.Name);
            myCat.Eat();
            myCat.Meow();

            //////////////////////////////////////////////Inheritance example 2
            Console.WriteLine("\n-----Inheritance Example 2-----\n");
            Circle circle = new Circle();
            circle.Draw();

            //////////////////////////////////////////////Inheritance example 3
            Console.WriteLine("\n-----Inheritance Example 3-----\n");
            Parent parent = new Parent("John", 40);

            Child child1 = new Child("Alice", 10, parent);
            Child child2 = new Child("Bob", 8, parent);

            parent.AddChild(child1);
            parent.AddChild(child2);

            Console.WriteLine("\nParent Information:");
            parent.DisplayInfo();

            Console.WriteLine("\nChildren Information:");
            child1.DisplayInfo();
            child2.DisplayInfo();

            //////////////////////////////////////////////Generic type example
            Console.WriteLine("\n-----Generic Type Example-----");
            // Box of integers
            Box<int> intBox = new Box<int>(10);
            Console.WriteLine("\nInteger in the box: " + intBox.GetItem());

            // Box of strings
            Box<string> stringBox = new Box<string>("Hello, world!");
            Console.WriteLine("String in the box: " + stringBox.GetItem());

            // Box of doubles
            Box<double> doubleBox = new Box<double>(3.14);
            Console.WriteLine("Double in the box: " + doubleBox.GetItem());

            //////////////////////////////////////////////Encapsulation example
            Console.WriteLine("\n-----Encapsulation Example-----\n");
            // Create a BankAccount object
            BankAccount account = new BankAccount("123456789", 1000);

            // Perform operations on the account
            account.Deposit(500);
            account.Withdraw(200);
            account.Withdraw(2000);

            // Display account information
            account.DisplayAccountInfo();
        }
    }
}
