
using System.Text.RegularExpressions;

Console.Write("Enter a sentence: ");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Input is empty.");
    return;
}

var words = Regex.Split(input.ToLower(), @"\W+").Where(w => !string.IsNullOrEmpty(w)).ToList();

Console.WriteLine($"Characters (with spaces): {input.Length}");
Console.WriteLine($"Characters (no spaces): {input.Replace(" ", "").Length}");
Console.WriteLine($"Word count: {words.Count}");

var mostCommonWord = words
    .GroupBy(w => w)
    .OrderByDescending(g => g.Count())
    .FirstOrDefault()?.Key;

Console.WriteLine($"Most common word: {mostCommonWord}");

Console.WriteLine($"Title Case: {System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input)}");


Console.WriteLine($"Vowel count: {CountVowels(input)}");

static int CountVowels(string input)
{
    return input.Count(c => "aeiouAEIOU".Contains(c));
}