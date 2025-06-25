interface IMoveable
{
    const int minSpeed = 0;
    static int maxSpeed = 60;

    void Move();
    string SpeedInfo { get; }
}
