// Console.WriteLine("Введите число A");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число {A} в степени {B} равно {GetExp(A)}");

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел равна {GetSum(num)}");


//метод//
int GetExp(int A, int B){
    int A1 = A;
    for (int i = 1; i < B; i++)
    {
        A1 *= A;
    }
    return A1;
}

int GetSum(int num){
    int sum = 0;
    while (num > 0){
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}