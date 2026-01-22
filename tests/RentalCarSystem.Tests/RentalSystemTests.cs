using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarSystem.Domain;

namespace RentalCarSystem.Tests;

/// <summary>
/// RentalSystem 烩办ン TDD 縊代刚
/// 代刚ó进ノ╰参俱
/// </summary>
[TestClass]
public class RentalSystemTests
{
    [TestMethod]
    public void ToRentalCar_WithValidCarTypeAndTime_ShouldReturnTrue()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        string carType = "Car";
        DateTime startTime = DateTime.Today;
        DateTime endTime = DateTime.Today.AddDays(3);
        bool expected = true;

        // Act
        bool actual = rentalSystem.ToRentalCar(carType, startTime, endTime);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_ShouldSetSelectedCarType()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        string expected = "SUV";

        // Act
        rentalSystem.SelectCarType(expected);
        string actual = rentalSystem.SelectedCarType;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectRentalTime_ShouldSetRentalPeriod()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        DateTime startTime = DateTime.Today;
        DateTime endTime = DateTime.Today.AddDays(5);
        int expected = 5;

        // Act
        rentalSystem.SelectRentalTime(startTime, endTime);
        int actual = rentalSystem.RentalDays;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_Car_ThreeDays_ShouldReturn3000()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        rentalSystem.SelectCarType("Car");
        rentalSystem.SelectRentalTime(DateTime.Today, DateTime.Today.AddDays(3));
        decimal expected = 3000m;

        // Act
        decimal actual = rentalSystem.CalculateFee();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_SUV_FiveDays_ShouldReturn7500()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        rentalSystem.SelectCarType("SUV");
        rentalSystem.SelectRentalTime(DateTime.Today, DateTime.Today.AddDays(5));
        decimal expected = 7500m;

        // Act
        decimal actual = rentalSystem.CalculateFee();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_SportsCar_SevenDays_ShouldReturn21000()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        rentalSystem.SelectCarType("SportsCar");
        rentalSystem.SelectRentalTime(DateTime.Today, DateTime.Today.AddDays(7));
        decimal expected = 21000m;

        // Act
        decimal actual = rentalSystem.CalculateFee();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_ElectricCar_FourDays_ShouldReturn11200()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        rentalSystem.SelectCarType("ElectricCar");
        rentalSystem.SelectRentalTime(DateTime.Today, DateTime.Today.AddDays(4));
        decimal expected = 11200m;

        // Act
        decimal actual = rentalSystem.CalculateFee();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RentalSystem_ShouldGenerateRentalId()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        rentalSystem.ToRentalCar("Car", DateTime.Today, DateTime.Today.AddDays(1));
        bool expected = true;

        // Act
        bool actual = !string.IsNullOrEmpty(rentalSystem.RentalId);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RentalSystem_ShouldSetRentalDate()
    {
        // Arrange
        var rentalSystem = new RentalSystem();
        rentalSystem.ToRentalCar("Car", DateTime.Today, DateTime.Today.AddDays(1));
        DateTime expected = DateTime.Today;

        // Act
        DateTime actual = rentalSystem.RentalDate.Date;

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
