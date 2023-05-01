// Task19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// bool CheckNum(int num)
// {
//     if (num / 10000 == num % 10 && (num % 10000) / 1000 == (num % 100) / 10) return true;
//     else return false;
// }

// Console.WriteLine("enter 5 digit number");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a;
// if (a < 0) b = a * -1;
// if (b > 9999 && b < 100000) Console.WriteLine($"{a} is polindrome -> {CheckNum(b)}");
// else Console.WriteLine("enter correct number");


// Task21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindLenghtSegment(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double a = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
//     return a;
// }

// Console.WriteLine("input coordinate x to A");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate y to A");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate z to A");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate x to B");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate y to B");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("input coordinate z to B");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Lenght of segment = {FindLenghtSegment(x1, y1, z1, x2, y2, z2)}");


// Task23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubesNumbers(int number)
// {
//     int count = 1;
//     if (number > 1)
//     {
//         while (count <= number)
//         {
//             Console.WriteLine($"{Math.Pow(count, 3)}");
//             count++;
//         }
//     }
//     else
//     {
//         while (count >= number)
//         {
//             Console.WriteLine($"{Math.Pow(count, 3)}");
//             count--;
//         }
//     }
// }

// Console.WriteLine("input number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"list of cubes of numbers from 1 to {a}");
// CubesNumbers(a);