using System.Windows;
using System.Windows.Controls;

namespace PractWork6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Title = ((RadioButton)sender).Content.ToString();
        }

        private void SetQuantity_ValueChanged(object sender, RoutedEventArgs e)
        {
            CheckPrice();
        }

        private void PriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckPrice();
        }

        private void CheckPrice()
        {
            if (PriceTextBox.Text != string.Empty)
                TotalPriceTextBlock.Text = $"{(int.Parse(PriceTextBox.Text) * SetQuantity.Value)} руб.";
            else
                TotalPriceTextBlock.Text = "0 руб.";
        }
    }
}