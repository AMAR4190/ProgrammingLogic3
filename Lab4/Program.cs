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

    // Method: Start()
    // This method simulates the car starting and prints a message.
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Method: Drive(int miles)
    // This method simulates the car driving a certain number of miles
    // and prints a message including the miles driven.
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

    // Method: GetDescription()
    // This method returns a string combining the car's year, color, and model.
    public string GetDescription()
    {
        // Using string interpolation for a clean and readable way to combine the fields.
        return $"{year} {color} {model}";
    }

    // New method: Repaint(string newColor)
    // This method updates the car's color and prints a confirmation message.
    public void Repaint(string newColor)
    {
        this.color = newColor; // 'this.color' refers to the 'color' field of the current object
        Console.WriteLine($"The car has been repainted to {newColor}.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();

        // Assigning initial values to the attributes of the 'myCar' object.
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display();           // Calling the Display method
        myCar.Start();             // Calling the Start method
        myCar.Drive(50);           // Calling the Drive method

        // Calling the GetDescription() method, storing the result, and printing it.
        string carDescription = myCar.GetDescription();
        Console.WriteLine($"Car Description: {carDescription}");

        // Calling the new Repaint() method to change the car's color to "red".
        myCar.Repaint("red");

        // Confirming that the color field has been updated by printing it directly.
        Console.WriteLine($"Current car color (after repaint): {myCar.color}");
    }
}
