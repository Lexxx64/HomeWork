// -----Задача 41-----//
Console.WriteLine("введите размерность массива ");
int size = int.Parse(Console.ReadLine()!);
int[] massive = new int[size];
Console.WriteLine("заполните массив числами через пробел ");
string stringArray = Console.ReadLine()!;
string[] array = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"В массиве [{String.Join(',', array)}]");
Console.Write($"Количество чисел больше 0 равно {GetMassive(massive, array, size)}");
// ----метод----//
int GetMassive(int[] massive, string[] array, int size){
    int count = 0;
    for(int i = 0; i < size; i++){
    massive[i] = Convert.ToInt32(array[i]);
    }
    foreach(int el in massive){
           if(el > 0){
            count++;
           }
    } return count;
}

//----Задача 43----//
// int[] Array = GetArray(6, 0, 101);
// Console.WriteLine($"Заданный массив [{String.Join(',', Array)}]");
// Console.Write($"Отсортированный массив [{String.Join(',', GetReverse(Array))}]");

// -----метод создания массива-----//
int[] GetArray(int size, int minValue, int maxValue){
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++){
        MyArray[i] = new Random().Next(minValue, maxValue);
    }
        return MyArray;
}

//----метод сортировки массива----//
int[] GetReverse(int[] Array){
    for(int i = 0; i < Array.Length; i++){
        for(int j = 0; j < Array.Length - 1; j++){
            if(Array[j] > Array[j+1]){
                int x = Array[j];
                Array[j] = Array[j+1];
                Array[j+1] = x;
            }
        }
    } return Array;
}


   
    

