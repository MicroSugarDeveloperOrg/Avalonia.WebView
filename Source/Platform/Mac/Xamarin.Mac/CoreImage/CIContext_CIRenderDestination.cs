using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public static class CIContext_CIRenderDestination
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareRender_FromRect_ToDestination_AtPoint_Error_ = "prepareRender:fromRect:toDestination:atPoint:error:";

	private static readonly IntPtr selPrepareRender_FromRect_ToDestination_AtPoint_Error_Handle = Selector.GetHandle("prepareRender:fromRect:toDestination:atPoint:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTaskToClear_Error_ = "startTaskToClear:error:";

	private static readonly IntPtr selStartTaskToClear_Error_Handle = Selector.GetHandle("startTaskToClear:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTaskToRender_FromRect_ToDestination_AtPoint_Error_ = "startTaskToRender:fromRect:toDestination:atPoint:error:";

	private static readonly IntPtr selStartTaskToRender_FromRect_ToDestination_AtPoint_Error_Handle = Selector.GetHandle("startTaskToRender:fromRect:toDestination:atPoint:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTaskToRender_ToDestination_Error_ = "startTaskToRender:toDestination:error:";

	private static readonly IntPtr selStartTaskToRender_ToDestination_Error_Handle = Selector.GetHandle("startTaskToRender:toDestination:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("CIContext");

	[Export("prepareRender:fromRect:toDestination:atPoint:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool PrepareRender(this CIContext This, CIImage image, CGRect fromRect, CIRenderDestination destination, CGPoint atPoint, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_CGPoint_ref_IntPtr(This.Handle, selPrepareRender_FromRect_ToDestination_AtPoint_Error_Handle, image.Handle, fromRect, destination.Handle, atPoint, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("startTaskToClear:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIRenderTask? StartTaskToClear(this CIContext This, CIRenderDestination destination, out NSError? error)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		IntPtr arg = IntPtr.Zero;
		CIRenderTask nSObject = Runtime.GetNSObject<CIRenderTask>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, selStartTaskToClear_Error_Handle, destination.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("startTaskToRender:fromRect:toDestination:atPoint:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIRenderTask? StartTaskToRender(this CIContext This, CIImage image, CGRect fromRect, CIRenderDestination destination, CGPoint atPoint, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		IntPtr arg = IntPtr.Zero;
		CIRenderTask nSObject = Runtime.GetNSObject<CIRenderTask>(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect_IntPtr_CGPoint_ref_IntPtr(This.Handle, selStartTaskToRender_FromRect_ToDestination_AtPoint_Error_Handle, image.Handle, fromRect, destination.Handle, atPoint, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("startTaskToRender:toDestination:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIRenderTask? StartTaskToRender(this CIContext This, CIImage image, CIRenderDestination destination, out NSError? error)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		IntPtr arg = IntPtr.Zero;
		CIRenderTask nSObject = Runtime.GetNSObject<CIRenderTask>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(This.Handle, selStartTaskToRender_ToDestination_Error_Handle, image.Handle, destination.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}
