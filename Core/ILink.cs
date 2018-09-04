namespace Core
{
    public interface ILink : ICustomElement
    {
        T Click<T>() where T : IComponent;
    }
}
