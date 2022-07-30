namespace ServiceLocator
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}
