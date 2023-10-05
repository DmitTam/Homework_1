// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int RaisedToTheNaturalPower(int numA, int numB)
{
    int result = 1;
    if (numB <= 0) Console.WriteLine("некорректный ввод");
    for (int i = 1; i <= numB; i++)
    {
        checked
        {
            result = numA * result;
        }
    }
    return result;
}


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
int raisedToThePower = RaisedToTheNaturalPower(numberA, numberB);
Console.WriteLine($"-> {raisedToThePower}");
