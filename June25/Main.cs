// See https://aka.ms/new-console-template for more information

using Main;

// 2.1
int[] numbers = Question2_1.GenerateNumbers(10);
Question2_1.PrintNumbers(numbers);
Question2_1.Reverse(numbers);
Question2_1.PrintNumbers(numbers);
Console.WriteLine();

// 2.2
for (int i = 1; i <= 10; i++)
{
    Console.Write(Question2_2.Fibonacci(i) + " ");
}
Console.WriteLine();


// 