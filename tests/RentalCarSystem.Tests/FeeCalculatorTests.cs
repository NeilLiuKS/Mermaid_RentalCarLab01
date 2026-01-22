using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarSystem.Domain;

namespace RentalCarSystem.Tests;

/// <summary>
/// FeeCalculator 領域物件的 TDD 紅燈測試
/// 測試租金計算功能
/// 租金費用：Car 1000元/天、SUV 1500元/天、Truck 2000元/天、SportsCar 3000元/天、ElectricCar 2800元/天
/// </summary>
[TestClass]
public class FeeCalculatorTests
{
    [TestMethod]
    public void CalculateFee_Car_ThreeDays_ShouldReturn3000()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 1000m; // Car
        int days = 3;
        decimal expected = 3000m;

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_SUV_FiveDays_ShouldReturn7500()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 1500m; // SUV
        int days = 5;
        decimal expected = 7500m;

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_Truck_TwoDays_ShouldReturn4000()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 2000m; // Truck
        int days = 2;
        decimal expected = 4000m;

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_SportsCar_SevenDays_ShouldReturn21000()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 3000m; // SportsCar
        int days = 7;
        decimal expected = 21000m;

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_ElectricCar_FourDays_ShouldReturn11200()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 2800m; // ElectricCar
        int days = 4;
        decimal expected = 11200m;

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_ShouldSetTotalFee()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 1500m;
        int days = 3;
        decimal expected = 4500m;

        // Act
        feeCalculator.CalculateFee(dailyRate, days);
        decimal actual = feeCalculator.TotalFee;

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_WithDiscount_ShouldApplyDiscount()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 1000m;
        int days = 10;
        decimal discountRate = 0.1m; // 10% discount
        decimal expected = 9000m; // 10000 - 10%

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days, discountRate);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void CalculateFee_ZeroDays_ShouldReturnZero()
    {
        // Arrange
        var feeCalculator = new FeeCalculator();
        decimal dailyRate = 1000m;
        int days = 0;
        decimal expected = 0m;

        // Act
        decimal actual = feeCalculator.CalculateFee(dailyRate, days);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
