public class HexaObserver : Observer
{
    public override void Update(int state)
        => Console.WriteLine($"Шестнадцатеричный: {Convert.ToString(state, 16)}");
}