// задача 1
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if ((num >= 100) && (num < 1000)){
   int result = (num - ((num/100)*100 + num%10))/10;
   Console.WriteLine($"{result}"); 
}
else{
    Console.WriteLine($"Число не является трехзначным");
}
