//-Задача 34-//
// int[] Array = GetArray(45, 100, 999);
// Console.WriteLine($"В массиве [{String.Join(',', Array)}] \nколичество четных чисел равно {EvNum(Array)}");

//-Задача 36-//
// int[] Array = GetArray(10, -10, 10);
// Console.WriteLine($"В массиве [{String.Join(',', Array)}] \nсумма чисел в нечетных индексах равна {GetSum(Array)}");

//-Задача 37-//
int[] Array = GetArray(6, 1, 10);
Console.WriteLine($"В массиве [{String.Join(',', Array)}] \nновый массив произведений пар [{String.Join(',',GetMult(Array))}]");

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

//----метод умножения пар чисел массива----//
int[] GetMult(int[] Array){
    int size = Array.Length/2;
    if (Array.Length % 2 == 1) size++;
    int[] MyArray = new int[size];
    for (int i = 0; i < Array.Length/2; i++){
        MyArray[i] = Array[i] * Array[Array.Length - 1 - i];
    }
    if (Array.Length % 2 == 1) MyArray[size - 1] = Array[Array.Length / 2];
    return MyArray;
}

