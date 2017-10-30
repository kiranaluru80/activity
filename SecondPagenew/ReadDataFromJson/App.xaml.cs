using Xamarin.Forms;

namespace ReadDataFromJson
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

            // MainPage =new NavigationPage( new SecondPage()){BarBackgroundColor = Color.FromRgb(47,135,198), BarTextColor = Color.White};
            MainPage = new NavigationPage(new SignInPage())
            {
                BarBackgroundColor = Color.FromHex("#ff5300"),
                BarTextColor = Color.White,
            };
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
