// int[] array = {0, 4, 21, 45, 46, 99, 333, 451, -151, -14};
// Console.WriteLine($"Всего в массиве больше 0 - {GetArray(array)} чисел");

// 
// int GetArray(int[] array){
//     int count = 0;
//     foreach(int el in array){
//         if(el > 0){
//         count++;
//         }
//     }    
//     return count;
// }
int[] array = {21, 4, 0, 45, 99, 46, 333, 451, -151, -14};
    for(int i = 0; i < array.Length; i++){
        for(int j = 0; j < array.Length - 1; j++){
            if(array[j] > array[j+1]){
                int x = array[j];
                array[j] = array[j+1];
                array[j+1] = x;
            }
        }
    }
Console.WriteLine(string.Join(",", array));

   
    
