using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Problem 1");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        Console.WriteLine("Problem 2");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();

        Console.WriteLine("Problem 3");
        int j = 5;
        while (j >= 1)
        {
            Console.WriteLine(j);
            j--;
        }
        Console.WriteLine();

        Console.WriteLine("Problem 4");
        int k = 10;
        while (k <= 1000)
        {
            Console.WriteLine(k);
            k += 10;
        }
        Console.WriteLine();

        Console.WriteLine("Problem 5");
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        Console.WriteLine();

        Console.WriteLine("Problem 6");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        Console.Write("Please enter a number from 1 to 7 to get the corresponding day: ");
        string dayNumberInput = Console.ReadLine()!;

        int dayIndex;

        if (int.TryParse(dayNumberInput, out dayIndex))
        {
            if (dayIndex >= 1 && dayIndex <= 7)
            {
                Console.WriteLine($"Day {dayIndex} is: {days[dayIndex - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid day number! Please enter a number between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a numeric value between 1 and 7.");
        }
        Console.WriteLine();

        Console.WriteLine("Problem 7");
        string[] bookTitles = { "Elephant", "Marrakech", "Khan-al-khalili" };
        string[] authors = { "George Orwell", "George Orwell", "Najib Mahfoud" };

        for (int i = 0; i < bookTitles.Length; i++)
        {
            Console.WriteLine($"{bookTitles[i]} by {authors[i]}");
        }
        Console.WriteLine();

        Console.WriteLine("Problem 8");
        int[] temperatures = { 25, 18, 30, 22, 15 };
        Console.WriteLine("Original temperatures: " + string.Join(", ", temperatures));

        Array.Sort(temperatures);
        Console.WriteLine("Temperatures sorted in ascending order: " + string.Join(", ", temperatures));

        int lowestTemperature = temperatures[0];
        int highestTemperature = temperatures[temperatures.Length - 1];

        Console.WriteLine($"Lowest temperature: {lowestTemperature}°C");
        Console.WriteLine($"Highest temperature: {highestTemperature}°C");
        Console.WriteLine();

        Console.WriteLine("Problem 9");
        int[] originalArray = { 5, 4, 3, 2, 1 };
        Console.WriteLine("Original array order: " + string.Join(", ", originalArray));

        Array.Reverse(originalArray);
        Console.WriteLine("Array after Array.Reverse(): " + string.Join(", ", originalArray));

        Console.WriteLine("Displaying reversed array with a for loop:");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {originalArray[i]}");
        }
    }
}
