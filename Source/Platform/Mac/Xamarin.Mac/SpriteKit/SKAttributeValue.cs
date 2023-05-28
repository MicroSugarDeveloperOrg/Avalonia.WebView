using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace SpriteKit;

[Register("SKAttributeValue", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class SKAttributeValue : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatValue = "floatValue";

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatValue_ = "setFloatValue:";

	private static readonly IntPtr selSetFloatValue_Handle = Selector.GetHandle("setFloatValue:");

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
	private const string selValueWithFloat_ = "valueWithFloat:";

	private static readonly IntPtr selValueWithFloat_Handle = Selector.GetHandle("valueWithFloat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithVectorFloat2_ = "valueWithVectorFloat2:";

	private static readonly IntPtr selValueWithVectorFloat2_Handle = Selector.GetHandle("valueWithVectorFloat2:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithVectorFloat3_ = "valueWithVectorFloat3:";

	private static readonly IntPtr selValueWithVectorFloat3_Handle = Selector.GetHandle("valueWithVectorFloat3:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueWithVectorFloat4_ = "valueWithVectorFloat4:";

	private static readonly IntPtr selValueWithVectorFloat4_Handle = Selector.GetHandle("valueWithVectorFloat4:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKAttributeValue");

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
	public virtual Vector2 VectorFloat2Value
	{
		[Export("vectorFloat2Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2_objc_msgSend(base.Handle, selVectorFloat2ValueHandle);
			}
			return Messaging.xamarin_simd__Vector2_objc_msgSendSuper(base.SuperHandle, selVectorFloat2ValueHandle);
		}
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
	public virtual Vector3 VectorFloat3Value
	{
		[Export("vectorFloat3Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector3_objc_msgSend(base.Handle, selVectorFloat3ValueHandle);
			}
			return Messaging.xamarin_simd__Vector3_objc_msgSendSuper(base.SuperHandle, selVectorFloat3ValueHandle);
		}
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
	public virtual Vector4 VectorFloat4Value
	{
		[Export("vectorFloat4Value", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector4_objc_msgSend(base.Handle, selVectorFloat4ValueHandle);
			}
			return Messaging.xamarin_simd__Vector4_objc_msgSendSuper(base.SuperHandle, selVectorFloat4ValueHandle);
		}
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKAttributeValue(NSCoder coder)
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
	protected SKAttributeValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKAttributeValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKAttributeValue()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("valueWithFloat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAttributeValue Create(float value)
	{
		return Runtime.GetNSObject<SKAttributeValue>(Messaging.IntPtr_objc_msgSend_float(class_ptr, selValueWithFloat_Handle, value));
	}

	[Export("valueWithVectorFloat2:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAttributeValue Create(Vector2 value)
	{
		return Runtime.GetNSObject<SKAttributeValue>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2(class_ptr, selValueWithVectorFloat2_Handle, value));
	}

	[Export("valueWithVectorFloat3:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAttributeValue Create(Vector3 value)
	{
		return Runtime.GetNSObject<SKAttributeValue>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3(class_ptr, selValueWithVectorFloat3_Handle, value));
	}

	[Export("valueWithVectorFloat4:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKAttributeValue Create(Vector4 value)
	{
		return Runtime.GetNSObject<SKAttributeValue>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector4(class_ptr, selValueWithVectorFloat4_Handle, value));
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
}
