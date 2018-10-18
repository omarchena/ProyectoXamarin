using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace ProyectoCenfotec
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            
            var mainPage = new MainPage() { Title = "WIKI" };

            MainPage = new NavigationPage(mainPage)
            {
                //BarTextColor = Color.Black,
                //BarBackgroundColor = Color.DarkRed
            };
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
