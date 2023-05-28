using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

internal sealed class PHProjectTypeDescriptionDataSourceWrapper : BaseWrapper, IPHProjectTypeDescriptionDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PHProjectTypeDescriptionDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("subtypesForProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription[] GetSubtypes(NSString projectType)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		return NSArray.ArrayFromHandle<PHProjectTypeDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("subtypesForProjectType:"), projectType.Handle));
	}

	[Export("typeDescriptionForProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHProjectTypeDescription? GetTypeDescription(NSString projectType)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		return Runtime.GetNSObject<PHProjectTypeDescription>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("typeDescriptionForProjectType:"), projectType.Handle));
	}

	[Export("footerTextForSubtypesOfProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString? GetFooterTextForSubtypes(NSString projectType)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("footerTextForSubtypesOfProjectType:"), projectType.Handle));
	}
}
