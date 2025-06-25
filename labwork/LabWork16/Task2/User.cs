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
                ValueChanged?.Invoke(this, EventArgs.Empty);
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
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public event EventHandler ValueChanged;
}