using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Sensor : INotifyPropertyChanged
{
    private double _temperature;
    private double _pressure;
    private double _humiduty;

    public double Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value;
            OnPropertyChanged();
        }
    }

    public double Pressure
    {
        get => _pressure;
        set
        {
            _pressure = value;
            OnPropertyChanged();
        }
    }

    public double Humiduty
    {
        get => _humiduty;
        set
        {
            _humiduty = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string propertyName = "")  //Атрибут, позволяющий узнать, где именно вызвали данный метод (в данном случае свойство)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
