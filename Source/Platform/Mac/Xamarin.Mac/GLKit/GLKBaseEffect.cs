using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GLKit;

[Register("GLKBaseEffect", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKBaseEffect : NSObject, IGLKNamedEffect, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorMaterialEnabled = "colorMaterialEnabled";

	private static readonly IntPtr selColorMaterialEnabledHandle = Selector.GetHandle("colorMaterialEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstantColor = "constantColor";

	private static readonly IntPtr selConstantColorHandle = Selector.GetHandle("constantColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFog = "fog";

	private static readonly IntPtr selFogHandle = Selector.GetHandle("fog");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLight0 = "light0";

	private static readonly IntPtr selLight0Handle = Selector.GetHandle("light0");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLight1 = "light1";

	private static readonly IntPtr selLight1Handle = Selector.GetHandle("light1");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLight2 = "light2";

	private static readonly IntPtr selLight2Handle = Selector.GetHandle("light2");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightModelAmbientColor = "lightModelAmbientColor";

	private static readonly IntPtr selLightModelAmbientColorHandle = Selector.GetHandle("lightModelAmbientColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightModelTwoSided = "lightModelTwoSided";

	private static readonly IntPtr selLightModelTwoSidedHandle = Selector.GetHandle("lightModelTwoSided");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLightingType = "lightingType";

	private static readonly IntPtr selLightingTypeHandle = Selector.GetHandle("lightingType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterial = "material";

	private static readonly IntPtr selMaterialHandle = Selector.GetHandle("material");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareToDraw = "prepareToDraw";

	private static readonly IntPtr selPrepareToDrawHandle = Selector.GetHandle("prepareToDraw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorMaterialEnabled_ = "setColorMaterialEnabled:";

	private static readonly IntPtr selSetColorMaterialEnabled_Handle = Selector.GetHandle("setColorMaterialEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConstantColor_ = "setConstantColor:";

	private static readonly IntPtr selSetConstantColor_Handle = Selector.GetHandle("setConstantColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightModelAmbientColor_ = "setLightModelAmbientColor:";

	private static readonly IntPtr selSetLightModelAmbientColor_Handle = Selector.GetHandle("setLightModelAmbientColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightModelTwoSided_ = "setLightModelTwoSided:";

	private static readonly IntPtr selSetLightModelTwoSided_Handle = Selector.GetHandle("setLightModelTwoSided:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLightingType_ = "setLightingType:";

	private static readonly IntPtr selSetLightingType_Handle = Selector.GetHandle("setLightingType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextureOrder_ = "setTextureOrder:";

	private static readonly IntPtr selSetTextureOrder_Handle = Selector.GetHandle("setTextureOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUseConstantColor_ = "setUseConstantColor:";

	private static readonly IntPtr selSetUseConstantColor_Handle = Selector.GetHandle("setUseConstantColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture2d0 = "texture2d0";

	private static readonly IntPtr selTexture2d0Handle = Selector.GetHandle("texture2d0");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture2d1 = "texture2d1";

	private static readonly IntPtr selTexture2d1Handle = Selector.GetHandle("texture2d1");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureOrder = "textureOrder";

	private static readonly IntPtr selTextureOrderHandle = Selector.GetHandle("textureOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransform = "transform";

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUseConstantColor = "useConstantColor";

	private static readonly IntPtr selUseConstantColorHandle = Selector.GetHandle("useConstantColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKBaseEffect");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ColorMaterialEnabled
	{
		[Export("colorMaterialEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selColorMaterialEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selColorMaterialEnabledHandle);
		}
		[Export("setColorMaterialEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetColorMaterialEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetColorMaterialEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Vector4 ConstantColor
	{
		[Export("constantColor", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selConstantColorHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selConstantColorHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setConstantColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetConstantColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetConstantColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyFog Fog
	{
		[Export("fog")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyFog>(Messaging.IntPtr_objc_msgSend(base.Handle, selFogHandle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyFog>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFogHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Label
	{
		[Export("label", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyLight Light0
	{
		[Export("light0")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyLight>(Messaging.IntPtr_objc_msgSend(base.Handle, selLight0Handle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyLight>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLight0Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyLight Light1
	{
		[Export("light1")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyLight>(Messaging.IntPtr_objc_msgSend(base.Handle, selLight1Handle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyLight>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLight1Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyLight Light2
	{
		[Export("light2")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyLight>(Messaging.IntPtr_objc_msgSend(base.Handle, selLight2Handle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyLight>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLight2Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Vector4 LightModelAmbientColor
	{
		[Export("lightModelAmbientColor", ArgumentSemantic.Assign)]
		get
		{
			Vector4 vector = default(Vector4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Vector4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			vector = ((!base.IsDirectBinding) ? Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selLightModelAmbientColorHandle) : Messaging.Vector4_objc_msgSend(base.Handle, selLightModelAmbientColorHandle));
			if (flag)
			{
				vector = *(Vector4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return vector;
		}
		[Export("setLightModelAmbientColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetLightModelAmbientColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetLightModelAmbientColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool LightModelTwoSided
	{
		[Export("lightModelTwoSided")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLightModelTwoSidedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLightModelTwoSidedHandle);
		}
		[Export("setLightModelTwoSided:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLightModelTwoSided_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLightModelTwoSided_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKLightingType LightingType
	{
		[Export("lightingType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GLKLightingType)Messaging.int_objc_msgSend(base.Handle, selLightingTypeHandle);
			}
			return (GLKLightingType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selLightingTypeHandle);
		}
		[Export("setLightingType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetLightingType_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetLightingType_Handle, (int)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyMaterial Material
	{
		[Export("material")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyMaterial>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaterialHandle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyMaterial>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaterialHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyTexture Texture2d0
	{
		[Export("texture2d0")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTexture2d0Handle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTexture2d0Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyTexture Texture2d1
	{
		[Export("texture2d1")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTexture2d1Handle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTexture2d1Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyTexture[]? TextureOrder
	{
		[Export("textureOrder", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureOrderHandle));
			}
			return NSArray.ArrayFromHandle<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureOrderHandle));
		}
		[Export("setTextureOrder:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextureOrder_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextureOrder_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyTransform Transform
	{
		[Export("transform")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyTransform>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransformHandle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyTransform>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransformHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UseConstantColor
	{
		[Export("useConstantColor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUseConstantColorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUseConstantColorHandle);
		}
		[Export("setUseConstantColor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUseConstantColor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUseConstantColor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GLKBaseEffect()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GLKBaseEffect(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKBaseEffect(IntPtr handle)
		: base(handle)
	{
	}

	[Export("prepareToDraw")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareToDraw()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareToDrawHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareToDrawHandle);
		}
	}
}
