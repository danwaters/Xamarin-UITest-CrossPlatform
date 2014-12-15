Cross-Platform Testing Example with Xamarin.UITest
============================

This sample uses the iOS and Android versions of the Xamarin Store app and a few key things to make cross platform testing easy.

* This example uses [Autofac IoC](http://www.autofac.org) to inject the IApp wherever needed. This prevents you from having to pass it all over the place. It also allows the test suite to configure itself for iOS or Android based on the current platform environment.
* Find ApiKey.cs and add your API key from the Xamarin Test Cloud Account Settings page.
* You can upload the exact same set of tests for the iOS app and the Android app without any code changes.
* In Test.cs there is a variable called _localPlatform_. Choose iOS or Android for your local development preference.
