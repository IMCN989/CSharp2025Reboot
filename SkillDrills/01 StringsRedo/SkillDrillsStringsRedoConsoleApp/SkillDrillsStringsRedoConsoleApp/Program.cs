using SkillDrillsStringsRedoConsoleApp;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;


//Using Linq
Console.Write("Enter a sentence: ");
string sentence = Console.ReadLine();
if (string.IsNullOrWhiteSpace(sentence))
{
    Console.WriteLine("Please enter a valid sentence.");
    return;
}

Console.WriteLine($"Using Linq find Number of Characters with Spaces:{TextStats.CountCharsUsingLinqCount(sentence, ' ')}");
Console.WriteLine($"Using Linq find Number of Characters without Spaces:{TextStats.CountCharsUsingLinqCount2(sentence)}");
Console.WriteLine($"The word count is:{TextStats.GetWordCount(sentence)}");
Console.WriteLine($"The word as UpperCase:{TextStats.WordToUpperCase(sentence)}");
Console.WriteLine($"The wmost common word is:{TextStats.GetMostCommonWord(sentence)}");






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

