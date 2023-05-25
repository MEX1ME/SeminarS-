//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a) return true;
//     return false;
// }

// Console.WriteLine($"input A lentht");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input B lentht");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"input C lentht");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{CheckTriangle(a,b,c)}");

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

// int[] Fibonachi(int size, int firstNum, int secondNum)
// {
//     int[] array = new int[size];
//     array[0] = firstNum;
//     array[1] = secondNum;
//     for (int i = 2; i < size; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// Console.WriteLine($"input size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input 1 num");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"input 2 num");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// PrintArray(Fibonachi(size, firstNum, secondNum));

//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] WishRotate(int[] wishRotate)
{
    int box = 0;
    for (int i = 0; i < wishRotate.Length - 1 - i; i++)
    {
        box = wishRotate[i];
        wishRotate[i] = wishRotate[wishRotate.Length - 1 - i];
        wishRotate[wishRotate.Length - 1 - i] = box;
    }
    return wishRotate;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

Console.WriteLine($"input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input minValue");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"input maxValue");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, minValue, maxValue);

PrintArray(array);
array = WishRotate(array);
PrintArray(array);
