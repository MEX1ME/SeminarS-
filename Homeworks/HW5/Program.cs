// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return myArray;
// }

// int CheckEvenNumbers(int[] goodArray)
// {
//     int count = 0;
//     for (int i = 0; i < goodArray.Length; i++)
//     {
//         if (goodArray[i] % 2 == 0) count++;
//     }
//     return count;
// }

// void PrintArray(int[] newArray)
// {
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write(newArray[i] + " ");
//     }
//     Console.WriteLine();
// }

// int size = 20;
// int minValue = 100;
// int maxValue = 999;

// int[] arrayNow = CreateArray(size, minValue, maxValue);
// PrintArray(arrayNow);
// Console.WriteLine($"number of even numbers -> {CheckEvenNumbers(arrayNow)}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] array1 = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array1[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array1;
// }

// void PrintArray(int[] array2)
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
//         Console.Write(array2[i] + " ");
//     }
//     Console.WriteLine();
// }


// int SummOddNum(int[] array3)
// {
//     int summOdd = 0;
//     for (int i = 0; i < array3.Length; i++)
//     {
//         if (array3[i] % 2 == 1 || array3[i] % 2 == -1) summOdd += array3[i];
//     }
//     return summOdd;
// }

// int size = 10;
// int minNum = -20;
// int maxNum = 20;

// int[] array4 = CreateArray(size, minNum, maxNum);
// PrintArray(array4);
// Console.WriteLine($"Summ of odd numbers = {SummOddNum(array4)}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateArray(int size, int minVal, int maxVal)
// {
//     double[] natArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         natArray[i] = Math.Round((new Random().NextDouble() * (maxVal - minVal) + minVal), 1);
//     }
//     return natArray;
// }

// void PrintArray(double[] prArray)
// {
//     for (int i = 0; i < prArray.Length; i++)
//     {
//         Console.Write(prArray[i] + " ");
//     }
//     Console.WriteLine();
// }

// double DifHel(double[] difArray)
// {
//     int min = 0;
//     int max = 0;
//     double result = 0;
//     for (int i = 0; i < difArray.Length; i++)
//     {
//         if (difArray[i] < difArray[min]) min = i;
//         if (difArray[i] > difArray[max]) max = i;
//     }
//     result = Math.Round((difArray[max] - difArray[min]),1);
//     return result;
// }

// int size = 10;
// int minValue = 2;
// int maxValue = 99;

// double[] bigArray = CreateArray(size, minValue, maxValue);
// PrintArray(bigArray);
// Console.WriteLine($"dif max and min hel of array -> {DifHel(bigArray)}");