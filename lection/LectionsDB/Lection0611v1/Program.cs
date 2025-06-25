using Lection0606.Database;
using Lection0606.Models;
using Lection0606.Repositories;
using Lection0606.Services;

string connectionString
    = "Data Source=mssql;Initial Catalog=ispp3101;Persist Security Info=True;User ID=ispp3101;Password=3101;Trust Server Certificate=True";

IDataBaseFactory factory = new MsSqlFactory(connectionString);
//ReviewRepository repository = new(factory);

var repository = new ReviewsRepository(factory);
ReviewsService service = new(repository);

var reviews = service.GetAll();
var review = service.GetById(3);

reviews = service.GetAllByGameId(5);

review.Comment = "qwe qwe";
repository.Update(review);

Console.WriteLine();