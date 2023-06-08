// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] CreateManualArray(int size)
// {
//     int[] newArray = new int[size];
//     Console.WriteLine("Input your numbers:");
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
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

// int CountZeros(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == 0) 
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.WriteLine("How many numbers you want to input?");
// int M = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateManualArray(M);
// Console.WriteLine();
// PrintArray(myArray);
// Console.WriteLine($"You have {CountZeros(myArray)} zeros");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] CreateManualArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

double[] FindIntersectionPoint(int[] parameters)
{
    double[] coordinates = new double[2];
    int b1 = parameters[0];
    int k1 = parameters[1];
    int b2 = parameters[2];
    int k2 = parameters[3];
    Console.WriteLine($"Your first function: y = {k1}x + {b1}");
    Console.WriteLine($"Your second function: y = {k2}x + {b2}");
    double x = (double) (b2 - b1) / (k1 - k2) ;
    coordinates[0] = x;
    double y = k1 * x + b1;
    coordinates[1] = y;
    return coordinates;
}

Console.WriteLine("You're about to set functions: ");
Console.WriteLine("y = k1X + b1 and y = k2X + b2 ");
Console.WriteLine("Input in due order: b1, k1, b2, k2 :");

int[] parameters = CreateManualArray(4);
double[] coordinates = FindIntersectionPoint(parameters);

double x = coordinates[0];
double y = coordinates[1];

Console.WriteLine("Intersection point of your functions is:");
Console.WriteLine($"({x}; {y})");