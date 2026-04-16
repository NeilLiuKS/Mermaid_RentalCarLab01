using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarSystem.Domain;

namespace RentalCarSystem.Tests;

/// <summary>
/// User 領域物件的 TDD 紅燈測試
/// 測試使用者註冊與租車功能
/// </summary>
[TestClass]
public class UserTests
{
    [TestMethod]
    public void RegisterAccount_WithValidInfo_ShouldReturnTrue()
    {
        // Arrange
        var user = new User();
        string userName = "John Doe";
        string email = "john@example.com";
        bool expected = true;

        // Act
        bool actual = user.RegisterAccount(userName, email);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RegisterAccount_ShouldSetUserId()
    {
        // Arrange
        var user = new User();
        string userName = "John Doe";
        string email = "john@example.com";
        bool expected = true;

        // Act
        user.RegisterAccount(userName, email);
        bool actual = !string.IsNullOrEmpty(user.UserId);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToRentalCar_WithRegisteredUser_ShouldReturnRentalRecord()
    {
        // Arrange
        var user = new User();
        user.RegisterAccount("John Doe", "john@example.com");
        string expected = "Rental";

        // Act
        var rentalResult = user.ToRentalCar();
        string actual = rentalResult?.GetType().Name.Contains("Rental") == true ? "Rental" : "None";

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void ToRentalCar_WithoutRegistration_ShouldReturnNull()
    {
        // Arrange
        var user = new User();
        object? expected = null;

        // Act
        var actual = user.ToRentalCar();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
