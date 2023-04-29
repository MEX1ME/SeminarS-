// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// int Search2Number(int a)
// {
//     int b = (a % 100) / 10;
//     return b;
// }

// Console.WriteLine($"please enter your three digit number");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a / 100 >= 1 && a / 100 <= 9)
// {
//     int c = Search2Number(a);
//     Console.WriteLine(c);
// }
// else
// {
//     Console.WriteLine($"the number is not three-digit");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// int Find3num(int num)
// {
//     int a = 100;
//     int ost = -1;
//     while (ost < 0)
//     {
//         if (num >= a && num < 10 * a)
//         {
//             ost = (num % (a / 10)) / (a / 100);
//         }
//         else
//         {
//             a = a * 10;
//         }
//     }
//     return ost;
// }

// Console.WriteLine("enter a number");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0) num = num * -1;
// if (num < 100) Console.WriteLine("there is no third digit");
// else Console.WriteLine(Find3num(num));

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool CheckDay(int a)
// {
//     if (a == 6 || a == 7) return true;
//     else return false;
// }
// Console.WriteLine("enter the day number");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber > 0 && dayNumber < 8) Console.WriteLine($"\"Day of week № {dayNumber} is a weekend\" - {CheckDay(dayNumber)}");
// else Console.WriteLine($"{dayNumber} is not the number of the day of the week");