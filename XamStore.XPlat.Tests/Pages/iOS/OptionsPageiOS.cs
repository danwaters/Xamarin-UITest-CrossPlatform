using System;
using Xamarin.UITest;
using XamStore.XPlat.Tests.Pages;

namespace XamStore.XPlat.Tests.Pages.iOS
{
	public class OptionsPageiOS : BasePage, IOptionsPage
	{
		public void SelectTShirtSize (string size)
		{
			app.ScrollDown ();
			// TODO: app is broken on ios 8; do nothing
		}

		public void SelectTShirtColor (string color)
		{
			// TODO: app is broken on ios 8; do nothing
		}

		public void AddToCart()
		{
			app.Tap (e => e.Id ("t-shirt"));
		}

		public OptionsPageiOS (IApp app)
			: base (app)
		{

		}
	}
}

