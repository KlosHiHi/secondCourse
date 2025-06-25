public interface IObserver
{
    Sensor Sensor { get; set; }

    void Update();
}


public class PressureDisplay : IObserver
{
    public Sensor Sensor { get; set; }

    public void Update() => Console.WriteLine($"p = {Sensor.Pressure}");
}


public class TemperatureDisplay : IObserver
{
    public Sensor Sensor { get; set; }

    public void Update() => Console.WriteLine($"t = {Sensor.Temperature}");
}