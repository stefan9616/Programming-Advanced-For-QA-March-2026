using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();

        string result = Orders.Order(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 1.50 2", "banana 1.25 3", "apple 1.99 1", "orange 0.99 2" };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "grapes 3.123 5", "banana 5.257 3", "cocomelon 4.369 3" };
        string expected = "grapes -> 15.62" + Environment.NewLine +
                          "banana -> 15.77" + Environment.NewLine +
                          "cocomelon -> 13.11";

        // Act
        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        string[] input = new string[] { "grapes 3 1.5", "banana 5 3.2", "cocomelon 4 2.2" };
        string expected = "grapes -> 4.50" + Environment.NewLine +
                          "banana -> 16.00" + Environment.NewLine +
                          "cocomelon -> 8.80";

        // Act
        string result = Orders.Order(input);

        Assert.That(result, Is.EqualTo(expected));
    }
}
