using System;
using System.Runtime.InteropServices;
using CoreGraphics;

namespace CoreAnimation;

public struct CATransform3D
{
	public nfloat m11;

	public nfloat m12;

	public nfloat m13;

	public nfloat m14;

	public nfloat m21;

	public nfloat m22;

	public nfloat m23;

	public nfloat m24;

	public nfloat m31;

	public nfloat m32;

	public nfloat m33;

	public nfloat m34;

	public nfloat m41;

	public nfloat m42;

	public nfloat m43;

	public nfloat m44;

	public static readonly CATransform3D Identity;

	public bool IsIdentity => CATransform3DIsIdentity(this);

	public bool IsAffine => CATransform3DIsAffine(this);

	static CATransform3D()
	{
		Identity = default(CATransform3D);
		Identity.m11 = 1f;
		Identity.m22 = 1f;
		Identity.m33 = 1f;
		Identity.m44 = 1f;
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern bool CATransform3DIsIdentity(CATransform3D t);

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern bool CATransform3DEqualToTransform(CATransform3D a, CATransform3D b);

	public bool Equals(CATransform3D other)
	{
		return CATransform3DEqualToTransform(this, other);
	}

	public override bool Equals(object other)
	{
		if (!(other is CATransform3D))
		{
			return false;
		}
		return CATransform3DEqualToTransform(this, (CATransform3D)other);
	}

	public unsafe override int GetHashCode()
	{
		int num = (int)m11;
		fixed (nfloat* ptr = &m11)
		{
			int* ptr2 = (int*)ptr;
			for (int i = 1; i < 4 * IntPtr.Size; i++)
			{
				num ^= ptr2[i];
			}
		}
		return num;
	}

	public static CATransform3D MakeTranslation(nfloat tx, nfloat ty, nfloat tz)
	{
		CATransform3D identity = Identity;
		identity.m41 = tx;
		identity.m42 = ty;
		identity.m43 = tz;
		return identity;
	}

	public static CATransform3D MakeScale(nfloat sx, nfloat sy, nfloat sz)
	{
		CATransform3D identity = Identity;
		identity.m11 = sx;
		identity.m22 = sy;
		identity.m33 = sz;
		return identity;
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", EntryPoint = "CATransform3DMakeRotation")]
	public static extern CATransform3D MakeRotation(nfloat angle, nfloat x, nfloat y, nfloat z);

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DTranslate(CATransform3D t, nfloat tx, nfloat ty, nfloat tz);

	public CATransform3D Translate(nfloat tx, nfloat ty, nfloat tz)
	{
		return CATransform3DTranslate(this, tx, ty, tz);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DScale(CATransform3D t, nfloat sx, nfloat sy, nfloat sz);

	public CATransform3D Scale(nfloat sx, nfloat sy, nfloat sz)
	{
		return CATransform3DScale(this, sx, sy, sz);
	}

	public CATransform3D Scale(nfloat s)
	{
		return CATransform3DScale(this, s, s, s);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DRotate(CATransform3D t, nfloat angle, nfloat x, nfloat y, nfloat z);

	public CATransform3D Rotate(nfloat angle, nfloat x, nfloat y, nfloat z)
	{
		return CATransform3DRotate(this, angle, x, y, z);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DConcat(CATransform3D a, CATransform3D b);

	public CATransform3D Concat(CATransform3D b)
	{
		return CATransform3DConcat(this, b);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DInvert(CATransform3D t);

	[Obsolete("Use Invert() as the argument to this method is unused.")]
	public CATransform3D Invert(CATransform3D t)
	{
		return CATransform3DInvert(this);
	}

	public CATransform3D Invert()
	{
		return CATransform3DInvert(this);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", EntryPoint = "CATransform3DMakeAffineTransform")]
	public static extern CATransform3D MakeFromAffine(CGAffineTransform m);

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern bool CATransform3DIsAffine(CATransform3D t);

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", EntryPoint = "CATransform3DGetAffineTransform")]
	public static extern CGAffineTransform GetAffine(CATransform3D t);

	public override string ToString()
	{
		return $"[{m11} {m12} {m13} {m14}; {m21} {m22} {m23} {m24}; {m31} {m32} {m33} {m34}; {m41} {m42} {m43} {m44}]";
	}
}
