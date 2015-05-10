using System;

public class NumberCalculations
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        int n = input.Length;
        double[] numbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }

        double minimum = CalculateMinimum(numbers);
        double maximum = CalculateMaximum(numbers);
        double average = CalculateAverage(numbers);
        double sum = CalculateSum(numbers);
        double product = CalculateProduct(numbers);

        Console.WriteLine("min = {0}, max = {1}, average = {2}, sum = {3} and product = {4} ", minimum, maximum,
            average, sum, product);
    }

    private static double CalculateMinimum(double[] numbers)
    {
        double minimum = double.MaxValue;
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
        }

        return minimum;
    }

    private static double CalculateMaximum(double[] numbers)
    {
        double maximum = double.MinValue;
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }

        return maximum;
    }

    private static double CalculateAverage(double[] numbers)
    {
        double average = 0.0;
        double sum = 0.0;
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        average = sum / n;
        return average;
    }

    private static double CalculateSum(double[] numbers)
    {
        double sum = 0.0;
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    private static double CalculateProduct(double[] numbers)
    {
        double product = 1.0;
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            product *= numbers[i];
        }

        return product;
    }
}