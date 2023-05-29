using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAShapeLayer", true)]
public class CAShapeLayer : CALayer
{
	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	private static readonly IntPtr selFillRuleHandle = Selector.GetHandle("fillRule");

	private static readonly IntPtr selSetFillRule_Handle = Selector.GetHandle("setFillRule:");

	private static readonly IntPtr selLineCapHandle = Selector.GetHandle("lineCap");

	private static readonly IntPtr selSetLineCap_Handle = Selector.GetHandle("setLineCap:");

	private static readonly IntPtr selLineDashPatternHandle = Selector.GetHandle("lineDashPattern");

	private static readonly IntPtr selSetLineDashPattern_Handle = Selector.GetHandle("setLineDashPattern:");

	private static readonly IntPtr selLineDashPhaseHandle = Selector.GetHandle("lineDashPhase");

	private static readonly IntPtr selSetLineDashPhase_Handle = Selector.GetHandle("setLineDashPhase:");

	private static readonly IntPtr selLineJoinHandle = Selector.GetHandle("lineJoin");

	private static readonly IntPtr selSetLineJoin_Handle = Selector.GetHandle("setLineJoin:");

	private static readonly IntPtr selLineWidthHandle = Selector.GetHandle("lineWidth");

	private static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle("setLineWidth:");

	private static readonly IntPtr selMiterLimitHandle = Selector.GetHandle("miterLimit");

	private static readonly IntPtr selSetMiterLimit_Handle = Selector.GetHandle("setMiterLimit:");

	private static readonly IntPtr selStrokeColorHandle = Selector.GetHandle("strokeColor");

	private static readonly IntPtr selSetStrokeColor_Handle = Selector.GetHandle("setStrokeColor:");

	private static readonly IntPtr selStrokeStartHandle = Selector.GetHandle("strokeStart");

	private static readonly IntPtr selSetStrokeStart_Handle = Selector.GetHandle("setStrokeStart:");

	private static readonly IntPtr selStrokeEndHandle = Selector.GetHandle("strokeEnd");

	private static readonly IntPtr selSetStrokeEnd_Handle = Selector.GetHandle("setStrokeEnd:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAShapeLayer");

	private object __mt_FillRule_var;

	private object __mt_LineCap_var;

	private object __mt_LineDashPattern_var;

	private object __mt_LineJoin_var;

	private static NSString _JoinMiter;

	private static NSString _JoinRound;

	private static NSString _JoinBevel;

	private static NSString _CapButt;

	private static NSString _CapRound;

	private static NSString _CapSquare;

	private static NSString _FillRuleNonZero;

	private static NSString _FillRuleEvenOdd;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGPath Path
	{
		[Export("path")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGPath(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return new CGPath(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
		[Export("setPath:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	public virtual CGColor FillColor
	{
		[Export("fillColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle));
		}
		[Export("setFillColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	public virtual NSString FillRule
	{
		[Export("fillRule", ArgumentSemantic.Copy)]
		get
		{
			return (NSString)(__mt_FillRule_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillRuleHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFillRuleHandle)))));
		}
		[Export("setFillRule:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillRule_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillRule_Handle, value.Handle);
			}
			__mt_FillRule_var = value;
		}
	}

	public virtual NSString LineCap
	{
		[Export("lineCap", ArgumentSemantic.Copy)]
		get
		{
			return (NSString)(__mt_LineCap_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineCapHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLineCapHandle)))));
		}
		[Export("setLineCap:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineCap_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineCap_Handle, value.Handle);
			}
			__mt_LineCap_var = value;
		}
	}

	public virtual NSNumber[] LineDashPattern
	{
		[Export("lineDashPattern", ArgumentSemantic.Copy)]
		get
		{
			return (NSNumber[])(__mt_LineDashPattern_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineDashPatternHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selLineDashPatternHandle))));
		}
		[Export("setLineDashPattern:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineDashPattern_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineDashPattern_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
			__mt_LineDashPattern_var = value;
		}
	}

