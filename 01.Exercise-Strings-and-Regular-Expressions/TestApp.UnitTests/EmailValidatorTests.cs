using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("domain@abv.bg")]
    [TestCase("yourname@yahoo.bg")]
    [TestCase("milen2@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("mitko.abv.bg")]
    [TestCase("domain@abg")]
    [TestCase("@diman.bg")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
