//  Task1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Enter the first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a < b)
// {
//     Console.WriteLine($"Number {a} is less than number {b}.");
// }
// else if (a > b)
// {
//     Console.WriteLine($"Number {a} is greater than number {b}.");
// }
// else if (a == b)
// {
//     Console.WriteLine($"Enter different numbers.");
// }

//  Task2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  Проверка чисел на равенство здесь не обязательна.
Console.WriteLine("Enter the first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    if (b < c)
    {
        Console.WriteLine($"{c} is the largest number");
    }
    else
    {
        Console.WriteLine($"{b} is the largest number");
    }
}
else
{
    if (a < c)
    {
        Console.WriteLine($"{c} is the largest number");
    }
    else
    {
        Console.WriteLine($"{a} is the largest number");
    }
}

