using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLMaterialProperty", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLMaterialProperty : NSObject, IMDLNamed, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLValue = "URLValue";

	private static readonly IntPtr selURLValueHandle = Selector.GetHandle("URLValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat2Value = "float2Value";

	private static readonly IntPtr selFloat2ValueHandle = Selector.GetHandle("float2Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat3Value = "float3Value";

	private static readonly IntPtr selFloat3ValueHandle = Selector.GetHandle("float3Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat4Value = "float4Value";

	private static readonly IntPtr selFloat4ValueHandle = Selector.GetHandle("float4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatValue = "floatValue";

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_ = "initWithName:semantic:";

	private static readonly IntPtr selInitWithName_Semantic_Handle = Selector.GetHandle("initWithName:semantic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_URL_ = "initWithName:semantic:URL:";

	private static readonly IntPtr selInitWithName_Semantic_URL_Handle = Selector.GetHandle("initWithName:semantic:URL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_Color_ = "initWithName:semantic:color:";

	private static readonly IntPtr selInitWithName_Semantic_Color_Handle = Selector.GetHandle("initWithName:semantic:color:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_Float2_ = "initWithName:semantic:float2:";

	private static readonly IntPtr selInitWithName_Semantic_Float2_Handle = Selector.GetHandle("initWithName:semantic:float2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_Float3_ = "initWithName:semantic:float3:";

	private static readonly IntPtr selInitWithName_Semantic_Float3_Handle = Selector.GetHandle("initWithName:semantic:float3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_Float4_ = "initWithName:semantic:float4:";

	private static readonly IntPtr selInitWithName_Semantic_Float4_Handle = Selector.GetHandle("initWithName:semantic:float4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_Float_ = "initWithName:semantic:float:";

	private static readonly IntPtr selInitWithName_Semantic_Float_Handle = Selector.GetHandle("initWithName:semantic:float:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_Matrix4x4_ = "initWithName:semantic:matrix4x4:";

	private static readonly IntPtr selInitWithName_Semantic_Matrix4x4_Handle = Selector.GetHandle("initWithName:semantic:matrix4x4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_String_ = "initWithName:semantic:string:";

	private static readonly IntPtr selInitWithName_Semantic_String_Handle = Selector.GetHandle("initWithName:semantic:string:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Semantic_TextureSampler_ = "initWithName:semantic:textureSampler:";

	private static readonly IntPtr selInitWithName_Semantic_TextureSampler_Handle = Selector.GetHandle("initWithName:semantic:textureSampler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLuminance = "luminance";

	private static readonly IntPtr selLuminanceHandle = Selector.GetHandle("luminance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrix4x4 = "matrix4x4";

	private static readonly IntPtr selMatrix4x4Handle = Selector.GetHandle("matrix4x4");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemantic = "semantic";

	private static readonly IntPtr selSemanticHandle = Selector.GetHandle("semantic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat2Value_ = "setFloat2Value:";

	private static readonly IntPtr selSetFloat2Value_Handle = Selector.GetHandle("setFloat2Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat3Value_ = "setFloat3Value:";

	private static readonly IntPtr selSetFloat3Value_Handle = Selector.GetHandle("setFloat3Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat4Value_ = "setFloat4Value:";

	private static readonly IntPtr selSetFloat4Value_Handle = Selector.GetHandle("setFloat4Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatValue_ = "setFloatValue:";

	private static readonly IntPtr selSetFloatValue_Handle = Selector.GetHandle("setFloatValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLuminance_ = "setLuminance:";

	private static readonly IntPtr selSetLuminance_Handle = Selector.GetHandle("setLuminance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrix4x4_ = "setMatrix4x4:";

	private static readonly IntPtr selSetMatrix4x4_Handle = Selector.GetHandle("setMatrix4x4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperties_ = "setProperties:";

	private static readonly IntPtr selSetProperties_Handle = Selector.GetHandle("setProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSemantic_ = "setSemantic:";

	private static readonly IntPtr selSetSemantic_Handle = Selector.GetHandle("setSemantic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStringValue_ = "setStringValue:";

	private static readonly IntPtr selSetStringValue_Handle = Selector.GetHandle("setStringValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextureSamplerValue_ = "setTextureSamplerValue:";

	private static readonly IntPtr selSetTextureSamplerValue_Handle = Selector.GetHandle("setTextureSamplerValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetType_ = "setType:";

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURLValue_ = "setURLValue:";

	private static readonly IntPtr selSetURLValue_Handle = Selector.GetHandle("setURLValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureSamplerValue = "textureSamplerValue";

	private static readonly IntPtr selTextureSamplerValueHandle = Selector.GetHandle("textureSamplerValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMaterialProperty");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColor? Color
	{
		[Export("color", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 Float2Value
	{
		[Export("float2Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selFloat2ValueHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selFloat2ValueHandle);
		}
		[Export("setFloat2Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetFloat2Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetFloat2Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 Float3Value
	{
		[Export("float3Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selFloat3ValueHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selFloat3ValueHandle);
		}
		[Export("setFloat3Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetFloat3Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetFloat3Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector4 Float4Value
	{
		[Export("float4Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector4_objc_msgSend(base.Handle, selFloat4ValueHandle);
			}
			return Messaging.xamarin_simd__Vector4_objc_msgSendSuper(base.SuperHandle, selFloat4ValueHandle);
		}
		[Export("setFloat4Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector4(base.Handle, selSetFloat4Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetFloat4Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float FloatValue
	{
		[Export("floatValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFloatValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFloatValueHandle);
		}
		[Export("setFloatValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetFloatValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetFloatValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual float Luminance
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("luminance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLuminanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLuminanceHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setLuminance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLuminance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLuminance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'MatrixFloat4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix4 Matrix4x4
	{
		[Export("matrix4x4", ArgumentSemantic.Assign)]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selMatrix4x4Handle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMatrix4x4Handle);
			}
			return retval;
		}
		[Export("setMatrix4x4:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Matrix4(base.Handle, selSetMatrix4x4_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Matrix4(base.SuperHandle, selSetMatrix4x4_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 MatrixFloat4x4
	{
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selMatrix4x4Handle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMatrix4x4Handle);
			}
			return retval;
		}
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix4(base.Handle, selSetMatrix4x4_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4(base.SuperHandle, selSetMatrix4x4_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialSemantic Semantic
	{
		[Export("semantic", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialSemantic)Messaging.UInt64_objc_msgSend(base.Handle, selSemanticHandle);
			}
			return (MDLMaterialSemantic)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSemanticHandle);
		}
		[Export("setSemantic:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSemantic_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSemantic_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? StringValue
	{
		[Export("stringValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
		[Export("setStringValue:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStringValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStringValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTextureSampler? TextureSamplerValue
	{
		[Export("textureSamplerValue", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLTextureSampler>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureSamplerValueHandle));
			}
			return Runtime.GetNSObject<MDLTextureSampler>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureSamplerValueHandle));
		}
		[Export("setTextureSamplerValue:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextureSamplerValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextureSamplerValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialPropertyType Type
	{
		[Export("type", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialPropertyType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (MDLMaterialPropertyType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? UrlValue
	{
		[Export("URLValue", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLValueHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLValueHandle));
		}
		[Export("setURLValue:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURLValue_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURLValue_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLMaterialProperty(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMaterialProperty(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:semantic:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithName_Semantic_Handle, arg, (ulong)semantic), "initWithName:semantic:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithName_Semantic_Handle, arg, (ulong)semantic), "initWithName:semantic:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:float:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, float value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_float(base.Handle, selInitWithName_Semantic_Float_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_float(base.SuperHandle, selInitWithName_Semantic_Float_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:float2:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, Vector2 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Vector2(base.Handle, selInitWithName_Semantic_Float2_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float2:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Vector2(base.SuperHandle, selInitWithName_Semantic_Float2_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float2:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:float3:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, Vector3 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Vector3(base.Handle, selInitWithName_Semantic_Float3_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float3:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Vector3(base.SuperHandle, selInitWithName_Semantic_Float3_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float3:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:float4:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, Vector4 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Vector4(base.Handle, selInitWithName_Semantic_Float4_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float4:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Vector4(base.SuperHandle, selInitWithName_Semantic_Float4_Handle, arg, (ulong)semantic, value), "initWithName:semantic:float4:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:matrix4x4:")]
	[Obsolete("Use the '(string, MDLMaterialSemantic, MatrixFloat4x4)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, Matrix4 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Matrix4(base.Handle, selInitWithName_Semantic_Matrix4x4_Handle, arg, (ulong)semantic, value), "initWithName:semantic:matrix4x4:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Matrix4(base.SuperHandle, selInitWithName_Semantic_Matrix4x4_Handle, arg, (ulong)semantic, value), "initWithName:semantic:matrix4x4:");
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, NMatrix4 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_NMatrix4(base.Handle, selInitWithName_Semantic_Matrix4x4_Handle, arg, (ulong)semantic, value), "initWithName:semantic:matrix4x4:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_NMatrix4(base.SuperHandle, selInitWithName_Semantic_Matrix4x4_Handle, arg, (ulong)semantic, value), "initWithName:semantic:matrix4x4:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:URL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, NSUrl? url)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selInitWithName_Semantic_URL_Handle, arg, (ulong)semantic, (url == null) ? IntPtr.Zero : url.Handle), "initWithName:semantic:URL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selInitWithName_Semantic_URL_Handle, arg, (ulong)semantic, (url == null) ? IntPtr.Zero : url.Handle), "initWithName:semantic:URL:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:string:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, string? stringValue)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(stringValue);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selInitWithName_Semantic_String_Handle, arg, (ulong)semantic, arg2), "initWithName:semantic:string:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selInitWithName_Semantic_String_Handle, arg, (ulong)semantic, arg2), "initWithName:semantic:string:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithName:semantic:textureSampler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, MDLTextureSampler? textureSampler)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selInitWithName_Semantic_TextureSampler_Handle, arg, (ulong)semantic, textureSampler?.Handle ?? IntPtr.Zero), "initWithName:semantic:textureSampler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selInitWithName_Semantic_TextureSampler_Handle, arg, (ulong)semantic, textureSampler?.Handle ?? IntPtr.Zero), "initWithName:semantic:textureSampler:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:semantic:color:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMaterialProperty(string name, MDLMaterialSemantic semantic, CGColor color)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selInitWithName_Semantic_Color_Handle, arg, (ulong)semantic, color.Handle), "initWithName:semantic:color:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selInitWithName_Semantic_Color_Handle, arg, (ulong)semantic, color.Handle), "initWithName:semantic:color:");
		}
		NSString.ReleaseNative(arg);
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

	[Export("setProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetProperties(MDLMaterialProperty property)
	{
		if (property == null)
		{
			throw new ArgumentNullException("property");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProperties_Handle, property.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProperties_Handle, property.Handle);
		}
	}

	[Export("setType:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetType(MDLMaterialPropertyType type)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSetType_Handle, (ulong)type);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetType_Handle, (ulong)type);
		}
	}
}
