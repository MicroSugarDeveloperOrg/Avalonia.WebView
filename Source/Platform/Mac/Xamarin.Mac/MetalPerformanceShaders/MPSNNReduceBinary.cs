using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNReduceBinary", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSNNReduceBinary : MPSCnnBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimarySourceClipRect = "primarySourceClipRect";

	private static readonly IntPtr selPrimarySourceClipRectHandle = Selector.GetHandle("primarySourceClipRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondarySourceClipRect = "secondarySourceClipRect";

	private static readonly IntPtr selSecondarySourceClipRectHandle = Selector.GetHandle("secondarySourceClipRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimarySourceClipRect_ = "setPrimarySourceClipRect:";

	private static readonly IntPtr selSetPrimarySourceClipRect_Handle = Selector.GetHandle("setPrimarySourceClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondarySourceClipRect_ = "setSecondarySourceClipRect:";

	private static readonly IntPtr selSetSecondarySourceClipRect_Handle = Selector.GetHandle("setSecondarySourceClipRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNReduceBinary");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRegion PrimarySourceClipRect
	{
		[Export("primarySourceClipRect", ArgumentSemantic.Assign)]
		get
		{
			MTLRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLRegion_objc_msgSend_stret(out retval, base.Handle, selPrimarySourceClipRectHandle);
			}
			else
			{
				Messaging.MTLRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPrimarySourceClipRectHandle);
			}
			return retval;
		}
		[Export("setPrimarySourceClipRect:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLRegion(base.Handle, selSetPrimarySourceClipRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLRegion(base.SuperHandle, selSetPrimarySourceClipRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRegion SecondarySourceClipRect
	{
		[Export("secondarySourceClipRect", ArgumentSemantic.Assign)]
		get
		{
			MTLRegion retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLRegion_objc_msgSend_stret(out retval, base.Handle, selSecondarySourceClipRectHandle);
			}
			else
			{
				Messaging.MTLRegion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSecondarySourceClipRectHandle);
			}
			return retval;
		}
		[Export("setSecondarySourceClipRect:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLRegion(base.Handle, selSetSecondarySourceClipRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLRegion(base.SuperHandle, selSetSecondarySourceClipRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNReduceBinary(NSCoder coder)
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
	protected MPSNNReduceBinary(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNReduceBinary(IntPtr handle)
		: base(handle)
	{
	}
}
