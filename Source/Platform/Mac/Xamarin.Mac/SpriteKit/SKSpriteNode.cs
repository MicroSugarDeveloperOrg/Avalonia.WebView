using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKSpriteNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKSpriteNode : SKNode, ISKWarpable, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorPoint = "anchorPoint";

	private static readonly IntPtr selAnchorPointHandle = Selector.GetHandle("anchorPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeValues = "attributeValues";

	private static readonly IntPtr selAttributeValuesHandle = Selector.GetHandle("attributeValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendMode = "blendMode";

	private static readonly IntPtr selBlendModeHandle = Selector.GetHandle("blendMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterRect = "centerRect";

	private static readonly IntPtr selCenterRectHandle = Selector.GetHandle("centerRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorBlendFactor = "colorBlendFactor";

	private static readonly IntPtr selColorBlendFactorHandle = Selector.GetHandle("colorBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColor_Size_ = "initWithColor:size:";

	private static readonly IntPtr selInitWithColor_Size_Handle = Selector.GetHandle("initWithColor:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImageNamed_ = "initWithImageNamed:";

	private static readonly IntPtr selInitWithImageNamed_Handle = Selector.GetHandle("initWithImageNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_ = "initWithTexture:";

	private static readonly IntPtr selInitWithTexture_Handle = Selector.GetHandle("initWithTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_Color_Size_ = "initWithTexture:color:size:";

	private static readonly IntPtr selInitWithTexture_Color_Size_Handle = Selector.GetHandle("initWithTexture:color:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightingBitMask = "lightingBitMask";

	private static readonly IntPtr selLightingBitMaskHandle = Selector.GetHandle("lightingBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalTexture = "normalTexture";

	private static readonly IntPtr selNormalTextureHandle = Selector.GetHandle("normalTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleToSize_ = "scaleToSize:";

	private static readonly IntPtr selScaleToSize_Handle = Selector.GetHandle("scaleToSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorPoint_ = "setAnchorPoint:";

	private static readonly IntPtr selSetAnchorPoint_Handle = Selector.GetHandle("setAnchorPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeValues_ = "setAttributeValues:";

	private static readonly IntPtr selSetAttributeValues_Handle = Selector.GetHandle("setAttributeValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendMode_ = "setBlendMode:";

	private static readonly IntPtr selSetBlendMode_Handle = Selector.GetHandle("setBlendMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCenterRect_ = "setCenterRect:";

	private static readonly IntPtr selSetCenterRect_Handle = Selector.GetHandle("setCenterRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorBlendFactor_ = "setColorBlendFactor:";

	private static readonly IntPtr selSetColorBlendFactor_Handle = Selector.GetHandle("setColorBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightingBitMask_ = "setLightingBitMask:";

	private static readonly IntPtr selSetLightingBitMask_Handle = Selector.GetHandle("setLightingBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNormalTexture_ = "setNormalTexture:";

	private static readonly IntPtr selSetNormalTexture_Handle = Selector.GetHandle("setNormalTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShader_ = "setShader:";

	private static readonly IntPtr selSetShader_Handle = Selector.GetHandle("setShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowCastBitMask_ = "setShadowCastBitMask:";

	private static readonly IntPtr selSetShadowCastBitMask_Handle = Selector.GetHandle("setShadowCastBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShadowedBitMask_ = "setShadowedBitMask:";

	private static readonly IntPtr selSetShadowedBitMask_Handle = Selector.GetHandle("setShadowedBitMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubdivisionLevels_ = "setSubdivisionLevels:";

	private static readonly IntPtr selSetSubdivisionLevels_Handle = Selector.GetHandle("setSubdivisionLevels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTexture_ = "setTexture:";

	private static readonly IntPtr selSetTexture_Handle = Selector.GetHandle("setTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForAttributeNamed_ = "setValue:forAttributeNamed:";

	private static readonly IntPtr selSetValue_ForAttributeNamed_Handle = Selector.GetHandle("setValue:forAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWarpGeometry_ = "setWarpGeometry:";

	private static readonly IntPtr selSetWarpGeometry_Handle = Selector.GetHandle("setWarpGeometry:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShader = "shader";

	private static readonly IntPtr selShaderHandle = Selector.GetHandle("shader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowCastBitMask = "shadowCastBitMask";

	private static readonly IntPtr selShadowCastBitMaskHandle = Selector.GetHandle("shadowCastBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShadowedBitMask = "shadowedBitMask";

	private static readonly IntPtr selShadowedBitMaskHandle = Selector.GetHandle("shadowedBitMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpriteNodeWithColor_Size_ = "spriteNodeWithColor:size:";

	private static readonly IntPtr selSpriteNodeWithColor_Size_Handle = Selector.GetHandle("spriteNodeWithColor:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpriteNodeWithImageNamed_ = "spriteNodeWithImageNamed:";

	private static readonly IntPtr selSpriteNodeWithImageNamed_Handle = Selector.GetHandle("spriteNodeWithImageNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpriteNodeWithImageNamed_NormalMapped_ = "spriteNodeWithImageNamed:normalMapped:";

	private static readonly IntPtr selSpriteNodeWithImageNamed_NormalMapped_Handle = Selector.GetHandle("spriteNodeWithImageNamed:normalMapped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpriteNodeWithTexture_ = "spriteNodeWithTexture:";

	private static readonly IntPtr selSpriteNodeWithTexture_Handle = Selector.GetHandle("spriteNodeWithTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpriteNodeWithTexture_NormalMap_ = "spriteNodeWithTexture:normalMap:";

	private static readonly IntPtr selSpriteNodeWithTexture_NormalMap_Handle = Selector.GetHandle("spriteNodeWithTexture:normalMap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpriteNodeWithTexture_Size_ = "spriteNodeWithTexture:size:";

	private static readonly IntPtr selSpriteNodeWithTexture_Size_Handle = Selector.GetHandle("spriteNodeWithTexture:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubdivisionLevels = "subdivisionLevels";

	private static readonly IntPtr selSubdivisionLevelsHandle = Selector.GetHandle("subdivisionLevels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture = "texture";

	private static readonly IntPtr selTextureHandle = Selector.GetHandle("texture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForAttributeNamed_ = "valueForAttributeNamed:";

	private static readonly IntPtr selValueForAttributeNamed_Handle = Selector.GetHandle("valueForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWarpGeometry = "warpGeometry";

	private static readonly IntPtr selWarpGeometryHandle = Selector.GetHandle("warpGeometry");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKSpriteNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WarpGeometry_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint AnchorPoint
	{
		[Export("anchorPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAnchorPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAnchorPointHandle);
		}
		[Export("setAnchorPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAnchorPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAnchorPoint_Handle, value);
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
	public virtual CGRect CenterRect
	{
		[Export("centerRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selCenterRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCenterRectHandle);
			}
			return retval;
		}
		[Export("setCenterRect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetCenterRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetCenterRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor? Color
	{
		[Export("color", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ColorBlendFactor
	{
		[Export("colorBlendFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selColorBlendFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selColorBlendFactorHandle);
		}
		[Export("setColorBlendFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetColorBlendFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetColorBlendFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual uint LightingBitMask
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("lightingBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selLightingBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLightingBitMaskHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setLightingBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetLightingBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetLightingBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKTexture? NormalTexture
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("normalTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selNormalTextureHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNormalTextureHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setNormalTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNormalTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNormalTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual SKShader? Shader
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shader", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(base.Handle, selShaderHandle));
			}
			return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShaderHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setShader:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShader_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual uint ShadowCastBitMask
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shadowCastBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selShadowCastBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selShadowCastBitMaskHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setShadowCastBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetShadowCastBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetShadowCastBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual uint ShadowedBitMask
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("shadowedBitMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selShadowedBitMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selShadowedBitMaskHandle);
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setShadowedBitMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetShadowedBitMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetShadowedBitMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual nint SubdivisionLevels
	{
		[Export("subdivisionLevels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSubdivisionLevelsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSubdivisionLevelsHandle);
		}
		[Export("setSubdivisionLevels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSubdivisionLevels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSubdivisionLevels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture? Texture
	{
		[Export("texture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureHandle));
		}
		[Export("setTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual SKWarpGeometry? WarpGeometry
	{
		[Export("warpGeometry", ArgumentSemantic.Assign)]
		get
		{
			SKWarpGeometry sKWarpGeometry = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKWarpGeometry>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWarpGeometryHandle)) : Runtime.GetNSObject<SKWarpGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, selWarpGeometryHandle)));
			MarkDirty();
			__mt_WarpGeometry_var = sKWarpGeometry;
			return sKWarpGeometry;
		}
		[Export("setWarpGeometry:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWarpGeometry_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWarpGeometry_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WarpGeometry_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKSpriteNode()
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
	public SKSpriteNode(NSCoder coder)
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
	protected SKSpriteNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKSpriteNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTexture:color:size:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKSpriteNode(SKTexture? texture, NSColor? color, CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize(base.Handle, selInitWithTexture_Color_Size_Handle, texture?.Handle ?? IntPtr.Zero, color?.Handle ?? IntPtr.Zero, size), "initWithTexture:color:size:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGSize(base.SuperHandle, selInitWithTexture_Color_Size_Handle, texture?.Handle ?? IntPtr.Zero, color?.Handle ?? IntPtr.Zero, size), "initWithTexture:color:size:");
		}
	}

	[Export("initWithTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKSpriteNode(SKTexture? texture)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTexture_Handle, texture?.Handle ?? IntPtr.Zero), "initWithTexture:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTexture_Handle, texture?.Handle ?? IntPtr.Zero), "initWithTexture:");
		}
	}

	[Export("initWithImageNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKSpriteNode(string name)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithImageNamed_Handle, arg), "initWithImageNamed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithImageNamed_Handle, arg), "initWithImageNamed:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithColor:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKSpriteNode(NSColor? color, CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(base.Handle, selInitWithColor_Size_Handle, color?.Handle ?? IntPtr.Zero, size), "initWithColor:size:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGSize(base.SuperHandle, selInitWithColor_Size_Handle, color?.Handle ?? IntPtr.Zero, size), "initWithColor:size:");
		}
	}

	[Export("spriteNodeWithTexture:normalMap:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKSpriteNode Create(SKTexture? texture, SKTexture? normalMap)
	{
		return Runtime.GetNSObject<SKSpriteNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSpriteNodeWithTexture_NormalMap_Handle, texture?.Handle ?? IntPtr.Zero, normalMap?.Handle ?? IntPtr.Zero));
	}

	[Export("spriteNodeWithImageNamed:normalMapped:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKSpriteNode Create(string imageName, bool generateNormalMap)
	{
		if (imageName == null)
		{
			throw new ArgumentNullException("imageName");
		}
		IntPtr arg = NSString.CreateNative(imageName);
		SKSpriteNode nSObject = Runtime.GetNSObject<SKSpriteNode>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selSpriteNodeWithImageNamed_NormalMapped_Handle, arg, generateNormalMap));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("spriteNodeWithColor:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKSpriteNode FromColor(NSColor? color, CGSize size)
	{
		return Runtime.GetNSObject<SKSpriteNode>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(class_ptr, selSpriteNodeWithColor_Size_Handle, color?.Handle ?? IntPtr.Zero, size));
	}

	[Export("spriteNodeWithImageNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKSpriteNode FromImageNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKSpriteNode nSObject = Runtime.GetNSObject<SKSpriteNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSpriteNodeWithImageNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("spriteNodeWithTexture:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKSpriteNode FromTexture(SKTexture? texture, CGSize size)
	{
		return Runtime.GetNSObject<SKSpriteNode>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(class_ptr, selSpriteNodeWithTexture_Size_Handle, texture?.Handle ?? IntPtr.Zero, size));
	}

	[Export("spriteNodeWithTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKSpriteNode FromTexture(SKTexture? texture)
	{
		return Runtime.GetNSObject<SKSpriteNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSpriteNodeWithTexture_Handle, texture?.Handle ?? IntPtr.Zero));
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

	[Export("scaleToSize:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScaleTo(CGSize size)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize(base.Handle, selScaleToSize_Handle, size);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selScaleToSize_Handle, size);
		}
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WarpGeometry_var = null;
		}
	}
}
