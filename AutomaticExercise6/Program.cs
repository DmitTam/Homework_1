using System;

public class Answer
{
    public static double FindMax(double[] array)
    {
      double max = array[0];
      for (int i = 0; i < array.Lenth; i++)
      {
        if array[i] > array[i++]
          max = array[i]; 
        else max = array[i++];
      }
      return max;
    }

    public static double FindMin(double[] array)
    {
      double min = array[0];
      for (int i = 0; i < array.Lenth; i++)
      {
        if array[i] < array[i++] min = array[i];
        else min = array[i++];
      }
      return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
      double maximum = FindMax(array);
      double minimum = FindMin(array);
      double difference = maximum - minimum;
      return difference;
    }

    public static void PrintArray(double[] array)
    {
      for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]:F2 + "\t");
        }
    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}