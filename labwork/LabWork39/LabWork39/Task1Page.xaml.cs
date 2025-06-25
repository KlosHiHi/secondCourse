namespace LabWork39
{
    public partial class Task1Page : ContentPage
    {
        public IEnumerable<FileInfo> Files { get; set; }

        public Task1Page()
        {
            InitializeComponent();

            DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork39\LabWork39\Resources\Files");
            Files = directory.GetFiles("*", SearchOption.AllDirectories).AsEnumerable();

            FilesListView.ItemsSource = Files.GroupBy(file => file.Extension)
                .Select(group => new
                {
                    group.Key,
                    TotalSize = group.Sum(file => file.Length),
                    Min = group.Min(file => file.Length),
                    Max = group.Max(file => file.Length),
                    FileQuantity = group.Count()
                });
        }
    }
}
