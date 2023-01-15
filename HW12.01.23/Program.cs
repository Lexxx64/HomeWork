// Console.WriteLine("Введите число A");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B");
// int B = int.Parse(Console.ReadLine()!);
// Console.Write($"Число {A} в степени {B} равно {GetExp(A)}");

// Console.WriteLine("Введите число ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write($"Сумма чисел равна {GetSum(num)}");

Console.WriteLine("Задан массив с размерностью 8");
int size = 8;
Console.Write($"Массив создан [{String.Join(',', GetArray(size))}]");

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

int[] GetArray(int size){
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++){
        MyArray[i] = new Random().Next(1, 10);
    }
        return MyArray;
}