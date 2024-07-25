//#define alternative1
#define alternative2

using System.Collections;

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

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        ListView listView = (ListView)sender;
#if alternative1
        var selected = listView.SelectedItem as string;
        DisplayAlert("L'élement courant", $"{selected}", "OK");
#endif
#if alternative2
        var selected = listView.SelectedItem as Langage;
        DisplayAlert("L'élement courant", $"{selected.Name}", "OK");
#endif




    }
}