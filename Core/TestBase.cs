namespace Core
{
    public abstract class TestBase
    {
        public ISession Session { get; }

        public TestBase()
        {
            Session = SessionFactory.Create();
        }
    }
}
