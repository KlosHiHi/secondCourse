public class BinaryObserver : Observer
{
    public override void Update(int state)
        => Console.WriteLine($"Двоичный: {Convert.ToString(state, 2)}");
}
