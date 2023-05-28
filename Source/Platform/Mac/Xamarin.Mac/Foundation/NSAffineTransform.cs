using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using ObjCRuntime;

namespace Foundation;

[Register("NSAffineTransform", true)]
public class NSAffineTransform : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendTransform_ = "appendTransform:";

	private static readonly IntPtr selAppendTransform_Handle = Selector.GetHandle("appendTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConcat = "concat";

	private static readonly IntPtr selConcatHandle = Selector.GetHandle("concat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTransform_ = "initWithTransform:";

	private static readonly IntPtr selInitWithTransform_Handle = Selector.GetHandle("initWithTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvert = "invert";

	private static readonly IntPtr selInvertHandle = Selector.GetHandle("invert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrependTransform_ = "prependTransform:";

	private static readonly IntPtr selPrependTransform_Handle = Selector.GetHandle("prependTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByDegrees_ = "rotateByDegrees:";

	private static readonly IntPtr selRotateByDegrees_Handle = Selector.GetHandle("rotateByDegrees:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateByRadians_ = "rotateByRadians:";

	private static readonly IntPtr selRotateByRadians_Handle = Selector.GetHandle("rotateByRadians:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleBy_ = "scaleBy:";

	private static readonly IntPtr selScaleBy_Handle = Selector.GetHandle("scaleBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleXBy_YBy_ = "scaleXBy:yBy:";

	private static readonly IntPtr selScaleXBy_YBy_Handle = Selector.GetHandle("scaleXBy:yBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSet = "set";

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransformStruct_ = "setTransformStruct:";

	private static readonly IntPtr selSetTransformStruct_Handle = Selector.GetHandle("setTransformStruct:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformBezierPath_ = "transformBezierPath:";

	private static readonly IntPtr selTransformBezierPath_Handle = Selector.GetHandle("transformBezierPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformPoint_ = "transformPoint:";

	private static readonly IntPtr selTransformPoint_Handle = Selector.GetHandle("transformPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformSize_ = "transformSize:";

	private static readonly IntPtr selTransformSize_Handle = Selector.GetHandle("transformSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformStruct = "transformStruct";

	private static readonly IntPtr selTransformStructHandle = Selector.GetHandle("transformStruct");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslateXBy_YBy_ = "translateXBy:yBy:";

	private static readonly IntPtr selTranslateXBy_YBy_Handle = Selector.GetHandle("translateXBy:yBy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAffineTransform");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform TransformStruct
	{
		[Export("transformStruct")]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGAffineTransform(base.Handle, selSetTransformStruct_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGAffineTransform(base.SuperHandle, selSetTransformStruct_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAffineTransform()
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
	public NSAffineTransform(NSCoder coder)
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
	protected NSAffineTransform(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAffineTransform(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAffineTransform(NSAffineTransform transform)
		: base(NSObjectFlag.Empty)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTransform_Handle, transform.Handle), "initWithTransform:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTransform_Handle, transform.Handle), "initWithTransform:");
		}
	}

	[Export("appendTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendTransform(NSAffineTransform transform)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendTransform_Handle, transform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendTransform_Handle, transform.Handle);
		}
	}

	[Export("concat")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Concat()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selConcatHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selConcatHandle);
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

	[Export("invert")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invert()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvertHandle);
		}
	}

	[Export("prependTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrependTransform(NSAffineTransform transform)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrependTransform_Handle, transform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrependTransform_Handle, transform.Handle);
		}
	}

	[Export("rotateByDegrees:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateByDegrees(nfloat angle)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selRotateByDegrees_Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selRotateByDegrees_Handle, angle);
		}
	}

	[Export("rotateByRadians:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateByRadians(nfloat angle)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selRotateByRadians_Handle, angle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selRotateByRadians_Handle, angle);
		}
	}

	[Export("scaleBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Scale(nfloat scale)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat(base.Handle, selScaleBy_Handle, scale);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selScaleBy_Handle, scale);
		}
	}

	[Export("scaleXBy:yBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Scale(nfloat scaleX, nfloat scaleY)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nfloat(base.Handle, selScaleXBy_YBy_Handle, scaleX, scaleY);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nfloat(base.SuperHandle, selScaleXBy_YBy_Handle, scaleX, scaleY);
		}
	}

	[Export("set")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Set()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	[Export("transformBezierPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBezierPath TransformBezierPath(NSBezierPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTransformBezierPath_Handle, path.Handle));
		}
		return Runtime.GetNSObject<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformBezierPath_Handle, path.Handle));
	}

	[Export("transformPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint TransformPoint(CGPoint aPoint)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selTransformPoint_Handle, aPoint);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selTransformPoint_Handle, aPoint);
	}

	[Export("transformSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize TransformSize(CGSize aSize)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_CGSize(base.Handle, selTransformSize_Handle, aSize);
		}
		return Messaging.CGSize_objc_msgSendSuper_CGSize(base.SuperHandle, selTransformSize_Handle, aSize);
	}

	[Export("translateXBy:yBy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Translate(nfloat deltaX, nfloat deltaY)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nfloat(base.Handle, selTranslateXBy_YBy_Handle, deltaX, deltaY);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nfloat(base.SuperHandle, selTranslateXBy_YBy_Handle, deltaX, deltaY);
		}
	}
}
