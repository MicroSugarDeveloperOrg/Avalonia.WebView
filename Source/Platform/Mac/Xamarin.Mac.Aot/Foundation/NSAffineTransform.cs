using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using ObjCRuntime;

namespace Foundation;

[Register("NSAffineTransform", true)]
public class NSAffineTransform : NSObject
{
	private static readonly IntPtr selTransformStructHandle = Selector.GetHandle("transformStruct");

	private static readonly IntPtr selSetTransformStruct_Handle = Selector.GetHandle("setTransformStruct:");

	private static readonly IntPtr selInitWithTransform_Handle = Selector.GetHandle("initWithTransform:");

	private static readonly IntPtr selTranslateXByYBy_Handle = Selector.GetHandle("translateXBy:yBy:");

	private static readonly IntPtr selRotateByDegrees_Handle = Selector.GetHandle("rotateByDegrees:");

	private static readonly IntPtr selRotateByRadians_Handle = Selector.GetHandle("rotateByRadians:");

	private static readonly IntPtr selScaleBy_Handle = Selector.GetHandle("scaleBy:");

	private static readonly IntPtr selScaleXByYBy_Handle = Selector.GetHandle("scaleXBy:yBy:");

	private static readonly IntPtr selInvertHandle = Selector.GetHandle("invert");

	private static readonly IntPtr selAppendTransform_Handle = Selector.GetHandle("appendTransform:");

	private static readonly IntPtr selPrependTransform_Handle = Selector.GetHandle("prependTransform:");

	private static readonly IntPtr selTransformPoint_Handle = Selector.GetHandle("transformPoint:");

	private static readonly IntPtr selTransformSize_Handle = Selector.GetHandle("transformSize:");

	private static readonly IntPtr selTransformBezierPath_Handle = Selector.GetHandle("transformBezierPath:");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr selConcatHandle = Selector.GetHandle("concat");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAffineTransform");

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGAffineTransform TransformStruct
	{
		[Export("transformStruct")]
		get
		{
			CGAffineTransform retval;
			if (IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selTransformStructHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTransformStructHandle);
			}
			return retval;
		}
		[Export("setTransformStruct:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetTransformStruct_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetTransformStruct_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAffineTransform()
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
	public NSAffineTransform(NSCoder coder)
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
	public NSAffineTransform(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAffineTransform(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTransform:")]
	public NSAffineTransform(NSAffineTransform transform)
		: base(NSObjectFlag.Empty)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTransform_Handle, transform.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTransform_Handle, transform.Handle);
		}
	}

	[Export("translateXBy:yBy:")]
	public virtual void Translate(double deltaX, double deltaY)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Double(base.Handle, selTranslateXByYBy_Handle, deltaX, deltaY);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Double(base.SuperHandle, selTranslateXByYBy_Handle, deltaX, deltaY);
		}
	}

	[Export("rotateByDegrees:")]
	public virtual void RotateByDegrees(double angle)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRotateByDegrees_Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRotateByDegrees_Handle, angle);
		}
	}

	[Export("rotateByRadians:")]
	public virtual void RotateByRadians(double angle)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selRotateByRadians_Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selRotateByRadians_Handle, angle);
		}
	}

	[Export("scaleBy:")]
	public virtual void Scale(double scale)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selScaleBy_Handle, scale);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selScaleBy_Handle, scale);
		}
	}

	[Export("scaleXBy:yBy:")]
	public virtual void Scale(double scaleX, double scaleY)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Double(base.Handle, selScaleXByYBy_Handle, scaleX, scaleY);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Double(base.SuperHandle, selScaleXByYBy_Handle, scaleX, scaleY);
		}
	}

	[Export("invert")]
	public virtual void Invert()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvertHandle);
		}
	}

	[Export("appendTransform:")]
	public virtual void AppendTransform(NSAffineTransform transform)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendTransform_Handle, transform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendTransform_Handle, transform.Handle);
		}
	}

	[Export("prependTransform:")]
	public virtual void PrependTransform(NSAffineTransform transform)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrependTransform_Handle, transform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrependTransform_Handle, transform.Handle);
		}
	}

	[Export("transformPoint:")]
	public virtual CGPoint TransformPoint(CGPoint aPoint)
	{
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selTransformPoint_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selTransformPoint_Handle, aPoint);
	}

	[Export("transformSize:")]
	public virtual CGSize TransformSize(CGSize aSize)
	{
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selTransformSize_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selTransformSize_Handle, aSize);
	}

	[Export("transformBezierPath:")]
	public virtual NSBezierPath TransformBezierPath(NSBezierPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (IsDirectBinding)
		{
			return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTransformBezierPath_Handle, path.Handle));
		}
		return (NSBezierPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformBezierPath_Handle, path.Handle));
	}

	[Export("set")]
	public virtual void Set()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	[Export("concat")]
	public virtual void Concat()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selConcatHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selConcatHandle);
		}
	}
}
