using System;
//The fibonnaci sequence is executed through recursion
class Program
{
    static void Main()//the main method
    {
        int n = 7; // Input number.
        int result = Fibonacci(n);
        Console.WriteLine($"Fibonacci number at position {n} is: {result}");//printing the output
    }

    static int Fibonacci(int n)//the main function.
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);//The runtime is exponential.N^2
    }
}