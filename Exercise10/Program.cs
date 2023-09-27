// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    return num / 10 % 10;
}

Console.WriteLine("Введите положительное трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <100 || number >= 1000)
{
    Console.WriteLine ("Некорректный ввод");
    return;
}

int a = SecondDigit(number);
Console.WriteLine($"-> {a}");








// if (number > 99)
// {
//     int a = SecondDigit(number);
// }
// else Console.WriteLine("Некорректный ввод");

// if (number < 1000)
// {
//     int a = SecondDigit(number);
// }
// else Console.WriteLine("Некорректный ввод");