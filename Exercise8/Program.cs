// Напишите программу, которая на вход принимает число (N), а на выходе показывает 
// все чётные числа от 1 до N.
// 5 -> 2, 4

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number > 1)
{
    while (count < number)
    {
        int A = count % 2;
        if (count+2 <= number)
        if (A == 0)
        {
            Console.Write($"{count+2} ");
        };
        count++;
    }
};
