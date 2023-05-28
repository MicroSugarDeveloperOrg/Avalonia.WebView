using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSharingServicePickerDelegate", false)]
[Model]
public class NSSharingServicePickerDelegate : NSObject, INSSharingServicePickerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingServicePickerDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSharingServicePickerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSharingServicePickerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("sharingServicePicker:delegateForSharingService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSSharingServiceDelegate DelegateForSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService sharingService)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingServicePicker:didChooseSharingService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChooseSharingService(NSSharingServicePicker sharingServicePicker, NSSharingService service)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingServicePicker:sharingServicesForItems:proposedSharingServices:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSharingService[] SharingServicesForItems(NSSharingServicePicker sharingServicePicker, NSObject[] items, NSSharingService[] proposedServices)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
