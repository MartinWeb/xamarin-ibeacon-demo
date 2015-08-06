using System;
using Xamarin.Forms;

namespace BeaconDemo
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new NavigationPage(new MainPage());
		}
	}

}

