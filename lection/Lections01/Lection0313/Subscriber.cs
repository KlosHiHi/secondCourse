class Subscriber
{
    public void OnVideoPublished(string title) 
        => Console.WriteLine($"смотри {title}");
}
