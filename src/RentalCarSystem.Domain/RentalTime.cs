namespace RentalCarSystem.Domain;

/// <summary>
/// 租用時間領域物件
/// </summary>
public class RentalTime
{
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public int Duration { get; private set; }

    /// <summary>
    /// 選擇租用時間區間
    /// </summary>
    public bool SelectRentalTime(DateTime startTime, DateTime endTime)
    {
        // TODO: 實作選擇租用時間邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }
}
