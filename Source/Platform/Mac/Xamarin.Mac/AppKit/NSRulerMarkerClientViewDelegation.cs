using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSRulerMarkerClientViewDelegation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_LocationForPoint_ = "rulerView:locationForPoint:";

	private static readonly IntPtr selRulerView_LocationForPoint_Handle = Selector.GetHandle("rulerView:locationForPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerView_PointForLocation_ = "rulerView:pointForLocation:";

	private static readonly IntPtr selRulerView_PointForLocation_Handle = Selector.GetHandle("rulerView:pointForLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSView");

	[Export("rulerView:locationForPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nfloat RulerViewLocation(this NSView This, NSRulerView ruler, CGPoint locationForPoint)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		return Messaging.nfloat_objc_msgSend_IntPtr_CGPoint(This.Handle, selRulerView_LocationForPoint_Handle, ruler.Handle, locationForPoint);
	}

	[Export("rulerView:pointForLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGPoint RulerViewPoint(this NSView This, NSRulerView ruler, nfloat pointForLocation)
	{
		NSApplication.EnsureUIThread();
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		return Messaging.CGPoint_objc_msgSend_IntPtr_nfloat(This.Handle, selRulerView_PointForLocation_Handle, ruler.Handle, pointForLocation);
	}
}
