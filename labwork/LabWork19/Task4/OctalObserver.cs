public class OctalObserver : Observer
{
    public override void Update(int state)
        => Console.WriteLine($"Восьмиричный: {Convert.ToString(state, 8)}");
}
