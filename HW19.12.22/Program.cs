// задача 1

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if ((num >= 100) && (num < 1000)){
   int result = (num / 10 % 10);
   Console.WriteLine($"{result}"); 
}
else{
    Console.WriteLine($"Число не является трехзначным");
}

// Задача 2

Console.Write($"Введите число в интервале от 1 до 100000: ");
int a = int.Parse(Console.ReadLine()!);
if (a > 100000){
    Console.WriteLine($"Упс, попробуйте снова!");
}
else{
    if ((a > 99) && (a < 100001)){
    string str = a.ToString();
    Console.WriteLine($"{str[2]}");
    }
    else{
    Console.WriteLine($"Такой цифры нет");
    }
}

// задача 3

Console.Write("Введите день недели от 1 до 7: ");
int date = int.Parse(Console.ReadLine()!);
if ((date >= 1) && (date <= 7))
    if ((date == 6) || (date == 7)){
    Console.WriteLine($"Выходной");
    }
    else{
    Console.WriteLine($"Будни");
    }
else{
    Console.WriteLine($"Нет такого дня недели");
}
   

