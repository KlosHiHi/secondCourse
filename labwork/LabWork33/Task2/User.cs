class User
{
    public string Address { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string HiddenPassword => new('*', Password.Length);
    public string CategoryName { get; set; }
    public bool isArchive { get; set; }

    public User(string address, string login, string password, string category, bool archive)
    {
        Address = address;
        Login = login;
        Password = password;
        CategoryName = category;
        isArchive = archive;
    }
}
