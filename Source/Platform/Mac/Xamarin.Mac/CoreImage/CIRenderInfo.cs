using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIRenderInfo", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIRenderInfo : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelExecutionTime = "kernelExecutionTime";

	private static readonly IntPtr selKernelExecutionTimeHandle = Selector.GetHandle("kernelExecutionTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPassCount = "passCount";

	private static readonly IntPtr selPassCountHandle = Selector.GetHandle("passCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelsProcessed = "pixelsProcessed";

	private static readonly IntPtr selPixelsProcessedHandle = Selector.GetHandle("pixelsProcessed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIRenderInfo");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double KernelExecutionTime
	{
		[Export("kernelExecutionTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selKernelExecutionTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selKernelExecutionTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PassCount
	{
		[Export("passCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPassCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPassCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PixelsProcessed
	{
		[Export("pixelsProcessed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPixelsProcessedHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPixelsProcessedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIRenderInfo(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIRenderInfo(IntPtr handle)
		: base(handle)
	{
	}
}
