//---Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//по убыванию элементы каждой строки двумерного массива.

// int[,] Array = GetArray(3, 4, 0, 10);
// PrintArray(Array);
// Console.WriteLine();
// SortArray(Array);
// PrintArray(Array);

//---Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] Array = GetArray(5, 6, 0, 10);
// PrintArray(Array);
// Console.WriteLine();
// Console.WriteLine($" Строка {GetRowsMin(Array)} с наименьшей суммой");

//---Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк матрицы А: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов матрицы А: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк матрицы B: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов матрицы B: ");
int columnsB = int.Parse(Console.ReadLine()!);
if(rowsA != columnsB){
    Console.Write($"Такие матрицы нельзя перемножить");
    return;
}
int[,] matrixA = GetArray(rowsA, columnsA, 1, 10);
int[,] matrixB = GetArray(rowsB, columnsB, 1, 10);
PrintArray(matrixA);
Console.WriteLine($"-");
PrintArray(matrixB);
Console.WriteLine($"-");
PrintArray(MultiMatrix(matrixA, matrixB));

//---метод умножения матриц---
int[,] MultiMatrix(int[,] matrixA, int[,] matrixB){
    int[,] newMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for(int i = 0; i < matrixA.GetLength(0); i++){
        for(int j = 0; j < matrixB.GetLength(1); j++){
            for(int k = 0; k < matrixA.GetLength(1); k++){
                newMatrix[i,j] += matrixA[i,k] * matrixB[k,j];
            }
        }
    }return newMatrix;
}


//---метод создание двумерного массива---
int[,] GetArray(int a, int b, int minValue, int maxValue){
    int[,] Array = new int[a,b];
    for(int i = 0; i < a; i++){
        for(int j = 0; j < b; j++){
            Array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }return Array;
}

//---метод печати двумерного массива---
void PrintArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
        for(int j = 0; j < Array.GetLength(1); j++){
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//---Метод сортировки по убыванию---
void SortArray(int[,] Array){
    for(int i = 0; i < Array.GetLength(0); i++){
       for(int j = 0; j < Array.GetLength(1); j++){
          for(int k = j + 1; k < Array.GetLength(1); k++)
            if(Array[i,k] > Array[i,j]){
                int x = Array[i,j];
                Array[i,j] = Array[i,k];
                Array[i,k] = x;
            } 
        }
    } 
}

//---метод нахождения строки с минимальной суммой---
int GetRowsMin(int[,] Array){
    int rows = 0;
    int minRows = 0;
    for(int i = 0; i < Array.GetLength(1); i++){
        minRows += Array[0,i];
    }
    for(int i = 1; i < Array.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < Array.GetLength(1); j++){
            sum += Array[i,j];
        }
        if(minRows > sum){
            minRows = sum;
            rows = i;
        }
        }
    return rows;
}
