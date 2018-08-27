namespace Core
{
    public interface ISession
    {
        DriverSettings DriverSettings { get; set; }

        Environments Environment { get; set; }

    }

    internal interface IHasWebDriver
    {
        Driver Driver { get; set; }
    }

    public class Session : IHasWebDriver, ISession
    {
  

        public Session()
        {
            if(Driver == null)
            {
                Driver = DriverFactory.GetDriver(DriverSettings);
            }
            
        }

        public Driver Driver { get; set; }
        public DriverSettings DriverSettings { get => new DriverSettings(); set => throw new System.NotImplementedException(); }
        public Environments Environment { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
