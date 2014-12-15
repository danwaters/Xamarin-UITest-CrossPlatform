using System;
using Xamarin.UITest;

namespace XamStore.XPlat.Tests.Pages.iOS
{
	public class MainPageiOS : BasePage, IMainPage
	{
		public void SelectMensTShirt ()
		{
			app.WaitForElement (e => e.Text ("free"));
			app.Tap (e => e.Text ("free"));
		}

		public void GoToCart()
		{
			app.WaitForElement (e => e.Id ("cart"));
			app.Tap(e => e.Id("cart"));
		}

		public void Checkout()
		{
			app.WaitForElement (e => e.Text ("Checkout"));
			app.Tap(e => e.Text("Checkout"));
		}

		public MainPageiOS (IApp app)
			: base (app)
		{

		}
	}
}

