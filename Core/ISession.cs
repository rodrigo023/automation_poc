using Core;

public interface ISession
{
    T GoToPage<T>() where T : INavigableComponent;
}