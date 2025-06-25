
class Car : IMoveable, IEquatable<Car>
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public string SpeedInfo
    {
        get
        {
            return $"{Speed} км/ч";
        }
    }

    public void Move()
    {
        Console.WriteLine($"{Brand} едет со скоростью {Speed} км/ч");
    }

    public bool Equals(Car? other)
        => Brand == other?.Brand && Speed == other.Speed;
}