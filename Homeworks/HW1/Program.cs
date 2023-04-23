//  Task1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Enter the first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.WriteLine($"Number {a} is less than number {b}.");
}
else if (a > b)
{
    Console.WriteLine($"Number {a} is greater than number {b}.");
}
else if (a == b)
{
    Console.WriteLine($"Enter different numbers.");
}

