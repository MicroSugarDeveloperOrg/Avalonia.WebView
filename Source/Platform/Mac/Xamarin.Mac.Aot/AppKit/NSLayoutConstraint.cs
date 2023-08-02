using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutConstraint", true)]
public class NSLayoutConstraint : NSObject
{
	private static readonly IntPtr selPriorityHandle = Selector.GetHandle("priority");

	private static readonly IntPtr selSetPriority_Handle = Selector.GetHandle("setPriority:");

	private static readonly IntPtr selShouldBeArchivedHandle = Selector.GetHandle("shouldBeArchived");

	private static readonly IntPtr selSetShouldBeArchived_Handle = Selector.GetHandle("setShouldBeArchived:");

	private static readonly IntPtr selFirstItemHandle = Selector.GetHandle("firstItem");

	private static readonly IntPtr selFirstAttributeHandle = Selector.GetHandle("firstAttribute");

	private static readonly IntPtr selRelationHandle = Selector.GetHandle("relation");

	private static readonly IntPtr selSecondItemHandle = Selector.GetHandle("secondItem");

	private static readonly IntPtr selSecondAttributeHandle = Selector.GetHandle("secondAttribute");

	private static readonly IntPtr selMultiplierHandle = Selector.GetHandle("multiplier");

	private static readonly IntPtr selConstantHandle = Selector.GetHandle("constant");

	private static readonly IntPtr selSetConstant_Handle = Selector.GetHandle("setConstant:");

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	private static readonly IntPtr selConstraintsWithVisualFormatOptionsMetricsViews_Handle = Selector.GetHandle("constraintsWithVisualFormat:options:metrics:views:");

	private static readonly IntPtr selConstraintWithItemAttributeRelatedByToItemAttributeMultiplierConstant_Handle = Selector.GetHandle("constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:");

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSLayoutConstraint");

	private object __mt_FirstItem_var;

	private object __mt_SecondItem_var;

	private object __mt_Animator_var;

	private object __mt_Animations_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual float Priority
	{
		[Export("priority")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPriorityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPriorityHandle);
		}
		[Export("setPriority:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPriority_Handle, value);
			}
		}
	}

	public virtual bool ShouldBeArchived
	{
		[Export("shouldBeArchived")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldBeArchivedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldBeArchivedHandle);
		}
		[Export("setShouldBeArchived:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldBeArchived_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldBeArchived_Handle, value);
			}
		}
	}

	public virtual NSObject FirstItem
	{
		[Export("firstItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_FirstItem_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstItemHandle))));
		}
	}

	public virtual NSLayoutAttribute FirstAttribute
	{
		[Export("firstAttribute")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLayoutAttribute)Messaging.Int64_objc_msgSend(base.Handle, selFirstAttributeHandle);
			}
			return (NSLayoutAttribute)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFirstAttributeHandle);
		}
	}

	public virtual NSLayoutRelation Relation
	{
		[Export("relation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLayoutRelation)Messaging.Int64_objc_msgSend(base.Handle, selRelationHandle);
			}
			return (NSLayoutRelation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRelationHandle);
		}
	}

	public virtual NSObject SecondItem
	{
		[Export("secondItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_SecondItem_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecondItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSecondItemHandle))));
		}
	}

	public virtual NSLayoutAttribute SecondAttribute
	{
		[Export("secondAttribute")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSLayoutAttribute)Messaging.Int64_objc_msgSend(base.Handle, selSecondAttributeHandle);
			}
			return (NSLayoutAttribute)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSecondAttributeHandle);
		}
	}

	public virtual double Multiplier
	{
		[Export("multiplier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMultiplierHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMultiplierHandle);
		}
	}

	public virtual double Constant
	{
		[Export("constant")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selConstantHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selConstantHandle);
		}
		[Export("setConstant:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetConstant_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetConstant_Handle, value);
			}
		}
	}

	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = (NSObject)(__mt_Animator_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle))));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_Animations_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle)))));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
			__mt_Animations_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutConstraint()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLayoutConstraint(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLayoutConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLayoutConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("constraintsWithVisualFormat:options:metrics:views:")]
	public static NSLayoutConstraint[] FromVisualFormat(string format, NSLayoutFormatOptions formatOptions, NSDictionary metrics, NSDictionary views)
	{
		NSApplication.EnsureUIThread();
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (views == null)
		{
			throw new ArgumentNullException("views");
		}
		IntPtr arg = NSString.CreateNative(format);
		NSLayoutConstraint[] result = NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selConstraintsWithVisualFormatOptionsMetricsViews_Handle, arg, (ulong)formatOptions, metrics?.Handle ?? IntPtr.Zero, views.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:")]
	public static NSLayoutConstraint Create(NSObject view1, NSLayoutAttribute attribute1, NSLayoutRelation relation, NSObject view2, NSLayoutAttribute attribute2, double multiplier, double constant)
	{
		NSApplication.EnsureUIThread();
		if (view1 == null)
		{
			throw new ArgumentNullException("view1");
		}
		return (NSLayoutConstraint)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_Int64_IntPtr_Int64_Double_Double(class_ptr, selConstraintWithItemAttributeRelatedByToItemAttributeMultiplierConstant_Handle, view1.Handle, (long)attribute1, (long)relation, view2?.Handle ?? IntPtr.Zero, (long)attribute2, multiplier, constant));
	}

	[Export("animationForKey:")]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("defaultAnimationForKey:")]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FirstItem_var = null;
			__mt_SecondItem_var = null;
			__mt_Animator_var = null;
			__mt_Animations_var = null;
		}
	}
}
