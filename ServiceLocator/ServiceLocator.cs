namespace ServiceLocator
{
//	the constructor of the class registers all the available services in a dictionary.
//	In our example, we have 3 different services accessible through IServiceA, IServiceB, and IServiceC.
//	It is assumed here that ServiceA implements IServiceA and so forth.
//	the generic GetService() method returns a reference the correct implementation fetching it from the dictionary

	public class ServiceLocator : IServiceLocator
	{
	// map that contains pairs of interfaces and
	// references to concrete implementations
	private IDictionary<object, object> services;

	internal ServiceLocator()
	{
		services = new Dictionary<object, object>();

		// fill the map
		this.services.Add(typeof(IServiceA), new ServiceA());
		this.services.Add(typeof(IServiceB), new ServiceB());
		this.services.Add(typeof(IServiceC), new ServiceC());
	}

	public T GetService<T>()
	{
		try
		{
			return (T)services[typeof(T)];
		}
		catch (KeyNotFoundException)
		{
			throw new ApplicationException("The requested service is not registered");
		}
	}
}
}
