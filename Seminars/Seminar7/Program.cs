//Задать двумерный массив

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
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


// Console.WriteLine($"input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input number of colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input minVal");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input maxVal");
// int maxValue = Convert.ToInt32(Console.ReadLine());



// Print2DArray(Create2DRandomArray(rows, colums, minValue, maxValue));


//Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
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

// int SummOfMainDiag(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }
//         }
//     }
//     return sum;
// }

// Console.WriteLine($"input number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input number of colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input minVal");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input maxVal");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine(SummOfMainDiag(myArray));


//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.