using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Coffee shop";
        string expected = "pohs eeffoC";
        // Act
        string result = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        string expected = "String cannot be null.";

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        decimal totalPrice = 400;
        decimal discount = 20;
        decimal expected = 320;

        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        Assert.That(result, Is.EqualTo(expected));

    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 400;
        decimal discount = -20;


        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int index = 2;
        int expected = 3;

        int result = _exceptions.IndexOutOfRangeGetElement(input, index);

        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int index = -1;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 8;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        bool input = true;
        string expected = "User logged in.";

        string result = _exceptions.InvalidOperationPerformSecureOperation(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        bool input = false;

        Assert.That(() => _exceptions.InvalidOperationPerformSecureOperation(input), Throws.InstanceOf<InvalidOperationException>());
        
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        string input = "3";
        int expected = 3;

        int result = _exceptions.FormatExceptionParseInt(input);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        string input = "test";

        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("Audi", 131);
        input.Add("BMW", 150);
        input.Add("Opel", 90);
        input.Add("Morcedes", 235);

        string key = "Audi";

        int expected = 131;

        int result = _exceptions.KeyNotFoundFindValueByKey(input, key);

        Assert.That(result, Is.EqualTo(expected));



    }

    [Test]

    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("Audi", 131);
        input.Add("BMW", 150);
        input.Add("Opel", 90);
        input.Add("Morcedes", 235);

        string key = "Lada";

        Assert.That(() => _exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        int a = 20;
        int b = 30;
        int expected = 50;

        int result = _exceptions.OverflowAddNumbers(a, b);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        int a = int.MaxValue;
        int b = 1;

        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        int a = int.MinValue;
        int b = -1;

        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        int a = 10;
        int b = 5;
        int expected = 2;

        int result = _exceptions.DivideByZeroDivideNumbers(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        int a = 5;
        int b = 0;

        Assert.That(() => _exceptions.DivideByZeroDivideNumbers(a, b), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        int[] input = { 1, 2, 3, 10, 20 };
        int index = 2;
        int expected = 36;

        int result = _exceptions.SumCollectionElements(input, index);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        int[] input = null;
        int index = 2;

        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        int[] input = { 1, 2, 3, 10, 20 };
        int index = 16;

        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.TypeOf<IndexOutOfRangeException>());

    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        Dictionary<string, string> input = new Dictionary<string, string>();
        input["one"] = "1";
        input["two"] = "2";
        input["three"] = "3";
        input["four"] = "4";
        input["five"] = "5";

        string key = "three";

        int expected = 3;

        int result = _exceptions.GetElementAsNumber(input, key);

        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        Dictionary<string, string> input = new Dictionary<string, string>();
        input["one"] = "1";
        input["two"] = "2";
        input["three"] = "3";
        input["four"] = "4";
        input["five"] = "5";

        string key = "nine";

        Assert.That(() => _exceptions.GetElementAsNumber(input, key), Throws.TypeOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> input = new Dictionary<string, string>();
        input["one"] = "1abc";
        input["two"] = "dve";
        input["three"] = "tri";
        

        string key = "two";

        Assert.That(() => _exceptions.GetElementAsNumber(input, key), Throws.TypeOf<FormatException>());
    }
}
