using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace UserControlsLibrary
{
    public partial class Clocks : UserControl
    {
        public DispatcherTimer timer = new(DispatcherPriority.Render);

        public Clocks()
        {
            InitializeComponent();

            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeTextBlock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
