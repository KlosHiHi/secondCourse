Student student = new();
Student holy = new();
Square square1 = new();
Square square2 = new();

student.Print();
square1.Print();
Console.WriteLine();

Console.WriteLine($"площадь: {square1.GetSquare()} см^2");
Console.WriteLine($"периметр: {square1.GetPerimeter()} см");
square1.ShowInfo();

Console.WriteLine();
IPrinter iprinter = student;
iprinter.Print();

iprinter = square1;
iprinter.Print();

IPrinter[] iprinters = [square1, square2, holy, student];

Console.WriteLine();
foreach (IPrinter printer in iprinters)
{
    printer.Print();
    if (printer is IFigure figure)
        Console.WriteLine(figure.Name);
}