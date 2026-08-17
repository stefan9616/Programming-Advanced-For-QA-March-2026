using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        string name = "Bread";
        double price = 2.50;
        int quantity = 10;
        string expected = "Product Inventory:" + Environment.NewLine + "Bread - Price: $2.50 - Quantity: 10";

        _inventory.AddProduct(name, price, quantity);

        Assert.That(_inventory.DisplayInventory(), Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        string expected = "Product Inventory:";

        string result = _inventory.DisplayInventory();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        _inventory.AddProduct("Bread", 2.50, 10);
        _inventory.AddProduct("Water", 1.50, 20);

        string expected = "Product Inventory:" 
            + Environment.NewLine 
            + "Bread - Price: $2.50 - Quantity: 10" 
            + Environment.NewLine 
            + "Water - Price: $1.50 - Quantity: 20";

        string result = _inventory.DisplayInventory();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        double expected = 0;

        double result = _inventory.CalculateTotalValue();

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        _inventory.AddProduct("Bread", 2.50, 10);
        _inventory.AddProduct("Water", 1.50, 20);

        double expected = 55;

        double result = _inventory.CalculateTotalValue();

        Assert.That(result, Is.EqualTo(expected));
    }
}
