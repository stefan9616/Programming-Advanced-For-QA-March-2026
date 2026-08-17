using NUnit.Framework;

using System;
using System.Text;
using TestApp.Store;

namespace TestApp.UnitTests;

public class ShopTests
{
    private Shop _shop;
    
    // TODO: write setup method
    [SetUp]
    public void SetUp()
    {
        _shop = new Shop();
    }



    // TODO: finish test
    [Test]
    public void Test_AddAndGetBoxes_ReturnsSortedBoxes()
    {
        // Arrange
        string[] products = new string[] { "12345 SmartWatches 7 100", "54321 Perfumes 4 50", "98765 Laptops 3 600"};

        StringBuilder expected = new StringBuilder();
        expected.AppendLine("98765");
        expected.AppendLine("-- Laptops - $600.00: 3");
        expected.AppendLine("-- $1800.00");
        expected.AppendLine("12345");
        expected.AppendLine("-- SmartWatches - $100.00: 7");
        expected.AppendLine("-- $700.00");
        expected.AppendLine("54321");
        expected.AppendLine("-- Perfumes - $50.00: 4");
        expected.AppendLine("-- $200.00");

        // Act
        string result = this._shop.AddAndGetBoxes(products);

        // Assert
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));
    }

    [Test]
    public void Test_AddAndGetBoxes_ReturnsEmptyString_WhenNoProductsGiven()
    {
        string[] products = Array.Empty<string>();
        string result = this._shop.AddAndGetBoxes(products);
        Assert.That(result, Is.Empty);

    }
}
