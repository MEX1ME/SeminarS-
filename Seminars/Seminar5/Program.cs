﻿//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.


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
//     Console.WriteLine();
// }

// void PosNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)

//     {
//         if (array[i] >= 0) sumPos+=array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of Positive elements -> {sumPos}, sum of negative elements -> {sumNeg}");
// }

// Console.WriteLine("inp size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("inp minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("inp maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// myArray = InvertArray(myArray);
// PrintArray(myArray);
// PosNegSum(myArray);

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] InvertArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// int UserInput(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

//new Random.NextDouble();