using System.Windows;
using System.Windows.Controls;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Category> categories =
            [
                new Category { CategoryId = 1, CategoryName ="email"},
                new Category { CategoryId = 2, CategoryName ="БД"},
                new Category { CategoryId = 3, CategoryName ="сайт"}
            ];

            User user1 = new("user1@gmail.com", "user1", "qwe123", "email", true);
            User user2 = new("user2@gmail.com", "user2", "4_5_6", "БД", false);
            User user3 = new("user3@gmail.com", "user3", "gg78hh9", "сайт", true);
            User user4 = new("user4@gmail.com", "user4", "_012", "email", true);
            User user5 = new("user5@gmail.com", "user5", "ki34Ry", "БД", true);

            List<User> users = [user1, user2, user3, user4, user5];

            UsersDataGrid.ItemsSource = users;

            СategoryColumn.ItemsSource = categories;
        }

        private void CopyPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetDataObject(((e.Source as Button).DataContext as User).Password);
        }
    }
}