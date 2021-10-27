using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalazarExamen
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Registro();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
