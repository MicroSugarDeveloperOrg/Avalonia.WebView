using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol]
[Register("CALayerDelegate", false)]
[Model]
public class CALayerDelegate : NSObject, ICALayerDelegate, INativeObject, IDisposable
{
	private IntPtr calayer;

	internal void SetCALayer(CALayer layer)
	{
		calayer = layer?.Handle ?? IntPtr.Zero;
	}

	protected override void Dispose(bool disposing)
	{
		if (calayer != IntPtr.Zero)
		{
			Messaging.void_objc_msgSend_IntPtr(calayer, Selector.GetHandle("setDelegate:"), IntPtr.Zero);
		}
		base.Dispose(disposing);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CALayerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CALayerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CALayerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("actionForLayer:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ActionForLayer(CALayer layer, string eventKey)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("displayLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisplayLayer(CALayer layer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawLayer:inContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawLayer(CALayer layer, CGContext context)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutSublayersOfLayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LayoutSublayersOfLayer(CALayer layer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layerWillDraw:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDrawLayer(CALayer layer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
