using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNumber", true)]
public class NSNumber : NSValue
{
	private static readonly IntPtr selCharValueHandle = Selector.GetHandle("charValue");

	private static readonly IntPtr selUnsignedCharValueHandle = Selector.GetHandle("unsignedCharValue");

	private static readonly IntPtr selShortValueHandle = Selector.GetHandle("shortValue");

	private static readonly IntPtr selUnsignedShortValueHandle = Selector.GetHandle("unsignedShortValue");

	private static readonly IntPtr selIntValueHandle = Selector.GetHandle("intValue");

	private static readonly IntPtr selUnsignedIntValueHandle = Selector.GetHandle("unsignedIntValue");

	private static readonly IntPtr selLongLongValueHandle = Selector.GetHandle("longLongValue");

	private static readonly IntPtr selUnsignedLongLongValueHandle = Selector.GetHandle("unsignedLongLongValue");

	private static readonly IntPtr selFloatValueHandle = Selector.GetHandle("floatValue");

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	private static readonly IntPtr selDecimalValueHandle = Selector.GetHandle("decimalValue");

	private static readonly IntPtr selBoolValueHandle = Selector.GetHandle("boolValue");

	private static readonly IntPtr selIntegerValueHandle = Selector.GetHandle("integerValue");

	private static readonly IntPtr selUnsignedIntegerValueHandle = Selector.GetHandle("unsignedIntegerValue");

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	private static readonly IntPtr selIsEqualToNumber_Handle = Selector.GetHandle("isEqualToNumber:");

	private static readonly IntPtr selDescriptionWithLocale_Handle = Selector.GetHandle("descriptionWithLocale:");

	private static readonly IntPtr selInitWithChar_Handle = Selector.GetHandle("initWithChar:");

	private static readonly IntPtr selInitWithUnsignedChar_Handle = Selector.GetHandle("initWithUnsignedChar:");

	private static readonly IntPtr selInitWithShort_Handle = Selector.GetHandle("initWithShort:");

	private static readonly IntPtr selInitWithUnsignedShort_Handle = Selector.GetHandle("initWithUnsignedShort:");

	private static readonly IntPtr selInitWithInt_Handle = Selector.GetHandle("initWithInt:");

	private static readonly IntPtr selInitWithUnsignedInt_Handle = Selector.GetHandle("initWithUnsignedInt:");

	private static readonly IntPtr selInitWithLongLong_Handle = Selector.GetHandle("initWithLongLong:");

	private static readonly IntPtr selInitWithUnsignedLongLong_Handle = Selector.GetHandle("initWithUnsignedLongLong:");

	private static readonly IntPtr selInitWithFloat_Handle = Selector.GetHandle("initWithFloat:");

	private static readonly IntPtr selInitWithDouble_Handle = Selector.GetHandle("initWithDouble:");

	private static readonly IntPtr selInitWithBool_Handle = Selector.GetHandle("initWithBool:");

	private static readonly IntPtr selNumberWithChar_Handle = Selector.GetHandle("numberWithChar:");

	private static readonly IntPtr selNumberWithUnsignedChar_Handle = Selector.GetHandle("numberWithUnsignedChar:");

	private static readonly IntPtr selNumberWithShort_Handle = Selector.GetHandle("numberWithShort:");

	private static readonly IntPtr selNumberWithUnsignedShort_Handle = Selector.GetHandle("numberWithUnsignedShort:");

	private static readonly IntPtr selNumberWithInt_Handle = Selector.GetHandle("numberWithInt:");

	private static readonly IntPtr selNumberWithUnsignedInt_Handle = Selector.GetHandle("numberWithUnsignedInt:");

	private static readonly IntPtr selNumberWithLongLong_Handle = Selector.GetHandle("numberWithLongLong:");

	private static readonly IntPtr selNumberWithUnsignedLongLong_Handle = Selector.GetHandle("numberWithUnsignedLongLong:");

	private static readonly IntPtr selNumberWithFloat_Handle = Selector.GetHandle("numberWithFloat:");

	private static readonly IntPtr selNumberWithDouble_Handle = Selector.GetHandle("numberWithDouble:");

	private static readonly IntPtr selNumberWithBool_Handle = Selector.GetHandle("numberWithBool:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNumber");

	public override IntPtr ClassHandle => class_ptr;

	public virtual sbyte SByteValue
	{
		[Export("charValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.SByte_objc_msgSend(base.Handle, selCharValueHandle);
			}
			return Messaging.SByte_objc_msgSendSuper(base.SuperHandle, selCharValueHandle);
		}
	}

	public virtual byte ByteValue
	{
		[Export("unsignedCharValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.byte_objc_msgSend(base.Handle, selUnsignedCharValueHandle);
			}
			return Messaging.byte_objc_msgSendSuper(base.SuperHandle, selUnsignedCharValueHandle);
		}
	}

	public virtual short Int16Value
	{
		[Export("shortValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.short_objc_msgSend(base.Handle, selShortValueHandle);
			}
			return Messaging.short_objc_msgSendSuper(base.SuperHandle, selShortValueHandle);
		}
	}

