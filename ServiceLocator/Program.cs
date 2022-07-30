using ServiceLocator;
using ServiceLocatorPattern = ServiceLocator.ServiceLocator;

//Суть паттерна Сервис Локатор сводится к тому, что вместо создания конкретных объектов («сервисов»)
//напрямую с помощью ключевого слова new, мы будем использовать специальный «фабричный» объект,
//который будет отвечать за создание, а точнее «нахождение» всех сервисов.

//For instance, inversion of control containers would not work without service location.
//It's how they resolve the services internally.

// Is service locator anti pattern ? - https://stackoverflow.com/questions/22795459/is-servicelocator-an-anti-pattern

//The clients do not know the actual classes implementing the service.
//They only have to interact with the service locator to get to an implementation.
IServiceLocator locator = new ServiceLocatorPattern();
IServiceA myServiceA = locator.GetService<IServiceA>();
