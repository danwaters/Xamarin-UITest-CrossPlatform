using System;
using Autofac;
using XamStore.XPlat.Tests.Pages;
using XamStore.XPlat.Tests.Pages.iOS;
using XamStore.XPlat.Tests.Pages.Android;
using Xamarin.UITest;

namespace XamStore.XPlat.Tests
{
	public static class ContainerConfig
	{
		public static IContainer Configure (IApp app, PagePlatform pageObjectPlatform)
		{
			var builder = new ContainerBuilder ();
			builder.RegisterInstance(app).As<IApp> ().SingleInstance ();

			switch (pageObjectPlatform)
			{
				case PagePlatform.Android:
					RegisterPagesForAndroid (builder);
					break;
				case PagePlatform.iOS:
					RegisterPagesForiOS (builder);
					break;
				default:
					throw new ArgumentException ("Unsupported test platform (should be iOS or Android)");
			}

			return builder.Build ();
		}

		private static void RegisterPagesForAndroid(ContainerBuilder builder)
		{
			builder.RegisterType<MainPageAndroid> ().As<IMainPage> ().SingleInstance ();
			builder.RegisterType<OptionsPageAndroid> ().As<IOptionsPage> ().SingleInstance ();
			builder.RegisterType<ShippingPageAndroid> ().As<IShippingPage> ().SingleInstance ();		
		}

		private static void RegisterPagesForiOS(ContainerBuilder builder)
		{
			builder.RegisterType<MainPageiOS> ().As<IMainPage> ().SingleInstance ();
			builder.RegisterType<OptionsPageiOS> ().As<IOptionsPage> ().SingleInstance ();
			builder.RegisterType<ShippingPageiOS> ().As<IShippingPage> ().SingleInstance ();
		}
	}
}

