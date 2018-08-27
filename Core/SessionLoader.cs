namespace Core
{
    public static class SessionFactory
    {
        public static ISession Create()
        {
            return new Session();
        }
    }
}
