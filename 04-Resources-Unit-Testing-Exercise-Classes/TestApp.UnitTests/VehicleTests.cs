using NUnit.Framework;

using System;
using System.Text;
using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    // TODO: write the setup method
   private Vehicles _vehicles;

    [SetUp]
    public void SetUp()
    {
        _vehicles = new Vehicles();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] input = new string[] { "Car/Toyota/Auris/120", "Truck/Iveco/Daily/4230", "Truck/Volvo/Atros/5210", "Car/Audi/A4/131" };

        StringBuilder expected = new StringBuilder();
        expected.AppendLine("Cars:");
        expected.AppendLine("Audi: A4 - 131hp");
        expected.AppendLine("Toyota: Auris - 120hp");
        expected.AppendLine("Trucks:");
        expected.AppendLine("Iveco: Daily - 4230kg");
        expected.AppendLine("Volvo: Atros - 5210kg");

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        string[] input = Array.Empty<string>();
        StringBuilder expected = new StringBuilder();
        expected.AppendLine("Cars:");
        expected.AppendLine("Trucks:");

        string result = this._vehicles.AddAndGetCatalogue(input);
        Assert.That(result, Is.EqualTo(expected.ToString().Trim()));

    }
}
