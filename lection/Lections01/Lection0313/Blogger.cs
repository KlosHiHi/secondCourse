public class Blogger
{
    public event Action<string> VideoPublished;

    public void PublishVideo(string title)
    {
        Console.WriteLine($"НОВОЕ ВИДЕО {title}");
        VideoPublished?.Invoke(title);
    }
}
