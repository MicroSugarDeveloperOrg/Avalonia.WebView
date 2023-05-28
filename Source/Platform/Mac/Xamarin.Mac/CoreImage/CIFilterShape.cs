using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFilterShape", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public class CIFilterShape : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtent = "extent";

	private static readonly IntPtr selExtentHandle = Selector.GetHandle("extent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRect_ = "initWithRect:";

	private static readonly IntPtr selInitWithRect_Handle = Selector.GetHandle("initWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsetByX_Y_ = "insetByX:Y:";

	private static readonly IntPtr selInsetByX_Y_Handle = Selector.GetHandle("insetByX:Y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectWith_ = "intersectWith:";

	private static readonly IntPtr selIntersectWith_Handle = Selector.GetHandle("intersectWith:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectWithRect_ = "intersectWithRect:";

	private static readonly IntPtr selIntersectWithRect_Handle = Selector.GetHandle("intersectWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeWithRect_ = "shapeWithRect:";

	private static readonly IntPtr selShapeWithRect_Handle = Selector.GetHandle("shapeWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformBy_Interior_ = "transformBy:interior:";

	private static readonly IntPtr selTransformBy_Interior_Handle = Selector.GetHandle("transformBy:interior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnionWith_ = "unionWith:";

	private static readonly IntPtr selUnionWith_Handle = Selector.GetHandle("unionWith:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnionWithRect_ = "unionWithRect:";

	private static readonly IntPtr selUnionWithRect_Handle = Selector.GetHandle("unionWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIFilterShape");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Extent
	{
		[Export("extent")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtentHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtentHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIFilterShape(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIFilterShape(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIFilterShape(CGRect rect)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithRect_Handle, rect), "initWithRect:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithRect_Handle, rect), "initWithRect:");
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("shapeWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilterShape FromRect(CGRect rect)
	{
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selShapeWithRect_Handle, rect));
	}

	[Export("insetByX:Y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Inset(int dx, int dy)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selInsetByX_Y_Handle, dx, dy));
		}
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper_int_int(base.SuperHandle, selInsetByX_Y_Handle, dx, dy));
	}

	[Export("intersectWith:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Intersect(CIFilterShape other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIntersectWith_Handle, other.Handle));
		}
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectWith_Handle, other.Handle));
	}

	[Export("intersectWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Intersect(CGRect rectangle)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selIntersectWithRect_Handle, rectangle));
		}
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selIntersectWithRect_Handle, rectangle));
	}

	[Export("transformBy:interior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Transform(CGAffineTransform transformation, bool interiorFlag)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_CGAffineTransform_bool(base.Handle, selTransformBy_Interior_Handle, transformation, interiorFlag));
		}
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper_CGAffineTransform_bool(base.SuperHandle, selTransformBy_Interior_Handle, transformation, interiorFlag));
	}

	[Export("unionWith:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Union(CIFilterShape other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUnionWith_Handle, other.Handle));
		}
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnionWith_Handle, other.Handle));
	}

	[Export("unionWithRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilterShape Union(CGRect rectangle)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selUnionWithRect_Handle, rectangle));
		}
		return Runtime.GetNSObject<CIFilterShape>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selUnionWithRect_Handle, rectangle));
	}
}
