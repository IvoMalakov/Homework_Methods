using  System;

public class FirstLargerThanNeighbours
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

        int index = GetIndexofFirstElementLargerThanNeighbours(numbers);

        Console.WriteLine("The index of the first element in your sequence larger than its neghbours is: {0}", index);
    }

    private static int GetIndexofFirstElementLargerThanNeighbours(int[] numbers)
    {
        int index = -1;
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    index = i;
                    break;
                }
            }

            else if (i == n - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    index = i;
                    break;
                }
            }

            else if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                index = i;
                break;
            }
        }

        return index;
    }
}