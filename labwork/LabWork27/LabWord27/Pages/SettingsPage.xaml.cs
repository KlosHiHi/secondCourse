using System.Windows.Controls;

namespace LabWork27.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            string[] gameGenre = { "RPG", "Симулятор", "Шутер" };

            string[] gameNames = { "The Elder Scrolls 5:Skyrim", "Mass Effect 2", "Dragon Age:Origins",
                "Дальнабойщики 3:покорение Америки", "Grand Theft Auto 5", "Need for Speed SHIFT",
                "S.T.A.L.K.E.R.:Shadow of Chernobyl", "Far Cry 3", "Atomic Heart"};

            for (int i = 0; i < 3; i++)
            {
                Expander expander = new() { Header = gameGenre[i] };
                WrapPanel wrapPanel = new();

                for (int j = 0; j < 3; j++)
                {
                    CheckBox checkBox = new() { Content = gameNames[i * 3 + j] };
                    wrapPanel.Children.Add(checkBox);
                }

                expander.Content = wrapPanel;
                GameStackPanel.Children.Add(expander);
            }
        }
    }
}
