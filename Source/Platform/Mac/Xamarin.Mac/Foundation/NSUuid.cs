using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSUUID", true)]
public class NSUuid : NSObject
{
	private static readonly IntPtr selInitWithUUIDString_Handle = Selector.GetHandle("initWithUUIDString:");

	private static readonly IntPtr selGetUUIDBytes_Handle = Selector.GetHandle("getUUIDBytes:");

	private static readonly IntPtr selUUIDStringHandle = Selector.GetHandle("UUIDString");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSUUID");

	public override IntPtr ClassHandle => class_ptr;

	private unsafe static IntPtr GetIntPtr(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (bytes.Length < 16)
		{
			throw new ArgumentException("length must be at least 16 bytes");
		}
		IntPtr result;
		fixed (byte* ptr = &bytes[0])
		{
			result = (IntPtr)ptr;
		}
		return result;
	}

	public NSUuid(byte[] bytes)
		: base(NSObjectFlag.Empty)
	{
		IntPtr intPtr = GetIntPtr(bytes);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithUUIDBytes:"), intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithUUIDBytes:"), intPtr);
		}
	}

	public byte[] GetBytes()
	{
		byte[] array = new byte[16];
		IntPtr intPtr = Marshal.AllocHGlobal(16);
		GetUuidBytes(intPtr);
		Marshal.Copy(intPtr, array, 0, 16);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUuid()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUuid(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUuid(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUuid(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUUIDString:")]
	public NSUuid(string str)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUUIDString_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUUIDString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("getUUIDBytes:")]
	internal virtual void GetUuidBytes(IntPtr uuid)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetUUIDBytes_Handle, uuid);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetUUIDBytes_Handle, uuid);
		}
	}

	[Export("UUIDString")]
	public virtual string AsString()
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUUIDStringHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUUIDStringHandle));
	}
}
