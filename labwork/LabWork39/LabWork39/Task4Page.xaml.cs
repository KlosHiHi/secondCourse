using System.Collections.Generic;

namespace LabWork39;

public partial class Task4Page : ContentPage
{
    public IEnumerable<DirectoryInfo> Directories { get; set; }
    public IEnumerable<FileInfo> Files { get; set; }
    public Task4Page()
	{
		InitializeComponent();

        DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork39\LabWork39\Resources\Files");

        Directories = directory.GetDirectories("*", SearchOption.AllDirectories).AsEnumerable();
        Files = directory.GetFiles("*", SearchOption.AllDirectories).AsEnumerable();


        var fileNames = Directories.Where(directory => directory.CreationTime.Date == DateTime.Today)
            .Join(Files, directory => directory.FullName, file => file.DirectoryName, (directory, file) => new
            {
                file.Name,
                file.DirectoryName,
            });

        FilesListView.ItemsSource = fileNames;
    }
}