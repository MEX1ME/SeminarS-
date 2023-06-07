// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] OrderNum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             for (int a = 1; a < array.GetLength(1); a++)
//             {
//                 if (array[i, a] > array[i, a - 1])
//                 {
//                     int temp = array[i, a - 1];
//                     array[i, a - 1] = array[i, a];
//                     array[i, a] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// int[,] array = Create2dArray(rows, colums, minValue, maxValue);
// PrintArray(array);
// array = OrderNum(array);
// Console.WriteLine();
// PrintArray(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// int[,] NewArray2d(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array;
// }

// void PrintArray2d(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int CheckMinSumm(int[,] array)
// {
//     int[] summRows = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ += array[i, j];
//         }
//         summRows[i] = summ;
//     }

//     int min = 0;
//     for (int a = 0; a < summRows.Length; a++)
//     {
//         if (summRows[a] < summRows[min])
//         {
//             min = a;
//         }
//     }
//     return min;
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minVal");
// int minVal = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxVal");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int[,] array = NewArray2d(rows, colums, minVal, maxVal);
// PrintArray2d(array);

// Console.WriteLine();
// int correctIndex = 1;
// int minHel = CheckMinSumm(array);
// Console.WriteLine($"{minHel + correctIndex} row is the smallest");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] NewArray2d(int rows_colums, int minVal, int maxVal)
// {
//     int[,] array = new int[rows_colums, rows_colums];
//     for (int i = 0; i < rows_colums; i++)
//     {
//         for (int j = 0; j < rows_colums; j++)
//         {
//             array[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array;
// }

// void PrintArray2d(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ProdArray(int[,] array1, int[,] array2)
// {
//     int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int a = 0; a < array2.GetLength(0); a++)
//             {
//                 array3[i, j] += array1[i, a] * array2[a, j];
//             }
//         }
//     }
//     return array3;
// }

// Console.WriteLine("input rows_colums");
// int rows_colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input minVal");
// int minVal = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxVal");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// int[,] array1 = NewArray2d(rows_colums, minVal, maxVal);
// Console.WriteLine("Printing 1 array");
// PrintArray2d(array1);

// Console.WriteLine();

// int[,] array2 = array1;
// Console.WriteLine("Printing 2 array");
// PrintArray2d(array2);

// Console.WriteLine();

// Console.WriteLine("Printing product of arrays");
// PrintArray2d(ProdArray(array1, array2));



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Array3D(int rows, int colums, int arrays, int minValue, int maxValue)
// {
//     int[,,] array3d = new int[rows, colums, arrays];
//     for (int i = 0; i < array3d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3d.GetLength(2); k++)
//             {
//                 array3d[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return array3d;
// }

// void Print3dArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input arrays");
// int arrays = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minVal");
// int minVal = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxVal");
// int maxVal = Convert.ToInt32(Console.ReadLine());

// Print3dArray(Array3D(rows, colums, arrays, minVal, maxVal));



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int arrayLength = 4;

// int[,] CreateSpiralArray(int minValue, int maxValue)
// {
//     int[,] array = new int[arrayLength, arrayLength];
//     int count = 1;
//     int rowStart = 0;
//     int rowEnd = arrayLength - 1;
//     int columnStart = 0;
//     int columnEnd = arrayLength - 1;
//     while (count <= arrayLength * arrayLength)
//     {
//         for (int i = columnStart; i <= columnEnd; i++)
//         {
//             array[rowStart, i] = new Random().Next(minValue, maxValue + 1);
//             count++;
//         }
//         rowStart++;
//         for (int i = rowStart; i <= rowEnd; i++)
//         {
//             array[i, columnEnd] = new Random().Next(minValue, maxValue + 1);
//             count++;
//         }
//         columnEnd--;
//         for (int i = columnEnd; i >= columnStart; i--)
//         {
//             array[rowEnd, i] = new Random().Next(minValue, maxValue + 1);
//             count++;
//         }
//         rowEnd--;
//         for (int i = rowEnd; i >= rowStart; i--)
//         {
//             array[i, columnStart] = new Random().Next(minValue, maxValue + 1);
//             count++;
//         }
//         columnStart++;
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// PrintArray(CreateSpiralArray(minValue,maxValue));
