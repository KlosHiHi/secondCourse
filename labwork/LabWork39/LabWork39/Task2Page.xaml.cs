namespace LabWork39;

public partial class Task2Page : ContentPage
{
    public IEnumerable<FileInfo> Files { get; set; }

    public Task2Page()
	{
		InitializeComponent();

        DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork39\LabWork39\Resources\Files");
        Files = directory.GetFiles("*", SearchOption.AllDirectories).AsEnumerable();

        FilesListView.ItemsSource = 
            Files.GroupBy(file => new {file.CreationTime.Year, file.CreationTime.Month})
            .Select(group => new
            {
                Year = group.Key.Year,
                Month = group.Key.Month,
                FilesQuntity = group.Count()

            });
    }
}