using Xamarin.UITest;

namespace XamStore.XPlat.Tests.Pages.Android
{
	public class OptionsPageAndroid : BasePage, IOptionsPage
	{
		public void SelectTShirtSize (string size)
		{
			app.WaitForElement (c => c.Id ("productSize"));
			app.Tap (c => c.Id ("productSize"));
			app.Tap (c => c.Raw (string.Format("CheckedTextView text:'{0}'", size)));
		}

		public void SelectTShirtColor (string color)
		{
			app.Tap (c => c.Id ("productColor"));
			app.Tap (c => c.Raw (string.Format("CheckedTextView text:'{0}'", color)));
		}

		public void AddToCart()
		{
			app.Tap (c => c.Id ("addToBasket"));
		}

		public OptionsPageAndroid (IApp app)
			: base (app)
		{
		}
	}
}

