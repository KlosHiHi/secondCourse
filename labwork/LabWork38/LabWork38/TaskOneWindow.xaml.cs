using System.Linq;

namespace LabWork38
{
    public partial class TaskOneWindow : ContentPage
    {
        public IEnumerable<FileInfo> Files { get; set; }
        public IEnumerable<FileInfo> Result { get; set; }

        private int _shownFiles = 0;
        public int ShownFiles
        {
            get => _shownFiles;
            set
            {
                if (value > TotalFiles)
                    _shownFiles = TotalFiles;
                else
                    _shownFiles = value;
            }
        }
        public int TotalFiles { get; set; }

        public int PageSize { get; set; } = 5;

        private int _currentPage = 1;

        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                if (value < 1)
                    _currentPage = 1;
                else if (value > PagesCount)
                    _currentPage = PagesCount;
                else
                    _currentPage = value;
            }
        }

        public int PagesCount { get; set; }

        public TaskOneWindow()
        {
            InitializeComponent();

            DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork38\LabWork38\Resources\Files");
            Files = directory.GetFiles().AsEnumerable();

            Result = Files.Skip((CurrentPage - 1) * PageSize).Take(PageSize).AsEnumerable();
            TotalFiles = Files.Count();

            BindingContext = this;


            ShowPagesQuantity();
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("OtherTaskWindow");
        }

        private void ShowPagesQuantity()
        {
            PagesCount = (int)Math.Ceiling((decimal)Files.Count() / PageSize);

            FilesListView.ItemsSource = Result;
            ShownFiles = Result.Count();

            ShownPagesLabel.Text = $"Показано {ShownFiles} из {TotalFiles} записей. Всего страниц: {PagesCount}";
        }


        // Task 1

        private void ShowMoreButton_Clicked(object sender, EventArgs e)
        {
            AddPages();
        }

        private void AddPages()
        {
            CurrentPage++;

            Result = Result.Concat(Files.Skip((CurrentPage - 1) * PageSize).Take(PageSize).AsEnumerable());

            ShowPagesQuantity();

            if (Result.Count() >= TotalFiles)
                ShowMoreButton.IsEnabled = false;
        }


        // Task 5

        private void PageSizePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangePageSize();
        }

        private void ChangePageSize()
        {
            ShowMoreButton.IsEnabled = true;
            PageSize = int.Parse(PageSizePicker.SelectedItem.ToString());

            CurrentPage = 1;

            Result = Files.Skip((CurrentPage - 1) * PageSize).Take(PageSize).AsEnumerable();

            ShowPagesQuantity();

            if (Result.Count() >= TotalFiles)
                ShowMoreButton.IsEnabled = false;
        }
    }
}
