using Xamarin.UITest;
using System.Linq;

namespace XamStore.XPlat.Tests.Pages.Android
{
	public class ShippingPageAndroid : BasePage, IShippingPage
	{
		public bool IsActive()
		{
			var foundElement = app.Query (e => e.Id ("shipping_address")).FirstOrDefault ();
			return foundElement != null;
		}

		public ShippingPageAndroid (IApp app)
			: base (app)
		{
		}
	}
}

