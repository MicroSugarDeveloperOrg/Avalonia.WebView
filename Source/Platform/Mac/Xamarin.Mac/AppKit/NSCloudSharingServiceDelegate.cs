using System;
using System.ComponentModel;
using CloudKit;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSCloudSharingServiceDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSCloudSharingServiceDelegate : NSSharingServiceDelegate, INSCloudSharingServiceDelegate, INativeObject, IDisposable, INSSharingServiceDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCloudSharingServiceDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCloudSharingServiceDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCloudSharingServiceDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("sharingService:didCompleteForItems:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Completed(NSSharingService sharingService, NSObject[] items, NSError? error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("optionsForSharingService:shareProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCloudKitSharingServiceOptions Options(NSSharingService cloudKitSharingService, NSItemProvider provider)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:didSaveShare:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Saved(NSSharingService sharingService, CKShare share)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:didStopSharing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stopped(NSSharingService sharingService, CKShare share)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
