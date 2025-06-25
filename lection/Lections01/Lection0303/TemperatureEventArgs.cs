class TemperatureEventArgs
{
    public double OldValue { get; }
    public double NewValue { get; }

    public TemperatureEventArgs(double oldValue, double newValue)
    {
        OldValue = oldValue;
        NewValue = newValue;
    }
}