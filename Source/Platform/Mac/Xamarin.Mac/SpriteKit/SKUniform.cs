using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace SpriteKit;

[Register("SKUniform", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SKUniform : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	private static bool? versionCheck = null;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatMatrix2Value = "floatMatrix2Value";

	private static readonly IntPtr selFloatMatrix2ValueHandle = Selector.GetHandle("floatMatrix2Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatMatrix3Value = "floatMatrix3Value";

	private static readonly IntPtr selFloatMatrix3ValueHandle = Selector.GetHandle("floatMatrix3Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatMatrix4Value = "floatMatrix4Value";

	private static readonly IntPtr selFloatMatrix4ValueHandle = Selector.GetHandle("floatMatrix4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatValue = "floatValue";

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatVector2Value = "floatVector2Value";

	private static readonly IntPtr selFloatVector2ValueHandle = Selector.GetHandle("floatVector2Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatVector3Value = "floatVector3Value";

	private static readonly IntPtr selFloatVector3ValueHandle = Selector.GetHandle("floatVector3Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatVector4Value = "floatVector4Value";

	private static readonly IntPtr selFloatVector4ValueHandle = Selector.GetHandle("floatVector4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ = "initWithName:";

	private static readonly IntPtr selInitWithName_Handle = Selector.GetHandle("initWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Float_ = "initWithName:float:";

	private static readonly IntPtr selInitWithName_Float_Handle = Selector.GetHandle("initWithName:float:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_FloatMatrix2_ = "initWithName:floatMatrix2:";

	private static readonly IntPtr selInitWithName_FloatMatrix2_Handle = Selector.GetHandle("initWithName:floatMatrix2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_FloatMatrix3_ = "initWithName:floatMatrix3:";

	private static readonly IntPtr selInitWithName_FloatMatrix3_Handle = Selector.GetHandle("initWithName:floatMatrix3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_FloatMatrix4_ = "initWithName:floatMatrix4:";

	private static readonly IntPtr selInitWithName_FloatMatrix4_Handle = Selector.GetHandle("initWithName:floatMatrix4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_FloatVector2_ = "initWithName:floatVector2:";

	private static readonly IntPtr selInitWithName_FloatVector2_Handle = Selector.GetHandle("initWithName:floatVector2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_FloatVector3_ = "initWithName:floatVector3:";

	private static readonly IntPtr selInitWithName_FloatVector3_Handle = Selector.GetHandle("initWithName:floatVector3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_FloatVector4_ = "initWithName:floatVector4:";

	private static readonly IntPtr selInitWithName_FloatVector4_Handle = Selector.GetHandle("initWithName:floatVector4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_MatrixFloat2x2_ = "initWithName:matrixFloat2x2:";

	private static readonly IntPtr selInitWithName_MatrixFloat2x2_Handle = Selector.GetHandle("initWithName:matrixFloat2x2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_MatrixFloat3x3_ = "initWithName:matrixFloat3x3:";

	private static readonly IntPtr selInitWithName_MatrixFloat3x3_Handle = Selector.GetHandle("initWithName:matrixFloat3x3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_MatrixFloat4x4_ = "initWithName:matrixFloat4x4:";

	private static readonly IntPtr selInitWithName_MatrixFloat4x4_Handle = Selector.GetHandle("initWithName:matrixFloat4x4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Texture_ = "initWithName:texture:";

	private static readonly IntPtr selInitWithName_Texture_Handle = Selector.GetHandle("initWithName:texture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_VectorFloat2_ = "initWithName:vectorFloat2:";

	private static readonly IntPtr selInitWithName_VectorFloat2_Handle = Selector.GetHandle("initWithName:vectorFloat2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_VectorFloat3_ = "initWithName:vectorFloat3:";

	private static readonly IntPtr selInitWithName_VectorFloat3_Handle = Selector.GetHandle("initWithName:vectorFloat3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_VectorFloat4_ = "initWithName:vectorFloat4:";

	private static readonly IntPtr selInitWithName_VectorFloat4_Handle = Selector.GetHandle("initWithName:vectorFloat4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixFloat2x2Value = "matrixFloat2x2Value";

	private static readonly IntPtr selMatrixFloat2x2ValueHandle = Selector.GetHandle("matrixFloat2x2Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixFloat3x3Value = "matrixFloat3x3Value";

	private static readonly IntPtr selMatrixFloat3x3ValueHandle = Selector.GetHandle("matrixFloat3x3Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixFloat4x4Value = "matrixFloat4x4Value";

	private static readonly IntPtr selMatrixFloat4x4ValueHandle = Selector.GetHandle("matrixFloat4x4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatMatrix2Value_ = "setFloatMatrix2Value:";

	private static readonly IntPtr selSetFloatMatrix2Value_Handle = Selector.GetHandle("setFloatMatrix2Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatMatrix3Value_ = "setFloatMatrix3Value:";

	private static readonly IntPtr selSetFloatMatrix3Value_Handle = Selector.GetHandle("setFloatMatrix3Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatMatrix4Value_ = "setFloatMatrix4Value:";

	private static readonly IntPtr selSetFloatMatrix4Value_Handle = Selector.GetHandle("setFloatMatrix4Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatValue_ = "setFloatValue:";

	private static readonly IntPtr selSetFloatValue_Handle = Selector.GetHandle("setFloatValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatVector2Value_ = "setFloatVector2Value:";

	private static readonly IntPtr selSetFloatVector2Value_Handle = Selector.GetHandle("setFloatVector2Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatVector3Value_ = "setFloatVector3Value:";

	private static readonly IntPtr selSetFloatVector3Value_Handle = Selector.GetHandle("setFloatVector3Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatVector4Value_ = "setFloatVector4Value:";

	private static readonly IntPtr selSetFloatVector4Value_Handle = Selector.GetHandle("setFloatVector4Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrixFloat2x2Value_ = "setMatrixFloat2x2Value:";

	private static readonly IntPtr selSetMatrixFloat2x2Value_Handle = Selector.GetHandle("setMatrixFloat2x2Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrixFloat3x3Value_ = "setMatrixFloat3x3Value:";

	private static readonly IntPtr selSetMatrixFloat3x3Value_Handle = Selector.GetHandle("setMatrixFloat3x3Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrixFloat4x4Value_ = "setMatrixFloat4x4Value:";

	private static readonly IntPtr selSetMatrixFloat4x4Value_Handle = Selector.GetHandle("setMatrixFloat4x4Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextureValue_ = "setTextureValue:";

	private static readonly IntPtr selSetTextureValue_Handle = Selector.GetHandle("setTextureValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVectorFloat2Value_ = "setVectorFloat2Value:";

	private static readonly IntPtr selSetVectorFloat2Value_Handle = Selector.GetHandle("setVectorFloat2Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVectorFloat3Value_ = "setVectorFloat3Value:";

	private static readonly IntPtr selSetVectorFloat3Value_Handle = Selector.GetHandle("setVectorFloat3Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVectorFloat4Value_ = "setVectorFloat4Value:";

	private static readonly IntPtr selSetVectorFloat4Value_Handle = Selector.GetHandle("setVectorFloat4Value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureValue = "textureValue";

	private static readonly IntPtr selTextureValueHandle = Selector.GetHandle("textureValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformType = "uniformType";

	private static readonly IntPtr selUniformTypeHandle = Selector.GetHandle("uniformType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_ = "uniformWithName:";

	private static readonly IntPtr selUniformWithName_Handle = Selector.GetHandle("uniformWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_Float_ = "uniformWithName:float:";

	private static readonly IntPtr selUniformWithName_Float_Handle = Selector.GetHandle("uniformWithName:float:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_MatrixFloat2x2_ = "uniformWithName:matrixFloat2x2:";

	private static readonly IntPtr selUniformWithName_MatrixFloat2x2_Handle = Selector.GetHandle("uniformWithName:matrixFloat2x2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_MatrixFloat3x3_ = "uniformWithName:matrixFloat3x3:";

	private static readonly IntPtr selUniformWithName_MatrixFloat3x3_Handle = Selector.GetHandle("uniformWithName:matrixFloat3x3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_MatrixFloat4x4_ = "uniformWithName:matrixFloat4x4:";

	private static readonly IntPtr selUniformWithName_MatrixFloat4x4_Handle = Selector.GetHandle("uniformWithName:matrixFloat4x4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_Texture_ = "uniformWithName:texture:";

	private static readonly IntPtr selUniformWithName_Texture_Handle = Selector.GetHandle("uniformWithName:texture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_VectorFloat2_ = "uniformWithName:vectorFloat2:";

	private static readonly IntPtr selUniformWithName_VectorFloat2_Handle = Selector.GetHandle("uniformWithName:vectorFloat2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_VectorFloat3_ = "uniformWithName:vectorFloat3:";

	private static readonly IntPtr selUniformWithName_VectorFloat3_Handle = Selector.GetHandle("uniformWithName:vectorFloat3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformWithName_VectorFloat4_ = "uniformWithName:vectorFloat4:";

	private static readonly IntPtr selUniformWithName_VectorFloat4_Handle = Selector.GetHandle("uniformWithName:vectorFloat4:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorFloat2Value = "vectorFloat2Value";

	private static readonly IntPtr selVectorFloat2ValueHandle = Selector.GetHandle("vectorFloat2Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorFloat3Value = "vectorFloat3Value";

	private static readonly IntPtr selVectorFloat3ValueHandle = Selector.GetHandle("vectorFloat3Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorFloat4Value = "vectorFloat4Value";

	private static readonly IntPtr selVectorFloat4ValueHandle = Selector.GetHandle("vectorFloat4Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKUniform");

	public virtual Vector2 FloatVector2Value
	{
		get
		{
			if (CheckSystemVersion())
			{
				return _VectorFloat2Value;
			}
			return _FloatVector2Value;
		}
		set
		{
			if (CheckSystemVersion())
			{
				_VectorFloat2Value = value;
			}
			else
			{
				_FloatVector2Value = value;
			}
		}
	}

	public virtual Vector3 FloatVector3Value
	{
		get
		{
			if (CheckSystemVersion())
			{
				return _VectorFloat3Value;
			}
			return _FloatVector3Value;
		}
		set
		{
			if (CheckSystemVersion())
			{
				_VectorFloat3Value = value;
			}
			else
			{
				_FloatVector3Value = value;
			}
		}
	}

	public virtual Vector4 FloatVector4Value
	{
		get
		{
			if (CheckSystemVersion())
			{
				return _VectorFloat4Value;
			}
			return _FloatVector4Value;
		}
		set
		{
			if (CheckSystemVersion())
			{
				_VectorFloat4Value = value;
			}
			else
			{
				_FloatVector4Value = value;
			}
		}
	}

	[Obsolete("Use 'MatrixFloat2x2Value' instead.")]
	public virtual Matrix2 FloatMatrix2Value
	{
		get
		{
			if (CheckSystemVersion())
			{
				return (Matrix2)NMatrix2.Transpose(MatrixFloat2x2Value);
			}
			return _FloatMatrix2Value;
		}
		set
		{
			if (CheckSystemVersion())
			{
				MatrixFloat2x2Value = NMatrix2.Transpose((NMatrix2)value);
			}
			else
			{
				_FloatMatrix2Value = value;
			}
		}
	}

	[Obsolete("Use 'MatrixFloat3x3Value' instead.")]
	public virtual Matrix3 FloatMatrix3Value
	{
		get
		{
			if (CheckSystemVersion())
			{
				return (Matrix3)NMatrix3.Transpose(MatrixFloat3x3Value);
			}
			return _FloatMatrix3Value;
		}
		set
		{
			if (CheckSystemVersion())
			{
				MatrixFloat3x3Value = NMatrix3.Transpose((NMatrix3)value);
			}
			else
			{
				_FloatMatrix3Value = value;
			}
		}
	}

	[Obsolete("Use 'MatrixFloat4x4Value' instead.")]
	public virtual Matrix4 FloatMatrix4Value
	{
		get
		{
			if (CheckSystemVersion())
			{
				return (Matrix4)NMatrix4.Transpose(MatrixFloat4x4Value);
			}
			return _FloatMatrix4Value;
		}
		set
		{
			if (CheckSystemVersion())
			{
				MatrixFloat4x4Value = NMatrix4.Transpose((NMatrix4)value);
			}
			else
			{
				_FloatMatrix4Value = value;
			}
		}
	}

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual NMatrix2 MatrixFloat2x2Value
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("matrixFloat2x2Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__NMatrix2_objc_msgSend(base.Handle, selMatrixFloat2x2ValueHandle);
			}
			return Messaging.xamarin_simd__NMatrix2_objc_msgSendSuper(base.SuperHandle, selMatrixFloat2x2ValueHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setMatrixFloat2x2Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix2(base.Handle, selSetMatrixFloat2x2Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix2(base.SuperHandle, selSetMatrixFloat2x2Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NMatrix3 MatrixFloat3x3Value
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("matrixFloat3x3Value", ArgumentSemantic.Assign)]
		get
		{
			NMatrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSend_stret(out retval, base.Handle, selMatrixFloat3x3ValueHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMatrixFloat3x3ValueHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setMatrixFloat3x3Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix3(base.Handle, selSetMatrixFloat3x3Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix3(base.SuperHandle, selSetMatrixFloat3x3Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NMatrix4 MatrixFloat4x4Value
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("matrixFloat4x4Value", ArgumentSemantic.Assign)]
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selMatrixFloat4x4ValueHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMatrixFloat4x4ValueHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setMatrixFloat4x4Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix4(base.Handle, selSetMatrixFloat4x4Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4(base.SuperHandle, selSetMatrixFloat4x4Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture TextureValue
	{
		[Export("textureValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureValueHandle));
			}
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureValueHandle));
		}
		[Export("setTextureValue:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextureValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextureValue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKUniformType UniformType
	{
		[Export("uniformType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKUniformType)Messaging.Int64_objc_msgSend(base.Handle, selUniformTypeHandle);
			}
			return (SKUniformType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUniformTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	internal virtual Matrix2 _FloatMatrix2Value
	{
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("floatMatrix2Value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Matrix2_objc_msgSend(base.Handle, selFloatMatrix2ValueHandle);
			}
			return Messaging.Matrix2_objc_msgSendSuper(base.SuperHandle, selFloatMatrix2ValueHandle);
		}
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setFloatMatrix2Value:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Matrix2(base.Handle, selSetFloatMatrix2Value_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Matrix2(base.SuperHandle, selSetFloatMatrix2Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	internal virtual Matrix3 _FloatMatrix3Value
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("floatMatrix3Value")]
		get
		{
			Matrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.Matrix3_objc_msgSend_stret(out retval, base.Handle, selFloatMatrix3ValueHandle);
			}
			else
			{
				Messaging.Matrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFloatMatrix3ValueHandle);
			}
			return retval;
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setFloatMatrix3Value:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Matrix3(base.Handle, selSetFloatMatrix3Value_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Matrix3(base.SuperHandle, selSetFloatMatrix3Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	internal virtual Matrix4 _FloatMatrix4Value
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("floatMatrix4Value")]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.Matrix4_objc_msgSend_stret(out retval, base.Handle, selFloatMatrix4ValueHandle);
			}
			else
			{
				Messaging.Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFloatMatrix4ValueHandle);
			}
			return retval;
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setFloatMatrix4Value:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Matrix4(base.Handle, selSetFloatMatrix4Value_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Matrix4(base.SuperHandle, selSetFloatMatrix4Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	internal virtual Vector2 _FloatVector2Value
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("floatVector2Value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Vector2_objc_msgSend(base.Handle, selFloatVector2ValueHandle);
			}
			return Messaging.Vector2_objc_msgSendSuper(base.SuperHandle, selFloatVector2ValueHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setFloatVector2Value:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector2(base.Handle, selSetFloatVector2Value_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetFloatVector2Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	internal virtual Vector3 _FloatVector3Value
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("floatVector3Value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Vector3_objc_msgSend(base.Handle, selFloatVector3ValueHandle);
			}
			return Messaging.Vector3_objc_msgSendSuper(base.SuperHandle, selFloatVector3ValueHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setFloatVector3Value:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector3(base.Handle, selSetFloatVector3Value_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetFloatVector3Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	internal virtual Vector4 _FloatVector4Value
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("floatVector4Value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Vector4_objc_msgSend(base.Handle, selFloatVector4ValueHandle);
			}
			return Messaging.Vector4_objc_msgSendSuper(base.SuperHandle, selFloatVector4ValueHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Export("setFloatVector4Value:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Vector4(base.Handle, selSetFloatVector4Value_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetFloatVector4Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	internal virtual Vector2 _VectorFloat2Value
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("vectorFloat2Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selVectorFloat2ValueHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selVectorFloat2ValueHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setVectorFloat2Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector2(base.Handle, selSetVectorFloat2Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2(base.SuperHandle, selSetVectorFloat2Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	internal virtual Vector3 _VectorFloat3Value
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("vectorFloat3Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selVectorFloat3ValueHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selVectorFloat3ValueHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setVectorFloat3Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector3(base.Handle, selSetVectorFloat3Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3(base.SuperHandle, selSetVectorFloat3Value_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	internal virtual Vector4 _VectorFloat4Value
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("vectorFloat4Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector4_objc_msgSend(base.Handle, selVectorFloat4ValueHandle);
			}
			return Messaging.xamarin_simd__Vector4_objc_msgSendSuper(base.SuperHandle, selVectorFloat4ValueHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setVectorFloat4Value:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Vector4(base.Handle, selSetVectorFloat4Value_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4(base.SuperHandle, selSetVectorFloat4Value_Handle, value);
			}
		}
	}

	private static bool CheckSystemVersion()
	{
		if (!versionCheck.HasValue)
		{
			versionCheck = PlatformHelper.CheckSystemVersion(10, 12);
		}
		return versionCheck.Value;
	}

	public SKUniform(string name, Vector2 value)
	{
		if (CheckSystemVersion())
		{
			InitializeHandle(InitWithNameVectorFloat2(name, value), "initWithName:vectorFloat2:");
		}
		else
		{
			InitializeHandle(InitWithNameFloatVector2(name, value), "initWithName:floatVector2:");
		}
	}

	public SKUniform(string name, Vector3 value)
	{
		if (CheckSystemVersion())
		{
			InitializeHandle(InitWithNameVectorFloat3(name, value), "initWithName:vectorFloat3:");
		}
		else
		{
			InitializeHandle(InitWithNameFloatVector3(name, value), "initWithName:floatVector3:");
		}
	}

	public SKUniform(string name, Vector4 value)
	{
		if (CheckSystemVersion())
		{
			InitializeHandle(InitWithNameVectorFloat4(name, value), "initWithName:vectorFloat4:");
		}
		else
		{
			InitializeHandle(InitWithNameFloatVector4(name, value), "initWithName:floatVector4:");
		}
	}

	[Obsolete("Use the '(string, MatrixFloat2x2)' overload instead.")]
	public SKUniform(string name, Matrix2 value)
	{
		if (CheckSystemVersion())
		{
			InitializeHandle(InitWithNameMatrixFloat2x2(name, value), "initWithName:matrixFloat2x2:");
		}
		else
		{
			InitializeHandle(InitWithNameFloatMatrix2(name, value), "initWithName:floatMatrix2:");
		}
	}

	[Obsolete("Use the '(string, MatrixFloat3x3)' overload instead.")]
	public SKUniform(string name, Matrix3 value)
	{
		if (CheckSystemVersion())
		{
			InitializeHandle(InitWithNameMatrixFloat3x3(name, value), "initWithName:matrixFloat3x3:");
		}
		else
		{
			InitializeHandle(InitWithNameFloatMatrix3(name, value), "initWithName:floatMatrix3:");
		}
	}

	[Obsolete("Use the '(string, MatrixFloat4x4)' overload instead.")]
	public SKUniform(string name, Matrix4 value)
	{
		if (CheckSystemVersion())
		{
			InitializeHandle(InitWithNameMatrixFloat4x4(name, value), "initWithName:matrixFloat4x4:");
		}
		else
		{
			InitializeHandle(InitWithNameFloatMatrix4(name, value), "initWithName:floatMatrix4:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKUniform()
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
	public SKUniform(NSCoder coder)
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
	protected SKUniform(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKUniform(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKUniform(string name)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithName_Handle, arg), "initWithName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithName_Handle, arg), "initWithName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:texture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKUniform(string name, SKTexture texture)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_Texture_Handle, arg, texture.Handle), "initWithName:texture:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_Texture_Handle, arg, texture.Handle), "initWithName:texture:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:float:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKUniform(string name, float value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float(base.Handle, selInitWithName_Float_Handle, arg, value), "initWithName:float:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selInitWithName_Float_Handle, arg, value), "initWithName:float:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:matrixFloat2x2:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKUniform(string name, NMatrix2 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_NMatrix2(base.Handle, selInitWithName_MatrixFloat2x2_Handle, arg, value), "initWithName:matrixFloat2x2:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_NMatrix2(base.SuperHandle, selInitWithName_MatrixFloat2x2_Handle, arg, value), "initWithName:matrixFloat2x2:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:matrixFloat3x3:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKUniform(string name, NMatrix3 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_NMatrix3(base.Handle, selInitWithName_MatrixFloat3x3_Handle, arg, value), "initWithName:matrixFloat3x3:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_NMatrix3(base.SuperHandle, selInitWithName_MatrixFloat3x3_Handle, arg, value), "initWithName:matrixFloat3x3:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:matrixFloat4x4:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKUniform(string name, NMatrix4 value)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_NMatrix4(base.Handle, selInitWithName_MatrixFloat4x4_Handle, arg, value), "initWithName:matrixFloat4x4:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_NMatrix4(base.SuperHandle, selInitWithName_MatrixFloat4x4_Handle, arg, value), "initWithName:matrixFloat4x4:");
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

	[Export("uniformWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUniformWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:texture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, SKTexture? texture)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selUniformWithName_Texture_Handle, arg, texture?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:float:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, float value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selUniformWithName_Float_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:vectorFloat2:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, Vector2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2(class_ptr, selUniformWithName_VectorFloat2_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:vectorFloat3:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, Vector3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector3(class_ptr, selUniformWithName_VectorFloat3_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:vectorFloat4:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, Vector4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector4(class_ptr, selUniformWithName_VectorFloat4_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:matrixFloat2x2:")]
	[Obsolete("Use the '(string, MatrixFloat2x2)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, Matrix2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Matrix2(class_ptr, selUniformWithName_MatrixFloat2x2_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:matrixFloat2x2:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, NMatrix2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_NMatrix2(class_ptr, selUniformWithName_MatrixFloat2x2_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:matrixFloat3x3:")]
	[Obsolete("Use the '(string, MatrixFloat3x3)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, Matrix3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Matrix3(class_ptr, selUniformWithName_MatrixFloat3x3_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:matrixFloat3x3:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, NMatrix3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_NMatrix3(class_ptr, selUniformWithName_MatrixFloat3x3_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:matrixFloat4x4:")]
	[Obsolete("Use 'the '(string, MatrixFloat4x4)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, Matrix4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Matrix4(class_ptr, selUniformWithName_MatrixFloat4x4_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("uniformWithName:matrixFloat4x4:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKUniform Create(string name, NMatrix4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKUniform nSObject = Runtime.GetNSObject<SKUniform>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_NMatrix4(class_ptr, selUniformWithName_MatrixFloat4x4_Handle, arg, value));
		NSString.ReleaseNative(arg);
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

	[Export("initWithName:floatMatrix2:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameFloatMatrix2(string name, Matrix2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_Matrix2(base.SuperHandle, selInitWithName_FloatMatrix2_Handle, arg, value) : Messaging.IntPtr_objc_msgSend_IntPtr_Matrix2(base.Handle, selInitWithName_FloatMatrix2_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:floatMatrix3:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameFloatMatrix3(string name, Matrix3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_Matrix3(base.SuperHandle, selInitWithName_FloatMatrix3_Handle, arg, value) : Messaging.IntPtr_objc_msgSend_IntPtr_Matrix3(base.Handle, selInitWithName_FloatMatrix3_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:floatMatrix4:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameFloatMatrix4(string name, Matrix4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_Matrix4(base.SuperHandle, selInitWithName_FloatMatrix4_Handle, arg, value) : Messaging.IntPtr_objc_msgSend_IntPtr_Matrix4(base.Handle, selInitWithName_FloatMatrix4_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:floatVector2:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameFloatVector2(string name, Vector2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_Vector2(base.SuperHandle, selInitWithName_FloatVector2_Handle, arg, value) : Messaging.IntPtr_objc_msgSend_IntPtr_Vector2(base.Handle, selInitWithName_FloatVector2_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:floatVector3:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameFloatVector3(string name, Vector3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_Vector3(base.SuperHandle, selInitWithName_FloatVector3_Handle, arg, value) : Messaging.IntPtr_objc_msgSend_IntPtr_Vector3(base.Handle, selInitWithName_FloatVector3_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:floatVector4:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameFloatVector4(string name, Vector4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_Vector4(base.SuperHandle, selInitWithName_FloatVector4_Handle, arg, value) : Messaging.IntPtr_objc_msgSend_IntPtr_Vector4(base.Handle, selInitWithName_FloatVector4_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Obsolete("Use the '(string, MatrixFloat2x2)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithNameMatrixFloat2x2(string name, Matrix2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Matrix2(base.Handle, selInitWithName_MatrixFloat2x2_Handle, arg, value);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Obsolete("Use the '(string, MatrixFloat3x3)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithNameMatrixFloat3x3(string name, Matrix3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Matrix3(base.Handle, selInitWithName_MatrixFloat3x3_Handle, arg, value);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Obsolete("Use the '(string, MatrixFloat4x4)' overload instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithNameMatrixFloat4x4(string name, Matrix4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Matrix4(base.Handle, selInitWithName_MatrixFloat4x4_Handle, arg, value);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:vectorFloat2:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameVectorFloat2(string name, Vector2 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector2(base.SuperHandle, selInitWithName_VectorFloat2_Handle, arg, value) : Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2(base.Handle, selInitWithName_VectorFloat2_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:vectorFloat3:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameVectorFloat3(string name, Vector3 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector3(base.SuperHandle, selInitWithName_VectorFloat3_Handle, arg, value) : Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector3(base.Handle, selInitWithName_VectorFloat3_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:vectorFloat4:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithNameVectorFloat4(string name, Vector4 value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector4(base.SuperHandle, selInitWithName_VectorFloat4_Handle, arg, value) : Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector4(base.Handle, selInitWithName_VectorFloat4_Handle, arg, value));
		NSString.ReleaseNative(arg);
		return result;
	}
}
