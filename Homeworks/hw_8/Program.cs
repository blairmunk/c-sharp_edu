﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// int SumRow(int[,] matr, int rowIndex)
// {
//     int sum = Int32.MinValue;
//     for (int j = 0; j < matr.GetLength(1); j++)
//         sum += matr[rowIndex,j];
//     return sum;
// }

// int[] GetSummedArray(int[,] matr)
// {
//     int[] arr = new int[matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         arr[i] = SumRow(matr,i);
//     }
//     return arr;
// }

// int GetIndexOfMin(int[] arr)
// {
//     int indexOfMin = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] < arr[i-1])
//             indexOfMin = i;
//     }
//     return indexOfMin;
// }

// void GetMessage(int indexOfRow)
// {
//     Console.WriteLine($"Row #{indexOfRow+1} contains minimal sum");
// }

// int[,] matrix = CreateMatrix();
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine();
// GetMessage(GetIndexOfMin(GetSummedArray(matrix)));



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
//     int[,] matr = new int[2, 2];
//     return matr;
// }

// int CalcMatrixElement(int[,] matrA, int[,] matrB, int i, int j)
// {
//     int cij = 0;
//     for (int r = 0; r < matrA.GetLength(1); r++)
//     {
//         cij += matrA[i,r]*matrB[r,j];
//     }
//     return cij;

// }


// int[,] ProductOfMatrix(int[,] matrA, int[,] matrB)
// {
//     int[,] matrC = new int[matrA.GetLength(0),matrB.GetLength(1)];
//     for (int i = 0; i < matrC.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrC.GetLength(0); j++)
//         {
//             matrC[i,j] = CalcMatrixElement(matrA, matrB, i, j);
//         }
//     }
//     return matrC;
// }

// int[,] matrixA = CreateMatrix();
// int[,] matrixB = CreateMatrix();
// FillArray(matrixA);
// FillArray(matrixB);
// PrintArray(matrixA);
// Console.WriteLine();
// PrintArray(matrixB);
// Console.WriteLine();

// if (matrixA.GetLength(1) == matrixB.GetLength(0))
// {
//     int[,] matrixC = ProductOfMatrix(matrixA, matrixB);
//     PrintArray(matrixC);
// }
// else
//     Console.WriteLine("These matriсes are not multipliable");


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrix()
{
    int[,,] matr = new int[2, 2, 2];
    return matr;
}

bool isExist(int[,,] matr, int elem)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                {
                    if (elem != matr[i,j,k] && elem != 0)
                        return false;       
                }
            }
        }
    }
    return true;
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                {
                    while(isExist(matr, matr[i,j,k]))
                        matr[i,j,k] = new Random().Next(10, 100);      
                }
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");   
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] matrix3D = CreateMatrix();
FillArray(matrix3D);
PrintArray(matrix3D);



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