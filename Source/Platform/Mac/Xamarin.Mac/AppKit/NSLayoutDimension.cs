using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutDimension", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSLayoutDimension : NSLayoutAnchor<NSLayoutDimension>
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintEqualToAnchor_Multiplier_ = "constraintEqualToAnchor:multiplier:";

	private static readonly IntPtr selConstraintEqualToAnchor_Multiplier_Handle = Selector.GetHandle("constraintEqualToAnchor:multiplier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintEqualToAnchor_Multiplier_Constant_ = "constraintEqualToAnchor:multiplier:constant:";

	private static readonly IntPtr selConstraintEqualToAnchor_Multiplier_Constant_Handle = Selector.GetHandle("constraintEqualToAnchor:multiplier:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintEqualToConstant_ = "constraintEqualToConstant:";

	private static readonly IntPtr selConstraintEqualToConstant_Handle = Selector.GetHandle("constraintEqualToConstant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintGreaterThanOrEqualToAnchor_Multiplier_ = "constraintGreaterThanOrEqualToAnchor:multiplier:";

	private static readonly IntPtr selConstraintGreaterThanOrEqualToAnchor_Multiplier_Handle = Selector.GetHandle("constraintGreaterThanOrEqualToAnchor:multiplier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintGreaterThanOrEqualToAnchor_Multiplier_Constant_ = "constraintGreaterThanOrEqualToAnchor:multiplier:constant:";

	private static readonly IntPtr selConstraintGreaterThanOrEqualToAnchor_Multiplier_Constant_Handle = Selector.GetHandle("constraintGreaterThanOrEqualToAnchor:multiplier:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintGreaterThanOrEqualToConstant_ = "constraintGreaterThanOrEqualToConstant:";

	private static readonly IntPtr selConstraintGreaterThanOrEqualToConstant_Handle = Selector.GetHandle("constraintGreaterThanOrEqualToConstant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintLessThanOrEqualToAnchor_Multiplier_ = "constraintLessThanOrEqualToAnchor:multiplier:";

	private static readonly IntPtr selConstraintLessThanOrEqualToAnchor_Multiplier_Handle = Selector.GetHandle("constraintLessThanOrEqualToAnchor:multiplier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintLessThanOrEqualToAnchor_Multiplier_Constant_ = "constraintLessThanOrEqualToAnchor:multiplier:constant:";

	private static readonly IntPtr selConstraintLessThanOrEqualToAnchor_Multiplier_Constant_Handle = Selector.GetHandle("constraintLessThanOrEqualToAnchor:multiplier:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintLessThanOrEqualToConstant_ = "constraintLessThanOrEqualToConstant:";

	private static readonly IntPtr selConstraintLessThanOrEqualToConstant_Handle = Selector.GetHandle("constraintLessThanOrEqualToConstant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLayoutDimension");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLayoutDimension(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSLayoutDimension(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutDimension(IntPtr handle)
		: base(handle)
	{
	}

	[Export("constraintEqualToAnchor:multiplier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintEqualToAnchor(NSLayoutDimension anchor, nfloat multiplier)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConstraintEqualToAnchor_Multiplier_Handle, anchor.Handle, multiplier));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConstraintEqualToAnchor_Multiplier_Handle, anchor.Handle, multiplier));
	}

	[Export("constraintEqualToAnchor:multiplier:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintEqualToAnchor(NSLayoutDimension anchor, nfloat multiplier, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_nfloat(base.Handle, selConstraintEqualToAnchor_Multiplier_Constant_Handle, anchor.Handle, multiplier, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_nfloat(base.SuperHandle, selConstraintEqualToAnchor_Multiplier_Constant_Handle, anchor.Handle, multiplier, constant));
	}

	[Export("constraintEqualToConstant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintEqualToConstant(nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selConstraintEqualToConstant_Handle, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selConstraintEqualToConstant_Handle, constant));
	}

	[Export("constraintGreaterThanOrEqualToAnchor:multiplier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualToAnchor(NSLayoutDimension anchor, nfloat multiplier)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConstraintGreaterThanOrEqualToAnchor_Multiplier_Handle, anchor.Handle, multiplier));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConstraintGreaterThanOrEqualToAnchor_Multiplier_Handle, anchor.Handle, multiplier));
	}

	[Export("constraintGreaterThanOrEqualToAnchor:multiplier:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualToAnchor(NSLayoutDimension anchor, nfloat multiplier, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_nfloat(base.Handle, selConstraintGreaterThanOrEqualToAnchor_Multiplier_Constant_Handle, anchor.Handle, multiplier, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_nfloat(base.SuperHandle, selConstraintGreaterThanOrEqualToAnchor_Multiplier_Constant_Handle, anchor.Handle, multiplier, constant));
	}

	[Export("constraintGreaterThanOrEqualToConstant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualToConstant(nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selConstraintGreaterThanOrEqualToConstant_Handle, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selConstraintGreaterThanOrEqualToConstant_Handle, constant));
	}

	[Export("constraintLessThanOrEqualToAnchor:multiplier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintLessThanOrEqualToAnchor(NSLayoutDimension anchor, nfloat multiplier)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConstraintLessThanOrEqualToAnchor_Multiplier_Handle, anchor.Handle, multiplier));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConstraintLessThanOrEqualToAnchor_Multiplier_Handle, anchor.Handle, multiplier));
	}

	[Export("constraintLessThanOrEqualToAnchor:multiplier:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintLessThanOrEqualToAnchor(NSLayoutDimension anchor, nfloat multiplier, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_nfloat(base.Handle, selConstraintLessThanOrEqualToAnchor_Multiplier_Constant_Handle, anchor.Handle, multiplier, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_nfloat(base.SuperHandle, selConstraintLessThanOrEqualToAnchor_Multiplier_Constant_Handle, anchor.Handle, multiplier, constant));
	}

	[Export("constraintLessThanOrEqualToConstant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintLessThanOrEqualToConstant(nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selConstraintLessThanOrEqualToConstant_Handle, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selConstraintLessThanOrEqualToConstant_Handle, constant));
	}
}
