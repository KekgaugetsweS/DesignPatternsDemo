namespace StoreDemo.Presentation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CustomerViewPage();
	}
}
