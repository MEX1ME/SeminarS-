//Task1 Найти номер четверти

// int FindQuard(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;

//     return 0;
// }

// Console.WriteLine("input X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input Y:");
// int y = Convert.ToInt32(Console.ReadLine());
// int result = FindQuard(x, y);

// Console.WriteLine($"Point with {x} and {y} coordinates located at {result} quart");

//Task3 Найти расстояние между точками плоскости

// double FindDistance (double xa, double ya, double xb, double yb)
// {
//     return Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2));
// }

// Console.WriteLine("Input coordinate x to A:");
// double xa = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate x to B:");
// double xb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between point A with coordinate ({xa}, {ya}) and point B with coordinates ({xb},{yb}) -> {FindDistance (xa,ya,xb,yb)}");

//Task3 По заданному номеру четверти показать диапазон возможных координат точек в этой четверти (x и y)

// string Diapazon(int num)
// {
//     if (num == 1) return "x>0, y>0";
//     if (num == 2) return "x<0, y>0";
//     if (num == 3) return "x<0, y<0";
//     if (num == 4) return "x>0, y<0";
//     return "0";
// }
// Console.WriteLine("Input quard");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"quard = {num}, coordinate {Diapazon(num)}");

//Task Программа, которая принимает на вход число N и возвращает квадрат чисел от 1 до N]

void XpeHb(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} -> {Math.Pow(count, 2)}");
        count++;
    }
}

Console.WriteLine("Input num");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0) Console.WriteLine($"input correct num");
else
XpeHb(num);