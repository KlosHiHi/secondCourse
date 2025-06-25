using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LabWork34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _scale = 100;

        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(
                ApplicationCommands.Save,
                SaveExecuted,
                SaveCanExecuted));

            DateTextBlock.Text = DateTime.Now.ToShortDateString();
        }

        private void SaveCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrEmpty(MainTextBox.Text);
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFileDialog.Title = "Сохранить файл";
            if (saveFileDialog.ShowDialog().Value)
                File.WriteAllText(saveFileDialog.FileName, MainTextBox.Text);
        }

        private void MainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SymbolsQuantity.Text = $"{MainTextBox.Text.Trim().Replace(" ", "").Length} символ(-ов)";
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if (IsStatusBarShowMenuItem.IsChecked)
                MainStatusBar.Visibility = Visibility.Visible;
            else
                MainStatusBar.Visibility = Visibility.Collapsed;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _scale = (int)ScaleSlider.Value;
            ScaleTextBlock.Text = $"Масштаб: {_scale}";
        }

        private void MinusScaleButton_Click(object sender, RoutedEventArgs e)
        {
            if (_scale > 10)
            {
                _scale--;
                ScaleTextBlock.Text = $"Масштаб: {_scale}";
            }
        }

        private void PlusScaleButton_Click(object sender, RoutedEventArgs e)
        {
            if (_scale < 500)
            {
                _scale++;
                ScaleTextBlock.Text = $"Масштаб: {_scale}";
            }
        }

        private void EraseContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = "";
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LeftAlignButton_Click(object sender, RoutedEventArgs e)
        {
            if (LeftAlignButton.IsChecked.Value)
            {
                CenterAlignButton.IsChecked = false;
                RightAlignButton.IsChecked = false;
                JustifyAlignButton.IsChecked = false;
            }
        }

        private void CenterAlignButton_Click(object sender, RoutedEventArgs e)
        {
            if (CenterAlignButton.IsChecked.Value)
            {
                LeftAlignButton.IsChecked = false;
                RightAlignButton.IsChecked = false;
                JustifyAlignButton.IsChecked = false;
            }
        }

        private void RightAlignButton_Click(object sender, RoutedEventArgs e)
        {
            if (RightAlignButton.IsChecked.Value)
            {
                CenterAlignButton.IsChecked = false;
                LeftAlignButton.IsChecked = false;
                JustifyAlignButton.IsChecked = false;
            }
        }

        private void JustifyAlignButton_Click(object sender, RoutedEventArgs e)
        {
            if (JustifyAlignButton.IsChecked.Value)
            {
                CenterAlignButton.IsChecked = false;
                RightAlignButton.IsChecked = false;
                LeftAlignButton.IsChecked = false;
            }
        }

        private void ShowHamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (HamburgerStackPanel.Width == 90)
                HamburgerStackPanel.Width = 40;
            else
                HamburgerStackPanel.Width = 90;
        }
    }
}