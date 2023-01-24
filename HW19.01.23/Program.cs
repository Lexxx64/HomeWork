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
Console.WriteLine("введите размерность массива ");
int size = int.Parse(Console.ReadLine()!);
int[] massive = new int[size];
int count = 0;
Console.WriteLine("заполните массив числами через пробел ");
string stringArray = Console.ReadLine()!;
string[] array = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
for(int i = 0; i < size; i++){
    massive[i] = Convert.ToInt32(array[i]);
    }
    foreach(int el in massive){
           if(el > 0){
            count++;
           }
    }
    Console.WriteLine($"{count}");




//     for(int i = 0; i < array.Length; i++){
//         for(int j = 0; j < array.Length - 1; j++){
//             if(array[j] > array[j+1]){
//                 int x = array[j];
//                 array[j] = array[j+1];
//                 array[j+1] = x;
//             }
//         }
//     }
// Console.WriteLine(string.Join(",", array));

   
    

