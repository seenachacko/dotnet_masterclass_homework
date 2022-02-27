int[] input = new[] {1, 2, 5, 7, 2, 3, 5, 7, 9 };
if ((input.Length % 2) != 0)
{
    Console.WriteLine("array lenth should be even");
}
else
{
    int[][] splitArray = Split(input);
    int[] result = AddArray(splitArray);
    WriteResult(result);
}

int[][] Split(int[] input)
{
    int mid = input.Length / 2;
    int[] first = input.Take(mid).ToArray();
    int[] second = input.Skip(mid).ToArray();
    return new int[][] { first, second };
}
int[] AddArray(int[][] splitArray)
{
    int len = splitArray[0].Length;
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = splitArray[0][i] + splitArray[1][i];
    }
    return result;
}
void WriteResult(int[] result)
{
    Console.WriteLine(String.Join(",", result));
}