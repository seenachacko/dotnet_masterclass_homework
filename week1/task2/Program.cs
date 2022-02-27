string input = "Intellectualization";
int vowelCount = GetVowelCount(input);
Console.WriteLine($"Number of vowels: {vowelCount}");

int GetVowelCount(string input)
{
    int count = 0;
    foreach (char letter in input)
    {
     if(letter == 'a' ||  letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U') 
     {
        count ++;
     }
    }

    return count;

}