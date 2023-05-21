// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Degree(int a, int b)
// {
//     int result = a;
//     for (int i = 1; i < b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }
// Console.WriteLine($"input a");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input b");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{a} ^ {b} = {Degree(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int SummOfDigitNum(int num)
// {
//     int sum = 0;
//     int a = 0;
//     while (num > 0)
//     {
//         a = num % 10;
//         num = num / 10;
//         sum = sum + a;
//     }
//     return sum;
// }
// Console.WriteLine("input number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"the sum of the digits of the number {number} --> {SummOfDigitNum(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] NewArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-500, 500);
//     }
//     return array;
// }

// void PrintArray(int[] array, int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int size = 8;
// int[] bestArray = NewArray(size);
// PrintArray(bestArray, size);