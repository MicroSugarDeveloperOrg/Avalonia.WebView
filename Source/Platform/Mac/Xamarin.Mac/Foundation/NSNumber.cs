using System.ComponentModel;
using CloudKit;
using CoreData;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSNumber", true)]
public class NSNumber : NSValue, IComparable, IComparable<NSNumber>, IEquatable<NSNumber>, ICKRecordValue, INativeObject, IDisposable, INSFetchRequestResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoolValue = "boolValue";

	private static readonly IntPtr selBoolValueHandle = Selector.GetHandle("boolValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharValue = "charValue";

	private static readonly IntPtr selCharValueHandle = Selector.GetHandle("charValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompare_ = "compare:";

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalValue = "decimalValue";

	private static readonly IntPtr selDecimalValueHandle = Selector.GetHandle("decimalValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptionWithLocale_ = "descriptionWithLocale:";

	private static readonly IntPtr selDescriptionWithLocale_Handle = Selector.GetHandle("descriptionWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatValue = "floatValue";

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBool_ = "initWithBool:";

	private static readonly IntPtr selInitWithBool_Handle = Selector.GetHandle("initWithBool:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithChar_ = "initWithChar:";

	private static readonly IntPtr selInitWithChar_Handle = Selector.GetHandle("initWithChar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDouble_ = "initWithDouble:";

	private static readonly IntPtr selInitWithDouble_Handle = Selector.GetHandle("initWithDouble:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFloat_ = "initWithFloat:";

	private static readonly IntPtr selInitWithFloat_Handle = Selector.GetHandle("initWithFloat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInt_ = "initWithInt:";

	private static readonly IntPtr selInitWithInt_Handle = Selector.GetHandle("initWithInt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInteger_ = "initWithInteger:";

	private static readonly IntPtr selInitWithInteger_Handle = Selector.GetHandle("initWithInteger:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLongLong_ = "initWithLongLong:";

	private static readonly IntPtr selInitWithLongLong_Handle = Selector.GetHandle("initWithLongLong:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithShort_ = "initWithShort:";

	private static readonly IntPtr selInitWithShort_Handle = Selector.GetHandle("initWithShort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUnsignedChar_ = "initWithUnsignedChar:";

	private static readonly IntPtr selInitWithUnsignedChar_Handle = Selector.GetHandle("initWithUnsignedChar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUnsignedInt_ = "initWithUnsignedInt:";

	private static readonly IntPtr selInitWithUnsignedInt_Handle = Selector.GetHandle("initWithUnsignedInt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUnsignedInteger_ = "initWithUnsignedInteger:";

	private static readonly IntPtr selInitWithUnsignedInteger_Handle = Selector.GetHandle("initWithUnsignedInteger:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUnsignedLongLong_ = "initWithUnsignedLongLong:";

	private static readonly IntPtr selInitWithUnsignedLongLong_Handle = Selector.GetHandle("initWithUnsignedLongLong:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUnsignedShort_ = "initWithUnsignedShort:";

	private static readonly IntPtr selInitWithUnsignedShort_Handle = Selector.GetHandle("initWithUnsignedShort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntValue = "intValue";

	private static readonly IntPtr selIntValueHandle = Selector.GetHandle("intValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntegerValue = "integerValue";

	private static readonly IntPtr selIntegerValueHandle = Selector.GetHandle("integerValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToNumber_ = "isEqualToNumber:";

	private static readonly IntPtr selIsEqualToNumber_Handle = Selector.GetHandle("isEqualToNumber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongLongValue = "longLongValue";

	private static readonly IntPtr selLongLongValueHandle = Selector.GetHandle("longLongValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongValue = "longValue";

	private static readonly IntPtr selLongValueHandle = Selector.GetHandle("longValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithBool_ = "numberWithBool:";

	private static readonly IntPtr selNumberWithBool_Handle = Selector.GetHandle("numberWithBool:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithChar_ = "numberWithChar:";

	private static readonly IntPtr selNumberWithChar_Handle = Selector.GetHandle("numberWithChar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithDouble_ = "numberWithDouble:";

	private static readonly IntPtr selNumberWithDouble_Handle = Selector.GetHandle("numberWithDouble:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithFloat_ = "numberWithFloat:";

	private static readonly IntPtr selNumberWithFloat_Handle = Selector.GetHandle("numberWithFloat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithInt_ = "numberWithInt:";

	private static readonly IntPtr selNumberWithInt_Handle = Selector.GetHandle("numberWithInt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithInteger_ = "numberWithInteger:";

	private static readonly IntPtr selNumberWithInteger_Handle = Selector.GetHandle("numberWithInteger:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithLong_ = "numberWithLong:";

	private static readonly IntPtr selNumberWithLong_Handle = Selector.GetHandle("numberWithLong:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithLongLong_ = "numberWithLongLong:";

	private static readonly IntPtr selNumberWithLongLong_Handle = Selector.GetHandle("numberWithLongLong:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithShort_ = "numberWithShort:";

	private static readonly IntPtr selNumberWithShort_Handle = Selector.GetHandle("numberWithShort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithUnsignedChar_ = "numberWithUnsignedChar:";

	private static readonly IntPtr selNumberWithUnsignedChar_Handle = Selector.GetHandle("numberWithUnsignedChar:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithUnsignedInt_ = "numberWithUnsignedInt:";

	private static readonly IntPtr selNumberWithUnsignedInt_Handle = Selector.GetHandle("numberWithUnsignedInt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithUnsignedInteger_ = "numberWithUnsignedInteger:";

	private static readonly IntPtr selNumberWithUnsignedInteger_Handle = Selector.GetHandle("numberWithUnsignedInteger:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithUnsignedLong_ = "numberWithUnsignedLong:";

	private static readonly IntPtr selNumberWithUnsignedLong_Handle = Selector.GetHandle("numberWithUnsignedLong:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithUnsignedLongLong_ = "numberWithUnsignedLongLong:";

	private static readonly IntPtr selNumberWithUnsignedLongLong_Handle = Selector.GetHandle("numberWithUnsignedLongLong:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberWithUnsignedShort_ = "numberWithUnsignedShort:";

	private static readonly IntPtr selNumberWithUnsignedShort_Handle = Selector.GetHandle("numberWithUnsignedShort:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShortValue = "shortValue";

	private static readonly IntPtr selShortValueHandle = Selector.GetHandle("shortValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsignedCharValue = "unsignedCharValue";

	private static readonly IntPtr selUnsignedCharValueHandle = Selector.GetHandle("unsignedCharValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsignedIntValue = "unsignedIntValue";

	private static readonly IntPtr selUnsignedIntValueHandle = Selector.GetHandle("unsignedIntValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsignedIntegerValue = "unsignedIntegerValue";

	private static readonly IntPtr selUnsignedIntegerValueHandle = Selector.GetHandle("unsignedIntegerValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsignedLongLongValue = "unsignedLongLongValue";

	private static readonly IntPtr selUnsignedLongLongValueHandle = Selector.GetHandle("unsignedLongLongValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsignedLongValue = "unsignedLongValue";

	private static readonly IntPtr selUnsignedLongValueHandle = Selector.GetHandle("unsignedLongValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsignedShortValue = "unsignedShortValue";

	private static readonly IntPtr selUnsignedShortValueHandle = Selector.GetHandle("unsignedShortValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNumber");

	public nfloat NFloatValue => (nfloat)DoubleValue;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BoolValue
	{
		[Export("boolValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBoolValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBoolValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual byte ByteValue
	{
		[Export("unsignedCharValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.byte_objc_msgSend(base.Handle, selUnsignedCharValueHandle);
			}
			return Messaging.byte_objc_msgSendSuper(base.SuperHandle, selUnsignedCharValueHandle);
		}
	}

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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual short Int16Value
	{
		[Export("shortValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.short_objc_msgSend(base.Handle, selShortValueHandle);
			}
			return Messaging.short_objc_msgSendSuper(base.SuperHandle, selShortValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Int32Value
	{
		[Export("intValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIntValueHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIntValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long Int64Value
	{
		[Export("longLongValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLongLongValueHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLongLongValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LongValue
	{
		[Export("longValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLongValueHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLongValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NIntValue
	{
		[Export("integerValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIntegerValueHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIntegerValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimal NSDecimalValue
	{
		[Export("decimalValue")]
		get
		{
			NSDecimal retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSDecimal_objc_msgSend_stret(out retval, base.Handle, selDecimalValueHandle);
			}
			else
			{
				Messaging.NSDecimal_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDecimalValueHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NUIntValue
	{
		[Export("unsignedIntegerValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selUnsignedIntegerValueHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selUnsignedIntegerValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual sbyte SByteValue
	{
		[Export("charValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.SByte_objc_msgSend(base.Handle, selCharValueHandle);
			}
			return Messaging.SByte_objc_msgSendSuper(base.SuperHandle, selCharValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringValue
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ushort UInt16Value
	{
		[Export("unsignedShortValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selUnsignedShortValueHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selUnsignedShortValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint UInt32Value
	{
		[Export("unsignedIntValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selUnsignedIntValueHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selUnsignedIntValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong UInt64Value
	{
		[Export("unsignedLongLongValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selUnsignedLongLongValueHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUnsignedLongLongValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint UnsignedLongValue
	{
		[Export("unsignedLongValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selUnsignedLongValueHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selUnsignedLongValueHandle);
		}
	}

	public new static NSNumber FromObject(object value)
	{
		if (value is float)
		{
			return FromFloat((float)value);
		}
		if (value is double)
		{
			return FromDouble((double)value);
		}
		if (value is sbyte)
		{
			return FromSByte((sbyte)value);
		}
		if (value is byte)
		{
			return FromByte((byte)value);
		}
		if (value is short)
		{
			return FromInt16((short)value);
		}
		if (value is ushort)
		{
			return FromUInt16((ushort)value);
		}
		if (value is int)
		{
			return FromInt32((int)value);
		}
		if (value is uint)
		{
			return FromUInt32((uint)value);
		}
		if (value is long)
		{
			return FromInt64((long)value);
		}
		if (value is ulong)
		{
			return FromUInt64((ulong)value);
		}
		if (value is bool)
		{
			return FromBoolean((bool)value);
		}
		if (value is nint)
		{
			return FromNInt((nint)value);
		}
		if (value is nuint)
		{
			return FromNUInt((nuint)value);
		}
		if (value is nfloat)
		{
			return FromNFloat((nfloat)value);
		}
		return null;
	}

	public static implicit operator NSNumber(float value)
	{
		return FromFloat(value);
	}

	public static implicit operator NSNumber(double value)
	{
		return FromDouble(value);
	}

	public static implicit operator NSNumber(bool value)
	{
		return FromBoolean(value);
	}

	public static implicit operator NSNumber(sbyte value)
	{
		return FromSByte(value);
	}

	public static implicit operator NSNumber(byte value)
	{
		return FromByte(value);
	}

	public static implicit operator NSNumber(short value)
	{
		return FromInt16(value);
	}

	public static implicit operator NSNumber(ushort value)
	{
		return FromUInt16(value);
	}

	public static implicit operator NSNumber(int value)
	{
		return FromInt32(value);
	}

	public static implicit operator NSNumber(uint value)
	{
		return FromUInt32(value);
	}

	public static implicit operator NSNumber(long value)
	{
		return FromInt64(value);
	}

	public static implicit operator NSNumber(ulong value)
	{
		return FromUInt64(value);
	}

	public static explicit operator byte(NSNumber source)
	{
		return source.ByteValue;
	}

	public static explicit operator sbyte(NSNumber source)
	{
		return source.SByteValue;
	}

	public static explicit operator short(NSNumber source)
	{
		return source.Int16Value;
	}

	public static explicit operator ushort(NSNumber source)
	{
		return source.UInt16Value;
	}

	public static explicit operator int(NSNumber source)
	{
		return source.Int32Value;
	}

	public static explicit operator uint(NSNumber source)
	{
		return source.UInt32Value;
	}

	public static explicit operator long(NSNumber source)
	{
		return source.Int64Value;
	}

	public static explicit operator ulong(NSNumber source)
	{
		return source.UInt64Value;
	}

	public static explicit operator float(NSNumber source)
	{
		return source.FloatValue;
	}

	public static explicit operator double(NSNumber source)
	{
		return source.DoubleValue;
	}

	public static explicit operator bool(NSNumber source)
	{
		return source.BoolValue;
	}

	public NSNumber(nfloat value)
		: this((double)value)
	{
	}

	public static NSNumber FromNFloat(nfloat value)
	{
		return FromDouble(value);
	}

	public override string ToString()
	{
		return StringValue;
	}

	public int CompareTo(object obj)
	{
		return CompareTo(obj as NSNumber);
	}

	public int CompareTo(NSNumber other)
	{
		if (other == null)
		{
			throw new ArgumentException("other");
		}
		return (int)Compare(other);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NSNumber);
	}

	public bool Equals(NSNumber other)
	{
		if (other == null)
		{
			return false;
		}
		return IsEqualToNumber(other);
	}

	public override int GetHashCode()
	{
		return StringValue.GetHashCode();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSNumber(NSCoder coder)
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
	protected NSNumber(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNumber(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithChar:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(sbyte value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_SByte(base.Handle, selInitWithChar_Handle, value), "initWithChar:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_SByte(base.SuperHandle, selInitWithChar_Handle, value), "initWithChar:");
		}
	}

	[Export("initWithUnsignedChar:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(byte value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_byte(base.Handle, selInitWithUnsignedChar_Handle, value), "initWithUnsignedChar:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_byte(base.SuperHandle, selInitWithUnsignedChar_Handle, value), "initWithUnsignedChar:");
		}
	}

	[Export("initWithShort:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(short value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_short(base.Handle, selInitWithShort_Handle, value), "initWithShort:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_short(base.SuperHandle, selInitWithShort_Handle, value), "initWithShort:");
		}
	}

	[Export("initWithUnsignedShort:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(ushort value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt16(base.Handle, selInitWithUnsignedShort_Handle, value), "initWithUnsignedShort:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt16(base.SuperHandle, selInitWithUnsignedShort_Handle, value), "initWithUnsignedShort:");
		}
	}

	[Export("initWithInt:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(int value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithInt_Handle, value), "initWithInt:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithInt_Handle, value), "initWithInt:");
		}
	}

	[Export("initWithUnsignedInt:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(uint value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selInitWithUnsignedInt_Handle, value), "initWithUnsignedInt:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selInitWithUnsignedInt_Handle, value), "initWithUnsignedInt:");
		}
	}

	[Export("initWithLongLong:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(long value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selInitWithLongLong_Handle, value), "initWithLongLong:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selInitWithLongLong_Handle, value), "initWithLongLong:");
		}
	}

	[Export("initWithUnsignedLongLong:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(ulong value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithUnsignedLongLong_Handle, value), "initWithUnsignedLongLong:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithUnsignedLongLong_Handle, value), "initWithUnsignedLongLong:");
		}
	}

	[Export("initWithFloat:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(float value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_float(base.Handle, selInitWithFloat_Handle, value), "initWithFloat:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_float(base.SuperHandle, selInitWithFloat_Handle, value), "initWithFloat:");
		}
	}

	[Export("initWithDouble:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(double value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithDouble_Handle, value), "initWithDouble:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithDouble_Handle, value), "initWithDouble:");
		}
	}

	[Export("initWithBool:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(bool value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selInitWithBool_Handle, value), "initWithBool:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selInitWithBool_Handle, value), "initWithBool:");
		}
	}

	[Export("initWithInteger:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(nint value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selInitWithInteger_Handle, value), "initWithInteger:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selInitWithInteger_Handle, value), "initWithInteger:");
		}
	}

	[Export("initWithUnsignedInteger:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSNumber(nuint value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithUnsignedInteger_Handle, value), "initWithUnsignedInteger:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithUnsignedInteger_Handle, value), "initWithUnsignedInteger:");
		}
	}

	[Export("compare:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Compare(NSNumber otherNumber)
	{
		if (otherNumber == null)
		{
			throw new ArgumentNullException("otherNumber");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, otherNumber.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, otherNumber.Handle);
	}

	[Export("descriptionWithLocale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DescriptionWithLocale(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescriptionWithLocale_Handle, locale.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescriptionWithLocale_Handle, locale.Handle));
	}

	[Export("numberWithBool:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromBoolean(bool value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_bool(class_ptr, selNumberWithBool_Handle, value));
	}

	[Export("numberWithUnsignedChar:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromByte(byte value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_byte(class_ptr, selNumberWithUnsignedChar_Handle, value));
	}

	[Export("numberWithDouble:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromDouble(double value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selNumberWithDouble_Handle, value));
	}

	[Export("numberWithFloat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromFloat(float value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_float(class_ptr, selNumberWithFloat_Handle, value));
	}

	[Export("numberWithShort:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromInt16(short value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_short(class_ptr, selNumberWithShort_Handle, value));
	}

	[Export("numberWithInt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromInt32(int value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selNumberWithInt_Handle, value));
	}

	[Export("numberWithLongLong:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromInt64(long value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selNumberWithLongLong_Handle, value));
	}

	[Export("numberWithLong:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromLong(nint value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selNumberWithLong_Handle, value));
	}

	[Export("numberWithInteger:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromNInt(nint value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selNumberWithInteger_Handle, value));
	}

	[Export("numberWithUnsignedInteger:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromNUInt(nuint value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_nuint(class_ptr, selNumberWithUnsignedInteger_Handle, value));
	}

	[Export("numberWithChar:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromSByte(sbyte value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_SByte(class_ptr, selNumberWithChar_Handle, value));
	}

	[Export("numberWithUnsignedShort:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromUInt16(ushort value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_UInt16(class_ptr, selNumberWithUnsignedShort_Handle, value));
	}

	[Export("numberWithUnsignedInt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromUInt32(uint value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selNumberWithUnsignedInt_Handle, value));
	}

	[Export("numberWithUnsignedLongLong:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromUInt64(ulong value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selNumberWithUnsignedLongLong_Handle, value));
	}

	[Export("numberWithUnsignedLong:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber FromUnsignedLong(nuint value)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_nuint(class_ptr, selNumberWithUnsignedLong_Handle, value));
	}

	[Export("isEqualToNumber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool IsEqualToNumber(NSNumber number)
	{
		if (number == null)
		{
			throw new ArgumentNullException("number");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToNumber_Handle, number.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToNumber_Handle, number.Handle);
	}
}
