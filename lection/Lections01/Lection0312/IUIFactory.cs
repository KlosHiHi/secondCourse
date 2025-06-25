public interface IUIFactory
{
    IButton CreateButton();
}

public interface IButton
{
    void Render();
}


public class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("win button");
}

public class WindowsUIFactory : IUIFactory
{
    public IButton CreateButton() => new WindowsButton();
}


class Document : ICloneable
{
    public string Text { get; set; }
    public object Clone() => new Document() { Text = Text };
}