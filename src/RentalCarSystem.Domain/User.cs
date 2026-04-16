namespace RentalCarSystem.Domain;

/// <summary>
/// 使用者領域物件
/// </summary>
public class User
{
    public string UserId { get; private set; } = string.Empty;
    public string UserName { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;

    /// <summary>
    /// 註冊帳號
    /// </summary>
    public bool RegisterAccount(string userName, string email)
    {
        // TODO: 實作使用者註冊邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }

    /// <summary>
    /// 租用車輛
    /// </summary>
    public object? ToRentalCar()
    {
        // TODO: 實作租車邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }
}
