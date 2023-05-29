using System.Runtime.InteropServices;
using CoreGraphics;

namespace CoreAnimation;

public struct CATransform3D
{
	public float m11;

	public float m12;

	public float m13;

	public float m14;

	public float m21;

	public float m22;

	public float m23;

	public float m24;

	public float m31;

	public float m32;

	public float m33;

	public float m34;

	public float m41;

	public float m42;

	public float m43;

	public float m44;

	public static readonly CATransform3D Identity;

	public bool IsIdentity => CATransform3DIsIdentity(this) != 0;

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
	private static extern int CATransform3DIsIdentity(CATransform3D t);

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern int CATransform3DEqualToTransform(CATransform3D a, CATransform3D b);

	public bool Equals(CATransform3D other)
	{
		return CATransform3DEqualToTransform(this, other) != 0;
	}

	public override bool Equals(object other)
	{
		if (!(other is CATransform3D))
		{
			return false;
		}
		return CATransform3DEqualToTransform(this, (CATransform3D)other) != 0;
	}

	public unsafe override int GetHashCode()
	{
		int num = (int)m11;
		fixed (float* ptr = &m11)
		{
			int* ptr2 = (int*)ptr;
			for (int i = 1; i < 16; i++)
			{
				num ^= ptr2[i];
			}
		}
		return num;
	}

	public static CATransform3D MakeTranslation(float tx, float ty, float tz)
	{
		CATransform3D identity = Identity;
		identity.m41 = tx;
		identity.m42 = ty;
		identity.m43 = tz;
		return identity;
	}

	public static CATransform3D MakeScale(float sx, float sy, float sz)
	{
		CATransform3D identity = Identity;
		identity.m11 = sx;
		identity.m22 = sy;
		identity.m33 = sz;
		return identity;
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", EntryPoint = "CATransform3DMakeRotation")]
	public static extern CATransform3D MakeRotation(float angle, float x, float y, float z);

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DTranslate(CATransform3D t, float tx, float ty, float tz);

	public CATransform3D Translate(float tx, float ty, float tz)
	{
		return CATransform3DTranslate(this, tx, ty, tz);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DScale(CATransform3D t, float sx, float sy, float sz);

	public CATransform3D Scale(float sx, float sy, float sz)
	{
		return CATransform3DScale(this, sx, sy, sz);
	}

	public CATransform3D Scale(float s)
	{
		return CATransform3DScale(this, s, s, s);
	}

	[DllImport("/System/Library/Frameworks/QuartzCore.framework/QuartzCore")]
	private static extern CATransform3D CATransform3DRotate(CATransform3D t, float angle, float x, float y, float z);

	public CATransform3D Rotate(float angle, float x, float y, float z)
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

	public CATransform3D Invert(CATransform3D t)
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
