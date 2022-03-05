string input = "world";
string reversed = ReverseString(input); 
Console.WriteLine($"Reversed input value: {reversed}");

string ReverseString(string input)
{
    char[] iputArray = input.ToCharArray();
    Array.Reverse(iputArray);
    return new string(iputArray);
}