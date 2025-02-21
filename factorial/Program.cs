using System;

class Program
{
    static void Main()
    {
        int n = 5; // Input number
        int result = Factorial(n);
        Console.WriteLine($"Factorial of {n} is: {result}");
    }

    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }
}
