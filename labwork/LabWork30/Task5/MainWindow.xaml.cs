using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private byte _redValue = 0;
        private byte _greenValue = 0;
        private byte _blueValue = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = e.OriginalSource as Slider;

            switch (slider.Name)
            {
                case "RedSlider":
                    _redValue = (byte)RedSlider.Value;
                    break;
                case "GreenSlider":
                    _greenValue = (byte)GreenSlider.Value;
                    break;
                case "BlueSlider":
                    _blueValue = (byte)BlueSlider.Value;
                    break;
                default:
                    break;
            }

            SetBackgroudColor(_redValue, _greenValue, _blueValue);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var checkBox = e.OriginalSource as CheckBox;

            switch (checkBox.Name)
            {
                case "RedCheckBox":
                    RedSlider.IsEnabled = true;
                    SetBackgroudColor(_redValue, _greenValue, _blueValue);
                    break;
                case "GreenCheckBox":
                    GreenSlider.IsEnabled = true;
                    SetBackgroudColor(_redValue, _greenValue, _blueValue);
                    break;
                case "BlueCheckBox":
                    BlueSlider.IsEnabled = true;
                    SetBackgroudColor(_redValue, _greenValue, _blueValue);
                    break;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var checkBox = e.OriginalSource as CheckBox;

            switch (checkBox.Name)
            {
                case "RedCheckBox":
                    RedSlider.IsEnabled = false;
                    RedSlider.Value = 0;
                    SetBackgroudColor(_redValue, _greenValue, _blueValue);
                    break;
                case "GreenCheckBox":
                    GreenSlider.IsEnabled = false;
                    GreenSlider.Value = 0;
                    SetBackgroudColor(_redValue, _greenValue, _blueValue);
                    break;
                case "BlueCheckBox":
                    BlueSlider.IsEnabled = false;
                    BlueSlider.Value = 0;
                    SetBackgroudColor(_redValue, _greenValue, _blueValue);
                    break;
            }
        }

        private void SetBackgroudColor(byte r, byte g, byte b)
        {
            Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}