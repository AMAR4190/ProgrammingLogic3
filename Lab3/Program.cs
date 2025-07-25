using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1: Simple For Loop (1 to 10)");
            Problem1_SimpleForLoop();

            Console.WriteLine("Problem 2: Even Numbers (1 to 20)");
            Problem2_EvenNumbers();

            Console.WriteLine("Problem 3: While Loop Countdown");
            Problem3_WhileLoopCountdown();

            Console.WriteLine("Problem 4: Multiples of 10 (10 to 1000)");
            Problem4_WhileLoopMultiplesOf10();

            Console.WriteLine("Problem 5: Seasons of the Year");
            Problem5_SeasonsOfTheYear();

            Console.WriteLine("Problem 6: Days of the Week (1-7)");
            Problem6_DaysOfTheWeek();

            Console.WriteLine("Problem 7: Favorite Books and Authors");
            Problem7_FavoriteBooksAndAuthors();

            Console.WriteLine("Problem 8: Temperature Tracker");
            Problem8_TemperatureTracker();

            Console.WriteLine("Problem 9: Reverse Countdown");
            Problem9_ReverseCountdown();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        static void Problem1_SimpleForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Problem2_EvenNumbers()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Problem3_WhileLoopCountdown()
        {
            int count = 5;
            while (count >= 1)
            {
                Console.WriteLine(count);
                count--;
            }
        }

        static void Problem4_WhileLoopMultiplesOf10()
        {
            int num = 10;
            while (num <= 1000)
            {
                Console.WriteLine(num);
                num += 10;
            }
        }

        static void Problem5_SeasonsOfTheYear()
        {
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }
        }

        static void Problem6_DaysOfTheWeek()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.Write("Enter a number from 1 to 7 to see the corresponding day: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber))
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {
                    Console.WriteLine($"Day {dayNumber} : {days[dayNumber - 1]}");
                }
                else
                {
                    Console.WriteLine("Invalid input: Please enter a number between 1 and 7.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input: Please enter a valid number.");
            }
        }

        static void Problem7_FavoriteBooksAndAuthors()
        {
            string[] bookTitles = { "The Hitchhiker's Guide to the Galaxy", "1984", "Pride and Prejudice" };
            string[] authors = { "Douglas Adams", "George Orwell", "Jane Austen" };

            for (int i = 0; i < bookTitles.Length; i++)
            {
                Console.WriteLine($"{bookTitles[i]} by {authors[i]}");
            }
        }

        static void Problem8_TemperatureTracker()
        {
            int[] temperatures = { 25, 18, 30, 22, 15 };

            Console.WriteLine("Original temperatures: " + string.Join(", ", temperatures));

            Array.Sort(temperatures);
            Console.WriteLine("Temperatures in ascending order: " + string.Join(", ", temperatures));

            int lowestTemp = temperatures[0];
            Console.WriteLine($"Lowest temperature: {lowestTemp}°C");

            int highestTemp = temperatures[temperatures.Length - 1];
            Console.WriteLine($"Highest temperature: {highestTemp}°C");
        }

        static void Problem9_ReverseCountdown()
        {
            int[] numbers = { 5, 4, 3, 2, 1 };

            Console.WriteLine("Original array: " + string.Join(", ", numbers));

            Array.Reverse(numbers);
            Console.WriteLine("Array after reversal: " + string.Join(", ", numbers));

            Console.WriteLine("Displaying new order:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
