public class Factory
{
    /// <summary>
    /// название 
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// прибыль
    /// </summary>
    /// 
    public int Income { get; set; }

    public void ShowInfo()
        => Console.WriteLine($"{Name}, {Income} руб.");

    public static Factory operator ++(Factory factory)
    {
        return new()
        {
            Name = factory.Name,
            Income = factory.Income + 1000
        };
    }

    public static Factory operator +(Factory factoryParent, Factory factoryChild)
    {
        return new()
        {
            Name = factoryParent.Name,
            Income = factoryParent.Income + factoryChild.Income
        };
    }

    public static bool operator true(Factory factory1)
    {
        return factory1.Income > 0;
    }

    public static bool operator false(Factory factory1)
    {
        return factory1.Income <= 0;
    }

    public static bool operator ==(Factory factory1, Factory factory2)
    {
        if (ReferenceEquals(factory1, factory2)) 
            return true;
        return factory1.Name == factory2.Name &&
            factory1.Income == factory2.Income;
    }

    public static bool operator !=(Factory factory1, Factory factory2)
    {
        return factory1.Name != factory2.Name ||
            factory1.Income != factory2.Income;
        // return !(factory1 == facroty2);
    }
}