Subject subject = new();
HexaObserver hexaObserver = new();
DecimalObserver decimalObserver = new();
OctalObserver octalObserver = new();
BinaryObserver binaryObserver = new();

subject.StateChanged += binaryObserver.Update;
subject.StateChanged += octalObserver.Update;
subject.StateChanged += decimalObserver.Update;
subject.StateChanged += hexaObserver.Update;

subject.State = 15;

Console.WriteLine();

subject.State = 10;

Console.WriteLine();

subject.State = 21;