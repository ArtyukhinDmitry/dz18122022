// строим таблицу

// int[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n]; // m - кол-во строков, n - кол-во столбцов
//     for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = m, по строчкам
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // j, m, k 
//         // matrix.GetLength(1) = n, по столбцам
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//             Console.Write(inputMatrix[i,j] + "\t" ); // Строчку с индексом
//         }

//         Console.WriteLine(); // После строчки можно сделать перенос
//     }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] result = GetMatrix(rows, columns, 0, 10); // Создали матрицу
// PrintMatrix(result);





// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// Console.Write("Введите m: ");
// var m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// var n = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(array.Length);
// }
// Print2DArray(GetArray(m, n));





// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


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

// int [,] GetMatrixQ(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j+=2)
//         {
//             matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j],2));
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

// int[,] newArray = GetMatrix(3, 4, 1, 5);
// PrintArray(newArray);
// Console.WriteLine();
// newArray = GetMatrixQ(newArray);
// PrintArray(newArray);



// 49 второй вариант

// int[,] ChangeMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)

//             {
//                 matrix[i, j] *= matrix[i, j]; // matrix[i,j] = matrix[i,j] * matrix[i,j]
//             }
//         }
//     }
//     return matrix;
// }
// System.Console.WriteLine();
// PrintMatrix(ChangeMatrix(result));





// Задача 51 найти диагональ главную

// int sum = 0;
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         if (i == j)
//             sum = sum + result[i, j];
//     }    
// } 
// Console.WriteLine(sum);

// второй вариант

// int GetSumDiagonal(int[,] matrix)
// {
//     int sum = 0; // Изначальное значение суммы
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j]; // sum = sum + matrix[i, j]
//             }
//         }
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел в главной диагонали: {GetSumDiagonal(result)}");



// 47 ещё одна задача - заполнить массив вещественными числами

// double[] test  = new double[10];

// for (int i = 0; i < test.Length; i++)
// {
//     test[i] = Math.Round(new Random().NextDouble() * 1000, 3);
// }

// Console.WriteLine(String.Join(", ", test));






// pflfxf проверка на ошибку

// int a = 15;

// if (a < 10)
// {
//     return; // Значение возращено - программа отработала
// }

// Console.WriteLine("Программа успешно отработала");
