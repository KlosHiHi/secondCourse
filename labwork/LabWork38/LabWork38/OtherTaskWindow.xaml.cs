
namespace LabWork38
{
    public partial class OtherTaskWindow : ContentPage
    {
        public IEnumerable<FileInfo> Files { get; set; }
        public IEnumerable<FileInfo> PageFiles { get; set; }
        public IEnumerable<FileInfo> FilteredFiles { get; set; }

        private int _pageSize = 5;
        private int _currentPage = 1;
        private int _pagesCount;
        private int _firstPage = 1;

        public int PageSize
        {
            get => _pageSize; 
            set => _pageSize = value > TotalFiles ? TotalFiles : value;
        }
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
        public int PagesCount 
        { 
            get => _pagesCount; 
            set => _pagesCount = value == 0 ? 1 : value; 
        }
        public int TotalFiles { get; set; }
       

        public OtherTaskWindow()
        {
            InitializeComponent();

            DirectoryInfo directory = new DirectoryInfo(@"C:\labs\LabWork38\LabWork38\Resources\Files");
            Files = directory.GetFiles().AsEnumerable();

            TextFiltering(string.Empty);

            BindingContext = this;
        }

        private void ShowPages()
        {
            PagesCount = (int)Math.Ceiling((decimal)(TotalFiles / PageSize));

            PageFiles = FilteredFiles.Skip((CurrentPage - 1) * PageSize).Take(PageSize).AsEnumerable();
            FilesListView.ItemsSource = PageFiles;

            ShownPagesLabel.Text = $"Показано {CurrentPage} из {PagesCount} страниц";
        }

        // Task 2

        private void SetPageButton_Clicked(object sender, EventArgs e)
        {
            PageNavigation(sender);
        }

        private void PageNavigation(object sender)
        {
            var button = (Button)sender;

            CurrentPage += 
                button.Text == ">" ? 1 : -1;

            ShowPages();
            SetButtonEnabling();
        }


        // Task 3

        private void PageNumberEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetPage(((Entry)sender).Text);
        }

        private void SetPage(string pageNumber)
        {
            if (!int.TryParse(pageNumber, out int number))
                return;

            CurrentPage = number;

            ShowPages();
            SetButtonEnabling();
        }

        private void ToBorderPageButton_Clicked(object sender, EventArgs e)
        {
            ToBorderPage(sender);
        }

        private void ToBorderPage(object sender)
        {
            var button = (Button)sender;

            CurrentPage = 
                button.Text == ">>" ? PagesCount : _firstPage;

            ShowPages();
            SetButtonEnabling();
        }

        private void SetButtonEnabling()
        {
            ToFirstPageButton.IsEnabled = true;
            PreviousPageButton.IsEnabled = true;

            ToLastPageButton.IsEnabled = true;
            NextPageButton.IsEnabled = true;

            if (CurrentPage >= PagesCount)
            {
                NextPageButton.IsEnabled = false;
                ToLastPageButton.IsEnabled = false;
            }

            if (CurrentPage <= _firstPage)
            {
                PreviousPageButton.IsEnabled = false;
                ToFirstPageButton.IsEnabled = false;
            }
        }


        // Task 4

        private void FileNameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextFiltering(FileNameEntry.Text);
        }

        private void TextFiltering(string text)
        {
            FilteredFiles = Files.Where(file => file.Name.Contains(text, StringComparison.OrdinalIgnoreCase));

            TotalFiles = FilteredFiles.Count();
            CurrentPage = _firstPage;

            ShowPages();
            SetButtonEnabling();
        }


        // Task 5

        private void PageCountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(PageCountEntry.Text, out int pageSize))
                return;

            PageSize = pageSize;

            TextFiltering(string.Empty);
        }
    }
}
