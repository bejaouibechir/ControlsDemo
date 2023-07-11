#define collectionviews
//#define commandviews
//#define inputcontrols
//#define prensentationcontrols
//#define textcontrols

namespace ControlsDemo;


public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if collectionviews
        MainPage = new CollectionsControlsDemo();
#endif
#if commandviews
        MainPage = new CommandsControlsDemo();
#endif
#if textcontrols
        MainPage = new TextControlsDemo();
#endif
#if prensentationcontrols
        MainPage = new PresentationControlsDemo();
#endif
#if inputcontrols
        MainPage = new InputControlsDemo();
#endif



    }
}
