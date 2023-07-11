namespace ControlsDemo;

public partial class CollectionsControlsDemo : ContentPage
{
	public CollectionsControlsDemo()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		Picker picker = (Picker)sender;
		DisplayAlert("A picker Test", picker.SelectedItem.ToString(), "OK");
    }
}