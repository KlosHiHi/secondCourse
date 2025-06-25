using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;

namespace LabWork31
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            BirthDatePicker.DisplayDateEnd = DateTime.Today;

            DateTime aniveresary = new(2025, 5, 6);
            DateTime birthday = new(2025, 5, 21);

            DisplayMeetingsCalendar.SelectedDates.Add(aniveresary);
            DisplayMeetingsCalendar.SelectedDates.Add(birthday);
        }

        private void BirthDatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var age = DateTime.Now.Year - BirthDatePicker.SelectedDate.Value.Year;
            if (BirthDatePicker.SelectedDate.Value.DayOfYear > DateTime.Now.DayOfYear)
                AgeTextBlock.Text = $"Возраст: {age - 1}";
            else
                AgeTextBlock.Text = $"Возраст: {age}";

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordLenghtTextBlock.Text = $"Вы ввели {PasswordBox.Password.Length} символов";
        }

        private void BioTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            BioLenghtTextBlock.Text = $"Осталось: {BioTextBox.MaxLength - BioTextBox.Text.Length} символов";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int experienceYear = (int)ExpYearSlider.Value;
            string yearLetters = "";

            if (experienceYear % 10 == 0 || (experienceYear > 10 && experienceYear < 15) || (experienceYear % 10 > 4 && experienceYear % 10 < 10))
                yearLetters = "лет";
            else if (experienceYear % 10 > 1 && experienceYear % 10 < 5)
                yearLetters = "года";
            else if (experienceYear % 10 == 1)
                yearLetters = "год";

            ExpYearTextBlock.Text = $"Стаж: {experienceYear} {yearLetters}";
        }

        private void SetMeetingButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelectMeetingDatePicker.SelectedDate != null)
                DisplayMeetingsCalendar.SelectedDates.Add((DateTime)SelectMeetingDatePicker.SelectedDate);
            else
                DisplaySelectedDateTextBlock.Text = "Дата не выбрана";
        }

        private void SelectMeetingDatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            DisplaySelectedDateTextBlock.Text = $"Дата: {SelectMeetingDatePicker.SelectedDate.Value.Date.ToShortDateString()}";
        }

        private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password != ConfirmPasswordBox.Password)
            {
                DifferentPasswordTipText.Visibility = Visibility.Visible;
                PasswordBox.BorderBrush = Brushes.Red;
                ConfirmPasswordBox.BorderBrush = Brushes.Red;
            }
            else
            {
                DifferentPasswordTipText.Visibility = Visibility.Collapsed;
                PasswordBox.BorderBrush = Brushes.Gray;
                ConfirmPasswordBox.BorderBrush = Brushes.Gray;
            }
        }

        private void EmailTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Regex regex = new(@"^(?i)[\w-]+@(?i)[a-z]+(\.(?i)[a-z0-9]+)+$");

            if(regex.IsMatch(EmailTextBox.Text))
            {
                UncorrectEmailTipText.Visibility = Visibility.Collapsed;
                EmailTextBox.BorderBrush = Brushes.Gray;
            }
            else
            {
                UncorrectEmailTipText.Visibility = Visibility.Visible;
                EmailTextBox.BorderBrush= Brushes.Red;
            }
        }
    }
}