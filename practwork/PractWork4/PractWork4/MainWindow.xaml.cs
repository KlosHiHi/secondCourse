using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace PractWork4
{
    public partial class MainWindow : Window
    {
        public Game SelectGame { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new GamesViewModel();

        }

        private void GameDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            SelectGame = GameDataGrid.SelectedItem as Game;
        }
    }
}