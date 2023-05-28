using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFRunLoop : INativeObject, IDisposable
{
	internal IntPtr handle;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeCommon;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ModeDefault;

	public static CFRunLoop Current => new CFRunLoop(CFRunLoopGetCurrent());

	public static CFRunLoop Main => new CFRunLoop(CFRunLoopGetMain());

	public bool IsWaiting => CFRunLoopIsWaiting(handle);

	public IntPtr Handle => handle;

	[Field("kCFRunLoopCommonModes", "CoreFoundation")]
	public static NSString ModeCommon
	{
		get
		{
			if (_ModeCommon == null)
			{
				_ModeCommon = Dlfcn.GetStringConstant(Libraries.CoreFoundation.Handle, "kCFRunLoopCommonModes");
			}
			return _ModeCommon;
		}
	}

	[Field("kCFRunLoopDefaultMode", "CoreFoundation")]
	public static NSString ModeDefault
	{
		get
		{
			if (_ModeDefault == null)
			{
				_ModeDefault = Dlfcn.GetStringConstant(Libraries.CoreFoundation.Handle, "kCFRunLoopDefaultMode");
			}
			return _ModeDefault;
		}
	}

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
	private static extern void CFRunLoopStop(IntPtr rl);

	public void Stop()
	{
		CFRunLoopStop(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopWakeUp(IntPtr rl);

	public void WakeUp()
	{
		CFRunLoopWakeUp(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFRunLoopIsWaiting(IntPtr rl);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern int CFRunLoopRunInMode(IntPtr mode, double seconds, [MarshalAs(UnmanagedType.I1)] bool returnAfterSourceHandled);

	public CFRunLoopExitReason RunInMode(NSString mode, double seconds, bool returnAfterSourceHandled)
	{
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		return (CFRunLoopExitReason)CFRunLoopRunInMode(mode.Handle, seconds, returnAfterSourceHandled);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopAddSource(IntPtr rl, IntPtr source, IntPtr mode);

	public void AddSource(CFRunLoopSource source, NSString mode)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		CFRunLoopAddSource(handle, source.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFRunLoopContainsSource(IntPtr rl, IntPtr source, IntPtr mode);

	public bool ContainsSource(CFRunLoopSource source, NSString mode)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		return CFRunLoopContainsSource(handle, source.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopRemoveSource(IntPtr rl, IntPtr source, IntPtr mode);

	public void RemoveSource(CFRunLoopSource source, NSString mode)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		CFRunLoopRemoveSource(handle, source.Handle, mode.Handle);
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

	protected virtual void Dispose(bool disposing)
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
		return cFRunLoop.Handle == handle;
	}
}
