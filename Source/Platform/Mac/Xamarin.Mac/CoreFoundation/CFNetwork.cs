using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public static class CFNetwork
{
	private delegate void CFProxyAutoConfigurationResultCallbackInternal(IntPtr client, IntPtr proxyList, IntPtr error);

	private delegate IntPtr CreatePACCFRunLoopSource(CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext context);

	private struct PACProxyCallbackData
	{
		public IntPtr ProxyListPtr;

		public IntPtr ErrorPtr;

		public IntPtr CFRunLoopPtr;

		public CFProxy[] ProxyList
		{
			get
			{
				if (ProxyListPtr != IntPtr.Zero)
				{
					return ParseProxies(ProxyListPtr);
				}
				return null;
			}
		}

		public NSError Error
		{
			get
			{
				if (ErrorPtr != IntPtr.Zero)
				{
					return Runtime.GetNSObject<NSError>(ErrorPtr);
				}
				return null;
			}
		}
	}

	private class CFWebProxy : IWebProxy
	{
		private ICredentials credentials;

		private bool userSpecified;

		public ICredentials Credentials
		{
			get
			{
				return credentials;
			}
			set
			{
				userSpecified = true;
				credentials = value;
			}
		}

		private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials)
		{
			string text;
			switch (proxy.ProxyType)
			{
			case CFProxyType.FTP:
				text = "ftp://";
				break;
			case CFProxyType.HTTP:
			case CFProxyType.HTTPS:
				text = "http://";
				break;
			default:
				credentials = null;
				return null;
			}
			string username = proxy.Username;
			string password = proxy.Password;
			string hostName = proxy.HostName;
			int port = proxy.Port;
			if (username != null)
			{
				credentials = new NetworkCredential(username, password);
			}
			else
			{
				credentials = null;
			}
			string uriString = text + hostName + ((port != 0) ? (":" + port) : string.Empty);
			return new Uri(uriString, UriKind.Absolute);
		}

		private static Uri GetProxyUriFromScript(NSString script, Uri targetUri, out NetworkCredential credentials)
		{
			CFProxy[] proxiesForAutoConfigurationScript = GetProxiesForAutoConfigurationScript(script, targetUri);
			if (proxiesForAutoConfigurationScript == null)
			{
				credentials = null;
				return targetUri;
			}
			for (int i = 0; i < proxiesForAutoConfigurationScript.Length; i++)
			{
				switch (proxiesForAutoConfigurationScript[i].ProxyType)
				{
				case CFProxyType.FTP:
				case CFProxyType.HTTP:
				case CFProxyType.HTTPS:
					return GetProxyUri(proxiesForAutoConfigurationScript[i], out credentials);
				case CFProxyType.None:
					credentials = null;
					return targetUri;
				}
			}
			credentials = null;
			return null;
		}

		public Uri GetProxy(Uri targetUri)
		{
			NetworkCredential networkCredential = null;
			Uri uri = null;
			if (targetUri == null)
			{
				throw new ArgumentNullException("targetUri");
			}
			try
			{
				CFProxySettings systemProxySettings = GetSystemProxySettings();
				CFProxy[] proxiesForUri = GetProxiesForUri(targetUri, systemProxySettings);
				if (proxiesForUri != null)
				{
					for (int i = 0; i < proxiesForUri.Length; i++)
					{
						if (!(uri == null))
						{
							break;
						}
						switch (proxiesForUri[i].ProxyType)
						{
						case CFProxyType.AutoConfigurationJavaScript:
							uri = GetProxyUriFromScript(proxiesForUri[i].AutoConfigurationJavaScript, targetUri, out networkCredential);
							break;
						case CFProxyType.FTP:
						case CFProxyType.HTTP:
						case CFProxyType.HTTPS:
							uri = GetProxyUri(proxiesForUri[i], out networkCredential);
							break;
						case CFProxyType.None:
							uri = targetUri;
							break;
						}
					}
					if (uri == null)
					{
						uri = targetUri;
					}
				}
				else
				{
					uri = targetUri;
				}
			}
			catch
			{
				uri = targetUri;
			}
			if (!userSpecified)
			{
				credentials = networkCredential;
			}
			return uri;
		}

		public bool IsBypassed(Uri targetUri)
		{
			if (targetUri == null)
			{
				throw new ArgumentNullException("targetUri");
			}
			return GetProxy(targetUri) == targetUri;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[Field("kCFErrorDomainCFNetwork", "CFNetwork")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFErrorDomainCFNetwork");
			}
			return _ErrorDomain;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error);

	private static NSArray CopyProxiesForAutoConfigurationScript(NSString proxyAutoConfigurationScript, NSUrl targetURL)
	{
		IntPtr error;
		IntPtr intPtr = CFNetworkCopyProxiesForAutoConfigurationScript(proxyAutoConfigurationScript.Handle, targetURL.Handle, out error);
		return (intPtr == IntPtr.Zero) ? null : new NSArray(intPtr);
	}

	public static CFProxy[] GetProxiesForAutoConfigurationScript(NSString proxyAutoConfigurationScript, NSUrl targetURL)
	{
		if (proxyAutoConfigurationScript == null)
		{
			throw new ArgumentNullException("proxyAutoConfigurationScript");
		}
		if (targetURL == null)
		{
			throw new ArgumentNullException("targetURL");
		}
		using NSArray nSArray = CopyProxiesForAutoConfigurationScript(proxyAutoConfigurationScript, targetURL);
		if (nSArray == null)
		{
			return null;
		}
		NSDictionary[] array = NSArray.ArrayFromHandle<NSDictionary>(nSArray.Handle);
		if (array == null)
		{
			return null;
		}
		CFProxy[] array2 = new CFProxy[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = new CFProxy(array[i]);
		}
		return array2;
	}

	public static CFProxy[] GetProxiesForAutoConfigurationScript(NSString proxyAutoConfigurationScript, Uri targetUri)
	{
		if (targetUri == null)
		{
			throw new ArgumentNullException("targetUri");
		}
		using NSUrl targetURL = NSUrl.FromString(targetUri.AbsoluteUri);
		return GetProxiesForAutoConfigurationScript(proxyAutoConfigurationScript, targetURL);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings);

	private static NSArray CopyProxiesForURL(NSUrl url, NSDictionary proxySettings)
	{
		IntPtr intPtr = CFNetworkCopyProxiesForURL(url.Handle, proxySettings.Handle);
		return (intPtr == IntPtr.Zero) ? null : new NSArray(intPtr);
	}

	public static CFProxy[] GetProxiesForURL(NSUrl url, CFProxySettings proxySettings)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (proxySettings == null)
		{
			proxySettings = GetSystemProxySettings();
		}
		using NSArray nSArray = CopyProxiesForURL(url, proxySettings.Dictionary);
		if (nSArray == null)
		{
			return null;
		}
		NSDictionary[] array = NSArray.ArrayFromHandle<NSDictionary>(nSArray.Handle);
		if (array == null)
		{
			return null;
		}
		CFProxy[] array2 = new CFProxy[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = new CFProxy(array[i]);
		}
		return array2;
	}

	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		using NSUrl url = NSUrl.FromString(uri.AbsoluteUri);
		return GetProxiesForURL(url, proxySettings);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFNetworkCopySystemProxySettings();

	public static CFProxySettings GetSystemProxySettings()
	{
		IntPtr intPtr = CFNetworkCopySystemProxySettings();
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		NSDictionary nSDictionary = new NSDictionary(intPtr);
		nSDictionary.DangerousRelease();
		return new CFProxySettings(nSDictionary);
	}

	private static CFProxy[] ParseProxies(IntPtr proxyList)
	{
		CFProxy[] array = null;
		if (proxyList != IntPtr.Zero)
		{
			using CFArray cFArray = new CFArray(proxyList, owns: false);
			array = new CFProxy[(long)cFArray.Count];
			for (int i = 0; i < array.Length; i++)
			{
				NSDictionary nSObject = Runtime.GetNSObject<NSDictionary>(cFArray.GetValue(i));
				array[i] = new CFProxy(nSObject);
			}
		}
		return array;
	}

	[MonoPInvokeCallback(typeof(CFProxyAutoConfigurationResultCallbackInternal))]
	private static void ExecutePacCallback(IntPtr client, IntPtr proxyList, IntPtr error)
	{
		PACProxyCallbackData structure = (PACProxyCallbackData)Marshal.PtrToStructure(client, typeof(PACProxyCallbackData));
		if (proxyList != IntPtr.Zero)
		{
			CFObject.CFRetain(proxyList);
			structure.ProxyListPtr = proxyList;
		}
		if (error != IntPtr.Zero)
		{
			NSObject.DangerousRetain(error);
			structure.ErrorPtr = error;
		}
		CFRunLoop cFRunLoop = new CFRunLoop(structure.CFRunLoopPtr);
		Marshal.StructureToPtr(structure, client, fDeleteOld: false);
		cFRunLoop.Stop();
	}

	private static async Task<(CFProxy[] proxies, NSError error)> ExecutePacCFRunLoopSourceAsync(CreatePACCFRunLoopSource factory, CancellationToken cancellationToken)
	{
		CFProxy[] proxies = null;
		NSError outError = null;
		if (cancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException("Operation was cancelled.");
		}
		await Task.Run(delegate
		{
			CFRunLoop runLoop = CFRunLoop.Current;
			PACProxyCallbackData structure = default(PACProxyCallbackData);
			structure.CFRunLoopPtr = runLoop.Handle;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
			try
			{
				Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
				CFStreamClientContext context = default(CFStreamClientContext);
				context.Info = intPtr;
				CFRunLoopSource loopSource = new CFRunLoopSource(factory(ExecutePacCallback, ref context));
				try
				{
					NSString mode = new NSString("Xamarin.iOS.Proxy");
					try
					{
						if (cancellationToken.IsCancellationRequested)
						{
							throw new OperationCanceledException("Operation was cancelled.");
						}
						cancellationToken.Register(delegate
						{
							loopSource.Invalidate();
							runLoop.RemoveSource(loopSource, mode);
							runLoop.Stop();
						});
						runLoop.AddSource(loopSource, mode);
						runLoop.RunInMode(mode, double.MaxValue, returnAfterSourceHandled: false);
						runLoop.RemoveSource(loopSource, mode);
					}
					finally
					{
						if ((object)mode != null)
						{
							((IDisposable)mode).Dispose();
						}
					}
				}
				finally
				{
					if (loopSource != null)
					{
						((IDisposable)loopSource).Dispose();
					}
				}
				if (cancellationToken.IsCancellationRequested)
				{
					throw new OperationCanceledException("Operation was cancelled.");
				}
				structure = (PACProxyCallbackData)Marshal.PtrToStructure(intPtr, typeof(PACProxyCallbackData));
				proxies = structure.ProxyList;
				outError = structure.Error;
			}
			finally
			{
				if (structure.ProxyListPtr != IntPtr.Zero)
				{
					CFObject.CFRelease(structure.ProxyListPtr);
				}
				if (structure.ErrorPtr != IntPtr.Zero)
				{
					NSObject.DangerousRelease(structure.ErrorPtr);
				}
				Marshal.FreeHGlobal(intPtr);
			}
		}, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (cancellationToken.IsCancellationRequested)
		{
			throw new OperationCanceledException("Operation was cancelled.");
		}
		return (proxies, outError);
	}

	private static CFProxy[] ExecutePacCFRunLoopSourceBlocking(CreatePACCFRunLoopSource factory, out NSError outError)
	{
		CFRunLoop current = CFRunLoop.Current;
		outError = null;
		PACProxyCallbackData structure = default(PACProxyCallbackData);
		structure.CFRunLoopPtr = current.Handle;
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
		try
		{
			Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
			CFStreamClientContext context = default(CFStreamClientContext);
			context.Info = intPtr;
			using (CFRunLoopSource source = new CFRunLoopSource(factory(ExecutePacCallback, ref context)))
			{
				using NSString mode = new NSString("Xamarin.iOS.Proxy");
				current.AddSource(source, mode);
				current.RunInMode(mode, double.MaxValue, returnAfterSourceHandled: false);
				current.RemoveSource(source, mode);
			}
			structure = (PACProxyCallbackData)Marshal.PtrToStructure(intPtr, typeof(PACProxyCallbackData));
			outError = structure.Error;
			return structure.ProxyList;
		}
		finally
		{
			if (structure.ProxyListPtr != IntPtr.Zero)
			{
				CFObject.CFRelease(structure.ProxyListPtr);
			}
			if (structure.ErrorPtr != IntPtr.Zero)
			{
				NSObject.DangerousRelease(structure.ErrorPtr);
			}
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext clientContext);

	public static CFProxy[] ExecuteProxyAutoConfigurationScript(string proxyAutoConfigurationScript, Uri targetUrl, out NSError outError)
	{
		outError = null;
		if (proxyAutoConfigurationScript == null)
		{
			throw new ArgumentNullException("proxyAutoConfigurationScript");
		}
		if (targetUrl == null)
		{
			throw new ArgumentNullException("targetUrl");
		}
		NSString pacScript = new NSString(proxyAutoConfigurationScript);
		try
		{
			NSUrl url = new NSUrl(targetUrl.AbsoluteUri);
			try
			{
				CreatePACCFRunLoopSource factory = delegate(CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext context)
				{
					return CFNetworkExecuteProxyAutoConfigurationScript(pacScript.Handle, url.Handle, cb, ref context);
				};
				return ExecutePacCFRunLoopSourceBlocking(factory, out outError);
			}
			finally
			{
				if ((object)url != null)
				{
					((IDisposable)url).Dispose();
				}
			}
		}
		finally
		{
			if ((object)pacScript != null)
			{
				((IDisposable)pacScript).Dispose();
			}
		}
	}

	public static async Task<(CFProxy[] proxies, NSError error)> ExecuteProxyAutoConfigurationScriptAsync(string proxyAutoConfigurationScript, Uri targetUrl, CancellationToken cancellationToken)
	{
		if (proxyAutoConfigurationScript == null)
		{
			throw new ArgumentNullException("proxyAutoConfigurationScript");
		}
		if (targetUrl == null)
		{
			throw new ArgumentNullException("targetUrl");
		}
		NSString pacScript = new NSString(proxyAutoConfigurationScript);
		try
		{
			NSUrl url = new NSUrl(targetUrl.AbsoluteUri);
			try
			{
				CreatePACCFRunLoopSource factory = delegate(CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext context)
				{
					return CFNetworkExecuteProxyAutoConfigurationScript(pacScript.Handle, url.Handle, cb, ref context);
				};
				return await ExecutePacCFRunLoopSourceAsync(factory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			finally
			{
				if ((object)url != null)
				{
					((IDisposable)url).Dispose();
				}
			}
		}
		finally
		{
			if ((object)pacScript != null)
			{
				((IDisposable)pacScript).Dispose();
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigurationURL, IntPtr targetURL, CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext clientContext);

	public static CFProxy[] ExecuteProxyAutoConfigurationUrl(Uri proxyAutoConfigurationUrl, Uri targetUrl, out NSError outError)
	{
		outError = null;
		if (proxyAutoConfigurationUrl == null)
		{
			throw new ArgumentNullException("proxyAutoConfigurationUrl");
		}
		if (targetUrl == null)
		{
			throw new ArgumentNullException("targetUrl");
		}
		NSUrl pacUrl = new NSUrl(proxyAutoConfigurationUrl.AbsoluteUri);
		try
		{
			NSUrl url = new NSUrl(targetUrl.AbsoluteUri);
			try
			{
				CreatePACCFRunLoopSource factory = delegate(CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext context)
				{
					return CFNetworkExecuteProxyAutoConfigurationURL(pacUrl.Handle, url.Handle, cb, ref context);
				};
				return ExecutePacCFRunLoopSourceBlocking(factory, out outError);
			}
			finally
			{
				if ((object)url != null)
				{
					((IDisposable)url).Dispose();
				}
			}
		}
		finally
		{
			if ((object)pacUrl != null)
			{
				((IDisposable)pacUrl).Dispose();
			}
		}
	}

	public static async Task<(CFProxy[] proxies, NSError error)> ExecuteProxyAutoConfigurationUrlAsync(Uri proxyAutoConfigurationUrl, Uri targetUrl, CancellationToken cancellationToken)
	{
		if (proxyAutoConfigurationUrl == null)
		{
			throw new ArgumentNullException("proxyAutoConfigurationUrl");
		}
		if (targetUrl == null)
		{
			throw new ArgumentNullException("targetUrl");
		}
		NSUrl pacUrl = new NSUrl(proxyAutoConfigurationUrl.AbsoluteUri);
		try
		{
			NSUrl url = new NSUrl(targetUrl.AbsoluteUri);
			try
			{
				CreatePACCFRunLoopSource factory = delegate(CFProxyAutoConfigurationResultCallbackInternal cb, ref CFStreamClientContext context)
				{
					return CFNetworkExecuteProxyAutoConfigurationURL(pacUrl.Handle, url.Handle, cb, ref context);
				};
				return await ExecutePacCFRunLoopSourceAsync(factory, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			finally
			{
				if ((object)url != null)
				{
					((IDisposable)url).Dispose();
				}
			}
		}
		finally
		{
			if ((object)pacUrl != null)
			{
				((IDisposable)pacUrl).Dispose();
			}
		}
	}

	public static IWebProxy GetDefaultProxy()
	{
		return new CFWebProxy();
	}
}
