namespace LabWork39;

public partial class Task3Page : ContentPage
{
    public IEnumerable<DirectoryInfo> Directories { get; set; }
    public IEnumerable<FileInfo> Files { get; set; }

    public Task3Page()
    {
        InitializeComponent();

        DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork39\LabWork39\Resources\Files");

        Files = directory.GetFiles("*", SearchOption.AllDirectories).AsEnumerable();
        Directories = directory.GetDirectories("*", SearchOption.AllDirectories).AsEnumerable();

        var selectedFiles = Files.Select(file => new
        {
            Name = file.Name,
            FullName = file.FullName,
            CreationTime = file.CreationTime
        });

        var selectedDirectories = Directories.Select(directory => new
        {
            Name = directory.Name,
            FullName = directory.FullName,
            CreationTime = directory.CreationTime
        });

        FilesListView.ItemsSource = selectedDirectories.Union(selectedFiles);
    }
}