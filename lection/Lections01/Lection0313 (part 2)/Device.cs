interface IDevice
{
    int GetData();
}


public class OldSensor
{
    public string ReadDataPort()
        => "t = 123 C";
}


class OldSensorAdapter : IDevice
{
    private readonly OldSensor _sensor;

    public int GetData()
    {
        var data  =  _sensor.ReadDataPort();
        data = data.Replace("t=", "");
        data = data.Split(' ')[0];
        return int.Parse(data);
    }
}
