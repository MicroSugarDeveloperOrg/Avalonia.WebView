using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAConstraint", true)]
public class CAConstraint : NSObject
{
	private static readonly IntPtr selAttributeHandle = Selector.GetHandle("attribute");

	private static readonly IntPtr selSourceNameHandle = Selector.GetHandle("sourceName");

	private static readonly IntPtr selSourceAttributeHandle = Selector.GetHandle("sourceAttribute");

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	private static readonly IntPtr selConstraintWithAttributeRelativeToAttributeScaleOffset_Handle = Selector.GetHandle("constraintWithAttribute:relativeTo:attribute:scale:offset:");

	private static readonly IntPtr selConstraintWithAttributeRelativeToAttributeOffset_Handle = Selector.GetHandle("constraintWithAttribute:relativeTo:attribute:offset:");

	private static readonly IntPtr selConstraintWithAttributeRelativeToAttribute_Handle = Selector.GetHandle("constraintWithAttribute:relativeTo:attribute:");

	private static readonly IntPtr selInitWithAttributeRelativeToAttributeScaleOffset_Handle = Selector.GetHandle("initWithAttribute:relativeTo:attribute:scale:offset:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAConstraint");

	public override IntPtr ClassHandle => class_ptr;

	public virtual CAConstraintAttribute Attribute
	{
		[Export("attribute")]
		get
		{
			if (IsDirectBinding)
			{
				return (CAConstraintAttribute)Messaging.int_objc_msgSend(base.Handle, selAttributeHandle);
			}
			return (CAConstraintAttribute)Messaging.int_objc_msgSendSuper(base.SuperHandle, selAttributeHandle);
		}
	}

	public virtual string SourceName
	{
		[Export("sourceName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceNameHandle));
		}
	}

	public virtual CAConstraintAttribute SourceAttribute
	{
		[Export("sourceAttribute")]
		get
		{
			if (IsDirectBinding)
			{
				return (CAConstraintAttribute)Messaging.int_objc_msgSend(base.Handle, selSourceAttributeHandle);
			}
			return (CAConstraintAttribute)Messaging.int_objc_msgSendSuper(base.SuperHandle, selSourceAttributeHandle);
		}
	}

	public virtual float Scale
	{
		[Export("scale")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selScaleHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAConstraint()
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
	public CAConstraint(NSCoder coder)
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
	public CAConstraint(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAConstraint(IntPtr handle)
		: base(handle)
	{
	}

	[Export("constraintWithAttribute:relativeTo:attribute:scale:offset:")]
	public static CAConstraint Create(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, float scale, float offset)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		CAConstraint result = (CAConstraint)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int_IntPtr_int_float_float(class_ptr, selConstraintWithAttributeRelativeToAttributeScaleOffset_Handle, (int)attribute, arg, (int)srcAttr, scale, offset));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("constraintWithAttribute:relativeTo:attribute:offset:")]
	public static CAConstraint Create(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, float offset)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		CAConstraint result = (CAConstraint)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int_IntPtr_int_float(class_ptr, selConstraintWithAttributeRelativeToAttributeOffset_Handle, (int)attribute, arg, (int)srcAttr, offset));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("constraintWithAttribute:relativeTo:attribute:")]
	public static CAConstraint Create(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttribute)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		CAConstraint result = (CAConstraint)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int_IntPtr_int(class_ptr, selConstraintWithAttributeRelativeToAttribute_Handle, (int)attribute, arg, (int)srcAttribute));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithAttribute:relativeTo:attribute:scale:offset:")]
	public CAConstraint(CAConstraintAttribute attribute, string relativeToSource, CAConstraintAttribute srcAttr, float scale, float offset)
		: base(NSObjectFlag.Empty)
	{
		if (relativeToSource == null)
		{
			throw new ArgumentNullException("relativeToSource");
		}
		IntPtr arg = NSString.CreateNative(relativeToSource);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int_IntPtr_int_float_float(base.Handle, selInitWithAttributeRelativeToAttributeScaleOffset_Handle, (int)attribute, arg, (int)srcAttr, scale, offset);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int_IntPtr_int_float_float(base.SuperHandle, selInitWithAttributeRelativeToAttributeScaleOffset_Handle, (int)attribute, arg, (int)srcAttr, scale, offset);
		}
		NSString.ReleaseNative(arg);
	}
}
