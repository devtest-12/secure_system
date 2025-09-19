using Scoops2GoAPI.Models;
using System.Security.Cryptography;
using System.Text;

namespace Scoops2GoAPI.Services;

public class AuthService
{
    private List<User> _users = new();

    public User? Authenticate(string username, string password)
    {
        var user = _users.FirstOrDefault(u => u.Username == username);
        if (user == null) return null;

        var hash = HashPassword(password);
        return user.PasswordHash == hash ? user : null;
    }

    public void Register(string username, string password)
    {
        var hash = HashPassword(password);
        _users.Add(new User { Id = _users.Count+1, Username = username, PasswordHash = hash });
    }

    private string HashPassword(string password)
    {
        using var sha = SHA256.Create();
        return Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }
}

