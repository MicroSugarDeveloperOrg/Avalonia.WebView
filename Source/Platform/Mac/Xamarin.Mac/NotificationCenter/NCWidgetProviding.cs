using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

[Protocol]
[Register("NCWidgetProviding", false)]
[Model]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NCWidgetProviding : NSObject, INCWidgetProviding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WidgetAllowsEditing
	{
		[Export("widgetAllowsEditing")]
		get
		{
			throw new ModelNotImplementedException();
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NCWidgetProviding()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NCWidgetProviding(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NCWidgetProviding(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("widgetMarginInsetsForProposedMarginInsets:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEdgeInsets GetWidgetMarginInsets(NSEdgeInsets defaultMarginInsets)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetDidBeginEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WidgetDidBeginEditing()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetDidEndEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WidgetDidEndEditing()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("widgetPerformUpdateWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WidgetPerformUpdate([BlockProxy(typeof(Trampolines.NIDActionArity1V69))] Action<NCUpdateResult> completionHandler)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
