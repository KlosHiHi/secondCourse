Console.WriteLine("Lection 01/25");

Cat murka = new();

murka.Print();

Random random = new();
DateTime birthDate = new(2000, 10, 20);

var person = new Person();
//person._fullName = "Brungilda";
Person.Country = "Kazakhstan";

person.Print();

Person.Country = "Urugvaii";

person.Print();