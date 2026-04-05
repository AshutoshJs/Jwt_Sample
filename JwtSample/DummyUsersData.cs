namespace JwtSample
{
    public static class DummyUsersData
    {
        public static List<Users> GetAllUsers()
        {
            return new List<Users>()
    {
        new Users()
        {
            UserId = 1,
            Email = "test",
            Password = "test",
            Role = "Admin",
            Department = "IT"
        },
        new Users()
        {
            UserId = 1,
            Email = "admin@example.com",
            Password = "admin123",
            Role = "Admin",
            Department = "IT"
        },
        new Users()
        {
            UserId = 2,
            Email = "manager@example.com",
            Password = "manager123",
            Role = "Manager",
            Department = "HR"
        },
        new Users()
        {
            UserId = 3,
            Email = "user@example.com",
            Password = "user123",
            Role = "User",
            Department = "Sales"
        },
         new Users()
        {
            UserId = 4,
            Email = "it.manager@example.com",
            Password = "pass123",
            Role = "Manager",
            Department = "IT"
        },
        new Users()
        {
            UserId = 5,
            Email = "hr.admin@example.com",
            Password = "pass123",
            Role = "Admin",
            Department = "HR"
        },
        new Users()
        {
            UserId = 6,
            Email = "sales.user@example.com",
            Password = "pass123",
            Role = "User",
            Department = "Sales"
        },
        new Users()
        {
            UserId = 7,
            Email = "guest.it@example.com",
            Password = "pass123",
            Role = "Guest",
            Department = "IT"
        }
    };
        }
    }
}
