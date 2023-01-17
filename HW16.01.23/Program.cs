//-Задача 34-//
// int[] Array = GetArray(45, 100, 999);
// Console.WriteLine($"В массиве [{String.Join(',', Array)}] \nколичество четных чисел равно {EvNum(Array)}");

//-Задача 36-//
int[] Array = GetArray(10, -10, 10);
Console.WriteLine($"В массиве [{String.Join(',', Array)}] \nсумма чисел в нечетных индексах равна {GetSum(Array)}");

//----метод-создание массива-----//
int[] GetArray(int size, int minValue, int maxValue){
    int[] MyArray = new int[size];
    for (int i = 0; i < size; i++){
        MyArray[i] = new Random().Next(minValue, maxValue);
    }
        return MyArray;
}
//----метод подсчета четных чисел---//
int EvNum(int[] Array){
    int count = 0;
    foreach (int el in Array){
        if (el%2 == 0){
            count++;
        }
    }
    return count;
}
//----метод суммирующий элементы нечетных ячеек----//
int GetSum(int[] Array){
    int sum = 0;
    for (int i = 0; i <= Array.Length; i++){
        if (i%2 != 0){
            sum += Array[i];
        }
    }
        return sum;
}