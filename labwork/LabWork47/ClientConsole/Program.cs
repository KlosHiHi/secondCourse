using DBLibrary.DataBase;
using DBLibrary.Models;
using DBLibrary.Repository;
using DBLibrary.Service;

string connectionString
    = "Data Source=mssql;Initial Catalog=ispp3101;Persist Security Info=True;User ID=ispp3101;Password=3101;Trust Server Certificate=True";

IDbConnectionFactory factory = new MsSqlFactory(connectionString);
GameRepository repository = new(factory);
GameService service = new(repository);

var games = service.GetAll();

var game = service.GetById(1);

game.PublicationYear = 2022;
game.Price = 11.99M;
service.Update(game);

game = new()
{
    Title = "To The Moon",
    Description = "Пиксельная RPG о двух рабочих некой корпорации Zigmund",
    PublicationYear = 2011,
    Price = 2.99M
};
service.Create(game);

service.Delete(8);