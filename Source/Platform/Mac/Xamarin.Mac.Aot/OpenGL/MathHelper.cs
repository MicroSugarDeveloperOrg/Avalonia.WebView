using System;

namespace OpenGL;

public static class MathHelper
{
	public const float Pi = (float)Math.PI;

	public const float PiOver2 = (float)Math.PI / 2f;

	public const float PiOver3 = (float)Math.PI / 3f;

	public const float PiOver4 = (float)Math.PI / 4f;

	public const float PiOver6 = (float)Math.PI / 6f;

	public const float TwoPi = (float)Math.PI * 2f;

	public const float ThreePiOver2 = 4.712389f;

	public const float E = (float)Math.E;

	public const float Log10E = 0.4342945f;

	public const float Log2E = 1.442695f;

	public static long NextPowerOfTwo(long n)
	{
		if (n < 0)
		{
			throw new ArgumentOutOfRangeException("n", "Must be positive.");
		}
		return (long)Math.Pow(2.0, Math.Ceiling(Math.Log(n, 2.0)));
	}

	public static int NextPowerOfTwo(int n)
	{
		if (n < 0)
		{
			throw new ArgumentOutOfRangeException("n", "Must be positive.");
		}
		return (int)Math.Pow(2.0, Math.Ceiling(Math.Log(n, 2.0)));
	}

	public static float NextPowerOfTwo(float n)
	{
		if (n < 0f)
		{
			throw new ArgumentOutOfRangeException("n", "Must be positive.");
		}
		return (float)Math.Pow(2.0, Math.Ceiling(Math.Log(n, 2.0)));
	}

	public static double NextPowerOfTwo(double n)
	{
		if (n < 0.0)
		{
			throw new ArgumentOutOfRangeException("n", "Must be positive.");
		}
		return Math.Pow(2.0, Math.Ceiling(Math.Log(n, 2.0)));
	}

	public static long Factorial(int n)
	{
		long num = 1L;
		while (n > 1)
		{
			num *= n;
			n--;
		}
		return num;
	}

	public static long BinomialCoefficient(int n, int k)
	{
		return Factorial(n) / (Factorial(k) * Factorial(n - k));
	}

	public unsafe static float InverseSqrtFast(float x)
	{
		float num = 0.5f * x;
		int num2 = *(int*)(&x);
		num2 = 1597463174 - (num2 >> 1);
		x = *(float*)(&num2);
		x *= 1.5f - num * x * x;
		return x;
	}

	public static double InverseSqrtFast(double x)
	{
		return InverseSqrtFast((float)x);
	}

	public static float DegreesToRadians(float degrees)
	{
		return degrees * ((float)Math.PI / 180f);
	}

	public static float RadiansToDegrees(float radians)
	{
		return radians * (180f / (float)Math.PI);
	}

	public static double DegreesToRadians(double degrees)
	{
		return degrees * (Math.PI / 180.0);
	}

	public static double RadiansToDegrees(double radians)
	{
		return radians * (180.0 / Math.PI);
	}

	public static void Swap(ref double a, ref double b)
	{
		double num = a;
		a = b;
		b = num;
	}

	public static void Swap(ref float a, ref float b)
	{
		float num = a;
		a = b;
		b = num;
	}
}
