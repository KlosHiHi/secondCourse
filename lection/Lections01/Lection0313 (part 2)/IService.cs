
public interface IService
{
    void Execute();
}

public class DataService : IService
{
    public void Execute()
    {
        Console.WriteLine("data processssas...BOOM");
    }
}

public class LoggingDecorator : IService
{
    private readonly IService _service;

    public LoggingDecorator(IService service) 
        => _service = service;

    public void Execute()
    {
        Console.WriteLine("LOG: process start");
        _service.Execute();
        Console.WriteLine("LOG: process was failed");
    }
}