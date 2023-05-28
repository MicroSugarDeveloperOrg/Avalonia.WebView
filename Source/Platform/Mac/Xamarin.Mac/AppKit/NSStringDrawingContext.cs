using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSStringDrawingContext", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSStringDrawingContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActualScaleFactor = "actualScaleFactor";

	private static readonly IntPtr selActualScaleFactorHandle = Selector.GetHandle("actualScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumScaleFactor = "minimumScaleFactor";

	private static readonly IntPtr selMinimumScaleFactorHandle = Selector.GetHandle("minimumScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumScaleFactor_ = "setMinimumScaleFactor:";

	private static readonly IntPtr selSetMinimumScaleFactor_Handle = Selector.GetHandle("setMinimumScaleFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTotalBounds = "totalBounds";

	private static readonly IntPtr selTotalBoundsHandle = Selector.GetHandle("totalBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStringDrawingContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ActualScaleFactor
	{
		[Export("actualScaleFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selActualScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selActualScaleFactorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumScaleFactor
	{
		[Export("minimumScaleFactor", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumScaleFactorHandle);
		}
		[Export("setMinimumScaleFactor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumScaleFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumScaleFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect TotalBounds
	{
		[Export("totalBounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selTotalBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTotalBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStringDrawingContext()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSStringDrawingContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStringDrawingContext(IntPtr handle)
		: base(handle)
	{
	}
}
