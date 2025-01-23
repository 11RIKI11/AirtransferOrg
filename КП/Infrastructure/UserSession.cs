namespace КП.Infrastructure
{
    public static class UserSession
    {
        public static long? UserId { get; private set; } = null;
        public static string? Role { get; private set; } = null;

        public static void Login(long userId, string role)
        {
            if (UserId.HasValue || !string.IsNullOrEmpty(Role))
            {
                Logger.Error("Id уже есть");
                throw new InvalidOperationException("Id уже есть");
            }
            
            UserId = userId;
            Role = role;
        }

        public static void Logout()
        {
            Application.Restart();
            UserId = null;
            Role = null;
        }
    }
}
