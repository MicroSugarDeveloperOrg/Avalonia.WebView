using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKShapeNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKShapeNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeValues = "attributeValues";

	private static readonly IntPtr selAttributeValuesHandle = Selector.GetHandle("attributeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendMode = "blendMode";

	private static readonly IntPtr selBlendModeHandle = Selector.GetHandle("blendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillColor = "fillColor";

	private static readonly IntPtr selFillColorHandle = Selector.GetHandle("fillColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillShader = "fillShader";

	private static readonly IntPtr selFillShaderHandle = Selector.GetHandle("fillShader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFillTexture = "fillTexture";

	private static readonly IntPtr selFillTextureHandle = Selector.GetHandle("fillTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGlowWidth = "glowWidth";

	private static readonly IntPtr selGlowWidthHandle = Selector.GetHandle("glowWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAntialiased = "isAntialiased";

	private static readonly IntPtr selIsAntialiasedHandle = Selector.GetHandle("isAntialiased");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineCap = "lineCap";

	private static readonly IntPtr selLineCapHandle = Selector.GetHandle("lineCap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineJoin = "lineJoin";

	private static readonly IntPtr selLineJoinHandle = Selector.GetHandle("lineJoin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineLength = "lineLength";

	private static readonly IntPtr selLineLengthHandle = Selector.GetHandle("lineLength");

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
	private const string selSetAntialiased_ = "setAntialiased:";

	private static readonly IntPtr selSetAntialiased_Handle = Selector.GetHandle("setAntialiased:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeValues_ = "setAttributeValues:";

	private static readonly IntPtr selSetAttributeValues_Handle = Selector.GetHandle("setAttributeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendMode_ = "setBlendMode:";

	private static readonly IntPtr selSetBlendMode_Handle = Selector.GetHandle("setBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillColor_ = "setFillColor:";

	private static readonly IntPtr selSetFillColor_Handle = Selector.GetHandle("setFillColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillShader_ = "setFillShader:";

	private static readonly IntPtr selSetFillShader_Handle = Selector.GetHandle("setFillShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFillTexture_ = "setFillTexture:";

	private static readonly IntPtr selSetFillTexture_Handle = Selector.GetHandle("setFillTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGlowWidth_ = "setGlowWidth:";

	private static readonly IntPtr selSetGlowWidth_Handle = Selector.GetHandle("setGlowWidth:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineCap_ = "setLineCap:";

	private static readonly IntPtr selSetLineCap_Handle = Selector.GetHandle("setLineCap:");

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
	private const string selSetStrokeShader_ = "setStrokeShader:";

	private static readonly IntPtr selSetStrokeShader_Handle = Selector.GetHandle("setStrokeShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStrokeTexture_ = "setStrokeTexture:";

	private static readonly IntPtr selSetStrokeTexture_Handle = Selector.GetHandle("setStrokeTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForAttributeNamed_ = "setValue:forAttributeNamed:";

	private static readonly IntPtr selSetValue_ForAttributeNamed_Handle = Selector.GetHandle("setValue:forAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithCircleOfRadius_ = "shapeNodeWithCircleOfRadius:";

	private static readonly IntPtr selShapeNodeWithCircleOfRadius_Handle = Selector.GetHandle("shapeNodeWithCircleOfRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithEllipseInRect_ = "shapeNodeWithEllipseInRect:";

	private static readonly IntPtr selShapeNodeWithEllipseInRect_Handle = Selector.GetHandle("shapeNodeWithEllipseInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithEllipseOfSize_ = "shapeNodeWithEllipseOfSize:";

	private static readonly IntPtr selShapeNodeWithEllipseOfSize_Handle = Selector.GetHandle("shapeNodeWithEllipseOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithPath_ = "shapeNodeWithPath:";

	private static readonly IntPtr selShapeNodeWithPath_Handle = Selector.GetHandle("shapeNodeWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithPath_Centered_ = "shapeNodeWithPath:centered:";

	private static readonly IntPtr selShapeNodeWithPath_Centered_Handle = Selector.GetHandle("shapeNodeWithPath:centered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithPoints_Count_ = "shapeNodeWithPoints:count:";

	private static readonly IntPtr selShapeNodeWithPoints_Count_Handle = Selector.GetHandle("shapeNodeWithPoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithRect_ = "shapeNodeWithRect:";

	private static readonly IntPtr selShapeNodeWithRect_Handle = Selector.GetHandle("shapeNodeWithRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithRect_CornerRadius_ = "shapeNodeWithRect:cornerRadius:";

	private static readonly IntPtr selShapeNodeWithRect_CornerRadius_Handle = Selector.GetHandle("shapeNodeWithRect:cornerRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithRectOfSize_ = "shapeNodeWithRectOfSize:";

	private static readonly IntPtr selShapeNodeWithRectOfSize_Handle = Selector.GetHandle("shapeNodeWithRectOfSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithRectOfSize_CornerRadius_ = "shapeNodeWithRectOfSize:cornerRadius:";

	private static readonly IntPtr selShapeNodeWithRectOfSize_CornerRadius_Handle = Selector.GetHandle("shapeNodeWithRectOfSize:cornerRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeNodeWithSplinePoints_Count_ = "shapeNodeWithSplinePoints:count:";

	private static readonly IntPtr selShapeNodeWithSplinePoints_Count_Handle = Selector.GetHandle("shapeNodeWithSplinePoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeColor = "strokeColor";

	private static readonly IntPtr selStrokeColorHandle = Selector.GetHandle("strokeColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeShader = "strokeShader";

	private static readonly IntPtr selStrokeShaderHandle = Selector.GetHandle("strokeShader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrokeTexture = "strokeTexture";

	private static readonly IntPtr selStrokeTextureHandle = Selector.GetHandle("strokeTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttributeNamed_ = "valueForAttributeNamed:";

	private static readonly IntPtr selValueForAttributeNamed_Handle = Selector.GetHandle("valueForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKShapeNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Antialiased
	{
		[Export("isAntialiased")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAntialiasedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAntialiasedHandle);
		}
		[Export("setAntialiased:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAntialiased_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAntialiased_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public new virtual NSDictionary<NSString, SKAttributeValue> AttributeValues
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("attributeValues", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeValuesHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAttributeValues:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeValues_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKBlendMode BlendMode
	{
		[Export("blendMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKBlendMode)Messaging.Int64_objc_msgSend(base.Handle, selBlendModeHandle);
			}
			return (SKBlendMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBlendModeHandle);
		}
		[Export("setBlendMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBlendMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBlendMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor FillColor
	{
		[Export("fillColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillColorHandle));
		}
		[Export("setFillColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKShader? FillShader
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("fillShader", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillShaderHandle));
			}
			return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillShaderHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setFillShader:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKTexture? FillTexture
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("fillTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selFillTextureHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFillTextureHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setFillTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFillTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFillTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GlowWidth
	{
		[Export("glowWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selGlowWidthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selGlowWidthHandle);
		}
		[Export("setGlowWidth:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetGlowWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetGlowWidth_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGLineCap LineCap
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("lineCap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CGLineCap)Messaging.int_objc_msgSend(base.Handle, selLineCapHandle);
			}
			return (CGLineCap)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLineCapHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setLineCap:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLineCap_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLineCap_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGLineJoin LineJoin
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("lineJoin")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CGLineJoin)Messaging.int_objc_msgSend(base.Handle, selLineJoinHandle);
			}
			return (CGLineJoin)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLineJoinHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setLineJoin:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLineJoin_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLineJoin_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nfloat LineLength
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("lineLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineLengthHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineLengthHandle);
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
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nfloat MiterLimit
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("miterLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMiterLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMiterLimitHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	public virtual NSColor StrokeColor
	{
		[Export("strokeColor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selStrokeColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStrokeColorHandle));
		}
		[Export("setStrokeColor:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStrokeColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStrokeColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKShader? StrokeShader
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("strokeShader", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(base.Handle, selStrokeShaderHandle));
			}
			return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStrokeShaderHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setStrokeShader:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStrokeShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStrokeShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKTexture? StrokeTexture
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("strokeTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selStrokeTextureHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStrokeTextureHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setStrokeTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStrokeTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStrokeTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static SKShapeNode FromPoints(CGPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		return FromPoints(ref points[0], (nuint)points.Length);
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static SKShapeNode FromPoints(CGPoint[] points, int offset, int length)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (offset > points.Length - length)
		{
			throw new InvalidOperationException("offset + length must not be greater than the length of the array");
		}
		return FromPoints(ref points[offset], (nuint)length);
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static SKShapeNode FromSplinePoints(CGPoint[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		return FromSplinePoints(ref points[0], (nuint)points.Length);
	}

	[iOS(8, 0)]
	[Mac(10, 10)]
	public static SKShapeNode FromSplinePoints(CGPoint[] points, int offset, int length)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (offset > points.Length - length)
		{
			throw new InvalidOperationException("offset + length must not be greater than the length of the array");
		}
		return FromSplinePoints(ref points[offset], (nuint)length);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKShapeNode()
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
	public SKShapeNode(NSCoder coder)
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
	protected SKShapeNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKShapeNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("shapeNodeWithCircleOfRadius:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromCircle(nfloat radius)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selShapeNodeWithCircleOfRadius_Handle, radius));
	}

	[Export("shapeNodeWithEllipseInRect:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromEllipse(CGRect rect)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selShapeNodeWithEllipseInRect_Handle, rect));
	}

	[Export("shapeNodeWithEllipseOfSize:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromEllipse(CGSize size)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selShapeNodeWithEllipseOfSize_Handle, size));
	}

	[Export("shapeNodeWithPath:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromPath(CGPath path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selShapeNodeWithPath_Handle, path.Handle));
	}

	[Export("shapeNodeWithPath:centered:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromPath(CGPath path, bool centered)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selShapeNodeWithPath_Centered_Handle, path.Handle, centered));
	}

	[Export("shapeNodeWithPoints:count:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromPoints(ref CGPoint points, nuint numPoints)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_ref_CGPoint_nuint(class_ptr, selShapeNodeWithPoints_Count_Handle, ref points, numPoints));
	}

	[Export("shapeNodeWithRect:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromRect(CGRect rect)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selShapeNodeWithRect_Handle, rect));
	}

	[Export("shapeNodeWithRectOfSize:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromRect(CGSize size)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_CGSize(class_ptr, selShapeNodeWithRectOfSize_Handle, size));
	}

	[Export("shapeNodeWithRect:cornerRadius:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromRect(CGRect rect, nfloat cornerRadius)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_CGRect_nfloat(class_ptr, selShapeNodeWithRect_CornerRadius_Handle, rect, cornerRadius));
	}

	[Export("shapeNodeWithRectOfSize:cornerRadius:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromRect(CGSize size, nfloat cornerRadius)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_CGSize_nfloat(class_ptr, selShapeNodeWithRectOfSize_CornerRadius_Handle, size, cornerRadius));
	}

	[Export("shapeNodeWithSplinePoints:count:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShapeNode FromSplinePoints(ref CGPoint points, nuint numPoints)
	{
		return Runtime.GetNSObject<SKShapeNode>(Messaging.IntPtr_objc_msgSend_ref_CGPoint_nuint(class_ptr, selShapeNodeWithSplinePoints_Count_Handle, ref points, numPoints));
	}

	[Export("valueForAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual SKAttributeValue? GetValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		SKAttributeValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForAttributeNamed_Handle, arg)) : Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForAttributeNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setValue:forAttributeNamed:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void SetValue(SKAttributeValue value, string key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForAttributeNamed_Handle, value.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
