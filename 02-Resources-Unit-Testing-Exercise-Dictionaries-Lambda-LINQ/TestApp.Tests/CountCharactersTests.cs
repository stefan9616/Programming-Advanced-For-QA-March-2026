using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string> {""};

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        List<string> input = new List<string> { "e" };
        string expected = "e -> 1";

        // Act
        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        List<string> input = new List<string> { "es", "mit", "toe" };
        string expected = "e -> 2" + Environment.NewLine +
                          "s -> 1" + Environment.NewLine +
                          "m -> 1" + Environment.NewLine +
                          "i -> 1" + Environment.NewLine +
                          "t -> 2" + Environment.NewLine +
                          "o -> 1";
                    
        // Act
        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        List<string> input = new List<string> { "e#", "mm?", "t@" };
        string expected = "e -> 1" + Environment.NewLine +
                          "# -> 1" + Environment.NewLine +
                          "m -> 2" + Environment.NewLine +
                          "? -> 1" + Environment.NewLine +
                          "t -> 1" + Environment.NewLine +
                          "@ -> 1";

        // Act
        string result = CountCharacters.Count(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
