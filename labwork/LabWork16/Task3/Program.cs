User user = new();
user.PropertyChanged += User_PropertyChanged;
user.Login = "hoyoverse";
user.Password = "123Errror";
user.Password = "12";

void User_PropertyChanged(object? sender, InfoEventArgs e)
{
    user = sender as User;
    Console.WriteLine($"{e.ChangedDate}: у пользователя {user.Login} изменено {e.PropertyName}");

    if (e.ErrorText != "")
        Console.WriteLine($"Ошибка: {e.ErrorText}");
}