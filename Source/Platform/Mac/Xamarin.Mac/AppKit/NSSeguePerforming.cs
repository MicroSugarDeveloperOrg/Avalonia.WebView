using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSeguePerforming", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSSeguePerforming : NSObject, INSSeguePerforming, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSeguePerforming()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSeguePerforming(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSeguePerforming(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("performSegueWithIdentifier:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformSegue(string identifier, NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("prepareForSegue:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForSegue(NSStoryboardSegue segue, NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("shouldPerformSegueWithIdentifier:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldPerformSegue(string identifier, NSObject sender)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
