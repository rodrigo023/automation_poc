using System;

namespace Core
{
    internal class Session : ISession
    {
        private IDriver _driver;
        private const string DriverProperty = "Driver";

        internal Session(IDriver driver)
        {
            _driver = driver;
        }

        public T CreatePage<T>() where T: IComponent
        {
            var component = (T)Activator.CreateInstance(typeof(T));
            SetDriver(component);

            return component;
        }

        private void SetDriver<T>(T component) where T: IComponent
        {
            var driverProperty = typeof(T).GetProperty(DriverProperty, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            driverProperty.SetValue(component, _driver);
        }
    }
}