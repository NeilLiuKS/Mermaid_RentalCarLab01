namespace RentalCarSystem.Domain;

/// <summary>
/// 租金計算器領域物件
/// </summary>
public class FeeCalculator
{
    public decimal TotalFee { get; private set; }
    public decimal Discount { get; private set; }

    /// <summary>
    /// 計算租金
    /// </summary>
    public decimal CalculateFee(decimal dailyRate, int days)
    {
        // TODO: 實作租金計算邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }

    /// <summary>
    /// 計算租金（含折扣）
    /// </summary>
    public decimal CalculateFee(decimal dailyRate, int days, decimal discountRate)
    {
        // TODO: 實作租金計算邏輯（含折扣）- TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }
}
