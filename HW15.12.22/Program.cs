Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()!);
Console.Clear();
if (a > b){
    Console.WriteLine($"Большее число: {a}, Меньшее число {b}");
}
else {
    Console.WriteLine($"Большее число: {b}, Меньшее число {a}");
}