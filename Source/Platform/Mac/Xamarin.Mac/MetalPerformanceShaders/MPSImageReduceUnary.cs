using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageReduceUnary", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSImageReduceUnary : MPSUnaryImageKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClipRectSource = "clipRectSource";

	private static readonly IntPtr selClipRectSourceHandle = Selector.GetHandle("clipRectSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClipRectSource_ = "setClipRectSource:";

	private static readonly IntPtr selSetClipRectSource_Handle = Selector.GetHandle("setClipRectSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageReduceUnary");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRegion ClipRectSource
	{
		[Export("clipRectSource", ArgumentSemantic.Assign)]
		get
		{
			MTLRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLRegion_objc_msgSend_stret(out retval, base.Handle, selClipRectSourceHandle);
			}
			else
			{
				Messaging.MTLRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selClipRectSourceHandle);
			}
			return retval;
		}
		[Export("setClipRectSource:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLRegion(base.Handle, selSetClipRectSource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLRegion(base.SuperHandle, selSetClipRectSource_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageReduceUnary(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSImageReduceUnary(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageReduceUnary(IntPtr handle)
		: base(handle)
	{
	}
}
