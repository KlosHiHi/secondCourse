using System.Windows;
using System.Windows.Input;

namespace LabWork41.Tasks
{
    public partial class Task4 : Window
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Не стоило туда нажимать", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
