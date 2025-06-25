namespace LabWork37
{
    public partial class MainPage : ContentPage
    {
        public IEnumerable<FileInfo> Files { get; set; }
        private IEnumerable<FileInfo> FilteredFiles { get; set; }
        private RadioButton SelectedRadio { get; set; } = new() { Value = "empty" };
        public DateTime CurrentDate { get; set; } = DateTime.Now;
        public int TotalFiles { get; set; }
        public int ShownFiles { get; set; }

        public MainPage()
        {
            InitializeComponent();
            DirectoryInfo directory = new(@"Y:\МДК.01.01");
            Files = directory.GetFiles().AsEnumerable();

            TotalFiles = Files.Count();
            FilteredFiles = Files;

            ShowFilesQuantity();

            BindingContext = this;
        }

        private void ClearEntryButton_Clicked(object sender, EventArgs e)
        {
            FileNameEntry.Text = String.Empty;
            FileSizeEntry.Text = String.Empty;
            MoreMultiFileSizeEntry.Text = String.Empty;
            LessMultiFileSizeEntry.Text = String.Empty;
            LessCheckBox.IsChecked = false;
            MoreCheckBox.IsChecked = false;
            DateCheckBox.IsChecked = false;
            FileDatePicker.Date = CurrentDate;
            TextFiltering(FileNameEntry.Text);
        }

        private void ShowFilesQuantity()
        {
            ShownFiles = FilteredFiles.Count();

            FilesListView.ItemsSource = FilteredFiles;

            FilesQuantityLable.Text = $"Показано {ShownFiles} из {TotalFiles} записей";
        }


        // Task 1
        private void FileNameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextFiltering(FileNameEntry.Text);
        }

        private void TextFiltering(string text)
        {
            FilteredFiles = Files.Where(file => file.Name.Contains(text, StringComparison.OrdinalIgnoreCase));

            ShowFilesQuantity();
        }


        // Task 2
        private void FileSizeEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            SizeFiltering(SelectedRadio, FileSizeEntry.Text);
        }

        private void SizeRadio_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            SizeFiltering(sender, FileSizeEntry.Text);
        }

        private void SizeFiltering(object sender, string fileSize)
        {
            if (!long.TryParse(fileSize, out long size))
                return;

            SelectedRadio = sender as RadioButton;

            if (SelectedRadio.Value.ToString() == "more")
                FilteredFiles = Files.Where(file => file.Length >= size);
            else if (SelectedRadio.Value.ToString() == "less")
                FilteredFiles = Files.Where(file => file.Length <= size);
            else
                FilteredFiles = Files;

            ShowFilesQuantity();
        }


        // Task 3
        private void MultiFileSizeEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            MultiSizeFiltering(MoreMultiFileSizeEntry.Text, LessMultiFileSizeEntry.Text);
        }

        private void MultiSizeCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            MultiSizeFiltering(MoreMultiFileSizeEntry.Text, LessMultiFileSizeEntry.Text);
        }

        private void MultiSizeFiltering(string lowerFileSize, string upperFileSize)
        {
            if (!long.TryParse(lowerFileSize, out long lowerBorderSize) && MoreCheckBox.IsChecked)
                return;

            if (!long.TryParse(upperFileSize, out long upperBorderSize) && LessCheckBox.IsChecked)
                return;

            FilteredFiles = Files;

            if (MoreCheckBox.IsChecked)
                FilteredFiles = FilteredFiles.Where(file => file.Length >= lowerBorderSize);

            if (LessCheckBox.IsChecked)
                FilteredFiles = FilteredFiles.Where(file => file.Length <= upperBorderSize);

            ShowFilesQuantity();
        }


        // Task 4
        private void DateCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            DateFiltering();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateFiltering();
        }

        private void DateFiltering()
        {
            if (DateCheckBox.IsChecked)
                FilteredFiles = Files.Where(file => file.LastWriteTime >= FileDatePicker.Date);
            else
                FilteredFiles = Files;

            if (FilteredFiles.Count() == 0)
                DisplayAlert("Ошибка", "Файлы не найдены", "ОК");

            ShowFilesQuantity();
        }
    }
}