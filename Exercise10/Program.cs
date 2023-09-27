// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    // int secondDigit = num / 10 % 10;
    return num / 10 % 10;
    // Console.WriteLine($"-> {secondDigit}");
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
while (number >0)
{
    if (number <100) Console.WriteLine("Некорректный ввод");
    if (number >= 1000) Console.WriteLine("Некорректный ввод");
    break;
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