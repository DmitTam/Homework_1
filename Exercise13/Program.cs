// /Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int ThirdDigit(int num)
{
    // int secondDigit = num / 10 % 10;
    return num % 10;
    // Console.WriteLine($"-> {secondDigit}");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number <100) 
{
    Console.WriteLine("-> третьей цифры нет");
    return;
}

if (number >1000)
{
    
}
int a = ThirdDigit(number);
Console.WriteLine($"-> {a}");








