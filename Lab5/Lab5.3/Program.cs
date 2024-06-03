using System;
using System.Collections.Generic;
using System.Linq;

public class UserAccount
{
    public string Name;
    public int Rank;
    public float WinRate;
    public string Type;
    public int Skin;

    public UserAccount(string _name, int _rank, float _winRate, string _type, int _skin)
    {
        Name = _name;
        Rank = _rank;
        WinRate = _winRate;
        Type = _type;
        Skin = _skin;
    }

    public static void Main()
    {
        List<UserAccount> userAccounts = new List<UserAccount>();

        userAccounts.Add(new UserAccount("Alice", 10, 60.5f, "A", 50));
        userAccounts.Add(new UserAccount("Bob", 5, 70f, "B", 10));
        userAccounts.Add(new UserAccount("Charlie", 15, 45.5f, "A", 25));
        userAccounts.Add(new UserAccount("David", 1, 90f, "C", 2));
        userAccounts.Add(new UserAccount("Eve", 3, 60.5f, "B", 10));
        userAccounts.Add(new UserAccount("Frank", 2, 55.5f, "C", 250));

        var typeCounts = userAccounts.ToLookup(u => u.Type, u => u);

        foreach (var group in typeCounts)
        {
            Console.WriteLine($"Type: {group.Key}, Count: {group.Count()}");
            foreach (var user in group)
            {
                Console.WriteLine($"Name: {user.Name}, Rank: {user.Rank}, WinRate: {user.WinRate}, Skin: {user.Skin}");
            }
            Console.WriteLine();
        }
    }
}