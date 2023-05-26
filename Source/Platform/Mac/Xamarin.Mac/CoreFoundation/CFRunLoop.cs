using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFRunLoop : INativeObject, IDisposable
{
	private static IntPtr CoreFoundationLibraryHandle = Dlfcn.dlopen("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation", 0);

	internal IntPtr handle;

	private static NSString _CFDefaultRunLoopMode;

	private static NSString _CFRunLoopCommonModes;

	public const string ModeDefault = "kCFRunLoopDefaultMode";

	public const string ModeCommon = "kCFRunLoopCommonModes";

	public static NSString CFDefaultRunLoopMode
	{
		get
		{
			if (_CFDefaultRunLoopMode == null)
			{
				_CFDefaultRunLoopMode = Dlfcn.GetStringConstant(CoreFoundationLibraryHandle, "kCFRunLoopDefaultMode");
			}
			return _CFDefaultRunLoopMode;
		}
	}

	public static NSString CFRunLoopCommonModes
	{
		get
		{
			if (_CFRunLoopCommonModes == null)
			{
				_CFRunLoopCommonModes = Dlfcn.GetStringConstant(CoreFoundationLibraryHandle, "kCFRunLoopCommonModes");
			}
			return _CFRunLoopCommonModes;
		}
	}

	public static CFRunLoop Current => new CFRunLoop(CFRunLoopGetCurrent());

	public static CFRunLoop Main => new CFRunLoop(CFRunLoopGetMain());

	public bool IsWaiting => CFRunLoopIsWaiting(handle) != 0;

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFRunLoopGetCurrent();

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFRunLoopGetMain();

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopRun();

	public void Run()
	{
		CFRunLoopRun();
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopStop(IntPtr loop);

	public void Stop()
	{
		CFRunLoopStop(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopWakeUp(IntPtr loop);

	public void WakeUp()
	{
		CFRunLoopWakeUp(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern int CFRunLoopIsWaiting(IntPtr loop);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, int returnAfterSourceHandled);

	public CFRunLoopExitReason RunInMode(NSString mode, double seconds, bool returnAfterSourceHandled)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		return (CFRunLoopExitReason)CFRunLoopRunInMode(mode.Handle, seconds, returnAfterSourceHandled ? 1 : 0);
	}

	[Obsolete("Use the NSString version of CFRunLoop.RunInMode() instead.")]
	public CFRunLoopExitReason RunInMode(string mode, double seconds, bool returnAfterSourceHandled)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		CFString cFString = new CFString(mode);
		int result = CFRunLoopRunInMode(cFString.Handle, seconds, returnAfterSourceHandled ? 1 : 0);
		cFString.Dispose();
		return (CFRunLoopExitReason)result;
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopAddSource(IntPtr loop, IntPtr source, IntPtr mode);

	public void AddSource(CFRunLoopSource source, NSString mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		CFRunLoopAddSource(handle, source.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFRunLoopContainsSource(IntPtr loop, IntPtr source, IntPtr mode);

	public bool ContainsSource(CFRunLoopSource source, NSString mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		return CFRunLoopContainsSource(handle, source.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFRunLoopRemoveSource(IntPtr loop, IntPtr source, IntPtr mode);

	public bool RemoveSource(CFRunLoopSource source, NSString mode)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		return CFRunLoopRemoveSource(handle, source.Handle, mode.Handle);
	}

	internal CFRunLoop(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal CFRunLoop(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFRunLoop()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public static bool operator ==(CFRunLoop a, CFRunLoop b)
	{
		return object.Equals(a, b);
	}

	public static bool operator !=(CFRunLoop a, CFRunLoop b)
	{
		return !object.Equals(a, b);
	}

	public override int GetHashCode()
	{
		return handle.GetHashCode();
	}

	public override bool Equals(object other)
	{
		CFRunLoop cFRunLoop = other as CFRunLoop;
		if (cFRunLoop == null)
		{
			return false;
		}
		return cFRunLoop.Handle == Handle;
	}
}
