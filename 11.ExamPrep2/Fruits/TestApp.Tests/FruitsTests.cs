using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        Dictionary<string, int> fruits = new()
        {
            {"Banana", 4 },
            {"Apple", 2 }
        };

        int expected = 4;

        string searchFruit = "Banana";

        int result = Fruits.GetFruitQuantity(fruits, searchFruit);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        Dictionary<string, int> fruits = new() 
        {
            {"Banana", 4 },
            {"Apple", 2 }
        };

        int expected = 0;

        string searchFruit = "Mango";

        int result = Fruits.GetFruitQuantity(fruits, searchFruit);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        Dictionary<string, int> fruits = new()
        {
            
        };

        int expected = 0;

        string searchFruit = "Mango";

        int result = Fruits.GetFruitQuantity(fruits, searchFruit);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        Dictionary<string, int> fruits = null;
     

        int expected = 0;

        string searchFruit = "Mango";

        int result = Fruits.GetFruitQuantity(fruits, searchFruit);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Dictionary<string, int> fruits = new()
        {
            {"Banana", 3},
            { "Apple", 4}
        };


        int expected = 0;

        string searchFruit = null;

        int result = Fruits.GetFruitQuantity(fruits, searchFruit);

        Assert.That(result, Is.EqualTo(expected));
    }
}
