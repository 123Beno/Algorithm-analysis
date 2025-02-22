using System;

class Program
{
    static void Main()//the main method
    {
        int n = 5; // Input number.
        int result = Factorial(n);
        Console.WriteLine($"Factorial of {n} is: {result}");//printing the output.
    }

    static int Factorial(int n)//the main function.
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);//Runtime is N.It grows linearly.
    }
}
