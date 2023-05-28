using System;
using AppKit;
using ObjCRuntime;

namespace WebKit;

public static class WebDownloadDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWindow OnDownloadWindowForSheet(this IWebDownloadDelegate This, WebDownload download)
	{
		if (download == null)
		{
			throw new ArgumentNullException("download");
		}
		return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("downloadWindowForAuthenticationSheet:"), download.Handle));
	}
}
