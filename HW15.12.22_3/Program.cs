Console.Write("Введите число для проверки: ");
int num = int.Parse(Console.ReadLine()!);
Console.Clear();
if(num % 2 == 0 ){
    Console.WriteLine($"Число чётное: {num}");
}
else{
    Console.WriteLine($"Число нечётное: {num}");
}
