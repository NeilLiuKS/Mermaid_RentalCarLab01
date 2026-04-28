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
        if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(email))
            return false;

        if (!email.Contains('@'))
            return false;

        UserId = Guid.NewGuid().ToString("N");
        UserName = userName.Trim();
        Email = email.Trim();

        return true;
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
