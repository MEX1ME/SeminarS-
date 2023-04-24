//Task1
// int MaxDigit(int randomNum)
// {
//     int dec = randomNum / 10;
//     int ed = randomNum % 10;
//     if(dec>ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 100);

// int result = MaxDigit(num);

// Console.WriteLine($"{num} -> {result}");

//Task2

// bool Kratnost(int num1, int num2)
// {
//     if (num1 % num2 == 0) return true;
//     else return false;
// }

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1},{num2} -> {Kratnost(num1, num2)}, ost {num1 % num2}");

//Task3

// bool Doublecratno(int a)
// {
//     if (a % 7 == 0 && a % 23 == 0) return true;
//     else return false;
// }

// Console.WriteLine($"Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = Doublecratno(num);
// Console.WriteLine($"{num} cratno 7 and 23 -> {result}");

//Task4

// bool Quad (int a, int b)
// {
//     if(a/b == b || b/a == a) return true;
//     else return false;
// }

// Console.WriteLine("Input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{a} and {b}, {Quad(a,b)}");