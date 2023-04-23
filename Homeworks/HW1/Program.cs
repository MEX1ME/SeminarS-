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
// Console.WriteLine("Enter the first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the third number");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a < b)
// {
//     if (b < c)
//     {
//         Console.WriteLine($"{c} is the largest number");
//     }
//     else
//     {
//         Console.WriteLine($"{b} is the largest number");
//     }
// }
// else
// {
//     if (a < c)
//     {
//         Console.WriteLine($"{c} is the largest number");
//     }
//     else
//     {
//         Console.WriteLine($"{a} is the largest number");
//     }
// }

//  Task3. Напишите программу, которая на вход принимает число и выдает, является ли число четным.

// Console.WriteLine("please put you number here");
// int num = Convert.ToInt32(Console.ReadLine());
// int remDiv = num % 2;
// if(remDiv == 0)
// {
//     Console.WriteLine($"Your number is even"); //четный
// }
// else
// {
//     Console.WriteLine($"Your number is odd"); //нечетный
// }

//  Task4. Напишите программу, которая принимает на вход число (N), а на выходе показывает все четные числа от 1 до N.
//  Вместо проверки остатка от деления на 2, можно было идти до нужного числа шагами, равными "2" по четным числам.
Console.WriteLine("Enter you number");
int n = Convert.ToInt32(Console.ReadLine());
int point = 1;
if (n == 1)
{
    Console.WriteLine("Congratulations, you are the captain \"mathematic\"!");
}
else
{
    Console.WriteLine("You see all even numbers from 1 to you number");
    if (point < n)
    {
        while (point <= n)
        {
            if (point % 2 == 0)
            {
                Console.WriteLine(point);
            }
            point++;
        }
    }
    else if (point > n)
    {
        while (point >= n)
        {
            if (point % 2 == 0)
            {
                Console.WriteLine(point);
            }
            point--;
        }
    }
}

