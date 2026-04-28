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
        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(email))
        {
            return false;
        }

        if (!email.Contains('@'))
            return false;

        AccountId = Guid.NewGuid().ToString("N");
        Username = username.Trim();
        Password = password;
        RegisteredDate = DateTime.Now;
        IsLoggedIn = false;

        return true;
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
