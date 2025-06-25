using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LabWork32
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringBuilder _selectedFilters = new StringBuilder();

        public MainWindow()
        {
            InitializeComponent();

            List<string> categories =
            [
                "Овощи и Фрукты",
                "Молочные продукты",
                "Хлеб, Выпечка",
                "Бакалея",
                "Птица, Мясо",
                "Рыба, Морепродукты",
                "Замороженные продукты",
                "Безалкогольные напитки",
                "Здоровое питание"
            ];

            List<Product> products =
            [
               new Product { Id = 1, Name = "Молоко", Category = "Молочные продукты", Price = 67.4M },
               new Product { Id = 2, Name = "Хлеб ржаной", Category = "Хлеб, Выпечка", Price = 60.99M },
               new Product { Id = 3, Name = "Яблоки сезонные", Category = "Овощи и Фрукты", Price = 98.99M },
               new Product { Id = 4, Name = "Крупа Гречневая", Category = "Бакалея", Price = 56.45M },
               new Product { Id = 5, Name = "Газированная вода", Category = "Безалкогольные напитки", Price = 45.67M }
            ];

            CategoryListBox.ItemsSource = categories;
            ProductsListView.Items.Clear();
            ProductsListView.ItemsSource = products;
        }

        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (CheckBox item in AvailabilityFilterListBox.Items)
            {
                if (item.IsChecked.Value)
                {
                    _selectedFilters.Append($" | {item.Content}");
                }
            }

            FiltersTextBlock.Text = $"Фильтры:{_selectedFilters}";
            _selectedFilters.Clear();
        }

        private void SortByComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SortByTextBlock.Text = $"Сортировка {(SortByComboBox.SelectedValue as ComboBoxItem).Content}";
        }

        private void CategoryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CategoryTextBlock.Text = $"Категория: {CategoryListBox.SelectedValue}";
        }

        private void BuyProductButton_Click(object sender, RoutedEventArgs e)
        {
            ProductsBasketListBox.Items.Add((e.Source as Button).DataContext as Product);
        }

        private void DeleteBasketProducButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ProductsBasketListBox.Items.IsEmpty)
            {
                for (int i = ProductsBasketListBox.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ProductsBasketListBox.Items.Remove(ProductsBasketListBox.SelectedItems[i]);
                }
            }
        }

        private void TileElementButton_Click(object sender, RoutedEventArgs e)
        {
            ProductsListView.ItemsPanel = (ItemsPanelTemplate)FindResource("TileElementsItemsPanelTemplate");
            ProductsListView.ItemTemplate = (DataTemplate)FindResource("TileElementDataTemplate");
        }

        private void ListElementButton_Click(object sender, RoutedEventArgs e)
        {
            ProductsListView.ItemsPanel = (ItemsPanelTemplate)FindResource("ListElementsItemsPanelTemplate");
            ProductsListView.ItemTemplate = (DataTemplate)FindResource("ListElementDataTemplate");
        }
    }
}