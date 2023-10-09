// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool ExistTriangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}


Console.WriteLine("Введите первую сторону");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону");
int side3 = Convert.ToInt32(Console.ReadLine());

bool result = ExistTriangle(side1, side2, side3);
Console.WriteLine(result? "Треугольник существует" : "Треугольник не существует");