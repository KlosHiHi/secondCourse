var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<Cat> cats = new List<Cat>
{
    new Cat { Id = 1, Name = "������", Breed = "����������", Color = "�����", Age = 5 },
    new Cat { Id = 2, Name = "�������", Breed = "��������", Color = "���-�����", Age = 3 },
    new Cat { Id = 3, Name = "�����", Breed = "���������� ���������������", Color = "�����", Age = 7 },
    new Cat { Id = 4, Name = "�����", Breed = "����-���", Color = "�����", Age = 4 },
    new Cat { Id = 5, Name = "����", Breed = "�������", Color = "���-������", Age = 2 },
    new Cat { Id = 6, Name = "����", Breed = "����������", Color = "�����������", Age = 6 },
    new Cat { Id = 7, Name = "������", Breed = "���������� ���������������", Color = "������", Age = 8 },
    new Cat { Id = 8, Name = "����", Breed = "��������", Color = "����������", Age = 3 },
    new Cat { Id = 9, Name = "�����", Breed = "����-���", Color = "�����", Age = 5 },
    new Cat { Id = 10, Name = "�������", Breed = "����������", Color = "�����", Age = 2 }
};

app.MapGet("/cats", () => cats);

app.MapGet("/cats/{id:int}", (int id) =>
{
    var result = cats.Find(cat => cat.Id == id);
    if (result == null)
        return Results.NotFound();
    return Results.Ok(result);
});

app.MapGet("/cats/{breed}", (string breed) =>
{
    var results = cats.Where(cat => cat.Breed == breed);
    if (results == null)
        return Results.NotFound();
    return Results.Ok(results);
});

app.MapGet("/cats/page{page:int}&size{pageSize:int}", (int page, int pageSize) =>
{
    if (page < 1 || pageSize < 1)
        return Results.BadRequest("������� ��� page ��� size ������������");

    var results = cats.Skip((page - 1) * pageSize).Take(pageSize);

    return Results.Ok(new 
    {
        Page = page, 
        PageSize = pageSize, 
        TotalItem = results.Count(), 
        Items = results
    });
}).WithOpenApi();

app.MapDelete("/cats/{id:int}", (int id) =>
{
    if (cats.Any(cat => cat.Id == id - 1))
    {
        cats.RemoveAt(id - 1);
        return Results.NoContent();
    }

    return Results.NotFound();
});

app.MapPost("/cats", (Cat newCat) =>
{
    if (cats.Any(cat => cat.Id == newCat.Id))
    {
        return Results.BadRequest("������������ � ��������� id ��� ����������");
    }

    cats.Add(newCat);
    return Results.Created();
});

app.Run();