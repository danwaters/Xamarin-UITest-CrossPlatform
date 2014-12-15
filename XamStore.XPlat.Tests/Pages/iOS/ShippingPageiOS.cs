using Xamarin.UITest;
using System.Linq;
using XamStore.XPlat.Tests;

namespace XamStore.XPlat.Tests.Pages.iOS
{
	public class ShippingPageiOS : BasePage, IShippingPage
	{
		public bool IsActive()
		{
			var foundElement = app.Query (e => e.Id ("shipping_address")).FirstOrDefault ();
			return foundElement != null;
		}

		public ShippingPageiOS (IApp app)
			: base(app)
		{
		}
	}
}

