using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAConstraint", true)]
public class CAConstraint : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttribute = "attribute";

	private static readonly IntPtr selAttributeHandle = Selector.GetHandle("attribute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintWithAttribute_RelativeTo_Attribute_ = "constraintWithAttribute:relativeTo:attribute:";

	private static readonly IntPtr selConstraintWithAttribute_RelativeTo_Attribute_Handle = Selector.GetHandle("constraintWithAttribute:relativeTo:attribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintWithAttribute_RelativeTo_Attribute_Offset_ = "constraintWithAttribute:relativeTo:attribute:offset:";

	private static readonly IntPtr selConstraintWithAttribute_RelativeTo_Attribute_Offset_Handle = Selector.GetHandle("constraintWithAttribute:relativeTo:attribute:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintWithAttribute_RelativeTo_Attribute_Scale_Offset_ = "constraintWithAttribute:relativeTo:attribute:scale:offset:";

	private static readonly IntPtr selConstraintWithAttribute_RelativeTo_Attribute_Scale_Offset_Handle = Selector.GetHandle("constraintWithAttribute:relativeTo:attribute:scale:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAttribute_RelativeTo_Attribute_Scale_Offset_ = "initWithAttribute:relativeTo:attribute:scale:offset:";

	private static readonly IntPtr selInitWithAttribute_RelativeTo_Attribute_Scale_Offset_Handle = Selector.GetHandle("initWithAttribute:relativeTo:attribute:scale:offset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScale = "scale";

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceAttribute = "sourceAttribute";

	private static readonly IntPtr selSourceAttributeHandle = Selector.GetHandle("sourceAttribute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceName = "sourceName";

	private static readonly IntPtr selSourceNameHandle = Selector.GetHandle("sourceName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAConstraint");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAConstraintAttribute Attribute
	{
		[Export("attribute")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CAConstraintAttribute)Messaging.int_objc_msgSend(base.Handle, selAttributeHandle);
			}
			return (CAConstraintAttribute)Messaging.int_objc_msgSendSuper(base.SuperHandle, selAttributeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Scale
	{
		[Export("scale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScaleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAConstraintAttribute SourceAttribute
	{
		[Export("sourceAttribute")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CAConstraintAttribute)Messaging.int_objc_msgSend(base.Handle, selSourceAttributeHandle);
			}
			return (CAConstraintAttribute)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSourceAttributeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SourceName
	{
		[Export("sourceName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAConstraint()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAConstraint(NSCoder coder)
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
	protected CAConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAttribute:relativeTo:attribute:scale:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CAConstraint(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, nfloat scale, nfloat offset)
		: base(NSObjectFlag.Empty)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int_IntPtr_int_nfloat_nfloat(base.Handle, selInitWithAttribute_RelativeTo_Attribute_Scale_Offset_Handle, (int)attribute, arg, (int)srcAttr, scale, offset), "initWithAttribute:relativeTo:attribute:scale:offset:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int_IntPtr_int_nfloat_nfloat(base.SuperHandle, selInitWithAttribute_RelativeTo_Attribute_Scale_Offset_Handle, (int)attribute, arg, (int)srcAttr, scale, offset), "initWithAttribute:relativeTo:attribute:scale:offset:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("constraintWithAttribute:relativeTo:attribute:scale:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAConstraint Create(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, nfloat scale, nfloat offset)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		CAConstraint nSObject = Runtime.GetNSObject<CAConstraint>(Messaging.IntPtr_objc_msgSend_int_IntPtr_int_nfloat_nfloat(class_ptr, selConstraintWithAttribute_RelativeTo_Attribute_Scale_Offset_Handle, (int)attribute, arg, (int)srcAttr, scale, offset));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("constraintWithAttribute:relativeTo:attribute:offset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAConstraint Create(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, nfloat offset)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		CAConstraint nSObject = Runtime.GetNSObject<CAConstraint>(Messaging.IntPtr_objc_msgSend_int_IntPtr_int_nfloat(class_ptr, selConstraintWithAttribute_RelativeTo_Attribute_Offset_Handle, (int)attribute, arg, (int)srcAttr, offset));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("constraintWithAttribute:relativeTo:attribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAConstraint Create(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttribute)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		CAConstraint nSObject = Runtime.GetNSObject<CAConstraint>(Messaging.IntPtr_objc_msgSend_int_IntPtr_int(class_ptr, selConstraintWithAttribute_RelativeTo_Attribute_Handle, (int)attribute, arg, (int)srcAttribute));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
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
}
