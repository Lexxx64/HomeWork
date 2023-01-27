// int[,] array = GetArray(3, 4, 0, 100);
// PrintArray(array);

// //----метод создания двухмерного массива----//
// int[,] GetArray (int m, int n, int minValue, int maxValue){
//     int [,] massive = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//              massive[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     } return massive;
// }

// //----метод вывода массива----//
// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     } 
// }

double[,] array = GetArray(3, 4);
PrintArray(array);

//----метод создания двухмерного массива----//
double[,] GetArray (int m, int n){
    double [,] massive = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
             massive[i, j] = new Random().NextDouble()*100-50;
        }
    } return massive;
}

//----метод вывода массива----//
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    } 
}