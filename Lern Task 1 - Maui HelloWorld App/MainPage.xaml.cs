using Microsoft.Maui.Graphics;

namespace Lern_Task_1___Maui_HelloWorld_App;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void PopupMenuWithMessage(object sender, EventArgs e)
    {
		DisplayAlert("Hello", "World", "Cancel");
    }
}

