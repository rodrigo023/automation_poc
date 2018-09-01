namespace Core
{
    public interface IComponentCreator
    {
        T Create<T>(IDriver driver) where T : IComponent;
    }
}