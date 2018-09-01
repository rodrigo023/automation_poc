using System;

namespace Core
{
    internal sealed class DefaultComponentCreator : IComponentCreator
    {
        public T Create<T>(IDriver driver) where T : IComponent
        {
            return (T)Activator.CreateInstance(typeof(T), driver);
        }
    }
}