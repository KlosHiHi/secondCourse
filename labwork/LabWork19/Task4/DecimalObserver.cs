public class DecimalObserver : Observer
{
    public override void Update(int state)
        => Console.WriteLine($"Десятичный: {Convert.ToString(state, 10)}");
}
