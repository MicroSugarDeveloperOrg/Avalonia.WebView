using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutAnchor", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSLayoutAnchor<AnchorType> : NSObject, INSCoding, INativeObject, IDisposable, INSCopying where AnchorType : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintEqualToAnchor_ = "constraintEqualToAnchor:";

	private static readonly IntPtr selConstraintEqualToAnchor_Handle = Selector.GetHandle("constraintEqualToAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintEqualToAnchor_Constant_ = "constraintEqualToAnchor:constant:";

	private static readonly IntPtr selConstraintEqualToAnchor_Constant_Handle = Selector.GetHandle("constraintEqualToAnchor:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintGreaterThanOrEqualToAnchor_ = "constraintGreaterThanOrEqualToAnchor:";

	private static readonly IntPtr selConstraintGreaterThanOrEqualToAnchor_Handle = Selector.GetHandle("constraintGreaterThanOrEqualToAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintGreaterThanOrEqualToAnchor_Constant_ = "constraintGreaterThanOrEqualToAnchor:constant:";

	private static readonly IntPtr selConstraintGreaterThanOrEqualToAnchor_Constant_Handle = Selector.GetHandle("constraintGreaterThanOrEqualToAnchor:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintLessThanOrEqualToAnchor_ = "constraintLessThanOrEqualToAnchor:";

	private static readonly IntPtr selConstraintLessThanOrEqualToAnchor_Handle = Selector.GetHandle("constraintLessThanOrEqualToAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintLessThanOrEqualToAnchor_Constant_ = "constraintLessThanOrEqualToAnchor:constant:";

	private static readonly IntPtr selConstraintLessThanOrEqualToAnchor_Constant_Handle = Selector.GetHandle("constraintLessThanOrEqualToAnchor:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintsAffectingLayout = "constraintsAffectingLayout";

	private static readonly IntPtr selConstraintsAffectingLayoutHandle = Selector.GetHandle("constraintsAffectingLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAmbiguousLayout = "hasAmbiguousLayout";

	private static readonly IntPtr selHasAmbiguousLayoutHandle = Selector.GetHandle("hasAmbiguousLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem = "item";

	private static readonly IntPtr selItemHandle = Selector.GetHandle("item");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLayoutAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Item_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSLayoutConstraint[] ConstraintsAffectingLayout
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("constraintsAffectingLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend(base.Handle, selConstraintsAffectingLayoutHandle));
			}
			return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConstraintsAffectingLayoutHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool HasAmbiguousLayout
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("hasAmbiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAmbiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAmbiguousLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSObject? Item
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("item", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selItemHandle)));
			MarkDirty();
			__mt_Item_var = nSObject;
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLayoutAnchor(NSCoder coder)
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
	protected NSLayoutAnchor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutAnchor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("constraintEqualToAnchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintEqualToAnchor(NSLayoutAnchor<AnchorType> anchor)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConstraintEqualToAnchor_Handle, anchor.Handle));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConstraintEqualToAnchor_Handle, anchor.Handle));
	}

	[Export("constraintEqualToAnchor:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintEqualToAnchor(NSLayoutAnchor<AnchorType> anchor, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConstraintEqualToAnchor_Constant_Handle, anchor.Handle, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConstraintEqualToAnchor_Constant_Handle, anchor.Handle, constant));
	}

	[Export("constraintGreaterThanOrEqualToAnchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualToAnchor(NSLayoutAnchor<AnchorType> anchor)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConstraintGreaterThanOrEqualToAnchor_Handle, anchor.Handle));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConstraintGreaterThanOrEqualToAnchor_Handle, anchor.Handle));
	}

	[Export("constraintGreaterThanOrEqualToAnchor:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintGreaterThanOrEqualToAnchor(NSLayoutAnchor<AnchorType> anchor, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConstraintGreaterThanOrEqualToAnchor_Constant_Handle, anchor.Handle, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConstraintGreaterThanOrEqualToAnchor_Constant_Handle, anchor.Handle, constant));
	}

	[Export("constraintLessThanOrEqualToAnchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintLessThanOrEqualToAnchor(NSLayoutAnchor<AnchorType> anchor)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConstraintLessThanOrEqualToAnchor_Handle, anchor.Handle));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConstraintLessThanOrEqualToAnchor_Handle, anchor.Handle));
	}

	[Export("constraintLessThanOrEqualToAnchor:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint ConstraintLessThanOrEqualToAnchor(NSLayoutAnchor<AnchorType> anchor, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (anchor == null)
		{
			throw new ArgumentNullException("anchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConstraintLessThanOrEqualToAnchor_Constant_Handle, anchor.Handle, constant));
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConstraintLessThanOrEqualToAnchor_Constant_Handle, anchor.Handle, constant));
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Item_var = null;
		}
	}
}
