using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        string[] input = new string[] { "hello" ,"hello", "hi", "hi"};


        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        string[] input = new string[] { "hello", "hello", "name", "hi", "hi" };
        string expected = "name";


        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.EqualTo(expected));
      
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        string[] input = new string[] { "hello", "cat", "hello", "name", "hi", "hi", "car" };
        string expected = "cat name car";


        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        string[] input = new string[] { "hello", "cAt", "hello", "naME", "hi", "hi", "Car" };
        string expected = "cat name car";


        string result = OddOccurrences.FindOdd(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
