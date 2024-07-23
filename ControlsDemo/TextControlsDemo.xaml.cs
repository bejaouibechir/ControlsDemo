using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ControlsDemo;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

     private void Entry_TextChanged(object sender, TextChangedEventArgs e)
     {
          
     }

     private void Entry_Completed(object sender, EventArgs e)
     {
          
     }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        string patron = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
          @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        Entry entry = (Entry)sender;
        var mail = txtEMail.Text;
        if (!Regex.IsMatch(mail,patron))
        {
            DisplayAlert("Format de mail invalide", "Le format de mail entré est invalide", "OK");
            txtEMail.Text = string.Empty;
            txtEMail.Focus();
        }

    }
}