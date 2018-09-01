using Autofac;
using NUnit.Framework;

namespace Core
{
    [SetUpFixture]
    [TestFixtureSource(typeof(TestEnvironmentSource))]
    public abstract class WebTest
    {
        protected ISession Session { get; private set; }
        private IContainer _container;
        private IDriver _driver;
        private IDriverSettings _driverSettings;

        protected WebTest(IDriverSettings driverSettings)
        {
            _driverSettings = driverSettings;
        }

        [OneTimeSetUp]
        public void SetUp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(_driverSettings).As<IDriverSettings>();
            builder.RegisterType<DefaultComponentCreator>().As<IComponentCreator>();
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

        [TearDown]
        public void FinishTest()
        {
            _driver.Quit();
        }
    }
}