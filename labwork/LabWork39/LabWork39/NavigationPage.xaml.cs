namespace LabWork39;

public partial class NavigationPage : ContentPage
{
	public NavigationPage()
	{
		InitializeComponent();
    }


    private async void ToTask1Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Task1Page());
    }
    private async void ToTask2Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Task2Page());
    }

    private async void ToTask3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Task3Page());
    }

    private async void ToTask4Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Task4Page());
    }

    private async void ToTask5Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Task5Page());
    }
}