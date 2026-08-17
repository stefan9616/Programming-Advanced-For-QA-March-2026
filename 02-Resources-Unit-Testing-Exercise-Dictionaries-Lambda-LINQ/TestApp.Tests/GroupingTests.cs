using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 14, 5, 17, 3, 18, 6, 2 };
        string expected = "Even numbers: 14, 18, 6, 2" + Environment.NewLine +
                          "Odd numbers: 5, 17, 3";

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 12, 6, 18, 4, 8 };
        string expected = "Even numbers: 12, 6, 18, 4, 8"; 

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        List<int> input = new List<int> { 11, 5, 17, 3, 7 };
        string expected = "Odd numbers: 11, 5, 17, 3, 7";

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { -14, -5, -17, -3, -18, -6, -2 };
        string expected = "Even numbers: -14, -18, -6, -2" + Environment.NewLine +
                          "Odd numbers: -5, -17, -3";

        // Act
        string result = Grouping.GroupNumbers(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
