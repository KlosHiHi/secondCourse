User user = new() { Login = "qwerty", Password = "1234"};
user.ValueChanged += User_ValueChange;
user.Login = "lololol";
user.Login = "igor";
user.Password = "lololol";

void User_ValueChange(object? sender, EventArgs e)
{
    User user = (User)sender;
    Console.WriteLine($"Изменены данные пользователя со следующим логином: {user.Login}");
}