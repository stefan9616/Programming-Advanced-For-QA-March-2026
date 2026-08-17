using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();

        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new();

        Dictionary<string, int> dict2 = new()
        {
            {"Gosho", 5},
            {"Marian", 6 }
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new()
        {
            { "Mitko", 1},
            { "Stefan", 4}
        };

        Dictionary<string, int> dict2 = new()
        {
            { "Gosho", 5},
            {"Ivan", 6 }
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        dict1.Add("Mitko", 1);
        dict1.Add("Pesho", 2);


        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        dict2.Add("Gosho", 5);
        dict2.Add("Pesho", 2);

        Dictionary<string, int> expected = new()
        {
            {"Pesho", 2 }
        };
            


        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new()
        { 
            { "Aleks", 4},
            { "Simo", 6}
        };

        Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            {"Aleks", 5 },
            { "Simo", 1}
        };

        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        Assert.That(result, Is.Empty);
    }
}


