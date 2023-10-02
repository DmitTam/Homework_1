// Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number и проверяет, 
// является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.


// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
//                      False


using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      int firstDigit = number / 10000;
      int secondDigit = number / 1000 % 10;
      int forthDigit = number % 100;
      int fifthDigit = number %10;
      if (number < 10000 || number >99999)
      {
        Console.WriteLine("Число не пятизначное");
        return false;
      }
      
      if (firstDigit == fifthDigit || secondDigit == forthDigit)
      {
        return true;
      }
      return false;
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 12321;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}