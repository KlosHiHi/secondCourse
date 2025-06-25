using DBLibrary;
using System.Windows;

namespace LabWork46
{
    public partial class MainWindow : Window
    {
        private readonly IDataBase _db = new SqlDataBase("mssql", "ispp3101", "ispp3101", "3101");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SqlQueryButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Изменено: {_db.ExecuteQuery(SqlTextBox.Text)} строк(-ока)", "Информация");
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (_db.UpdateGame(int.Parse(IdTextBox.Text), newTitleTextBox.Text, double.Parse(newPriceTextBox.Text)))
                MessageBox.Show("Успешно обновленно", "Информация");
            else
                MessageBox.Show("Ошибка обновления", "Информация");
        }
    }
}