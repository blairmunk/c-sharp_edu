// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4.  // 0,5 7 -2 -0,2 // 1 -3,3 8 -9,9  // 8 7,8 -7,1 9

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                Console.Write("{0,6:F2}", matr[i, j]);        
            }
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                matr[i,j] = random.NextDouble() * 100;        
            }
        }
    }
}

double[,] CreateMatrix()
{
    Console.WriteLine("Input dimensions of your matrix:");
    Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[m, n];
    return matrix;
}

double[,] matrix = CreateMatrix();
FillArray(matrix);
PrintArray(matrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2 // 5 9 2 3 // 8 4 2 4
// 17 -> такого числа в массиве нет

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             {
//                 Console.Write($"{matr[i, j]} ");        
//             }
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             {
//                 matr[i,j] = new Random().Next(1, 10);        
//             }
//         }
//     }
// }
// void CheckIndex(int[,] matr, int m, int n)
// {
//     if (m < matr.GetLength(0) && n < matr.GetLength(1)) Console.WriteLine($"This element is {matr[m,n]}");
//     else Console.WriteLine("This element doesn't exist");
// }
// int[,] CreateMatrix()
// {
//     int[,] matr = new int[3, 5];
//     return matr;
// }

// int[,] matrix = CreateMatrix();
// FillArray(matrix);
// PrintArray(matrix);

// Console.WriteLine("Input position of your matrix:");
// Console.Write("i = ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("j = ");
// int j = Convert.ToInt32(Console.ReadLine());

// CheckIndex(matrix, i, j);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: // 1 4 7 2 // 5 9 2 3 // 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void PrintTwoDimArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             {
//                 Console.Write($"{matr[i, j]} ");        
//             }
//         }
//         Console.WriteLine();
//     }
// }
// void PrintOneDimArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}; ");        
//     }
//     Console.WriteLine();

// }
// void FillArrayManual(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             {
//                 Console.Write($"Input element ({i},{j}): ");
//                 matr[i,j] = Convert.ToInt32(Console.ReadLine());        
//             }
//         }
//     }
// }
// double[] FindColumnAverage(int[,] matr)
// {
//     double[] colAverage = new double[matr.GetLength(1)];
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             sum += matr[i,j]; 
//         }
//         colAverage[j] = Math.Round((double) sum / matr.GetLength(0), 1);  
//     }
//     return colAverage;
// }
// int[,] CreateMatrix()
// {
//     int[,] matr = new int[3, 4];
//     return matr;
// }

// int[,] matrix = CreateMatrix();
// FillArrayManual(matrix);
// PrintTwoDimArray(matrix);
// Console.WriteLine();
// Console.WriteLine("Average of columns is:");
// PrintOneDimArray(FindColumnAverage(matrix));


// 