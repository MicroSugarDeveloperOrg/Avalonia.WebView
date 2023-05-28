using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNImageTranslationAlignmentObservation", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNImageTranslationAlignmentObservation : VNImageAlignmentObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentTransform = "alignmentTransform";

	private static readonly IntPtr selAlignmentTransformHandle = Selector.GetHandle("alignmentTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignmentTransform_ = "setAlignmentTransform:";

	private static readonly IntPtr selSetAlignmentTransform_Handle = Selector.GetHandle("setAlignmentTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNImageTranslationAlignmentObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform AlignmentTransform
	{
		[Export("alignmentTransform", ArgumentSemantic.Assign)]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selAlignmentTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAlignmentTransformHandle);
			}
			return retval;
		}
		[Export("setAlignmentTransform:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetAlignmentTransform_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetAlignmentTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNImageTranslationAlignmentObservation(NSCoder coder)
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
	protected VNImageTranslationAlignmentObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNImageTranslationAlignmentObservation(IntPtr handle)
		: base(handle)
	{
	}
}
