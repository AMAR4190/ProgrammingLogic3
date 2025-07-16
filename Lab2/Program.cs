using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Part 1: Operator Practice");
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine($"Variables: a = {a}, b = {b}, c = {c}");

        bool aGreaterThanB = (a > b);
        Console.WriteLine($"a > b: {aGreaterThanB}");

        bool aLessThanC = (a < c);
        Console.WriteLine($"a < c: {aLessThanC}");

        bool aGreaterThanBoth = (a > b && a > c);
        Console.WriteLine($"a > b && a > c: {aGreaterThanBoth}");

        bool aGreaterThanEither = (a > b || a > c);
        Console.WriteLine($"a > b || a > c: {aGreaterThanEither}");
        Console.WriteLine();


        Console.WriteLine("Part 2: Boolean Logic");
        bool isRaining = true;
        bool haveUmbrella = false;

        Console.WriteLine($"Is it raining? {isRaining}");
        Console.WriteLine($"Do you have an umbrella? {haveUmbrella}");

        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }
        Console.WriteLine();


        Console.WriteLine("Part 3: Conditional Logic – Movie Ticket Pricing");
        Console.Write("Please enter your age: ");
        string ageInput = Console.ReadLine()!;
        int age;

        if (int.TryParse(ageInput, out age))
        {
            if (age < 5)
            {
                Console.WriteLine("Ticket is free!");
            }
            else if (age >= 5 && age <= 12)
            {
                Console.WriteLine("Child ticket: $5");
            }
            else if (age >= 13 && age <= 64)
            {
                Console.WriteLine("Standard ticket: $10");
            }
            else
            {
                Console.WriteLine("Senior ticket: $6");
            }
        }
        Console.WriteLine();


        Console.WriteLine("Part 4: Using a switch Statement");
        Console.Write("Please enter a day of the week (1-7): ");
        string dayInput = Console.ReadLine()!;
        int dayNumber;

        if (int.TryParse(dayInput, out dayNumber))
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }
        }

    }
}
