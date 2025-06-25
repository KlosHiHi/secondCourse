public class Subject
{
    private int _state;
    public event Action<int> StateChanged;

    public int State
    {
        get => _state;
        set
        {
            _state = value;
            Console.WriteLine($"Входное значение: {value}");
            StateChanged?.Invoke(value);
        }
    }
}
