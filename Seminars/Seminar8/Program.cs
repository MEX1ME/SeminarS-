// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Invalid input");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// int[,] Create2DArray(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array2d = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array2d[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array2d;
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
//     Console.WriteLine();
// }

// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);

// PrintArray2d(myArray);
// myArray = RowsToColumns(myArray);
// PrintArray2d(myArray);

//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент



// int[,] RowsToColumns(int[,] array)
// {
//     int minRows = 0;
//     int minColums = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[minRows, minColums])
//             {
//                 minRows = i;
//                 minColums = j;
//             }
//         }
//     }

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minColums] = 0;
//     }

//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minRows, j] = 0;
//     }


//     return array;
// }

// int[,] Create2DArray(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array2d = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array2d[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array2d;
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
//     Console.WriteLine();
// }



// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);

// PrintArray2d(myArray);
// myArray = RowsToColumns(myArray);
// PrintArray2d(myArray);









//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

// int[,] RowsToColumns(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp = array[0, j];
//             array[0,j] = array[array.GetLength(0)-1, j];
//             array[array.GetLength(0)-1, j] = temp;
//         }
//     }
//     return array;
// }

// int[,] Create2DArray(int rows, int colums, int minVal, int maxVal)
// {
//     int[,] array2d = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array2d[i, j] = new Random().Next(minVal, maxVal + 1);
//         }
//     }
//     return array2d;
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
//     Console.WriteLine();
// }



// Console.WriteLine("input rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums");
// int colums = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, colums, minValue, maxValue);

// PrintArray2d(myArray);
// myArray = RowsToColumns(myArray);
// PrintArray2d(myArray);