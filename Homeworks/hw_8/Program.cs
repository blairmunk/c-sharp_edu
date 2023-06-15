// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] CreateMatrix()
// {
//     int[,] matr = new int[4, 4];
//     return matr;
// }

// int findSmallestPosition(int[,] matr, int startPosition, int rowIndex)
// {
// 	int smallestPosition = startPosition;
	
// 	for(int j = startPosition; j < matr.GetLength(1); j++)
// 	{
// 		if(matr[rowIndex,j] < matr[rowIndex,smallestPosition])
// 			smallestPosition = j;
// 	}
// 	return smallestPosition;
// }

// void selectionSort(int[,] matr, int rowIndex)
// {
// 	for(int j = 0; j < matr.GetLength(1); j++)
// 	{
// 		int smallestPosition = findSmallestPosition(matr, j, rowIndex);
// 		int temp = matr[rowIndex,j];
//         matr[rowIndex,j] = matr[rowIndex,smallestPosition];
//         matr[rowIndex,smallestPosition] = temp;
// 	}
// }

// void SortRows(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         selectionSort(matr, i);
//     }
// }

// int[,] matrix = CreateMatrix();
// FillArray(matrix);
// PrintArray(matrix);
// SortRows(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                Console.Write($"{matr[i, j]} ");        
            }
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                matr[i,j] = new Random().Next(1, 10);        
            }
        }
    }
}

int[,] CreateMatrix()
{
    int[,] matr = new int[4, 4];
    return matr;
}

int[,] matrix = CreateMatrix();
FillArray(matrix);
PrintArray(matrix);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void PrintTwoDimTextArray(int[,] matr)
// {
//     string fmt = "00";
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             {
//                 Console.Write($"{matr[i, j].ToString(fmt)} ");        
//             }
//         }
//         Console.WriteLine();
//     }    
// }

// int[,] GetSpiral(int[,] arr)
// {
//     int imin = 0;
//     int imax = arr.GetLength(0) - 1;
//     int jmin = 0;
//     int jmax = arr.GetLength(1) - 1;
//     int num = 1;
//     int i = imin;
//     int j = jmin;

//     while (imin <= imax && jmin <= jmax)
//     {
//         for (j = jmin; j <= jmax; j++)
//         {
//             arr[i,j] = num;
//             num += 1;
//         }
//         j -= 1;
//         imin += 1;

//         for (i = imin; i <= imax; i++)
//         {
//             arr[i,j] = num;
//             num += 1;
//         }
//         i -= 1;
//         jmax -= 1;

//         for (j = jmax; j >= jmin; j--)
//         {
//             arr[i,j] = num;
//             num += 1;
//         }
//         j += 1;
//         imax -= 1;
        
//         for (i = imax; i >= imin; i--)
//         {
//             arr[i,j] = num;
//             num += 1;
//         }
//         i += 1;
//         jmin += 1;
//     }
//     return arr;
// }

// int[,] matrix = new int[4,4];

// PrintTwoDimTextArray(GetSpiral(matrix));