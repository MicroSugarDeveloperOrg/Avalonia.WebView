using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

internal sealed class PHProjectTypeDescriptionInvalidatorWrapper : BaseWrapper, IPHProjectTypeDescriptionInvalidator, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PHProjectTypeDescriptionInvalidatorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("invalidateTypeDescriptionForProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InvalidateTypeDescription(NSString projectType)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("invalidateTypeDescriptionForProjectType:"), projectType.Handle);
	}

	[Export("invalidateFooterTextForSubtypesOfProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InvalidateFooterTextForSubtypes(NSString projectType)
	{
		NSApplication.EnsureUIThread();
		if (projectType == null)
		{
			throw new ArgumentNullException("projectType");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("invalidateFooterTextForSubtypesOfProjectType:"), projectType.Handle);
	}
}
