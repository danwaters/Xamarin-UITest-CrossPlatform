using System;
using Xamarin.UITest;

namespace XamStore.XPlat.Tests
{
	public static class Environment
	{
		public static PagePlatform GetPagePlatformFromEnvironment(TestPlatform testPlatform, PagePlatform localPreference)
		{
			if (testPlatform == TestPlatform.Local)			
				return localPreference;

			switch (testPlatform)
			{
				case TestPlatform.TestCloudAndroid:
					return PagePlatform.Android;
				case TestPlatform.TestCloudiOS:
					return PagePlatform.iOS;
				default:
					throw new ArgumentException ();
			}
		}
	}
}

