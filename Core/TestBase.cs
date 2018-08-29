using Autofac;
using NUnit.Framework;

namespace Core
{
    [SetUpFixture]
    public abstract class TestBase
    {
        protected ISession Session { get; private set; }
        private IContainer _container;
        private IDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(new DriverSettings(Browsers.Chrome)).As<IDriverSettings>();
            builder.RegisterType<Driver>().As<IDriver>().InstancePerLifetimeScope();
            builder.RegisterType<Session>().As<ISession>()
                .FindConstructorsWith(x => x.GetConstructors(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance));
            _container = builder.Build();
        }

        [SetUp]
        public void StartTest()
        {
            using (var lifetimeScope = _container.BeginLifetimeScope())
            {
                _driver = lifetimeScope.Resolve<IDriver>();
                _driver.Launch();
                Session = lifetimeScope.Resolve<ISession>();
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}