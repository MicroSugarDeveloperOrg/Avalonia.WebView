using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[iOS(9, 0)]
[Mac(10, 11)]
[Register("AUParameter", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AUParameter : AUParameterNode, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddress = "address";

	private static readonly IntPtr selAddressHandle = Selector.GetHandle("address");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDependentParameters = "dependentParameters";

	private static readonly IntPtr selDependentParametersHandle = Selector.GetHandle("dependentParameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlags = "flags";

	private static readonly IntPtr selFlagsHandle = Selector.GetHandle("flags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxValue = "maxValue";

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinValue = "minValue";

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_Originator_ = "setValue:originator:";

	private static readonly IntPtr selSetValue_Originator_Handle = Selector.GetHandle("setValue:originator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_Originator_AtHostTime_ = "setValue:originator:atHostTime:";

	private static readonly IntPtr selSetValue_Originator_AtHostTime_Handle = Selector.GetHandle("setValue:originator:atHostTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_Originator_AtHostTime_EventType_ = "setValue:originator:atHostTime:eventType:";

	private static readonly IntPtr selSetValue_Originator_AtHostTime_EventType_Handle = Selector.GetHandle("setValue:originator:atHostTime:eventType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromValue_ = "stringFromValue:";

	private static readonly IntPtr selStringFromValue_Handle = Selector.GetHandle("stringFromValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnit = "unit";

	private static readonly IntPtr selUnitHandle = Selector.GetHandle("unit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitName = "unitName";

	private static readonly IntPtr selUnitNameHandle = Selector.GetHandle("unitName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueFromString_ = "valueFromString:";

	private static readonly IntPtr selValueFromString_Handle = Selector.GetHandle("valueFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueStrings = "valueStrings";

	private static readonly IntPtr selValueStringsHandle = Selector.GetHandle("valueStrings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUParameter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong Address
	{
		[Export("address")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selAddressHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAddressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? DependentParameters
	{
		[Export("dependentParameters", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selDependentParametersHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDependentParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AudioUnitParameterOptions Flags
	{
		[Export("flags")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AudioUnitParameterOptions)Messaging.UInt32_objc_msgSend(base.Handle, selFlagsHandle);
			}
			return (AudioUnitParameterOptions)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFlagsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaxValue
	{
		[Export("maxValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaxValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaxValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinValue
	{
		[Export("minValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AudioUnitParameterUnit Unit
	{
		[Export("unit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AudioUnitParameterUnit)Messaging.int_objc_msgSend(base.Handle, selUnitHandle);
			}
			return (AudioUnitParameterUnit)Messaging.int_objc_msgSendSuper(base.SuperHandle, selUnitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? UnitName
	{
		[Export("unitName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUnitNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnitNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selValueHandle);
		}
		[Export("setValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? ValueStrings
	{
		[Export("valueStrings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValueStringsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueStringsHandle));
		}
	}

	public unsafe string GetString(float? value)
	{
		if (value.HasValue && value.HasValue)
		{
			float value2 = value.Value;
			return _GetString(new IntPtr(&value2));
		}
		return _GetString(IntPtr.Zero);
	}

	public void SetValue(float value, AUParameterObserverToken originator)
	{
		SetValue(value, originator.ObserverToken);
	}

	public void SetValue(float value, AUParameterObserverToken originator, ulong hostTime)
	{
		SetValue(value, originator.ObserverToken, hostTime);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AUParameter()
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
	public AUParameter(NSCoder coder)
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
	protected AUParameter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUParameter(IntPtr handle)
		: base(handle)
	{
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

	[Export("stringFromValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetString(ref float value)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_ref_Single(base.Handle, selStringFromValue_Handle, ref value));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_ref_Single(base.SuperHandle, selStringFromValue_Handle, ref value));
	}

	[Export("valueFromString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetValue(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		float result = ((!base.IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueFromString_Handle, arg) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selValueFromString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setValue:originator:")]
	[Obsolete("Use the 'AUParameterObserverToken' overload.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(float value, IntPtr originator)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selSetValue_Originator_Handle, value, originator);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selSetValue_Originator_Handle, value, originator);
		}
	}

	[Export("setValue:originator:atHostTime:")]
	[Obsolete("Use the 'AUParameterObserverToken' overload.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(float value, IntPtr originator, ulong hostTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr_UInt64(base.Handle, selSetValue_Originator_AtHostTime_Handle, value, originator, hostTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr_UInt64(base.SuperHandle, selSetValue_Originator_AtHostTime_Handle, value, originator, hostTime);
		}
	}

	[Export("setValue:originator:atHostTime:eventType:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void SetValue(float value, IntPtr originator, ulong hostTime, AUParameterAutomationEventType eventType)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr_UInt64_UInt32(base.Handle, selSetValue_Originator_AtHostTime_EventType_Handle, value, originator, hostTime, (uint)eventType);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr_UInt64_UInt32(base.SuperHandle, selSetValue_Originator_AtHostTime_EventType_Handle, value, originator, hostTime, (uint)eventType);
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetValue(float value, AUParameterObserverToken originator, ulong hostTime, AUParameterAutomationEventType eventType)
	{
		SetValue(value, originator.ObserverToken, hostTime, eventType);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal string _GetString(IntPtr value)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromValue_Handle, value));
	}
}
