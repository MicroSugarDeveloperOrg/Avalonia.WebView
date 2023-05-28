using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreFoundation;

public class CFString : NativeObject
{
	internal string str;

	public int Length
	{
		get
		{
			if (str != null)
			{
				return str.Length;
			}
			return (int)CFStringGetLength(base.Handle);
		}
	}

	public char this[nint p]
	{
		get
		{
			if (str != null)
			{
				return str[(int)p];
			}
			return CFStringGetCharacterAtIndex(base.Handle, p);
		}
	}

	protected CFString()
	{
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern IntPtr CFStringCreateWithCharacters(IntPtr allocator, string str, nint count);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern nint CFStringGetLength(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern IntPtr CFStringGetCharactersPtr(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern IntPtr CFStringGetCharacters(IntPtr handle, CFRange range, IntPtr buffer);

	internal static IntPtr LowLevelCreate(string str)
	{
		if (str == null)
		{
			return IntPtr.Zero;
		}
		return CFStringCreateWithCharacters(IntPtr.Zero, str, str.Length);
	}

	public CFString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		base.Handle = CFStringCreateWithCharacters(IntPtr.Zero, str, str.Length);
		this.str = str;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", EntryPoint = "CFStringGetTypeID")]
	public static extern nint GetTypeID();

	public CFString(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	protected internal CFString(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	internal unsafe static string FetchString(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		int num = (int)CFStringGetLength(handle);
		IntPtr intPtr = CFStringGetCharactersPtr(handle);
		IntPtr intPtr2 = IntPtr.Zero;
		if (intPtr == IntPtr.Zero)
		{
			CFRange range = new CFRange(0, num);
			intPtr2 = Marshal.AllocCoTaskMem(num * 2);
			CFStringGetCharacters(handle, range, intPtr2);
			intPtr = intPtr2;
		}
		string result = new string((char*)(void*)intPtr, 0, num);
		if (intPtr2 != IntPtr.Zero)
		{
			Marshal.FreeCoTaskMem(intPtr2);
		}
		return result;
	}

	internal static string FetchString(IntPtr handle, bool releaseHandle)
	{
		string result = FetchString(handle);
		if (releaseHandle && handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
		}
		return result;
	}

	public static implicit operator string(CFString x)
	{
		if (x.str == null)
		{
			x.str = FetchString(x.Handle);
		}
		return x.str;
	}

	public static implicit operator CFString(string s)
	{
		return new CFString(s);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", CharSet = CharSet.Unicode)]
	private static extern char CFStringGetCharacterAtIndex(IntPtr handle, nint p);

	public override string ToString()
	{
		if (str != null)
		{
			return str;
		}
		return FetchString(base.Handle);
	}
}
