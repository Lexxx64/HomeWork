//Задача 64: Выполнить с помощью рекурсии.Задайте значение N.Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.

// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetToMin(N, 1));

//Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} \nравна {GetSumEl(M, N)}");

//Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления
// функции Аккермана с помощью рекурсии. Даны два неотрицательных числа n и m.

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A({n},{m}) = {GetAck(n,m)}");

//---метод рекурсии задачи 64
string GetToMin(int start, int end)
{
    if (start == end) return end.ToString();
    return (start + " " + GetToMin(start - 1, end));
}

//---Метод рекурсии задачи 66
int GetSumEl(int start, int end)
{
    int sum = start;
    if (start == end) return sum;
    return (sum += GetSumEl(start + 1, end));
}

//---Метод функции Аккермана---
int GetAck(int n, int m){
           
    if(n == 0) return m + 1;
          
    if(m == 0) return GetAck(n - 1, 1);
    return (GetAck(n-1, GetAck(n, m - 1)));
}
