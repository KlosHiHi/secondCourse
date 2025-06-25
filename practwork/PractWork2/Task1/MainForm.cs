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
                MessageBox.Show("����� �� ������ ��������� ����. ������� [;]", "������ ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamReader reader = new StreamReader("logins.csv"))
            {
                while ((_result = reader.ReadLine()) != null)
                {
                    _userData = _result.Split(";");

                    if (LoginTextBox.Text.ToLower() == _userData[0])
                    {
                        MessageBox.Show("������ ����� ��� �����!", "������ ������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            File.AppendAllText("logins.csv", $"{LoginTextBox.Text.ToLower()};{PasswordTextBox.Text};{DateTime.Now}\n");
            MessageBox.Show("�� ������� ������������������", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
