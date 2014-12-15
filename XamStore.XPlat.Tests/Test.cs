using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Android;
using XamStore.XPlat.Tests.Pages;
using Autofac;
using System;

namespace XamStore.XPlat.Tests
{
	[TestFixture]
	public class OrderingTests
	{
		private IApp app;

		private const string IosPath = "/Users/Dan/Desktop/XamarinStoreiOS.app";
		private const string AndroidPath = "com.xamarin.XamStore.apk";

		private readonly TestPlatform executingPlatform = TestEnvironment.Platform;
		private readonly PagePlatform localPreference = PagePlatform.iOS;

	    private IMainPage mainPage;
		private IOptionsPage optionsPage;
		private IShippingPage shippingPage;

		private IContainer container;

		[SetUp]
		public void Setup()
		{
			var pagePlatform = Environment.GetPagePlatformFromEnvironment (executingPlatform, localPreference);

			app = Configure (pagePlatform);
			container = ContainerConfig.Configure (app, pagePlatform);

			mainPage = container.Resolve<IMainPage> ();
			optionsPage = container.Resolve<IOptionsPage> ();
			shippingPage = container.Resolve<IShippingPage> ();
		}

		private IApp Configure(PagePlatform platform)
		{
			switch (platform)
			{
				case PagePlatform.Android:
					return ConfigureApp.Android.ApiKey (ApiKey.Key).ApkFile (AndroidPath).StartApp ();
				case PagePlatform.iOS:
					return ConfigureApp.iOS.ApiKey (ApiKey.Key).AppBundle (IosPath).StartApp ();
				default:
					throw new ArgumentException ("Unsupported test platform (should be Android or iOS).");
			}
		}
			
		[Test]
		public void OrderingAShirt ()
		{
			app.Screenshot ("Given the app is running");

			app.Screenshot ("I select the Men's C# T-shirt");
			mainPage.SelectMensTShirt ();

			app.Screenshot ("Then I set the size to Medium");
			optionsPage.SelectTShirtSize ("Medium");

			app.Screenshot ("Then I set the color to Green");
			optionsPage.SelectTShirtColor ("Green");

			app.Screenshot ("And I add it to the cart");
			optionsPage.AddToCart ();

			app.Screenshot ("Then I go to my cart");
			mainPage.GoToCart ();

			app.Screenshot ("Then I check out");
			mainPage.Checkout ();

			//app.Screenshot ("Then I see my shipping information");
			//Assert.IsTrue (shippingPage.IsActive ());
		}
	}
}

