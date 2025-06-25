namespace LabWork39;

public partial class Task5Page : ContentPage
{
    public IEnumerable<DirectoryInfo> Directories { get; set; }
    public IEnumerable<FileInfo> Files { get; set; }
    public Task5Page()
    {
        InitializeComponent();

        DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork39\LabWork39\Resources\Files");

        Directories = directory.GetDirectories("*", SearchOption.AllDirectories).AsEnumerable();
        Files = directory.GetFiles("*", SearchOption.AllDirectories).AsEnumerable();


        var fileNames = 
            Directories.GroupJoin(Files, directory => directory.FullName, file => file.DirectoryName, (directory, file) => new
            {
                directory.FullName,
                Quantity = file.Count()
            });

        FilesListView.ItemsSource = fileNames;
    }
}