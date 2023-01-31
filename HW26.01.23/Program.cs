int[,] Array = GetArray(3, 4, 0, 10);
PrintArray(Array);
Console.WriteLine();
SortArray(Array);
PrintArray(Array);

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