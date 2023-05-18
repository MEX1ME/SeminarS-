//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 36478439

// int DigitCount(int num)
// {
//     int count = 0;
//     while (num > 1)
//     {
//         count++;
//         num/=10;
//     }
//     return count;
// }

// Console.WriteLine("input number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"number of digit in {num} -> {DigitCount(num)}");

//Задача 4. Напишите программу, которая выводит массив из N элементов, заполненный (нулями и единицами) числами от и до в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// Console.WriteLine("inp size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("inp minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("inp maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.