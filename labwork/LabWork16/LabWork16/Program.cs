using System.ComponentModel;

User user = new();
user.PropertyChanged += User_PropertyChanged;

user.Login = "hermit";
user.Password = "gogle12";
user.Login = "qwerty";

void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"Изменен {e.PropertyName}");
}