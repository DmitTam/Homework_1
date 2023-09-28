// как объявить массив
// int[] array = new int[8];
// или
// int[] array = new int[8]{4, 7, 1, 4, 4, 2, 6, 9};
// или
// int[] array = new int[]{4, 7, 1, 4, 4, 2, 6, 9};
// или
// int[] array = {4, 7, 1, 4, 4, 2, 6, 9};
// или
// var array = new int[8]{4, 7, 1, 4, 4, 2, 6, 9};


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] arr = CreateArray(8);
PrintArray(arr);