namespace RentalCarSystem.Domain;

/// <summary>
/// 帳號領域物件
/// </summary>
public class Account
{
    public string AccountId { get; private set; } = string.Empty;
    public string Username { get; private set; } = string.Empty;
    public string Password { get; private set; } = string.Empty;
    public DateTime RegisteredDate { get; private set; }
    public bool IsLoggedIn { get; private set; }

    /// <summary>
    /// 註冊帳號
    /// </summary>
    public bool RegisterAccount(string username, string password, string email)
    {
        // TODO: 實作帳號註冊邏輯 - TDD 紅燈測試，尚未實作
        throw new NotImplementedException();
    }

    /// <summary>
    /// 登入帳號
    /// </summary>
    public bool Login(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            return false;

        if (string.IsNullOrEmpty(AccountId))
            return false;

        if (Username != username || Password != password)
            return false;

        IsLoggedIn = true;
        return true;
    }
}
