using Core;

public interface ISession
{
    T CreatePage<T>() where T : IComponent;
}