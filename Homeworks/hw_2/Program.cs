// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Input 3-digit number: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int secondDigit = -1;
//     while ( num > 99)
//     {
//         num /= 10;
//         secondDigit = num % 10;
//     }
//     Console.WriteLine($"The second digit of this number is {secondDigit}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetThirdDigit(int num)
{
    int thirdDigit = -1;
    while ( num > 99 )
    {
        thirdDigit = num % 10;
        num /= 10;
    }

    if (thirdDigit != -1)
    {
        Console.WriteLine($"The third digit of this number is {thirdDigit}");    
    }
    else
        Console.WriteLine("The third digit doesn't exist");
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
GetThirdDigit(num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void WhatsADay(int day)
// {
//     if (day >= 1 && day <= 5)
//     {
//         Console.WriteLine("It's a workday");    
//     }
//     else if (day <= 7 && day >= 6) 
//     {
//         Console.WriteLine("It's a weekend day");
//     }    
//     else 
//     {
//         Console.WriteLine("You're out of range");
//     }
// }

// Console.Write("Input number in the range 1..7: ");
// int day = Convert.ToInt32(Console.ReadLine());
// WhatsADay(day);


