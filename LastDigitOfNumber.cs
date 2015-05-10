using  System;

public class LastDigitOfNumber
{
    public static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        string lastDigitAsWord = GetLastDigitAsWord(number);

        Console.WriteLine("The last digit of your number is: " + lastDigitAsWord);
    }

    private static string GetLastDigitAsWord(int number)
    {
        string lastDigitAsWord = String.Empty;
        int remainder = number % 10;

        switch (remainder)
        {
            case 0:
                lastDigitAsWord = "zero";
                break;
            case 1:
                lastDigitAsWord = "one";
                break;
            case 2:
                lastDigitAsWord = "two";
                break;
            case 3:
                lastDigitAsWord = "three";
                break;
            case 4:
                lastDigitAsWord = "four";
                break;
            case 5:
                lastDigitAsWord = "five";
                break;
            case 6:
                lastDigitAsWord = "six";
                break;
            case 7:
                lastDigitAsWord = "seven";
                break;
            case 8:
                lastDigitAsWord = "eight";
                break;
            case 9:
                lastDigitAsWord = "nine";
                break;
        }

        return lastDigitAsWord;
    }
}