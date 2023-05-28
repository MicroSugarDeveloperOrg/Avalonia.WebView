using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSOpenSavePanelDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldEnableUrl(this INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("panel:shouldEnableURL:"), panel.Handle, url.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ValidateUrl(this INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl url, out NSError? outError)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("panel:validateURL:error:"), panel.Handle, url.Handle, ref arg);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChangeToDirectory(this INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl newDirectoryUrl)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (newDirectoryUrl == null)
		{
			throw new ArgumentNullException("newDirectoryUrl");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("panel:didChangeToDirectoryURL:"), panel.Handle, newDirectoryUrl.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string UserEnteredFilename(this INSOpenSavePanelDelegate This, NSSavePanel panel, string filename, bool confirmed)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr intPtr = NSString.CreateNative(filename);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("panel:userEnteredFilename:confirmed:"), panel.Handle, intPtr, confirmed));
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillExpand(this INSOpenSavePanelDelegate This, NSSavePanel panel, bool expanding)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("panel:willExpand:"), panel.Handle, expanding);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SelectionDidChange(this INSOpenSavePanelDelegate This, NSSavePanel panel)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("panelSelectionDidChange:"), panel.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use ValidateUrl instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsValidFilename(this INSOpenSavePanelDelegate This, NSSavePanel panel, string fileName)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr intPtr = NSString.CreateNative(fileName);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("panel:isValidFilename:"), panel.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DidChangeToDirectory instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DirectoryDidChange(this INSOpenSavePanelDelegate This, NSSavePanel panel, string path)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = NSString.CreateNative(path);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("panel:directoryDidChange:"), panel.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "This method does not control sorting order.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSComparisonResult CompareFilenames(this INSOpenSavePanelDelegate This, NSSavePanel panel, string name1, string name2, bool caseSensitive)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (name1 == null)
		{
			throw new ArgumentNullException("name1");
		}
		if (name2 == null)
		{
			throw new ArgumentNullException("name2");
		}
		IntPtr intPtr = NSString.CreateNative(name1);
		IntPtr intPtr2 = NSString.CreateNative(name2);
		NSComparisonResult result = (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(This.Handle, Selector.GetHandle("panel:compareFilename:with:caseSensitive:"), panel.Handle, intPtr, intPtr2, caseSensitive);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use ShouldEnableUrl instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowFilename(this INSOpenSavePanelDelegate This, NSSavePanel panel, string filename)
	{
		NSApplication.EnsureUIThread();
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr intPtr = NSString.CreateNative(filename);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("panel:shouldShowFilename:"), panel.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
