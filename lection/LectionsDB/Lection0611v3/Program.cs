using WebApiServices;

Console.WriteLine("Hello, World!");

var client = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:5185/api/")
};

ReviewsApiService service = new(client);

try
{
    var reviews = await service.GetReviewsAsync();
    var review = await service.GetReviewAsync(5);
    review.User = "HerMan";
    await service.UpdateReviewAsync(review);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();