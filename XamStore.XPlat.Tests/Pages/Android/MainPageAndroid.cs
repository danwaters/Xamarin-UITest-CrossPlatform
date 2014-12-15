using Xamarin.UITest;

namespace XamStore.XPlat.Tests.Pages.Android
{
	public class MainPageAndroid : BasePage, IMainPage
	{
		public void SelectMensTShirt ()
		{
			app.WaitForElement(e => e.Id("productTitle"));
			app.Tap(e => e.Id("productTitle"));
		}

		public void GoToCart()
		{
			app.WaitForElement (c => c.Id ("cart_menu_item"));
			app.Tap (c => c.Id ("cart_menu_item"));
		}

		public void Checkout()
		{
			app.WaitForElement(c => c.Marked("Checkout"));
			app.Tap (c => c.Marked ("Checkout"));
		}

		public MainPageAndroid (IApp app)
			: base(app)
		{
		}
	}

}

