using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFMutableString : CFString
{
	protected CFMutableString(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	protected CFMutableString(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFStringCreateMutable(IntPtr alloc, nint maxLength);

	public CFMutableString(string @string = "", nint maxLength = default(nint))
	{
		if (@string == null)
		{
			throw new ArgumentNullException("string");
		}
		if (maxLength < 0)
		{
			throw new ArgumentException("maxLength");
		}
		base.Handle = CFStringCreateMutable(IntPtr.Zero, maxLength);
		if (@string != null)
		{
			CFStringAppendCharacters(base.Handle, @string, @string.Length);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFStringCreateMutableCopy(IntPtr alloc, nint maxLength, IntPtr theString);

	public CFMutableString(CFString theString, nint maxLength = default(nint))
	{
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		if (maxLength < 0)
		{
			throw new ArgumentException("maxLength");
		}
		base.Handle = CFStringCreateMutableCopy(IntPtr.Zero, maxLength, theString.GetHandle());
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern void CFStringAppendCharacters(IntPtr theString, string chars, nint numChars);

	public void Append(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("string");
		}
		str = null;
		CFStringAppendCharacters(base.Handle, @string, @string.Length);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool CFStringTransform(IntPtr @string, ref CFRange range, IntPtr transform, [MarshalAs(UnmanagedType.I1)] bool reverse);

	public bool Transform(ref CFRange range, CFStringTransform transform, bool reverse)
	{
		return Transform(ref range, transform.GetConstant().GetHandle(), reverse);
	}

	public bool Transform(ref CFRange range, CFString transform, bool reverse)
	{
		return Transform(ref range, transform.GetHandle(), reverse);
	}

	public bool Transform(ref CFRange range, NSString transform, bool reverse)
	{
		return Transform(ref range, transform.GetHandle(), reverse);
	}

	public bool Transform(ref CFRange range, string transform, bool reverse)
	{
		IntPtr transform2 = NSString.CreateNative(transform);
		try
		{
			return Transform(ref range, transform2, reverse);
		}
		finally
		{
			NSString.ReleaseNative(transform2);
		}
	}

	private bool Transform(ref CFRange range, IntPtr transform, bool reverse)
	{
		if (transform == IntPtr.Zero)
		{
			throw new ArgumentNullException("transform");
		}
		str = null;
		return CFStringTransform(base.Handle, ref range, transform, reverse);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool CFStringTransform(IntPtr @string, IntPtr range, IntPtr transform, [MarshalAs(UnmanagedType.I1)] bool reverse);

	public bool Transform(CFStringTransform transform, bool reverse)
	{
		return Transform(transform.GetConstant().GetHandle(), reverse);
	}

	public bool Transform(CFString transform, bool reverse)
	{
		return Transform(transform.GetHandle(), reverse);
	}

	public bool Transform(NSString transform, bool reverse)
	{
		return Transform(transform.GetHandle(), reverse);
	}

	public bool Transform(string transform, bool reverse)
	{
		IntPtr transform2 = NSString.CreateNative(transform);
		try
		{
			return Transform(transform2, reverse);
		}
		finally
		{
			NSString.ReleaseNative(transform2);
		}
	}

	private bool Transform(IntPtr transform, bool reverse)
	{
		if (transform == IntPtr.Zero)
		{
			throw new ArgumentNullException("transform");
		}
		str = null;
		return CFStringTransform(base.Handle, IntPtr.Zero, transform, reverse);
	}
}
