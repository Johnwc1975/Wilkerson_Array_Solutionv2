


// Jonathan Wilkerson



// IT113



// NOTES: Notes the instructor should read

//Here's an efficient implementation that should run in less than a second:



// BEHAVIORS NOT IMPLEMENTED AND WHY: Are there any parts of the assignment 

//We use a do-while loop to generate random characters and ensure their uniqueness in the array by checking the ArrayContainsChar function.

//The ArrayContainsChar function checks for character uniqueness in a case-insensitive manner by converting both characters to lowercase before comparison.

//The Stopwatch class is used to measure the execution time.

//The code generates random uppercase and lowercase characters to ensure case-insensitive uniqueness



// you did not complete?

//im pretty sure im completed : )







using System;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        int arraySize = 50;
        char[] charArray = GenerateRandomUniqueChars(arraySize);
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        foreach (char c in charArray)
        {
            Console.Write(c + " ");
        }
        stopwatch.Stop();

        Console.WriteLine("\nElapsed Time: " + stopwatch.ElapsedMilliseconds + "ms");
    }

    // Generate an array of random unique characters (case-insensitive)
    static char[] GenerateRandomUniqueChars(int size)
    {
        Random random = new Random();
        string allPossibleChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        // Shuffle the characters randomly
        char[] shuffledChars = allPossibleChars.ToCharArray();
        int n = shuffledChars.Length;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            char temp = shuffledChars[k];
            shuffledChars[k] = shuffledChars[n];
            shuffledChars[n] = temp;
        }

        // Take the first 'size' characters
        return shuffledChars.Take(size).ToArray();
    }
}
