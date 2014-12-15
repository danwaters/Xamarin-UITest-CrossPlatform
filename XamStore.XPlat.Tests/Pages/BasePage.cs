using Xamarin.UITest;

namespace XamStore.XPlat.Tests.Pages
{
	public class BasePage
	{
		protected IApp app;

		public BasePage (IApp app)
		{
			this.app = app;
		}
	}
}

