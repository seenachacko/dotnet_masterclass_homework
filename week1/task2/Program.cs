string input = "Intellectualization";
int vowelCount = GetVowelCount(input);
Console.WriteLine($"Number of vowels: {vowelCount}");

int GetVowelCount(string input)
{
    int count = 0;
    string word = input.ToLower();
    foreach (char letter in word)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            count++;
        }
    }

    return count;

}