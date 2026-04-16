using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarSystem.Domain;

namespace RentalCarSystem.Tests;

/// <summary>
/// CarType 領域物件的 TDD 紅燈測試
/// 測試車型選擇功能
/// 車型：Car 1000元/天、SUV 1500元/天、Truck 2000元/天、SportsCar 3000元/天、ElectricCar 2800元/天
/// </summary>
[TestClass]
public class CarTypeTests
{
    [TestMethod]
    public void SelectCarType_Car_ShouldReturnCorrectDailyRate()
    {
        // Arrange
        var carType = new CarType();
        decimal expected = 1000m;

        // Act
        carType.SelectCarType("Car");
        decimal actual = carType.DailyRate;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_SUV_ShouldReturnCorrectDailyRate()
    {
        // Arrange
        var carType = new CarType();
        decimal expected = 1500m;

        // Act
        carType.SelectCarType("SUV");
        decimal actual = carType.DailyRate;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_Truck_ShouldReturnCorrectDailyRate()
    {
        // Arrange
        var carType = new CarType();
        decimal expected = 2000m;

        // Act
        carType.SelectCarType("Truck");
        decimal actual = carType.DailyRate;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_SportsCar_ShouldReturnCorrectDailyRate()
    {
        // Arrange
        var carType = new CarType();
        decimal expected = 3000m;

        // Act
        carType.SelectCarType("SportsCar");
        decimal actual = carType.DailyRate;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_ElectricCar_ShouldReturnCorrectDailyRate()
    {
        // Arrange
        var carType = new CarType();
        decimal expected = 2800m;

        // Act
        carType.SelectCarType("ElectricCar");
        decimal actual = carType.DailyRate;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_ShouldSetTypeName()
    {
        // Arrange
        var carType = new CarType();
        string expected = "SUV";

        // Act
        carType.SelectCarType("SUV");
        string actual = carType.TypeName;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void SelectCarType_InvalidType_ShouldReturnZeroDailyRate()
    {
        // Arrange
        var carType = new CarType();
        decimal expected = 0m;

        // Act
        carType.SelectCarType("InvalidType");
        decimal actual = carType.DailyRate;

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
