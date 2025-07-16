using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Name: Mohammed BEN AMAR
         * Title: IT-1050 - Lab 1
         */

        // Step 2: Basic Output
        // Print your name and course title.
        Console.WriteLine("My Name: Mohammed BEN AMAR");
        Console.WriteLine("Course Title: IT-1050 - Lab 1");
        Console.WriteLine();

        // Step 3: Declare and Use Variables
        // Declare and assign values to variables of different types.

        // int - My favorite number
        int favoriteNumber = 9;
        Console.WriteLine("My favorite number is: " + favoriteNumber);

        // string - My favorite programming language
        string favoriteLanguage = "Python";
        Console.WriteLine("My favorite programming language is: " + favoriteLanguage);

        // double - The number of programs I've written before this
        double numberOfProgramsWritten = 3; // Using a decimal for demonstration
        Console.WriteLine("The number of programs I've written before this is: " + numberOfProgramsWritten);

        // bool - Do I have programming experience?
        bool hasProgrammingExperience = true;
        Console.WriteLine("Do I have programming experience? " + hasProgrammingExperience);
        Console.WriteLine();

        // Step 4: Use Constants
        // Declare a constant string for your school name and display it.

        const string schoolName = "Tr-c";
        Console.WriteLine("My school name is: " + schoolName);
        Console.WriteLine();

        // Step 5: Type Casting

        // Create a double variable and assign it a value with decimal places
        double doubleValue = 9.78;
        Console.WriteLine("Original double value: " + doubleValue);

        // Convert this double to an int using explicit casting
        int intFromDouble = (int)doubleValue;
        Console.WriteLine("Double converted to int (explicit cast): " + intFromDouble);

        // Use the Convert class to convert an int to a string
        int originalInt = 980;
        string stringFromInt = Convert.ToString(originalInt);
        Console.WriteLine("Original int: " + originalInt + ", Converted to string: \"" + stringFromInt + "\"");

        // Use the Convert class to convert a bool to a string
        bool originalBool = false;
        string stringFromBool = Convert.ToString(originalBool);
        Console.WriteLine("Original bool: " + originalBool + ", Converted to string: \"" + stringFromBool + "\"");
        Console.WriteLine();

        // Step 6: User Input and Type Conversion
        // Prompt the user for their name and age, then display a greeting.

        Console.WriteLine("Step 6: User Input and Type Conversion");
        Console.Write("Please enter your name: ");
        Console.Write("Please enter your age: ");
        Console.WriteLine();

        // Step 7: Arithmetic Operators
        // Create two int variables.

        Console.WriteLine("Step 7: Arithmetic Operators");
        int num1 = 30;
        int num2 = 10;
        Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);

        // Addition
        int sum = num1 + num2;
        Console.WriteLine("Addition (num1 + num2): " + sum);

        // Subtraction
        int difference = num1 - num2;
        Console.WriteLine("Subtraction (num1 - num2): " + difference);

        // Multiplication
        int product = num1 * num2;
        Console.WriteLine("Multiplication (num1 * num2): " + product);

        // Division (integer division will truncate decimals)
        int quotient = num1 / num2;
        Console.WriteLine("Division (num1 / num2): " + quotient);

        // Modulus (remainder of division)
        int remainder = num1 % num2;
        Console.WriteLine("Modulus (num1 % num2): " + remainder);
        Console.WriteLine();

        // Step 8: Floating Point Precision
        // Create a float and a double, assign the same decimal value, and print both.

        Console.WriteLine("Step 8: Floating Point Precision");
        float floatValue = 1.123456789f;
        double doublePrecisionValue = 1.123456789;

        Console.WriteLine("Float value: " + floatValue);
        Console.WriteLine("Double value: " + doublePrecisionValue);
        Console.WriteLine("Observe the difference in precision. Double typically shows more decimal places accurately.");
        Console.WriteLine();

        // Step 9: Increment and Decrement
        // Declare an int, use increment (++) and decrement (--) operators.

        Console.WriteLine("Step 9: Increment and Decrement");
        int counter = 10;
        Console.WriteLine("Initial counter value: " + counter);

        // Increment
        counter++; // counter is now 11
        Console.WriteLine("After increment (++): " + counter);

        // Decrement
        counter--; // counter is now 10 again
        Console.WriteLine("After decrement (--): " + counter);
        Console.WriteLine();

    }
}
