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





// // Задача 3
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= num; i++){
//     Console.Write($"{Math.Pow(i, 3)} ");
// }
