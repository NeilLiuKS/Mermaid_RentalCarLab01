---
description: "實作租車用戶登入邏輯。Use when: 需要在 Account 領域物件中實作 Login 方法，驗證租車用戶已註冊帳號後方可登入系統。"
agent: "agent"
---

# 租車用戶登入邏輯實作

## 業務規則

租車用戶在線上預約租車之前，必須先完成以下流程：
1. 註冊帳戶資料（已有 `RegisterAccount()` 方法）
2. **以註冊帳號進行登入**（本 prompt 聚焦此步驟）
3. 登入成功後才可預先租用車輛

## 實作需求

請在 `Account` 領域物件中實作登入方法，遵循以下規範：

### Login 方法規格
- 方法簽章：`public bool Login(string username, string password)`
- 登入成功條件：`username` 與 `password` 需與已註冊帳號的資料一致
- 登入失敗條件：
  - 帳號尚未註冊（無 `AccountId`）
  - 使用者名稱或密碼不符
  - 使用者名稱或密碼為空值
- 登入成功後應設定 `IsLoggedIn` 狀態為 `true`

### 程式碼風格
- 遵循專案現有的 C# 領域物件設計模式
- 參考 [Account.cs](../../src/RentalCarSystem.Domain/Account.cs) 的現有實作風格
- 參考 [AccountTests.cs](../../tests/RentalCarSystem.Tests/AccountTests.cs) 的測試寫法
- 使用 `private set` 保護屬性封裝

### 輸出內容
1. 在 `Account.cs` 中新增 `IsLoggedIn` 屬性與 `Login()` 方法
2. 在 `AccountTests.cs` 中新增對應的單元測試案例，包含：
   - 已註冊帳號以正確帳密登入應回傳 `true`
   - 未註冊帳號嘗試登入應回傳 `false`
   - 帳號或密碼錯誤應回傳 `false`
   - 帳號或密碼為空值應回傳 `false`
   - 登入成功後 `IsLoggedIn` 應為 `true`
