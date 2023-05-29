using System;
using System.Runtime.InteropServices;

namespace Foundation;

public struct NSDecimal
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

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalCompare")]
	public static extern NSComparisonResult Compare(ref NSDecimal left, ref NSDecimal right);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalRound")]
	public static extern void Round(out NSDecimal result, ref NSDecimal number, int scale, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalNormalize")]
	public static extern NSCalculationError Normalize(ref NSDecimal number1, ref NSDecimal number2);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalAdd")]
	public static extern NSCalculationError Add(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalSubtract")]
	public static extern NSCalculationError Subtract(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalMultiply")]
	public static extern NSCalculationError Multiply(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalDivide")]
	public static extern NSCalculationError Divide(out NSDecimal result, ref NSDecimal left, ref NSDecimal right, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalPower")]
	public static extern NSComparisonResult Power(out NSDecimal result, ref NSDecimal number, int power, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalMultiplyByPowerOf10")]
	public static extern NSComparisonResult MultiplyByPowerOf10(out NSDecimal result, ref NSDecimal number, short power10, NSRoundingMode mode);

	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSDecimalMultiplyByPowerOf10")]
	private static extern IntPtr NSDecimalString(ref NSDecimal value, IntPtr locale);

	public override string ToString()
	{
		return $"{fields}:{m1}{m2}{m3}{m4}{m5}{m6}{m7}{m8}";
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
		return new NSNumber(value).NSDecimalValue;
	}

	public static explicit operator int(NSDecimal value)
	{
		return new NSDecimalNumber(value).Int32Value;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is NSDecimal))
		{
			return false;
		}
		return this == (NSDecimal)obj;
	}

	public override int GetHashCode()
	{
		return fields ^ m1 ^ m2 ^ m3 ^ m4 ^ m5 ^ m6 ^ m7 ^ m8;
	}
}
