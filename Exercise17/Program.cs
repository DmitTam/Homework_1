





public class Answer
{
    static bool IsPalindrome(int number)
    {
        int firstDigit = number / 10000;
        int secondDigit = number / 1000 % 10;
        int forthDigit = number % 100;
        int fifthDigit = number % 10;
        if (firstDigit == fifthDigit || secondDigit == fifthDigit)
            { return true; }
            return false;
            if (number > 99999 | number < 10000)
            {
                Console.WriteLine("число не пятизначное");
            }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            number = 99;
        }
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}

