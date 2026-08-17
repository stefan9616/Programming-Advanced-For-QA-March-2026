using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Miner.Mine(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "GOLD 2", "Silver 10", "Gold 4", "goLD 2", "silver 15", "SiLVeR 5" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        string[] input = new string[] { "gold 2", "silver 10", "gold 4", "gold 2","wood 50", "iron 100", "wood 10", "silver 15", "silver 5" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30{Environment.NewLine}wood -> 60{Environment.NewLine}iron -> 100"));
    }
}
