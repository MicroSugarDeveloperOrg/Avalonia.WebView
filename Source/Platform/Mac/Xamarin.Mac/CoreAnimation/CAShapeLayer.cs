using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAShapeLayer", true)]
public class CAShapeLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillColor = "fillColor";

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillRule = "fillRule";

	private static readonly IntPtr selFillRuleHandle = Selector.GetHandle("fillRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineCap = "lineCap";

	private static readonly IntPtr selLineCapHandle = Selector.GetHandle("lineCap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineDashPattern = "lineDashPattern";

	private static readonly IntPtr selLineDashPatternHandle = Selector.GetHandle("lineDashPattern");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineDashPhase = "lineDashPhase";

	private static readonly IntPtr selLineDashPhaseHandle = Selector.GetHandle("lineDashPhase");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineJoin = "lineJoin";

	private static readonly IntPtr selLineJoinHandle = Selector.GetHandle("lineJoin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineWidth = "lineWidth";

	private static readonly IntPtr selLineWidthHandle = Selector.GetHandle("lineWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiterLimit = "miterLimit";

	private static readonly IntPtr selMiterLimitHandle = Selector.GetHandle("miterLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillColor_ = "setFillColor:";

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillRule_ = "setFillRule:";

	private static readonly IntPtr selSetFillRule_Handle = Selector.GetHandle("setFillRule:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineCap_ = "setLineCap:";

	private static readonly IntPtr selSetLineCap_Handle = Selector.GetHandle("setLineCap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineDashPattern_ = "setLineDashPattern:";

	private static readonly IntPtr selSetLineDashPattern_Handle = Selector.GetHandle("setLineDashPattern:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineDashPhase_ = "setLineDashPhase:";

	private static readonly IntPtr selSetLineDashPhase_Handle = Selector.GetHandle("setLineDashPhase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineJoin_ = "setLineJoin:";

	private static readonly IntPtr selSetLineJoin_Handle = Selector.GetHandle("setLineJoin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineWidth_ = "setLineWidth:";

	private static readonly IntPtr selSetLineWidth_Handle = Selector.GetHandle("setLineWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMiterLimit_ = "setMiterLimit:";

	private static readonly IntPtr selSetMiterLimit_Handle = Selector.GetHandle("setMiterLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPath_ = "setPath:";

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrokeColor_ = "setStrokeColor:";

	private static readonly IntPtr selSetStrokeColor_Handle = Selector.GetHandle("setStrokeColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrokeEnd_ = "setStrokeEnd:";

	private static readonly IntPtr selSetStrokeEnd_Handle = Selector.GetHandle("setStrokeEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrokeStart_ = "setStrokeStart:";

	private static readonly IntPtr selSetStrokeStart_Handle = Selector.GetHandle("setStrokeStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeColor = "strokeColor";

	private static readonly IntPtr selStrokeColorHandle = Selector.GetHandle("strokeColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeEnd = "strokeEnd";

	private static readonly IntPtr selStrokeEndHandle = Selector.GetHandle("strokeEnd");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeStart = "strokeStart";

	private static readonly IntPtr selStrokeStartHandle = Selector.GetHandle("strokeStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAShapeLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CapButt;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CapRound;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CapSquare;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FillRuleEvenOdd;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FillRuleNonZero;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JoinBevel;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JoinMiter;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _JoinRound;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? FillColor
	{
		[Export("fillColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setFillColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString FillRule
	{
		[Export("fillRule", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillRuleHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillRuleHandle));
		}
		[Export("setFillRule:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillRule_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillRule_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString LineCap
	{
		[Export("lineCap", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLineCapHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineCapHandle));
		}
		[Export("setLineCap:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineCap_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineCap_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? LineDashPattern
	{
		[Export("lineDashPattern", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selLineDashPatternHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineDashPatternHandle));
		}
		[Export("setLineDashPattern:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineDashPattern_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineDashPattern_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineDashPhase
	{
		[Export("lineDashPhase")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineDashPhaseHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineDashPhaseHandle);
		}
		[Export("setLineDashPhase:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineDashPhase_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineDashPhase_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString LineJoin
	{
		[Export("lineJoin", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLineJoinHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLineJoinHandle));
		}
		[Export("setLineJoin:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLineJoin_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLineJoin_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineWidth
	{
		[Export("lineWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineWidthHandle);
		}
		[Export("setLineWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MiterLimit
	{
		[Export("miterLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMiterLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMiterLimitHandle);
		}
		[Export("setMiterLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMiterLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMiterLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPath? Path
	{
		[Export("path")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPath(intPtr);
		}
		[Export("setPath:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? StrokeColor
	{
		[Export("strokeColor")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStrokeColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selStrokeColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setStrokeColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStrokeColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStrokeColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat StrokeEnd
	{
		[Export("strokeEnd")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStrokeEndHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStrokeEndHandle);
		}
		[Export("setStrokeEnd:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetStrokeEnd_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetStrokeEnd_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat StrokeStart
	{
		[Export("strokeStart")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStrokeStartHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStrokeStartHandle);
		}
		[Export("setStrokeStart:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetStrokeStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetStrokeStart_Handle, value);
			}
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAShapeLayer()
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
	public CAShapeLayer(NSCoder coder)
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
	protected CAShapeLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAShapeLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}
}
