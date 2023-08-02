using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFilterShape", true)]
public class CIFilterShape : NSObject
{
	private static readonly IntPtr selShapeWithRect_Handle = Selector.GetHandle("shapeWithRect:");

	private static readonly IntPtr selInitWithRect_Handle = Selector.GetHandle("initWithRect:");

	private static readonly IntPtr selTransformByInterior_Handle = Selector.GetHandle("transformBy:interior:");

	private static readonly IntPtr selInsetByXY_Handle = Selector.GetHandle("insetByX:Y:");

	private static readonly IntPtr selUnionWith_Handle = Selector.GetHandle("unionWith:");

	private static readonly IntPtr selUnionWithRect_Handle = Selector.GetHandle("unionWithRect:");

	private static readonly IntPtr selIntersectWith_Handle = Selector.GetHandle("intersectWith:");

	private static readonly IntPtr selIntersectWithRect_Handle = Selector.GetHandle("intersectWithRect:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIFilterShape");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFilterShape(NSCoder coder)
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
	public CIFilterShape(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIFilterShape(IntPtr handle)
		: base(handle)
	{
	}

	[Export("shapeWithRect:")]
	public static CIFilterShape FromRect(CGRect rect)
	{
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selShapeWithRect_Handle, rect));
	}

	[Export("initWithRect:")]
	public CIFilterShape(CGRect rect)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithRect_Handle, rect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithRect_Handle, rect);
		}
	}

	[Export("transformBy:interior:")]
	public virtual CIFilterShape Transform(CGAffineTransform transformation, bool interiorFlag)
	{
		if (IsDirectBinding)
		{
			return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGAffineTransform_bool(base.Handle, selTransformByInterior_Handle, transformation, interiorFlag));
		}
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform_bool(base.SuperHandle, selTransformByInterior_Handle, transformation, interiorFlag));
	}

	[Export("insetByX:Y:")]
	public virtual CIFilterShape Inset(long dx, long dy)
	{
		if (IsDirectBinding)
		{
			return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64_Int64(base.Handle, selInsetByXY_Handle, dx, dy));
		}
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selInsetByXY_Handle, dx, dy));
	}

	[Export("unionWith:")]
	public virtual CIFilterShape Union(CIFilterShape other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUnionWith_Handle, other.Handle));
		}
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnionWith_Handle, other.Handle));
	}

	[Export("unionWithRect:")]
	public virtual CIFilterShape Union(CGRect rectangle)
	{
		if (IsDirectBinding)
		{
			return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selUnionWithRect_Handle, rectangle));
		}
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selUnionWithRect_Handle, rectangle));
	}

	[Export("intersectWith:")]
	public virtual CIFilterShape Intersect(CIFilterShape other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIntersectWith_Handle, other.Handle));
		}
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectWith_Handle, other.Handle));
	}

	[Export("intersectWithRect:")]
	public virtual CIFilterShape IntersectWithRect(CGRect rectangle)
	{
		if (IsDirectBinding)
		{
			return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selIntersectWithRect_Handle, rectangle));
		}
		return (CIFilterShape)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selIntersectWithRect_Handle, rectangle));
	}
}
