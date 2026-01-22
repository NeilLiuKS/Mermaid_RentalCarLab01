using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarSystem.Domain;

namespace RentalCarSystem.Tests;

/// <summary>
/// Account 領域物件的 TDD 紅燈測試
/// 測試帳號註冊功能
/// </summary>
[TestClass]
public class AccountTests
{
    [TestMethod]
    public void RegisterAccount_WithValidUserInfo_ShouldCreateAccountSuccessfully()
    {
        // Arrange
        var account = new Account();
        string username = "testuser";
        string password = "password123";
        string email = "testuser@example.com";
        bool expected = true;

        // Act
        bool actual = account.RegisterAccount(username, password, email);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RegisterAccount_ShouldSetAccountId()
    {
        // Arrange
        var account = new Account();
        string username = "testuser";
        string password = "password123";
        string email = "testuser@example.com";
        bool expected = true;

        // Act
        account.RegisterAccount(username, password, email);
        bool actual = !string.IsNullOrEmpty(account.AccountId);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RegisterAccount_ShouldSetRegisteredDate()
    {
        // Arrange
        var account = new Account();
        string username = "testuser";
        string password = "password123";
        string email = "testuser@example.com";
        DateTime expected = DateTime.Today;

        // Act
        account.RegisterAccount(username, password, email);
        DateTime actual = account.RegisteredDate.Date;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RegisterAccount_WithEmptyUsername_ShouldReturnFalse()
    {
        // Arrange
        var account = new Account();
        string username = "";
        string password = "password123";
        string email = "testuser@example.com";
        bool expected = false;

        // Act
        bool actual = account.RegisterAccount(username, password, email);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
