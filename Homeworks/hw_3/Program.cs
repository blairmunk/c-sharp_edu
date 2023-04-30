// Задача 19 (Для 5-значного числа)
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

bool IsPalindrome(int num)
{
    int digits = 5;
    int tempNumber = num;
    for (int i = 1; i <= digits/2; i++)
    {
        int leftDigit = (int)((num / Math.Pow(10, digits - i))%10);
        int rightDigit = tempNumber % 10;
        if (leftDigit != rightDigit)
        {  
            return false;
        }
        tempNumber /= 10;
    }
    return true;
}

Console.Write("Input a 5-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 10000 == 0 || number / 10000 >= 10) 
{
    Console.WriteLine("Your number isn't 5-digit. Repeat your input");
    return;
}

if (IsPalindrome(number)) Console.WriteLine("It is a palindrome");
else Console.WriteLine("It's NOT a palindrome");

// Задача 19 (Для любого числа из диапазона int)
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

// int CountDigitNumber(int num)
// {   
//     int digits = 0;
//     while (num != 0)
//     {
//         digits++;
//         num /= 10;
//     }
//     return digits;
// }

// bool IsPalindrome(int num)
// {
//     int digits = CountDigitNumber(num);
//     int tempNumber = num;
//     for (int i = 1; i <= digits/2; i++)
//     {
//         int leftDigit = (int)((num / Math.Pow(10, digits - i))%10);
//         int rightDigit = tempNumber % 10;
//         if (leftDigit != rightDigit)
//         {  
//             return false;
//         }
//         tempNumber /= 10;
//     }
//     return true;
// }

// Console.Write("Input a 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (IsPalindrome(number)) Console.WriteLine("It is a palindrome");
// else Console.WriteLine("It's NOT a palindrome");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Round(Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) ), 2);
// }

// Console.Write("Input coordinates of point A (x1, y1, z1): ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input coordinates of point B (x2, y2, z2): ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double dist = Distance(x1,y1,z1,x2,y2,z2);
// Console.WriteLine($"Distance between A({x1},{y1},{z1}) and B({x2},{y2},{z2}) points is: {dist}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int GetCube(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write($"{i*i*i} ");
//     }
//     Console.WriteLine();
//     return 0;
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// GetCube(num);