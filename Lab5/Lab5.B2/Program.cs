using System;
using System.Collections.Generic;
using System.Linq;

public class UserAccountLab5
{
    public string Name;
    public int Rank;
    public float WinRate;
    public string Type;
    public int Skin;

    public UserAccountLab5(string _name, int _rank, float _winRate, string _type, int _skin)
    {
        Name = _name;
        Rank = _rank;
        WinRate = _winRate;
        Type = _type;
        Skin = _skin;
    }

    public static void Main()
    {
        List<UserAccountLab5> user_list = new List<UserAccountLab5>();

        user_list.Add(new UserAccountLab5("Sơn Tùng", 10, 55.5f, "Ca Nhạc", 50));
        user_list.Add(new UserAccountLab5("Đen Vâu", 5, 70f, "Ca Nhạc", 10));
        user_list.Add(new UserAccountLab5("Thuỳ Linh", 15, 45.5f, "Ca Nhạc", 25));
        user_list.Add(new UserAccountLab5("Độ Mixi", 1, 90f, "Live", 2));
        user_list.Add(new UserAccountLab5("Bà Tuyết Diamond", 3, 60.5f, "Ẩm Thực", 10));
        user_list.Add(new UserAccountLab5("Free Fire", 2, 55.5f, "Game", 250));
        user_list.Add(new UserAccountLab5("Liên Quân", 10, 65.5f, "Game", 2000));
        user_list.Add(new UserAccountLab5("FO4", 11, 85.5f, "Game", 500));
        user_list.Add(new UserAccountLab5("CSGO", 9, 45.5f, "Game", 300));
        user_list.Add(new UserAccountLab5("PUBG", 12, 85.5f, "Game", 400));

        // a/ Xuất ra màn hình danh sách các người có “WinRate” > 50 
        var highWinRateUsers = user_list.Where(u => u.WinRate > 50);
        Console.WriteLine("Danh sách người có WinRate > 50:");
        foreach (UserAccountLab5 user in highWinRateUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Win Rate: {user.WinRate}");
        }

        // b/ Tìm người có WinRate cao nhất 
        var highestWinRateUser = user_list.OrderByDescending(u => u.WinRate).First();
        Console.WriteLine($"Người có WinRate cao nhất: {highestWinRateUser.Name}, Win Rate: {highestWinRateUser.WinRate}");

        // c/ Cho biết danh sách UserAccount có bao nhiêu tài khoản? 
        int totalAccounts = user_list.Count;
        Console.WriteLine($"Tổng số tài khoản UserAccount: {totalAccounts}");
    }
}