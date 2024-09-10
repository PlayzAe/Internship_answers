using System;

class Program
{
    static void Main(string[] args)
    {
        // TASK 1
        // Declare and initialize the following variables:
        // A string variable named name with the value "John Doe"
        // An integer variable named age with the value 25
        // A boolean variable named isAdmin with the value true

        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;
        Console.WriteLine(name + " " + age + " " + isAdmin);

        // TASK 2
        // Write a program that takes an integer input from the user and prints out whether the number is even or odd.
        // Use an if-else statement to determine whether the number is even or odd.
        // Print "Even" if the number is even, and "Odd" if the number is odd.

        Console.WriteLine("Enter an integer: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b % 2 == 0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }

        // TASK 3
        // Write a program that prints out the numbers 1 to 10 using a for loop.
        Console.WriteLine("Numbers from 1 to 10:");
        for (int a = 1; a <= 10; a++)
        {
            Console.WriteLine(a);
        }

        // TASK 4
        // Declare and initialize an integer array with the values 2, 4, 6, 8, 10.
        // Print the sum of all elements in the array to the console.

        int[] values = { 2, 4, 6, 8, 10 };
        Console.WriteLine($"The sum of the elements in the array is {values[0] + values[1] + values[2] + values[3] + values[4]}");

        // Foreach Loop
        int[] value2 = { 2, 4, 6, 8, 10 };
        foreach (int c in value2)
        {
            Console.WriteLine(c);
        }

        // TASK 5
        // Call the Greet method from the Main method with the argument "Alice".
        Greet("Alice");
    }

    
    static void Greet(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}
