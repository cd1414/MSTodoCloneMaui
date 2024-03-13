namespace ToDoMaui;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public void MenuClicked(object sender, EventArgs e)
	{
		Shell.Current.FlyoutIsPresented = true;
	}
}


