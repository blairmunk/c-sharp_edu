// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Input a 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int digits = 0;

// int countDigitNumber = number;
// while (countDigitNumber != 0)
// {
//     digits++;
//     countDigitNumber /= 10;
// }

// bool isPalindrome = true;
// int deadNumber = number;
// for (int i = 1; i <= digits/2; i++)
// {
//     Console.WriteLine((number / 10));
//     Console.WriteLine(deadNumber % 10);
//     if ( (number / Math.Pow(10, digits - i))%10 != deadNumber % 10 )
//         {
//             isPalindrome = false;
//             break;
//         }
//     deadNumber /= 10;
// }
// Console.WriteLine(isPalindrome);


// Console.Write("Input a 5-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool isPalindrome = true;
// int deadNumber = number;
// for (int i = 1; i <= digits/2; i++)
// {
//     Console.WriteLine((number / 10));
//     Console.WriteLine(deadNumber % 10);
//     if ( (number / Math.Pow(10, digits - i))%10 != deadNumber % 10 )
//         {
//             isPalindrome = false;
//             break;
//         }
//     deadNumber /= 10;
// }

// Console.WriteLine(isPalindrome);




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Input coordinates of point A (x1, y1, z1): ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input coordinates of point B (x2, y2, z2): ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt( Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) );

// Console.WriteLine(distance);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i*i*i} ");
    }
    Console.WriteLine();
    return 0;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
GetCube(num);