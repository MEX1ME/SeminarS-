// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// double[,] Create2DMass(int m, int n, double minValue, double maxValue)
// {
//     double[,] array2d = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array2d[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//         }
//     }
//     return array2d;
// }

// void Print2DArray(double[,] arrayDoub)
// {
//     for (int i = 0; i < arrayDoub.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayDoub.GetLength(1); j++)
//         {
//             Console.Write(Math.Round(arrayDoub[i, j], 2) + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("input m val - rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input n val - colums");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min val");
// double minVal = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("input max val");
// double maxVal = Convert.ToDouble(Console.ReadLine());

// Print2DArray(Create2DMass(m, n, minVal, maxVal));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
// }

// string FindPosition(int numRows, int numColums, int[,] array)
// {
//     if (numRows < array.GetLength(0) && numColums < array.GetLength(1)) return Convert.ToString("you helement is " + array[numRows, numColums]);
//     else return "there is no such element in the array";
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

// int[,] niceArray = Create2DArray(rows, colums, minValue, maxValue);

// PrintArray2d(niceArray);

// Console.WriteLine("input horizontal position by index format (0, 1, 2,...9)");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input vertical position by index format (0, 1, 2,...9)");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.WriteLine(FindPosition(y, x, niceArray));




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] Create2DArray(int rows, int colums, int minVal, int maxVal)
{
    int[,] myArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            myArray[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return myArray;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintMeanArith(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        Console.Write(Math.Round(summ/array.GetLength(0),1) + "; ");
    }
}

Console.WriteLine("input rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input colums");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input minVal");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maxVal");
int maxVal = Convert.ToInt32(Console.ReadLine());

int[,] goodArray = Create2DArray(rows, colums, minVal, maxVal);
Print2DArray(goodArray);
Console.WriteLine();
PrintMeanArith(goodArray);
