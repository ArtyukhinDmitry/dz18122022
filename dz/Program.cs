// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i,j] + "\t" );
//         }

//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк m: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов n: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] result = GetMatrix(rows, columns, 0, 10);
// PrintMatrix(result);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] GetMatrix(int m, int n, int minV, int maxV)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minV, maxV+1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         Console.Write(inputArray[i,j] + "\t");
//     }
//         Console.WriteLine();
//     }
// }

// int[,] newArray = GetMatrix(3, 3, 1, 5);
// PrintArray(newArray);

// Console.Write("Введите строку m: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите столбец n: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows < newArray.GetLength(0) && columns < newArray.GetLength(1)) Console.WriteLine(newArray[rows, columns]);
// else Console.WriteLine($"{rows}{columns} -> такого числа в массиве нет");






// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] GetMatrix(int m, int n, int minV, int maxV)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(minV, maxV+1);
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] inputArray)
// {   for (int i = 0; i < inputArray.GetLength(0); i++)
//         {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         Console.Write(inputArray[i,j] + "\t");
//             }
//     Console.WriteLine();
//     }
// }

// void AverageArray(int[,] inputArray)
// {   
//     double result = 0;
//     Console.Write($"Cреднее арифметическое элементов в каждом столбце: ");
//     for (int j = 0; j < inputArray.GetLength(1); j++)
//     {
//         for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         result += inputArray[i,j];
//     }
//     Console.Write(result / inputArray.GetLength(0) + "\t");
//     result = 0;
//     }
// }

// int[,] newArray = GetMatrix(3, 4, 2, 5);
// PrintArray(newArray);
// AverageArray(newArray);

