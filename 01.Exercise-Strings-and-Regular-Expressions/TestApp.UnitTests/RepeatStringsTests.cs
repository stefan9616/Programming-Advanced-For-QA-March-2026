using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = new string[] { };

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        string[] input = new string[] { "abc" };

        string result = RepeatStrings.Repeat(input);

        Assert.That(result, Is.EqualTo("abcabcabc"));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        string[] input = new string[] { "ad", "as" };

        string result = RepeatStrings.Repeat(input);

        Assert.That(result, Is.EqualTo("adadasas"));
    }
}
