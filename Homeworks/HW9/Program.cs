// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NumberN(int num)
// {
//     if (num > 0)
//     {
//         Console.Write(num + " ");
//         NumberN(num - 1);

//     }
// }
// Console.WriteLine("Input N");
// int num = Convert.ToInt32(Console.ReadLine());
// NumberN(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SummHel(int m,int n)
// {
//     int sum = m;
//     if (m <= n)
//     {
//         return SummHel(m + 1,n)+sum;
//     }
//     else return 0;
// }
// int m = 1;
// int n = 16;
// Console.WriteLine(SummHel(m,n));



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Acker(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (m > 0 && n == 0)
//         return Acker(m - 1, 1);
//     else return Acker(m - 1, Acker(m, n - 1));
// }

// Console.WriteLine("input m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input n");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// if (m >= 0 && n >= 0) Console.WriteLine($"A({m},{n}) = {Acker(m, n)}");
// else Console.WriteLine("input correct numbers");
