namespace LabWork38
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(OtherTaskWindow), typeof(OtherTaskWindow));
        }
    }
}
