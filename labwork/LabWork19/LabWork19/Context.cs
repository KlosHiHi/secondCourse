class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy) 
        => _strategy = strategy;

    public int ExecuteStrategy(int number1, int number2)
        => _strategy.Operation(number1, number2);
}
