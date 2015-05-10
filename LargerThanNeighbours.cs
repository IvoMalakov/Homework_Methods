using  System;

public class LargerThanNeighbours
{
    public static void Main()
    {
        Console.WriteLine("Enter a sequence of integer numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        int n = input.Length;
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < n; i++)
        {
            bool isLarger = IsLargerThanNeighbours(numbers, i);
            Console.WriteLine("Is number {0} larger than its two neighbours?: {1}", numbers[i], isLarger);
        }
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool isLarger = false;

        if (i == 0)
        {
            if (numbers[i] > numbers[i + 1])
            {
                isLarger = true;
            }
        }

        else if (i == numbers.Length - 1)
        {
            if (numbers[i] > numbers[i - 1])
            {
                isLarger = true;
            }
        }

        else if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
        {
            isLarger = true;
        }

        return isLarger;
    }
}