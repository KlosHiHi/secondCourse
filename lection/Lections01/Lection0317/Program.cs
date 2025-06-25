Console.WriteLine("mv(x)");

User model = GetUserById(123);
UserView view = new();

UserController controller = new(model, view);
controller.UpdateView();
controller.UserLogin = "adm";
controller.UpdateView();

static User GetUserById(int id)
    => new() { Id = id, Login = "admin" };
