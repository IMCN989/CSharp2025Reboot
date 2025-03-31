using SkillDrillsStringsRedoConsoleApp;

namespace _01_Strings_Redo.Tests;

public class TextStatsTests
{
    [Fact]
    public void GetWordCount_ShouldReturnCorrectCount()
    {
        string input = "This is a test";
        int result = TextStats.GetWordCount(input);
        Assert.Equal(4, result);
    }

    [Fact]
    public void GetMostCommonWord_ShouldReturnCorrectWord()
    {
        string input = "cat dog dog bird cat dog";
        string result = TextStats.GetMostCommonWord(input);
        Assert.Equal("dog", result);
    }


    //// Copy the methods from Program.cs here temporarily or make them public in Program.cs and reference the class.
    //private int GetWordCount(string input) => input.Split(' ').Length;

    //private string GetMostCommonWord(string sentence)
    //{
    //    string[] words = sentence.Split(' ');
    //    string commonWord = words.GroupBy(x => x)
    //        .OrderByDescending(x => x.Count())
    //        .First()
    //        .Key;
    //    return commonWord;
    //}


}