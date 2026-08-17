using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class MergeDictionariesTests
{
    [Test]
    public void Test_Merge_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        Dictionary<string, int> result = MergeDictionaries.Merge(dict1, dict2);

        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Merge_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsNonEmptyDictionary()
    {
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, int> dict2 = new()
        {
            {"Todor", 40 },
            {"Georgi", 35 },
            {"Anna", 23 }
        };

        Dictionary<string, int> expected = new()

        {
            {"Todor", 40 },
            {"Georgi", 35 },
            {"Anna", 23 }
        };

        Dictionary<string, int> result = MergeDictionaries.Merge(dict1, dict2);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_Merge_TwoNonEmptyDictionaries_ReturnsMergedDictionary()
    {
        Dictionary<string, int> dict1 = new()
        {
            {"Mitko", 29 },
            {"Aneliq", 20 },
            {"Sofiq", 30 },
            {"Ivan", 14 }

        };
        Dictionary<string, int> dict2 = new()
        {
            {"Todor", 40 },
            {"Georgi", 35 },
            {"Anna", 23 }
        };

        Dictionary<string, int> expected = new()

        {
            {"Mitko", 29 },
            {"Aneliq", 20 },
            {"Sofiq", 30 },
            {"Ivan", 14 },
            {"Todor", 40 },
            {"Georgi", 35 },
            {"Anna", 23 }
        };

        Dictionary<string, int> result = MergeDictionaries.Merge(dict1, dict2);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Merge_OverlappingKeys_ReturnsMergedDictionaryWithValuesFromDict2()
    {
        Dictionary<string, int> dict1 = new()
        {
            {"Mitko", 29 },
            {"Aneliq", 20 },
            {"Sofiq", 30 },
            {"Ivan", 14 }

        };
        Dictionary<string, int> dict2 = new()
        {
            {"Mitko", 40 },
            {"Aneliq", 35 },
            {"Sofiq", 23 },
            {"Ivan", 20 }


        };

        Dictionary<string, int> expected = new()

        {
            {"Mitko", 40 },
            {"Aneliq", 35 },
            {"Sofiq", 23 },
            {"Ivan", 20 }
        };

        Dictionary<string, int> result = MergeDictionaries.Merge(dict1, dict2);

        Assert.That(result, Is.EqualTo(expected));
    }
}
