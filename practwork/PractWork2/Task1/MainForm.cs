namespace Task1
{
    public partial class MainForm : Form
    {
        private string _result;
        private string[] _userData = new string[3];

        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Contains(";"))
            {
                MessageBox.Show("Логин не должен содержать спец. символы [;]", "Ошибка логина", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamReader reader = new StreamReader("logins.csv"))
            {
                while ((_result = reader.ReadLine()) != null)
                {
                    _userData = _result.Split(";");

                    if (LoginTextBox.Text.ToLower() == _userData[0])
                    {
                        MessageBox.Show("Данный логин уже занят!", "Ошибка логина", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            File.AppendAllText("logins.csv", $"{LoginTextBox.Text.ToLower()};{PasswordTextBox.Text};{DateTime.Now}\n");
            MessageBox.Show("Вы успешно зарегистрировались", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
