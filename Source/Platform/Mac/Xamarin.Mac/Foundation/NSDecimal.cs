using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Foundation;

public struct NSDecimal : IEquatable<NSDecimal>
{
	public int fields;

	public short m1;

	public short m2;

	public short m3;

	public short m4;

	public short m5;

	public short m6;

	public short m7;

	public short m8;

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nint NSDecimalCompare(ref NSDecimal left, ref NSDecimal right);

	public static NSComparisonResult Compare(ref NSDecimal left, ref NSDecimal right)
	{
		return (NSComparisonResult)(long)NSDecimalCompare(ref left, ref right);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern void NSDecimalRound(out NSDecimal result, ref NSDecimal number, nint scale, nuint mode);

	public static void Round(out NSDecimal result, ref NSDecimal number, nint scale, NSRoundingMode mode)
	{
		NSDecimalRound(out result, ref number, scale, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalNormalize(ref NSDecimal number1, ref NSDecimal number2);

	public static NSCalculationError Normalize(ref NSDecimal number1, ref NSDecimal number2)
	{
		return (NSCalculationError)(ulong)NSDecimalNormalize(ref number1, ref number2);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalAdd(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, nuint mode);

	public static NSCalculationError Add(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode)
	{
		return (NSCalculationError)(ulong)NSDecimalAdd(out result, ref left, ref right, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalSubtract(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, nuint mode);

	public static NSCalculationError Subtract(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode)
	{
		return (NSCalculationError)(ulong)NSDecimalSubtract(out result, ref left, ref right, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalMultiply(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, nuint mode);

	public static NSCalculationError Multiply(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode)
	{
		return (NSCalculationError)(ulong)NSDecimalMultiply(out result, ref left, ref right, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalDivide(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, nuint mode);

	public static NSCalculationError Divide(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode)
	{
		return (NSCalculationError)(ulong)NSDecimalDivide(out result, ref left, ref right, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalPower(out NSDecimal result, ref NSDecimal number, nint power, nuint mode);

	public static NSCalculationError Power(out NSDecimal result, ref NSDecimal number, nint power, NSRoundingMode mode)
	{
		return (NSCalculationError)(ulong)NSDecimalPower(out result, ref number, power, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern nuint NSDecimalMultiplyByPowerOf10(out NSDecimal result, ref NSDecimal number, short power10, nuint mode);

	public static NSCalculationError MultiplyByPowerOf10(out NSDecimal result, ref NSDecimal number, short power10, NSRoundingMode mode)
	{
		return (NSCalculationError)(ulong)NSDecimalMultiplyByPowerOf10(out result, ref number, power10, (nuint)(ulong)mode);
	}

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private static extern IntPtr NSDecimalString(ref NSDecimal value, IntPtr locale);

	public override string ToString()
	{
		return new NSString(NSDecimalString(ref this, NSLocale.CurrentLocale.Handle));
	}

	public static NSDecimal operator +(NSDecimal left, NSDecimal right)
	{
		Add(out var result, ref left, ref right, NSRoundingMode.Plain);
		return result;
	}

	public static NSDecimal operator -(NSDecimal left, NSDecimal right)
	{
		Subtract(out var result, ref left, ref right, NSRoundingMode.Plain);
		return result;
	}

	public static NSDecimal operator *(NSDecimal left, NSDecimal right)
	{
		Multiply(out var result, ref left, ref right, NSRoundingMode.Plain);
		return result;
	}

	public static NSDecimal operator /(NSDecimal left, NSDecimal right)
	{
		Divide(out var result, ref left, ref right, NSRoundingMode.Plain);
		return result;
	}

	public static bool operator ==(NSDecimal left, NSDecimal right)
	{
		return Compare(ref left, ref right) == NSComparisonResult.Same;
	}

	public static bool operator !=(NSDecimal left, NSDecimal right)
	{
		return Compare(ref left, ref right) != NSComparisonResult.Same;
	}

	public static implicit operator NSDecimal(int value)
	{
		using NSNumber nSNumber = new NSNumber(value);
		return nSNumber.NSDecimalValue;
	}

	public static explicit operator int(NSDecimal value)
	{
		using NSDecimalNumber nSDecimalNumber = new NSDecimalNumber(value);
		return nSDecimalNumber.Int32Value;
	}

	public static implicit operator NSDecimal(float value)
	{
		using NSNumber nSNumber = new NSNumber(value);
		return nSNumber.NSDecimalValue;
	}

	public static explicit operator float(NSDecimal value)
	{
		using NSDecimalNumber nSDecimalNumber = new NSDecimalNumber(value);
		return nSDecimalNumber.FloatValue;
	}

	public static implicit operator NSDecimal(double value)
	{
		using NSNumber nSNumber = new NSNumber(value);
		return nSNumber.NSDecimalValue;
	}

	public static explicit operator double(NSDecimal value)
	{
		using NSDecimalNumber nSDecimalNumber = new NSDecimalNumber(value);
		return nSDecimalNumber.DoubleValue;
	}

	public static implicit operator NSDecimal(decimal value)
	{
		using NSDecimalNumber nSDecimalNumber = new NSDecimalNumber(value.ToString(CultureInfo.InvariantCulture));
		return nSDecimalNumber.NSDecimalValue;
	}

	public static explicit operator decimal(NSDecimal value)
	{
		using NSDecimalNumber nSDecimalNumber = new NSDecimalNumber(value);
		return decimal.Parse(nSDecimalNumber.ToString(), CultureInfo.InvariantCulture);
	}

	public bool Equals(NSDecimal other)
	{
		return this == other;
	}

	public override bool Equals(object obj)
	{
		return obj is NSDecimal nSDecimal && this == nSDecimal;
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}
}
