Console.WriteLine("Design pattern");

Logger.GetInstance().Log("LOG: test Singleton");
Logger.GetInstance().Log($"LOG: {DateTime.Now}");



Application application = new();
var pdf = application.Create("pdf");

IUIFactory factory = new WindowsUIFactory();
IButton button = factory.CreateButton();
button.Render();
Console.WriteLine();

// дальше 03.13
QueryBuilder builder = new("users");

builder = builder
    .Where("age > 18")
    .Select("name, age")
    .OrderBy("name")
    .OrderBy("age");

Console.WriteLine(builder.Build());

Console.WriteLine();