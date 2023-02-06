// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество стоблцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols]; 
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// SortArray(array);
// PrintArray(array);


// void FillArray(int[,] array) 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10); 
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2} \t"); 
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int n = 0; n < array.GetLength(1) - 1; n++)
//             {
//                 if (array[i, n] < array[i, n + 1])
//                 {
//                     int temp = array[i, n + 1];
//                     array[i, n + 1] = array[i, n];
//                     array[i, n] = temp;
//                 }
//             }
//         }
//     }
// }




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество стоблцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// SearchMinNumRows(array);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2} \t");
//         Console.WriteLine();
//     }
// }

// void SearchMinNumRows(int[,] array)
// {
//     int min = 0;
//     int minSum = 0;
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         min += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
//         if (sum < min)
//         {
//             min = sum;
//             minSum = i;
//         }
//         sum = 0;
//     }
//     Console.Write($"Строка с наименьшей суммой элементов: {minSum + 1}");
// }




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.WriteLine("Введите количество строк первой матрицы");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество стоблцов первой матрицы");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк второй матрицы");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество стоблцов второй матрицы");
// int d = Convert.ToInt32(Console.ReadLine());

// int[,] firstArray = new int[a, b];
// FillArray(firstArray);
// Console.WriteLine($"Первая матрица:");
// PrintArray(firstArray);
// int[,] secondArray = new int[a, b];
// FillArray(secondArray);
// Console.WriteLine($"Вторая матрица:");
// PrintArray(secondArray);
// int[,] resultArray = new int[a, d];
// Multiply(firstArray, secondArray, resultArray);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintArray(resultArray);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2} \t");
//         Console.WriteLine();
//     }
// }

// void Multiply(int[,] firstArray, int[,] secondArray, int[,] resultArray)
// {
//     for (int i = 0; i < resultArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultArray.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int n = 0; n < firstArray.GetLength(1); n++)
//             {
//                 sum += firstArray[i, n] * secondArray[n, j];
//             }
//             resultArray[i, j] = sum;
//         }
//     }
// }



// Задача 60. Сформируйте трёхмерный массив из уникальных двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Введите размер массива X * Y * Z");
// Console.WriteLine("Введите X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Z");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,,] array = new int[x, y, z];
// FillArray(array);
// PrintArray(array);


// void FillArray(int[,,] array)
// {
//     int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//     int num;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(0, 10);
//         num = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(0, 10);
//                     j = 0;
//                     num = temp[i];
//                 }
//                 num = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array.GetLength(0); x++)
//     {
//         for (int y = 0; y < array.GetLength(1); y++)
//         {
//             for (int z = 0; z < array.GetLength(2); z++)
//             {
//                 array[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}); ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int n = 4;
// int[,] array = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//     array[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
//     else if (i < j && i + j >= array.GetLength(0) - 1) i++;
//     else if (i >= j && i + j > array.GetLength(1) - 1) j--;
//     else i--;
// }

// PrintArray(array);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write($" {array[i, j]} ");

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }





