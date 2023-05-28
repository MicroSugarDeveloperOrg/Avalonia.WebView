using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMeasurement", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class NSMeasurement<UnitType> : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding where UnitType : NSUnit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBeConvertedToUnit_ = "canBeConvertedToUnit:";

	private static readonly IntPtr selCanBeConvertedToUnit_Handle = Selector.GetHandle("canBeConvertedToUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDoubleValue_Unit_ = "initWithDoubleValue:unit:";

	private static readonly IntPtr selInitWithDoubleValue_Unit_Handle = Selector.GetHandle("initWithDoubleValue:unit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeasurementByAddingMeasurement_ = "measurementByAddingMeasurement:";

	private static readonly IntPtr selMeasurementByAddingMeasurement_Handle = Selector.GetHandle("measurementByAddingMeasurement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeasurementByConvertingToUnit_ = "measurementByConvertingToUnit:";

	private static readonly IntPtr selMeasurementByConvertingToUnit_Handle = Selector.GetHandle("measurementByConvertingToUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeasurementBySubtractingMeasurement_ = "measurementBySubtractingMeasurement:";

	private static readonly IntPtr selMeasurementBySubtractingMeasurement_Handle = Selector.GetHandle("measurementBySubtractingMeasurement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnit = "unit";

	private static readonly IntPtr selUnitHandle = Selector.GetHandle("unit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMeasurement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUnit Unit
	{
		[Export("unit", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUnit>(Messaging.IntPtr_objc_msgSend(base.Handle, selUnitHandle));
			}
			return Runtime.GetNSObject<NSUnit>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnitHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMeasurement(NSCoder coder)
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
	protected NSMeasurement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMeasurement(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDoubleValue:unit:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMeasurement(double doubleValue, NSUnit unit)
		: base(NSObjectFlag.Empty)
	{
		if (unit == null)
		{
			throw new ArgumentNullException("unit");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double_IntPtr(base.Handle, selInitWithDoubleValue_Unit_Handle, doubleValue, unit.Handle), "initWithDoubleValue:unit:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selInitWithDoubleValue_Unit_Handle, doubleValue, unit.Handle), "initWithDoubleValue:unit:");
		}
	}

	[Export("canBeConvertedToUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBeConvertedTo(NSUnit unit)
	{
		if (unit == null)
		{
			throw new ArgumentNullException("unit");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanBeConvertedToUnit_Handle, unit.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanBeConvertedToUnit_Handle, unit.Handle);
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

	[Export("measurementByAddingMeasurement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMeasurement<UnitType> GetMeasurementByAdding(NSMeasurement<UnitType> measurement)
	{
		if (measurement == null)
		{
			throw new ArgumentNullException("measurement");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMeasurement<UnitType>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMeasurementByAddingMeasurement_Handle, measurement.Handle));
		}
		return Runtime.GetNSObject<NSMeasurement<UnitType>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMeasurementByAddingMeasurement_Handle, measurement.Handle));
	}

	[Export("measurementByConvertingToUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMeasurement<UnitType> GetMeasurementByConverting(NSUnit unit)
	{
		if (unit == null)
		{
			throw new ArgumentNullException("unit");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMeasurement<UnitType>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMeasurementByConvertingToUnit_Handle, unit.Handle));
		}
		return Runtime.GetNSObject<NSMeasurement<UnitType>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMeasurementByConvertingToUnit_Handle, unit.Handle));
	}

	[Export("measurementBySubtractingMeasurement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMeasurement<UnitType> GetMeasurementBySubtracting(NSMeasurement<UnitType> measurement)
	{
		if (measurement == null)
		{
			throw new ArgumentNullException("measurement");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMeasurement<UnitType>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMeasurementBySubtractingMeasurement_Handle, measurement.Handle));
		}
		return Runtime.GetNSObject<NSMeasurement<UnitType>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMeasurementBySubtractingMeasurement_Handle, measurement.Handle));
	}
}
