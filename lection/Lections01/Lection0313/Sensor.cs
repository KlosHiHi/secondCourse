
public class Sensor
{
    private List<IObserver> _observers = new();

    public double Temperature
    {
        get => default;
        set
        {
        }
    }

    public double Pressure
    {
        get => default;
        set
        {
        }
    }

    public void AddObserver(IObserver observer)
        => _observers.Add(observer);

    public void RemoveObserver(IObserver observer)
        => _observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
            observer.Update();
    }
}
