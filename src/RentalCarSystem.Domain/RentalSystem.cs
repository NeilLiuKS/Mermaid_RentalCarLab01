namespace RentalCarSystem.Domain;

/// <summary>
/// 租車系統領域物件
/// </summary>
public class RentalSystem
{
    public string RentalId { get; private set; } = string.Empty;
    public DateTime RentalDate { get; private set; }
    public string SelectedCarType { get; private set; } = string.Empty;
    public int RentalDays { get; private set; }

    /// <summary>
    /// 租用車輛
    /// </summary>
    public bool ToRentalCar(string carType, DateTime startTime, DateTime endTime)
    {
        // TODO: 實作租車邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }

    /// <summary>
    /// 選擇車型
    /// </summary>
    public void SelectCarType(string carType)
    {
        // TODO: 實作選擇車型邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }

    /// <summary>
    /// 選擇租用時間區間
    /// </summary>
    public void SelectRentalTime(DateTime startTime, DateTime endTime)
    {
        // TODO: 實作選擇租用時間邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }

    /// <summary>
    /// 計算租金
    /// </summary>
    public decimal CalculateFee()
    {
        // TODO: 實作租金計算邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }
}
