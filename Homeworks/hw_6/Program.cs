// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateManualArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Input your numbers:");
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToInt32(Console.ReadLine());
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

int CountZeros(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0) 
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("How many numbers you want to input?");
int M = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateManualArray(M);
Console.WriteLine();
PrintArray(myArray);

Console.WriteLine($"You have {CountZeros(myArray)} zeros");






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)