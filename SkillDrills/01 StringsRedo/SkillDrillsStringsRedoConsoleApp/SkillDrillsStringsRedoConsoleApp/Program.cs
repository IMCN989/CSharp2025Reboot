using System.Linq;
using static System.Net.Mime.MediaTypeNames;


//Using Linq
Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();
int countWithSpaces = CountCharsUsingLinqCount(sentence, ' ');
int countWithoutSpaces = CountCharsUsingLinqCount2(sentence);
Console.WriteLine($"Using Linq find Number of Characters with Spaces:{countWithSpaces}");
Console.WriteLine($"Using Linq find Number of Characters without Spaces:{countWithoutSpaces}");
Console.WriteLine($"The word count is:{GetWordCount(sentence)}");
Console.WriteLine($"The word as UpperCase:{WordToUpperCase(sentence)}");
Console.WriteLine($"The wmost common word is:{GetMostCommonWord(sentence)}");

//Methods

int CountCharsUsingLinqCount(string sentence, char toFind)
{
    return sentence.Count(t => t == toFind);
}

int CountCharsUsingLinqCount2(string sentence)
{
    return sentence.Count();
}

int GetWordCount(string input) { return input.Split(' ').Length; }


string WordToUpperCase (string sentence)
{
    string[] words = sentence.Split(' ');
    string result = "";
    foreach (var word in words)
    {
        result += word.ToUpper() + " ";
    }
    return result;
}
string GetMostCommonWord(string sentence)
{
    string[] words = sentence.Split(' ');
    string commonWord = words.GroupBy(x => x)
        .OrderByDescending(x => x.Count())
        .First()
        .Key;
    return commonWord;
}  

//Using For Each Loop
//Console.Write("Enter a sentence: ");
//sentence = Console.ReadLine();

//int count = 0;
//count = CountCharsUsingForeach(sentence, ' ');
//Console.WriteLine($"Using ForEach Loop Number of Characters with Spaces: {count}");
//int CountCharsUsingForeach(string source, char toFind)
//{
//    int count = 0;

//    foreach (var ch in source)
//    {
//        if (ch == toFind)
//            count++;
//    }

//    return count;
//}

