using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LabWork41.Tasks
{
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Width == 35)
            {
                DoubleAnimation ShowMenuAnimation = new()
                {
                    From = MenuStackPanel.ActualWidth,
                    To = 150,
                    Duration = TimeSpan.FromSeconds(0.5)
                };

                DoubleAnimation IncreaseButtonAnimation = new()
                {
                    From = HamburgerButton.ActualWidth,
                    To = 150,
                    Duration = TimeSpan.FromSeconds(0.5)
                };

                MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, ShowMenuAnimation);
                HamburgerButton.BeginAnimation(Button.WidthProperty, IncreaseButtonAnimation);
            }
            else
            {
                DoubleAnimation HideMenuAnimation = new()
                {
                    From = MenuStackPanel.ActualWidth,
                    To = 0,
                    Duration = TimeSpan.FromSeconds(0.5)
                };

                DoubleAnimation DecreaseButtonAnimation = new()
                {
                    From = HamburgerButton.ActualWidth,
                    To = 35,
                    Duration = TimeSpan.FromSeconds(0.5)
                };

                MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, HideMenuAnimation);
                HamburgerButton.BeginAnimation(Button.WidthProperty, DecreaseButtonAnimation);
            }

        }
    }
}
