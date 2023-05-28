// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// int[] CreRanNum(int m, int miV, int maV)
// {
//     int[] newArray = new int[m];
//     for (int i = 0; i < m; i++)
//     {
//         newArray[i] = new Random().Next(miV, maV + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] arrayPrint)
// {
//     for (int i = 0; i < arrayPrint.Length; i++)
//     {
//         Console.Write(arrayPrint[i] + " ");
//     }
// }

// int CheckPositive(int[] badArray)
// {
//     int count = 0;
//     for (int i = 0; i < badArray.Length; i++)
//     {
//         if (badArray[i] > 0) count++;
//     }
//     return count;
// }

// Console.WriteLine("Enter Number Digit");
// int numDigit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter maxVal");
// int maV = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter minVal");
// int miV = Convert.ToInt32(Console.ReadLine());

// int[] freendlyArray = CreRanNum(numDigit, miV, maV);
// Console.WriteLine($"nomber of positive count of array");
// PrintArray(freendlyArray);
// Console.WriteLine($"is {CheckPositive(freendlyArray)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int FindX(int k1, int b1, int k2, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    return x;
}

int FindY(int k1, int b1, int x)
{
    int y = k1 * x + b1;
    return y;
}

Console.WriteLine("For two 'y = k1 * x + b1' type functions input args");

Console.WriteLine("Enter Number k1");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number b1");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number k2");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number b2");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) Console.WriteLine($"Прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} параллельны");
else
{
int x = FindX(k1,b1,k2,b2);
int y = FindY(k1,k2,x);
Console.WriteLine($"Прямые пересекаются в точке x,y -> {x},{y}");
}
