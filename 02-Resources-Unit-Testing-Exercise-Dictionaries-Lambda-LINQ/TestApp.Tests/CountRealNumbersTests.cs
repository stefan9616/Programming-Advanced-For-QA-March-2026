using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1 };
        string expected = "1 -> 1";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 45, 13, 32, 45, 1 };
        string expected = "1 -> 2" + Environment.NewLine +
                          "13 -> 1" + Environment.NewLine +
                          "32 -> 1" + Environment.NewLine +
                          "45 -> 2";

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        int[] input = new int[] { -7, -45, -13, -15, -13 };
        string expected =
                          "-45 -> 1" + Environment.NewLine +
                          "-15 -> 1" + Environment.NewLine +
                          "-13 -> 2" + Environment.NewLine +
                          "-7 -> 1";
                          

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
         int[] input = new int[] { 0, 0 };

        string expected = "0 -> 2" ;

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
