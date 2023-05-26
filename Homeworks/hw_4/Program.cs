// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Expon(int bas, int exp)
// {
//     int result = Convert.ToInt32(Math.Pow(bas, exp));
//     return result;
// }

// bool resume = true;

// while (resume == true)
// {
//     Console.Write("Input two numbers: ");
//     int bas = Convert.ToInt32(Console.ReadLine());
//     int exp = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Your result is {Expon(bas, exp)}");
//     Console.WriteLine("Do you want to repeat? (Y/n)");
//     string repeat = Console.ReadLine();
//     if (repeat == "n")
//     {
//         resume = false;
//     } 
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int GetDigitsSum(int num)
// {
//     int sum = 0;
//     while (num != 0)
//     {
//         int digit = num % 10;
//         sum += digit;
//         num /= 10;
//     }
//     return sum;
// }

// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetDigitsSum(num));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Input elements:");
    for(int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Input size value of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
PrintArray(myArray);