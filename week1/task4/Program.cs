int n = 6;
int nthNumber = Fibonacci(n); //TODO: Implement Fibonacci
Console.WriteLine($"Nth fibonacci number is {nthNumber}");

int Fibonacci(int input)
{
    int n1 = 0, n2 = 1, n3 = 0;
    for (int i = 2; i <= input; i++)
    {
        n3 = n1 + n2;
        n1 = n2;
        n2 = n3;
    }

    return n3;
}