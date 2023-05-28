using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutConstraint", true)]
public class NSLayoutConstraint : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivateConstraints_ = "activateConstraints:";

	private static readonly IntPtr selActivateConstraints_Handle = Selector.GetHandle("activateConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimations = "animations";

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimator = "animator";

	private static readonly IntPtr selAnimatorHandle = Selector.GetHandle("animator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstant = "constant";

	private static readonly IntPtr selConstantHandle = Selector.GetHandle("constant");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintWithItem_Attribute_RelatedBy_ToItem_Attribute_Multiplier_Constant_ = "constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:";

	private static readonly IntPtr selConstraintWithItem_Attribute_RelatedBy_ToItem_Attribute_Multiplier_Constant_Handle = Selector.GetHandle("constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintsWithVisualFormat_Options_Metrics_Views_ = "constraintsWithVisualFormat:options:metrics:views:";

	private static readonly IntPtr selConstraintsWithVisualFormat_Options_Metrics_Views_Handle = Selector.GetHandle("constraintsWithVisualFormat:options:metrics:views:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeactivateConstraints_ = "deactivateConstraints:";

	private static readonly IntPtr selDeactivateConstraints_Handle = Selector.GetHandle("deactivateConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultAnimationForKey_ = "defaultAnimationForKey:";

	private static readonly IntPtr selDefaultAnimationForKey_Handle = Selector.GetHandle("defaultAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstAnchor = "firstAnchor";

	private static readonly IntPtr selFirstAnchorHandle = Selector.GetHandle("firstAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstAttribute = "firstAttribute";

	private static readonly IntPtr selFirstAttributeHandle = Selector.GetHandle("firstAttribute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstItem = "firstItem";

	private static readonly IntPtr selFirstItemHandle = Selector.GetHandle("firstItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsActive = "isActive";

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiplier = "multiplier";

	private static readonly IntPtr selMultiplierHandle = Selector.GetHandle("multiplier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPriority = "priority";

	private static readonly IntPtr selPriorityHandle = Selector.GetHandle("priority");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelation = "relation";

	private static readonly IntPtr selRelationHandle = Selector.GetHandle("relation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondAnchor = "secondAnchor";

	private static readonly IntPtr selSecondAnchorHandle = Selector.GetHandle("secondAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondAttribute = "secondAttribute";

	private static readonly IntPtr selSecondAttributeHandle = Selector.GetHandle("secondAttribute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondItem = "secondItem";

	private static readonly IntPtr selSecondItemHandle = Selector.GetHandle("secondItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActive_ = "setActive:";

	private static readonly IntPtr selSetActive_Handle = Selector.GetHandle("setActive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstant_ = "setConstant:";

	private static readonly IntPtr selSetConstant_Handle = Selector.GetHandle("setConstant:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPriority_ = "setPriority:";

	private static readonly IntPtr selSetPriority_Handle = Selector.GetHandle("setPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldBeArchived_ = "setShouldBeArchived:";

	private static readonly IntPtr selSetShouldBeArchived_Handle = Selector.GetHandle("setShouldBeArchived:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBeArchived = "shouldBeArchived";

	private static readonly IntPtr selShouldBeArchivedHandle = Selector.GetHandle("shouldBeArchived");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLayoutConstraint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_FirstItem_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_SecondItem_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool Active
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isActive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setActive:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetActive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetActive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Animations
	{
		[Export("animations")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle));
		}
		[Export("setAnimations:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Animator
	{
		[Export("animator")]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimatorHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimatorHandle)));
			nSObject.SetAsProxy();
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Constant
	{
		[Export("constant")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selConstantHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selConstantHandle);
		}
		[Export("setConstant:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetConstant_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetConstant_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSLayoutAnchor<NSObject> FirstAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("firstAnchor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutAnchor<NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutAnchor<NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutAttribute FirstAttribute
	{
		[Export("firstAttribute")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLayoutAttribute)Messaging.Int64_objc_msgSend(base.Handle, selFirstAttributeHandle);
			}
			return (NSLayoutAttribute)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFirstAttributeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject FirstItem
	{
		[Export("firstItem", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstItemHandle)));
			MarkDirty();
			__mt_FirstItem_var = nSObject;
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Multiplier
	{
		[Export("multiplier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMultiplierHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMultiplierHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Priority
	{
		[Export("priority")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPriorityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPriorityHandle);
		}
		[Export("setPriority:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPriority_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPriority_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutRelation Relation
	{
		[Export("relation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLayoutRelation)Messaging.Int64_objc_msgSend(base.Handle, selRelationHandle);
			}
			return (NSLayoutRelation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRelationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual NSLayoutAnchor<NSObject>? SecondAnchor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("secondAnchor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutAnchor<NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selSecondAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutAnchor<NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecondAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutAttribute SecondAttribute
	{
		[Export("secondAttribute")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLayoutAttribute)Messaging.Int64_objc_msgSend(base.Handle, selSecondAttributeHandle);
			}
			return (NSLayoutAttribute)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSecondAttributeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject SecondItem
	{
		[Export("secondItem", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecondItemHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSecondItemHandle)));
			MarkDirty();
			__mt_SecondItem_var = nSObject;
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBeArchived
	{
		[Export("shouldBeArchived")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldBeArchivedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldBeArchivedHandle);
		}
		[Export("setShouldBeArchived:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldBeArchived_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldBeArchived_Handle, value);
			}
		}
	}

	private static NSNumber AsNumber(object o)
	{
		if (o is NSNumber)
		{
			return (NSNumber)o;
		}
		if (o is double)
		{
			return new NSNumber((double)o);
		}
		if (o is int)
		{
			return new NSNumber((int)o);
		}
		if (o is float)
		{
			return new NSNumber((float)o);
		}
		if (o is long)
		{
			return new NSNumber((long)o);
		}
		if (o is uint)
		{
			return new NSNumber((uint)o);
		}
		if (o is ulong)
		{
			return new NSNumber((ulong)o);
		}
		if (o is byte)
		{
			return new NSNumber((byte)o);
		}
		if (o is sbyte)
		{
			return new NSNumber((sbyte)o);
		}
		if (o is ushort)
		{
			return new NSNumber((ushort)o);
		}
		if (o is short)
		{
			return new NSNumber((short)o);
		}
		if (o is nint)
		{
			return new NSNumber((nint)o);
		}
		if (o is nuint)
		{
			return new NSNumber((nuint)o);
		}
		if (o is nfloat)
		{
			return new NSNumber((nfloat)o);
		}
		return null;
	}

	public static NSLayoutConstraint[] FromVisualFormat(string format, NSLayoutFormatOptions formatOptions, params object[] viewsAndMetrics)
	{
		NSMutableDictionary nSMutableDictionary = null;
		NSMutableDictionary nSMutableDictionary2 = null;
		int num = viewsAndMetrics.Length;
		if (num != 0)
		{
			if (num % 2 != 0)
			{
				throw new ArgumentException("You should provide pairs and values, the parameter passed is not even", "viewsAndMetrics");
			}
			for (int i = 0; i < num; i += 2)
			{
				object obj = viewsAndMetrics[i];
				NSString nSString;
				if (obj is string)
				{
					nSString = new NSString((string)obj);
				}
				else
				{
					if (!(obj is NSString))
					{
						throw new ArgumentException($"Item at {i} is not a string or an NSString", "viewsAndMetrics");
					}
					nSString = (NSString)obj;
				}
				object obj2 = viewsAndMetrics[i + 1];
				if (obj2 is NSView)
				{
					if (nSMutableDictionary == null)
					{
						nSMutableDictionary = new NSMutableDictionary();
					}
					nSMutableDictionary[nSString] = (NSObject)obj2;
					continue;
				}
				if (obj2 is INativeObject && Messaging.bool_objc_msgSend_IntPtr(((INativeObject)obj2).Handle, Selector.GetHandle("isKindOfClass:"), ObjCRuntime.Class.GetHandle(typeof(NSView))))
				{
					if (nSMutableDictionary == null)
					{
						nSMutableDictionary = new NSMutableDictionary();
					}
					nSMutableDictionary.LowlevelSetObject(((INativeObject)obj2).Handle, nSString.Handle);
					continue;
				}
				NSNumber nSNumber = AsNumber(obj2);
				if (nSNumber == null)
				{
					throw new ArgumentException($"Item at {i + 1} is not a number or a view", "viewsAndMetrics");
				}
				if (nSMutableDictionary2 == null)
				{
					nSMutableDictionary2 = new NSMutableDictionary();
				}
				nSMutableDictionary2[nSString] = nSNumber;
			}
		}
		if (nSMutableDictionary == null)
		{
			throw new ArgumentException("You should at least provide a pair of name, view", "viewAndMetrics");
		}
		return FromVisualFormat(format, formatOptions, nSMutableDictionary2, nSMutableDictionary);
	}

	public static NSLayoutConstraint Create(NSObject view1, NSLayoutAttribute attribute1, NSLayoutRelation relation, nfloat multiplier, nfloat constant)
	{
		return Create(view1, attribute1, relation, null, NSLayoutAttribute.NoAttribute, multiplier, constant);
	}

	public static NSLayoutConstraint Create(NSObject view1, NSLayoutAttribute attribute1, NSLayoutRelation relation)
	{
		return Create(view1, attribute1, relation, null, NSLayoutAttribute.NoAttribute, 1f, 0f);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutConstraint()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSLayoutConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("activateConstraints:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ActivateConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selActivateConstraints_Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("animationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject AnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("constraintWithItem:attribute:relatedBy:toItem:attribute:multiplier:constant:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLayoutConstraint Create(NSObject view1, NSLayoutAttribute attribute1, NSLayoutRelation relation, NSObject? view2, NSLayoutAttribute attribute2, nfloat multiplier, nfloat constant)
	{
		NSApplication.EnsureUIThread();
		if (view1 == null)
		{
			throw new ArgumentNullException("view1");
		}
		return Runtime.GetNSObject<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_Int64_IntPtr_Int64_nfloat_nfloat(class_ptr, selConstraintWithItem_Attribute_RelatedBy_ToItem_Attribute_Multiplier_Constant_Handle, view1.Handle, (long)attribute1, (long)relation, view2?.Handle ?? IntPtr.Zero, (long)attribute2, multiplier, constant));
	}

	[Export("deactivateConstraints:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeactivateConstraints(NSLayoutConstraint[] constraints)
	{
		NSApplication.EnsureUIThread();
		if (constraints == null)
		{
			throw new ArgumentNullException("constraints");
		}
		NSArray nSArray = NSArray.FromNSObjects(constraints);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selDeactivateConstraints_Handle, nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("defaultAnimationForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject DefaultAnimationFor(NSString key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDefaultAnimationForKey_Handle, key.Handle));
	}

	[Export("constraintsWithVisualFormat:options:metrics:views:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLayoutConstraint[] FromVisualFormat(string format, NSLayoutFormatOptions formatOptions, NSDictionary? metrics, NSDictionary views)
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
		NSLayoutConstraint[] result = NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selConstraintsWithVisualFormat_Options_Metrics_Views_Handle, arg, (ulong)formatOptions, metrics?.Handle ?? IntPtr.Zero, views.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FirstItem_var = null;
			__mt_SecondItem_var = null;
		}
	}
}
