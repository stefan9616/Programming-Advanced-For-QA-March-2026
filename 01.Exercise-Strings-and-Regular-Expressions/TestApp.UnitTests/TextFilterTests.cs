using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        string[] bannedWords = new string[] {"dog", "cat"};
        string text = "My daughter is so beautiful";

        string result = TextFilter.Filter(bannedWords, text);

        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        string[] bannedWords = new string[] {"daughter" };
        string text = "My daughter is so beautiful";

        string expected = "My ******** is so beautiful";

        string result = TextFilter.Filter(bannedWords, text);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        string[] bannedWords = new string[] { };
        string text = "My daughter is so beautiful";

        string result = TextFilter.Filter(bannedWords, text);

        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string[] bannedWords = new string[] {  "so"  };
        string text = "My daughter is so beautiful";
        string expected = "My daughter is ** beautiful";

        string result = TextFilter.Filter(bannedWords, text);

        Assert.That(result, Is.EqualTo(expected));
    }
}
