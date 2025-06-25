Console.WriteLine("LINQ-запросы (link) - Language INtegrated Query");

//products.Select(...).Where(...) - пример LINQ

var user = new { Login = "admin", Password = "dima12" };
var numbers = Enumerable.Range(1, 5).ToList();
List<string> users = ["admin", "user1", "user2"];

List<Cat> cats =
[
    new Cat { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
    new Cat { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
    new Cat { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
    new Cat { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
    new Cat { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
    new Cat { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
    new Cat { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
    new Cat { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
    new Cat { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
    new Cat { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
];

//Select()
var cats1 = cats.Select(cat => cat.Name); //одно свойство
var cats2 = cats.Select(cat => new { cat.Name, cat.Age }); //для нескольких - анонимный тип
var cats3 = cats.Select(cat => new CatDto { Name = cat.Name, Breed = cat.Breed });  //создание отдельного класса

//Where()
var num1 = numbers.Where(i => i % 2 == 0);
var users1 = users.Where(user => user.StartsWith("user"));

var cats4 = cats.Where(cat => cat.Breed == "Сиамская");
var cats5 = cats.Where(cat => cat.Breed == "Сиамская" && cat.Age < 5);

var cats6 = cats.Where(cat => cat.Color == "Рыжий"); // цвет выбран всегда
cats6 = cats6.Where(cat => cat.Age < 3); // добавили проверку на возраст
cats6 = cats6.Where(cat => cat.Breed == "Мейн-кун"); // проверка на возраст
cats6 = cats6.AsEnumerable();

var cats7 = cats.AsEnumerable(); // привели список к нумерабелу
cats7 = cats7.Where(cat => cat.Age < 3);
cats7 = cats7.Where(cat => cat.Breed == "Мейн-кун");

var cats8 = cats
    .Where(cat => cat.Age < 3)
    .Where(cat => cat.Breed == "Мейн-кун");

var cats9 = cats.OrderBy(cat => cat.Name);
var casts10 = cats.OrderByDescending(cat => cat.Name);

var cats11 = cats
    .OrderBy(cat => cat.Breed)
    .ThenByDescending(cat => cat.Age)
    .ThenBy(cat => cat.Name);

Console.WriteLine();

int pageSize = 3; // кол-во элементов на странице (pageSize / elementsCount)
int currentPage = 1; // порядок страницы

var cats12 = cats
    .Skip((currentPage - 1) * pageSize)
    .Take(pageSize);

int lastPage = (int)Math.Ceiling(1.0 * cats.Count() / pageSize);

//агрегатные функции
var persCount = cats.Count(c => c.Breed == "Персидская");
var catsCount = cats.Count();
var minAge = cats.Min(c => c.Age); // минимальный возраст
var agesSum = cats.Sum(c => c.Age);

var multResult = numbers.Aggregate((x, y) => x * y);

cats.ForEach(cat => Console.WriteLine($"[{cat.Id}] {cat.Name}"));

var names = cats.Aggregate((x, y) => new Cat { Name = String.Concat(x.Name, y.Name) });

//группировка
var colorGroup = cats
    .GroupBy(cat => cat.Color)
    .Select(group => new { Color = group.Key, Count = group.Count() });

var cats13 = cats
    .GroupBy(c => new { c.Color, c.Breed })
    .Select(group => new
    {
        group.Key.Color,
        group.Key.Breed,
        AvgAge = group.Average(c => c.Age)
    });

cats.Distinct();

var cats14 = cats
    .Select(c => c.Breed)
    .Distinct();

var cats15 = cats.Where(c => c.Breed == "Мейн-Кун")
    .Union(cats.Where(c => c.Breed == "Сиамская"));

var cats16 = cats
    .Where(c => c.Age > 2)
    .Except(cats.Where(c => c.Breed == "Сиамская"));

var cats17 = cats
    .Select(c => c.Color)
    .Concat(cats.Select(c => c.Breed))
    .Distinct();

bool areRed = cats.All(c => c.Color == "Рыжий");
bool notKitten = cats.All(c => c.Age > 1);

bool haveKitten = cats.Any(c => c.Age <= 1);
bool haveCats = cats.Any(); // есть элементы в списке

var redCatF = cats.FirstOrDefault(c => c.Color == "Рыжий");
var redCatL = cats.LastOrDefault(c => c.Color == "Рыжий");
var redCatS = cats.SingleOrDefault(c => c.Color == "Рыжий");

