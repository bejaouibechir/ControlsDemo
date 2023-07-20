//#define itemsviews
//#define commandviews
//#define inputcontrols
//#define prensentationcontrols
//#define textcontrols
#define collectionviews 

namespace ControlsDemo;


public partial class App : Application
{
	public App()
	{
		InitializeComponent();
#if itemsviews
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

#if collectionviews
        MainPage = new CollectionViewPageDemo();
#endif



    }
}
