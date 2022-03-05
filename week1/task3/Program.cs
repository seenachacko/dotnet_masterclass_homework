int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int[] result = GetResult(arr);
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");

int[] GetResult(int[] input)
{
    int multiplicationResult = 1;
    int sumofNegativeNumbers = 0;

    foreach (int number in input)
    {
        if (number > 0)
        {
            multiplicationResult = multiplicationResult * number;
        }
        else
        {
            sumofNegativeNumbers = sumofNegativeNumbers + number;
        }
    }
    return new[] { sumofNegativeNumbers, multiplicationResult };
}