using System;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCloudSharingValidationWrapper : BaseWrapper, INSCloudSharingValidation, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSCloudSharingValidationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("cloudShareForUserInterfaceItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKShare? GetCloudShare(INSValidatedUserInterfaceItem item)
	{
		NSApplication.EnsureUIThread();
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return Runtime.GetNSObject<CKShare>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("cloudShareForUserInterfaceItem:"), item.Handle));
	}
}
