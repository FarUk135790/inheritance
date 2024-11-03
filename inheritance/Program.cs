using System;

// Завдання 1: Фігура

class Figure
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0;
    }
}

class Circle : Figure
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

// Використання об'єктів фігур
static void TestFigures()
{
    Circle circle = new Circle { Radius = 5 };
    Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };

    Console.WriteLine($"Circle - Area: {circle.CalculateArea()}, Perimeter: {circle.CalculatePerimeter()}");
    Console.WriteLine($"Rectangle - Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
}

// Завдання 2: Фрукт

class Fruit
{
    public string Name { get; set; }
}

class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

class Pear : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

// Використання об'єктів фруктів
static void TestFruits()
{
    Apple apple = new Apple { Name = "Apple", Variety = "Red Delicious", Color = "Red" };
    Pear pear = new Pear { Name = "Pear", Variety = "Bartlett", Color = "Green" };

    Console.WriteLine($"Apple - Name: {apple.Name}, Variety: {apple.Variety}, Color: {apple.Color}");
    Console.WriteLine($"Pear - Name: {pear.Name}, Variety: {pear.Variety}, Color: {pear.Color}");
}

// Завдання 3: Тварини

public abstract class Animal
{
    public float Weight { get; set; }
    public string Color { get; set; }

    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    public abstract string MakeSound();
}

public abstract class AnimalWithTail : Animal
{
    public float TailLength { get; set; }

    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    private string Purr()
    {
        return "purrrrrrrr";
    }

    private string Meow()
    {
        return "Meow";
    }

    public override string MakeSound()
    {
        return Purr() + Meow();
    }

    public override string ToString()
    {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

public class Dog : AnimalWithTail
{
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
    {
    }

    public override string MakeSound()
    {
        return "Woof";
    }

    public override string ToString()
    {
        return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

// Використання тварин
static void TestAnimals()
{
    Cat cat = new Cat("Black", 5.5f, 10.2f);
    Dog dog = new Dog("Brown", 10.0f, 15.5f);

    Console.WriteLine(cat.MakeSound());
    Console.WriteLine(dog.MakeSound());

    Console.WriteLine(cat);
    Console.WriteLine(dog);
}
