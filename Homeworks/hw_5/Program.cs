// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void CountEvenNum(int[] array)
// {
//     int countNums = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) countNums += 1;
//     }
//     Console.WriteLine($"Amount of even numbers is {countNums}");
// }

// Console.WriteLine("Input size value of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = 100;
// int maxValue = 999;

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// CountEvenNum(myArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SumOddElement(int[] array)
{
    int sumNums = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumNums += array[i];
    }
    Console.WriteLine($"Sum of odd elements is {sumNums}");
}

Console.WriteLine("Input size value of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);

PrintArray(myArray);
SumOddElement(myArray);




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SumOddElement(int[] array)
{
    int sumNums = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumNums += array[i];
    }
    Console.WriteLine($"Sum of odd elements is {sumNums}");
}

Console.WriteLine("Input size value of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of element");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);

PrintArray(myArray);
SumOddElement(myArray);
