int[] array = {0, 4, 21, 45, 46, 99, 333, 451, -151, -14};
Console.WriteLine($"Всего в массиве больше 0 - {GetArray(array)} чисел");

// 
int GetArray(int[] array){
    int count = 0;
    foreach(int el in array){
        if(el > 0){
        count++;
        }
    }    
    return count;
}