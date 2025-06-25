using System.Runtime.CompilerServices;

public class User
{
    private string _login;
    private string _password;

    public string Login
    {
        get => _login;
        set
        {
            if (_login != value)
            {
                _login = value;
                string errorText = _login == String.Empty ? "логин пустой" : "";
                OnPropertyChanged(errorText);
            }
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            if (_password != value)
            {
                _password = value;
                string errorText = (_password.Length < 6 || _password.Length > 20) ?
                    "размер пароля не соответствует нужной длинне" : "";
                OnPropertyChanged(errorText);
            }
        }
    }

    public event EventHandler<InfoEventArgs> PropertyChanged;

    private void OnPropertyChanged(string errorText, [CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new InfoEventArgs(propertyName, errorText, DateTime.Now));
    }
}