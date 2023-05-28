using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIRenderTask", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIRenderTask : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitUntilCompletedAndReturnError_ = "waitUntilCompletedAndReturnError:";

	private static readonly IntPtr selWaitUntilCompletedAndReturnError_Handle = Selector.GetHandle("waitUntilCompletedAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIRenderTask");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIRenderTask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIRenderTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("waitUntilCompletedAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIRenderInfo? WaitUntilCompleted(out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		CIRenderInfo result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIRenderInfo>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selWaitUntilCompletedAndReturnError_Handle, ref arg)) : Runtime.GetNSObject<CIRenderInfo>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selWaitUntilCompletedAndReturnError_Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