	public virtual ushort UInt16Value
	{
		[Export("unsignedShortValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selUnsignedShortValueHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selUnsignedShortValueHandle);
		}
	}

	public virtual int Int32Value
	{
		[Export("intValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIntValueHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIntValueHandle);
		}
	}

	public virtual uint UInt32Value
	{
		[Export("unsignedIntValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selUnsignedIntValueHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selUnsignedIntValueHandle);
		}
	}

	public virtual long Int64Value
	{
		[Export("longLongValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLongLongValueHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLongLongValueHandle);
		}
	}

	public virtual ulong UInt64Value
	{
		[Export("unsignedLongLongValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selUnsignedLongLongValueHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUnsignedLongLongValueHandle);
		}
	}

	public virtual float FloatValue
	{
		[Export("floatValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selFloatValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selFloatValueHandle);
		}
	}

	public virtual double DoubleValue
	{
		[Export("doubleValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
	}

	public virtual NSDecimal NSDecimalValue
	{
		[Export("decimalValue")]
		get
		{
			NSDecimal retval;
			if (IsDirectBinding)
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

	public virtual bool BoolValue
	{
		[Export("boolValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBoolValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBoolValueHandle);
		}
	}

	public virtual long IntValue
	{
		[Export("integerValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selIntegerValueHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIntegerValueHandle);
		}
	}

	public virtual ulong UnsignedIntegerValue
	{
		[Export("unsignedIntegerValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selUnsignedIntegerValueHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUnsignedIntegerValueHandle);
		}
	}

	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
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

	public override string ToString()
	{
		return StringValue;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSNumber(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNumber(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNumber(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compare:")]
	public virtual int Compare(NSNumber otherNumber)
	{
		if (otherNumber == null)
		{
			throw new ArgumentNullException("otherNumber");
		}
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, otherNumber.Handle);
		}
		return Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, otherNumber.Handle);
	}

	[Export("isEqualToNumber:")]
	public virtual bool IsEqualToNumber(NSNumber number)
	{
		if (number == null)
		{
			throw new ArgumentNullException("number");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToNumber_Handle, number.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToNumber_Handle, number.Handle);
	}

	[Export("descriptionWithLocale:")]
	public virtual string DescriptionWithLocale(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescriptionWithLocale_Handle, locale.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescriptionWithLocale_Handle, locale.Handle));
	}

	[Export("initWithChar:")]
	public NSNumber(sbyte value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_SByte(base.Handle, selInitWithChar_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_SByte(base.SuperHandle, selInitWithChar_Handle, value);
		}
	}

	[Export("initWithUnsignedChar:")]
	public NSNumber(byte value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_byte(base.Handle, selInitWithUnsignedChar_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_byte(base.SuperHandle, selInitWithUnsignedChar_Handle, value);
		}
	}

	[Export("initWithShort:")]
	public NSNumber(short value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_short(base.Handle, selInitWithShort_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_short(base.SuperHandle, selInitWithShort_Handle, value);
		}
	}

	[Export("initWithUnsignedShort:")]
	public NSNumber(ushort value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt16(base.Handle, selInitWithUnsignedShort_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt16(base.SuperHandle, selInitWithUnsignedShort_Handle, value);
		}
	}

	[Export("initWithInt:")]
	public NSNumber(int value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithInt_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithInt_Handle, value);
		}
	}

	[Export("initWithUnsignedInt:")]
	public NSNumber(uint value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selInitWithUnsignedInt_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selInitWithUnsignedInt_Handle, value);
		}
	}

	[Export("initWithLongLong:")]
	public NSNumber(long value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selInitWithLongLong_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selInitWithLongLong_Handle, value);
		}
	}

	[Export("initWithUnsignedLongLong:")]
	public NSNumber(ulong value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selInitWithUnsignedLongLong_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selInitWithUnsignedLongLong_Handle, value);
		}
	}

	[Export("initWithFloat:")]
	public NSNumber(float value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_float(base.Handle, selInitWithFloat_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_float(base.SuperHandle, selInitWithFloat_Handle, value);
		}
	}

	[Export("initWithDouble:")]
	public NSNumber(double value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithDouble_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithDouble_Handle, value);
		}
	}

	[Export("initWithBool:")]
	public NSNumber(bool value)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_bool(base.Handle, selInitWithBool_Handle, value);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selInitWithBool_Handle, value);
		}
	}

	[Export("numberWithChar:")]
	public static NSNumber FromSByte(sbyte value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_SByte(class_ptr, selNumberWithChar_Handle, value));
	}

	[Export("numberWithUnsignedChar:")]
	public static NSNumber FromByte(byte value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_byte(class_ptr, selNumberWithUnsignedChar_Handle, value));
	}

	[Export("numberWithShort:")]
	public static NSNumber FromInt16(short value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_short(class_ptr, selNumberWithShort_Handle, value));
	}

	[Export("numberWithUnsignedShort:")]
	public static NSNumber FromUInt16(ushort value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt16(class_ptr, selNumberWithUnsignedShort_Handle, value));
	}

	[Export("numberWithInt:")]
	public static NSNumber FromInt32(int value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(class_ptr, selNumberWithInt_Handle, value));
	}

	[Export("numberWithUnsignedInt:")]
	public static NSNumber FromUInt32(uint value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selNumberWithUnsignedInt_Handle, value));
	}

	[Export("numberWithLongLong:")]
	public static NSNumber FromInt64(long value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selNumberWithLongLong_Handle, value));
	}

	[Export("numberWithUnsignedLongLong:")]
	public static NSNumber FromUInt64(ulong value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selNumberWithUnsignedLongLong_Handle, value));
	}

	[Export("numberWithFloat:")]
	public static NSNumber FromFloat(float value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_float(class_ptr, selNumberWithFloat_Handle, value));
	}

	[Export("numberWithDouble:")]
	public static NSNumber FromDouble(double value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selNumberWithDouble_Handle, value));
	}

	[Export("numberWithBool:")]
	public static NSNumber FromBoolean(bool value)
	{
		return (NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool(class_ptr, selNumberWithBool_Handle, value));
	}
}
