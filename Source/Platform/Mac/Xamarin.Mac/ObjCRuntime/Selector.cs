using System;
using System.Runtime.InteropServices;

namespace ObjCRuntime;

public class Selector : IEquatable<Selector>, INativeObject
{
	internal static readonly IntPtr Init = GetHandle("init");

	internal static readonly IntPtr InitWithCoder = GetHandle("initWithCoder:");

	internal static IntPtr AllocHandle = GetHandle("alloc");

	internal static IntPtr ReleaseHandle = GetHandle("release");

	internal static IntPtr RetainHandle = GetHandle("retain");

	internal static IntPtr AutoreleaseHandle = GetHandle("autorelease");

	internal static IntPtr DoesNotRecognizeSelectorHandle = GetHandle("doesNotRecognizeSelector:");

	internal static IntPtr PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle = GetHandle("performSelectorOnMainThread:withObject:waitUntilDone:");

	internal static IntPtr PerformSelectorWithObjectAfterDelayHandle = GetHandle("performSelector:withObject:afterDelay:");

	internal const string Alloc = "alloc";

	internal const string Class = "class";

	internal const string Release = "release";

	internal const string Retain = "retain";

	internal const string Autorelease = "autorelease";

	internal const string Dealloc = "dealloc";

	internal const string DoesNotRecognizeSelector = "doesNotRecognizeSelector:";

	internal const string PerformSelectorOnMainThreadWithObjectWaitUntilDone = "performSelectorOnMainThread:withObject:waitUntilDone:";

	internal const string PerformSelectorInBackground = "performSelectorInBackground:withObject:";

	internal const string PerformSelectorWithObjectAfterDelay = "performSelector:withObject:afterDelay:";

	private IntPtr handle;

	private string name;

	public IntPtr Handle => handle;

	public string Name => name;

	public Selector(IntPtr sel)
		: this(sel, check: true)
	{
	}

	internal Selector(IntPtr sel, bool check)
	{
		if (check && !sel_isMapped(sel))
		{
			throw new ArgumentException("sel is not a selector handle.");
		}
		handle = sel;
		name = GetName(sel);
	}

	public Selector(string name)
	{
		this.name = name;
		handle = GetHandle(name);
	}

	public static bool operator !=(Selector left, Selector right)
	{
		return !(left == right);
	}

	public static bool operator ==(Selector left, Selector right)
	{
		if ((object)left == null)
		{
			return (object)right == null;
		}
		if ((object)right == null)
		{
			return false;
		}
		return left.handle == right.handle;
	}

	public override bool Equals(object right)
	{
		return Equals(right as Selector);
	}

	public bool Equals(Selector right)
	{
		if (right == null)
		{
			return false;
		}
		return handle == right.handle;
	}

	public override int GetHashCode()
	{
		return handle.GetHashCode();
	}

	internal static string GetName(IntPtr handle)
	{
		return Marshal.PtrToStringAuto(sel_getName(handle));
	}

	public static Selector FromHandle(IntPtr sel)
	{
		if (!sel_isMapped(sel))
		{
			return null;
		}
		return new Selector(sel, check: false);
	}

	public static Selector Register(IntPtr handle)
	{
		return new Selector(handle);
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern IntPtr sel_getName(IntPtr sel);

	[DllImport("/usr/lib/libobjc.dylib", EntryPoint = "sel_registerName")]
	public static extern IntPtr GetHandle(string name);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern bool sel_isMapped(IntPtr sel);
}
