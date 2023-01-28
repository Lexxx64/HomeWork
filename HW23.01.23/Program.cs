// int[,] array = GetArray(3, 4, 0, 100);
// PrintArray(array);

// //----метод создания двухмерного массива
// int[,] GetArray (int m, int n, int minValue, int maxValue){
//     int [,] massive = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//              massive[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     } return massive;
// }

// //----метод вывода массива
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     } 
// }
//--Задача 47. Задайте двумерный массив размером m×n
//заполненный случайными вещественными числами.
// double[,] array = GetDoubleArray(3, 4);
// PrintDoubleArray(array);

//----метод создания двухмерного массива----
double[,] GetDoubleArray (int m, int n){
    double [,] massive = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
             massive[i, j] = new Random().NextDouble()*100-50;
        }
    } return massive;
}

//----метод вывода массива----
void PrintDoubleArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    } 
}

//Задача 50. Напишите программу, которая на вход принимает число, проверяя есть ли
// такое число в двумерном массиве и возвращает сообщение о том, что оно найдено
// или же указание, что такого элемента нет


int[,] array = GetArray(4, 3, 10, 18);
Console.WriteLine("Введите число маркер ");
int num = int.Parse(Console.ReadLine()!);
PrintArray(array);
GetNum(array, num);

//---Метод создания целочисленного массива---
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

//---Метод вывода целочисленного массива---
void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
     Console.WriteLine();
    }
}

//--- Метод поиск числа---
bool GetNum(int[,] array, int num){
   for(int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j< array.GetLength(1); j++){
        if(array[i,j] == num){
            Console.WriteLine($"Мапкер{num} есть в массиве");
            return true;
        }
    }
   }
   Console.WriteLine($"Маркер {num} отсутствует в массиве");
   return false;  
}
