using System;
using System.Linq;

public class ReverseNumber
{
    public static void Main()
    {
        Console.Write("Enter a floating point number: ");
        double number = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(number);

        Console.WriteLine();
        Console.WriteLine("After the reversing your number {0} looks like that: {1}", number, reversed);
        Console.WriteLine();
    }

    private static double GetReversedNumber(double number)
    {
        string reversedNumberAsString = new string(number.ToString().Reverse().ToArray());
        double reversedNumber = double.Parse(reversedNumberAsString);

        return reversedNumber;
    }
}