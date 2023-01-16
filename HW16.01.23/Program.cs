int[] Array = GetArray(45, 100, 999);
Console.WriteLine($"В массиве [{String.Join(',', Array)}] \nколичество четных чисел равно {EvNum(Array)}");


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