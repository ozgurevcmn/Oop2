using System;

class Polymorphism
{
    public void greet()
    {
        Console.WriteLine("Hello");
    }

    public void greet(string name)
    {
        Console.WriteLine("Hello " + name);
    }
}

class Polymorphism2
{
    public void totalSum(int a, int b)
    {
        Console.WriteLine("The sum of numbers is " + (a + b));
    }

    public void totalSum(double a, double b)
    {
        Console.WriteLine("The sum of numbers is " + (a + b));
    }
}


