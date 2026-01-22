using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarSystem.Domain;

namespace RentalCarSystem.Tests;

/// <summary>
/// RentalTime 領域物件的 TDD 紅燈測試
/// 測試租用時間區間選擇功能
/// </summary>
[TestClass]
public class RentalTimeTests
{
    [TestMethod]
    public void SelectRentalTime_WithValidDates_ShouldReturnTrue()
    {
        // Arrange
        var rentalTime = new RentalTime();
        DateTime startTime = DateTime.Today;
        DateTime endTime = DateTime.Today.AddDays(3);
        bool expected = true;

        // Act
        bool actual = rentalTime.SelectRentalTime(startTime, endTime);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectRentalTime_ShouldCalculateDuration()
    {
        // Arrange
        var rentalTime = new RentalTime();
        DateTime startTime = DateTime.Today;
        DateTime endTime = DateTime.Today.AddDays(5);
        int expected = 5;

        // Act
        rentalTime.SelectRentalTime(startTime, endTime);
        int actual = rentalTime.Duration;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectRentalTime_OneDayRental_ShouldReturnDurationOne()
    {
        // Arrange
        var rentalTime = new RentalTime();
        DateTime startTime = DateTime.Today;
        DateTime endTime = DateTime.Today.AddDays(1);
        int expected = 1;

        // Act
        rentalTime.SelectRentalTime(startTime, endTime);
        int actual = rentalTime.Duration;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectRentalTime_EndDateBeforeStartDate_ShouldReturnFalse()
    {
        // Arrange
        var rentalTime = new RentalTime();
        DateTime startTime = DateTime.Today.AddDays(5);
        DateTime endTime = DateTime.Today;
        bool expected = false;

        // Act
        bool actual = rentalTime.SelectRentalTime(startTime, endTime);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectRentalTime_ShouldSetStartTime()
    {
        // Arrange
        var rentalTime = new RentalTime();
        DateTime expected = DateTime.Today;
        DateTime endTime = DateTime.Today.AddDays(3);

        // Act
        rentalTime.SelectRentalTime(expected, endTime);
        DateTime actual = rentalTime.StartTime;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectRentalTime_ShouldSetEndTime()
    {
        // Arrange
        var rentalTime = new RentalTime();
        DateTime startTime = DateTime.Today;
        DateTime expected = DateTime.Today.AddDays(3);

        // Act
        rentalTime.SelectRentalTime(startTime, expected);
        DateTime actual = rentalTime.EndTime;

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
