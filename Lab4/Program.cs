using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    public void Repaint(string newColor)
    {
        this.color = newColor;
        Console.WriteLine("The car has been repainted to " + newColor + ".");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();

        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020; // Calling the Display method

        myCar.Display();
        myCar.Start();
        myCar.Drive(50);

        string carDescription = myCar.GetDescription();
        Console.WriteLine("Car Description: " + carDescription);

        myCar.Repaint("red");

        Console.WriteLine("Current car color (after repaint): " + myCar.color);
    }
}
