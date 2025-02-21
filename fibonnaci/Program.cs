using System;

class Program
{
    static void Main()
    {
        int n = 7; // Input number
        int result = Fibonacci(n);
        Console.WriteLine($"Fibonacci number at position {n} is: {result}");
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}