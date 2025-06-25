using System.ComponentModel;

Console.WriteLine("events");

Sensor sensorSouth = new() { Temperature = -2, Pressure = 750, Humiduty = 50 };
sensorSouth.PropertyChanged += Sensor_PropertyChanged;
sensorSouth.Temperature = 0;
sensorSouth.Humiduty = 60;

Sensor sensorWest = new() { Temperature = 5, Pressure = 770, Humiduty = 40 };
sensorWest.PropertyChanged += Sensor_PropertyChanged;
sensorWest.Temperature = 10;
sensorWest.Pressure = 770;

void Sensor_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Sensor sensor = (Sensor)sender;
    Console.WriteLine($"изменилось показание {e.PropertyName}");
    Console.WriteLine($"t = {sensor.Temperature}, p = {sensor.Pressure}, h = {sensor.Humiduty}");
    Console.WriteLine();
}

