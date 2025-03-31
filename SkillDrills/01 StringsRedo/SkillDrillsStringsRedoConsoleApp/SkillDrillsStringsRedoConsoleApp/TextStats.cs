using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillDrillsStringsRedoConsoleApp;

public class TextStats
{
    public static int GetWordCount(string input) { return input.Split(' ').Length; }

    public static string WordToUpperCase(string sentence)
    {
        string[] words = sentence.Split(' ');
        string result = "";
        foreach (var word in words)
        {
            result += word.ToUpper() + " ";
        }
        return result;
    }

    public static string GetMostCommonWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string commonWord = words.GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .First()
            .Key;
        return commonWord;
    }

    public static int CountCharsUsingLinqCount(string sentence, char toFind)
    {
        return sentence.Count(t => t == toFind);
    }

    public static int CountCharsUsingLinqCount2(string sentence)
    {
        return sentence.Count();
    }
}
