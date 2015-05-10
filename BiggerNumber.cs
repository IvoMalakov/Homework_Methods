using System;

public class BiggerNumber
{
    public static void Main()
    {
        Console.Write("Enter your first integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second integer number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);

        Console.WriteLine();
        Console.WriteLine("The larges number of {0} and {1} is: {2}", firstNumber, secondNumber, max);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;

        if (firstNumber >= secondNumber)
        {
            max = firstNumber;
        }

        else
        {
            max = secondNumber;
        }

        return max;
    }
}