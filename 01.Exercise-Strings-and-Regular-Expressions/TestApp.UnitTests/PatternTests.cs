using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("Hello", 2, "hElLohElLo")]
    [TestCase("STEFAN", 5, "sTeFaNsTeFaNsTeFaNsTeFaNsTeFaN")]
    [TestCase("%IvanA@", 2, "%IvAnA@%IvAnA@")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("")]
    [TestCase(null)]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException(string input)
    {
        
        int repetition = 2;

        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetition));
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        string input = "Hello";
        int repetition = -2;

        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetition));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        string input = "Hello";
        int repetition = 0;

        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetition));
    }
}