	public virtual float LineDashPhase
	{
		[Export("lineDashPhase")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLineDashPhaseHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLineDashPhaseHandle);
		}
		[Export("setLineDashPhase:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLineDashPhase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLineDashPhase_Handle, value);
			}
		}
	}

	public virtual NSString LineJoin
	{
		[Export("lineJoin", ArgumentSemantic.Copy)]
		get
		{
			return (NSString)(__mt_LineJoin_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineJoinHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLineJoinHandle)))));
		}
		[Export("setLineJoin:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineJoin_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineJoin_Handle, value.Handle);
			}
			__mt_LineJoin_var = value;
		}
	}

	public virtual float LineWidth
	{
		[Export("lineWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLineWidthHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLineWidthHandle);
		}
		[Export("setLineWidth:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLineWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLineWidth_Handle, value);
			}
		}
	}

	public virtual float MiterLimit
	{
		[Export("miterLimit")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMiterLimitHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMiterLimitHandle);
		}
		[Export("setMiterLimit:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMiterLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMiterLimit_Handle, value);
			}
		}
	}

	public virtual CGColor StrokeColor
	{
		[Export("strokeColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selStrokeColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStrokeColorHandle));
		}
		[Export("setStrokeColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStrokeColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStrokeColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[Since(4, 2)]
	public virtual float StrokeStart
	{
		[Export("strokeStart")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selStrokeStartHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selStrokeStartHandle);
		}
		[Export("setStrokeStart:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetStrokeStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetStrokeStart_Handle, value);
			}
		}
	}

	[Since(4, 2)]
	public virtual float StrokeEnd
	{
		[Export("strokeEnd")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selStrokeEndHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selStrokeEndHandle);
		}
		[Export("setStrokeEnd:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetStrokeEnd_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetStrokeEnd_Handle, value);
			}
		}
	}

	[Field("kCALineJoinMiter", "CoreAnimation")]
	public static NSString JoinMiter
	{
		get
		{
			if (_JoinMiter == null)
			{
				_JoinMiter = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCALineJoinMiter");
			}
			return _JoinMiter;
		}
	}

	[Field("kCALineJoinRound", "CoreAnimation")]
	public static NSString JoinRound
	{
		get
		{
			if (_JoinRound == null)
			{
				_JoinRound = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCALineJoinRound");
			}
			return _JoinRound;
		}
	}

	[Field("kCALineJoinBevel", "CoreAnimation")]
	public static NSString JoinBevel
	{
		get
		{
			if (_JoinBevel == null)
			{
				_JoinBevel = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCALineJoinBevel");
			}
			return _JoinBevel;
		}
	}

	[Field("kCALineCapButt", "CoreAnimation")]
	public static NSString CapButt
	{
		get
		{
			if (_CapButt == null)
			{
				_CapButt = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCALineCapButt");
			}
			return _CapButt;
		}
	}

	[Field("kCALineCapRound", "CoreAnimation")]
	public static NSString CapRound
	{
		get
		{
			if (_CapRound == null)
			{
				_CapRound = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCALineCapRound");
			}
			return _CapRound;
		}
	}

	[Field("kCALineCapSquare", "CoreAnimation")]
	public static NSString CapSquare
	{
		get
		{
			if (_CapSquare == null)
			{
				_CapSquare = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCALineCapSquare");
			}
			return _CapSquare;
		}
	}

	[Field("kCAFillRuleNonZero", "CoreAnimation")]
	public static NSString FillRuleNonZero
	{
		get
		{
			if (_FillRuleNonZero == null)
			{
				_FillRuleNonZero = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFillRuleNonZero");
			}
			return _FillRuleNonZero;
		}
	}

	[Field("kCAFillRuleEvenOdd", "CoreAnimation")]
	public static NSString FillRuleEvenOdd
	{
		get
		{
			if (_FillRuleEvenOdd == null)
			{
				_FillRuleEvenOdd = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFillRuleEvenOdd");
			}
			return _FillRuleEvenOdd;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAShapeLayer()
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
	public CAShapeLayer(NSCoder coder)
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
	public CAShapeLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAShapeLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FillRule_var = null;
			__mt_LineCap_var = null;
			__mt_LineDashPattern_var = null;
			__mt_LineJoin_var = null;
		}
	}
}
