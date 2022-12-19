Console.Write("Введите число для проверки: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 1;
Console.Clear();
while (num1 <= num){
    if (num1 % 2 == 0)
    Console.Write($"{num1} ");
    num1++;
}
