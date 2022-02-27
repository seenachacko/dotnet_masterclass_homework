string input = "world";
string reversed = ReverseString(input); 
Console.WriteLine($"Reversed input value: {reversed}");

string ReverseString(string input)
{
    char[] myArr = input.ToCharArray();
    Array.Reverse(myArr);
    return new string(myArr);
}