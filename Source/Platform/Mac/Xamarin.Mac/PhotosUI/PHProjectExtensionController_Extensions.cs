using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

public static class PHProjectExtensionController_Extensions
{
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHProjectTypeDescription[] GetSupportedProjectTypes(this IPHProjectExtensionController This)
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<PHProjectTypeDescription>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("supportedProjectTypes")));
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IPHProjectTypeDescriptionDataSource GetTypeDescriptionDataSource(this IPHProjectExtensionController This, NSString category, IPHProjectTypeDescriptionInvalidator invalidator)
	{
		NSApplication.EnsureUIThread();
		if (category == null)
		{
			throw new ArgumentNullException("category");
		}
		if (invalidator == null)
		{
			throw new ArgumentNullException("invalidator");
		}
		return Runtime.GetINativeObject<IPHProjectTypeDescriptionDataSource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("typeDescriptionDataSourceForCategory:invalidator:"), category.Handle, invalidator.Handle), owns: false);
	}
}
