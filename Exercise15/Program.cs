// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 5 || number > 0) 
{
    Console.WriteLine(" -> нет");
    return;
}
if (number == 6) Console.WriteLine(" -> да");
if (number == 7) Console.WriteLine(" -> да");

bool WeekDay(int num)
{
    return 
}