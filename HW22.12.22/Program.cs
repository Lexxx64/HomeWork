// Задача 1

Console.WriteLine("Введите пятизначное число ");
int res = int.Parse(Console.ReadLine()!);
if ((res > 9999) && (res < 100000)){
    int a = (res / 10000);
    int b = (res / 1000 % 10);
    int c = (res / 10 % 10);
    int d = (res % 10);
    if ((a == d) && (b == c)){
        Console.Write($"Да детка, {res} это палиндром");
    }
    else {
        Console.Write($"Мимо, {res} не палиндром");
    }
}
else {
    Console.Write($"Где тут пять знаков то?");
}

// Задача 2

Console.WriteLine("Введите координату Х точки1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки1: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Х точки2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки2: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки2: ");
int zb = int.Parse(Console.ReadLine()!);
double count = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками: {count:f2}");

// Задача 3

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= num; i++){
    Console.Write($"{Math.Pow(i, 3)} ");
}
