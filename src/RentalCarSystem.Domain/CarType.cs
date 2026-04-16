namespace RentalCarSystem.Domain;

/// <summary>
/// 車型領域物件
/// 車型有：Car 1000元/天、SUV 1500元/天、Truck 2000元/天、SportsCar 3000元/天、ElectricCar 2800元/天
/// </summary>
public class CarType
{
    public string CarTypeId { get; private set; } = string.Empty;
    public string TypeName { get; private set; } = string.Empty;
    public decimal DailyRate { get; private set; }

    /// <summary>
    /// 選擇車型
    /// </summary>
    public void SelectCarType(string typeName)
    {
        // TODO: 實作選擇車型邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }
}
