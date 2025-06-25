using Lection0606.Database;
using Lection0606.Repositories;

var builder = WebApplication.CreateBuilder(args);

// DB WORK

string connectionString
    = "Data Source=mssql;Initial Catalog=ispp3101;Persist Security Info=True;User ID=ispp3101;Password=3101;Trust Server Certificate=True";

//IDataBaseFactory factory = new MsSqlFactory(connectionString);
//var repository = new ReviewsRepository(factory);
builder.Services.AddSingleton<IDataBaseFactory>(new MsSqlFactory(connectionString));
builder.Services.AddScoped<ReviewsRepository>();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
