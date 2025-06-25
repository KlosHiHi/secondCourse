using System.Windows;
using System.Windows.Controls;

namespace UserControlsLibrary
{
    public partial class SetQuantity : UserControl
    {
        public event RoutedEventHandler ValueChanged;

        public int MaxValue { get; set; }

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(SetQuantity), new PropertyMetadata(0));

        public SetQuantity()
        {
            InitializeComponent();
            DataContext = this;
            Value = 0;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            MinusButton.IsEnabled = true;

            Value++;

            if (Value == MaxValue)
                PlusButton.IsEnabled = false;

            ValueChanged?.Invoke(sender, e);
        }


        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            PlusButton.IsEnabled = true;

            Value--;

            if (Value == 0)
                MinusButton.IsEnabled = false;

            ValueChanged?.Invoke(sender, e);
        }
    }
}
