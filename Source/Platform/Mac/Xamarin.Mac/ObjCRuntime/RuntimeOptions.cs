using System;
using System.IO;
using System.Net.Http;
using Foundation;

namespace ObjCRuntime;

internal class RuntimeOptions
{
	private const string HttpClientHandlerValue = "HttpClientHandler";

	private const string CFNetworkHandlerValue = "CFNetworkHandler";

	private const string NSUrlSessionHandlerValue = "NSUrlSessionHandler";

	private string http_message_handler;

	internal static RuntimeOptions Read()
	{
		Class c = new Class(typeof(NSObject.NSObject_Disposer));
		string resourcePath = NSBundle.FromClass(c).ResourcePath;
		string fileName = GetFileName(resourcePath);
		if (!File.Exists(fileName))
		{
			return null;
		}
		using NSDictionary nSDictionary = NSDictionary.FromFile(fileName);
		RuntimeOptions runtimeOptions = new RuntimeOptions();
		runtimeOptions.http_message_handler = (NSString)nSDictionary["HttpMessageHandler"];
		return runtimeOptions;
	}

	internal static HttpMessageHandler GetHttpMessageHandler()
	{
		string text = Read()?.http_message_handler;
		switch (text)
		{
		case "CFNetworkHandler":
			return new CFNetworkHandler();
		case "NSUrlSessionHandler":
			return new NSUrlSessionHandler();
		default:
			if (text != null && text != "HttpClientHandler")
			{
				Console.WriteLine(text + " is not a valid HttpMessageHandler, defaulting to System.Net.Http.HttpClientHandler");
			}
			return new HttpClientHandler();
		}
	}

	private RuntimeOptions()
	{
	}

	private static string GetFileName(string resource_dir)
	{
		return Path.Combine(resource_dir, "runtime-options.plist");
	}
}
