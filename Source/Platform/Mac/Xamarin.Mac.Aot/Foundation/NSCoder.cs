using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSCoder", true)]
public class NSCoder : NSObject
{
	private static readonly IntPtr selAllowedClassesHandle = Selector.GetHandle("allowedClasses");

	private static readonly IntPtr selEncodeObject_Handle = Selector.GetHandle("encodeObject:");

	private static readonly IntPtr selEncodeRootObject_Handle = Selector.GetHandle("encodeRootObject:");

	private static readonly IntPtr selDecodeObjectHandle = Selector.GetHandle("decodeObject");

	private static readonly IntPtr selEncodeConditionalObjectForKey_Handle = Selector.GetHandle("encodeConditionalObject:forKey:");

	private static readonly IntPtr selEncodeObjectForKey_Handle = Selector.GetHandle("encodeObject:forKey:");

	private static readonly IntPtr selEncodeBoolForKey_Handle = Selector.GetHandle("encodeBool:forKey:");

	private static readonly IntPtr selEncodeDoubleForKey_Handle = Selector.GetHandle("encodeDouble:forKey:");

	private static readonly IntPtr selEncodeFloatForKey_Handle = Selector.GetHandle("encodeFloat:forKey:");

	private static readonly IntPtr selEncodeInt32ForKey_Handle = Selector.GetHandle("encodeInt32:forKey:");

	private static readonly IntPtr selEncodeInt64ForKey_Handle = Selector.GetHandle("encodeInt64:forKey:");

	private static readonly IntPtr selEncodeBytesLengthForKey_Handle = Selector.GetHandle("encodeBytes:length:forKey:");

	private static readonly IntPtr selContainsValueForKey_Handle = Selector.GetHandle("containsValueForKey:");

	private static readonly IntPtr selDecodeBoolForKey_Handle = Selector.GetHandle("decodeBoolForKey:");

	private static readonly IntPtr selDecodeDoubleForKey_Handle = Selector.GetHandle("decodeDoubleForKey:");

	private static readonly IntPtr selDecodeFloatForKey_Handle = Selector.GetHandle("decodeFloatForKey:");

	private static readonly IntPtr selDecodeInt32ForKey_Handle = Selector.GetHandle("decodeInt32ForKey:");

	private static readonly IntPtr selDecodeInt64ForKey_Handle = Selector.GetHandle("decodeInt64ForKey:");

	private static readonly IntPtr selDecodeObjectForKey_Handle = Selector.GetHandle("decodeObjectForKey:");

	private static readonly IntPtr selDecodeBytesForKeyReturnedLength_Handle = Selector.GetHandle("decodeBytesForKey:returnedLength:");

	private static readonly IntPtr selRequiresSecureCodingHandle = Selector.GetHandle("requiresSecureCoding");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCoder");

	private object __mt_AllowedClasses_var;

	public override IntPtr ClassHandle => class_ptr;

	[Since(6, 0)]
	public virtual NSSet AllowedClasses
	{
		[Export("allowedClasses")]
		get
		{
			return (NSSet)(__mt_AllowedClasses_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedClassesHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedClassesHandle)))));
		}
	}

	public unsafe void Encode(byte[] buffer, string key)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		fixed (byte* ptr = &buffer[0])
		{
			EncodeBlock((IntPtr)ptr, buffer.Length, key);
		}
	}

	public unsafe void Encode(byte[] buffer, int offset, int count, string key)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (offset < 0)
		{
			throw new ArgumentException("offset < 0");
		}
		if (count < 0)
		{
			throw new ArgumentException("count < 0");
		}
		if (offset > buffer.Length - count)
		{
			throw new ArgumentException("Reading would overrun buffer");
		}
		fixed (byte* ptr = &buffer[0])
		{
			EncodeBlock((IntPtr)ptr, buffer.Length, key);
		}
	}

	public unsafe byte[] DecodeBytes(string key)
	{
		int num = 0;
		int* ptr = &num;
		IntPtr intPtr = DecodeBytes(key, (IntPtr)ptr);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		return array;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCoder()
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
	public NSCoder(NSCoder coder)
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
	public NSCoder(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCoder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeObject:")]
	public virtual void Encode(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeObject_Handle, obj.Handle);
		}
	}

	[Export("encodeRootObject:")]
	public virtual void EncodeRoot(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRootObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRootObject_Handle, obj.Handle);
		}
	}

	[Export("decodeObject")]
	public virtual NSObject DecodeObject()
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDecodeObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDecodeObjectHandle));
	}

	[Export("encodeConditionalObject:forKey:")]
	public virtual void EncodeConditionalObject(NSObject val, string key)
	{
		if (val == null)
		{
			throw new ArgumentNullException("val");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeConditionalObjectForKey_Handle, val.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeConditionalObjectForKey_Handle, val.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeObject:forKey:")]
	public virtual void Encode(NSObject val, string key)
	{
		if (val == null)
		{
			throw new ArgumentNullException("val");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeObjectForKey_Handle, val.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeObjectForKey_Handle, val.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeBool:forKey:")]
	public virtual void Encode(bool val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selEncodeBoolForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selEncodeBoolForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeDouble:forKey:")]
	public virtual void Encode(double val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_IntPtr(base.Handle, selEncodeDoubleForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selEncodeDoubleForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeFloat:forKey:")]
	public virtual void Encode(float val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selEncodeFloatForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selEncodeFloatForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeInt32:forKey:")]
	public virtual void Encode(int val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selEncodeInt32ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selEncodeInt32ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeInt64:forKey:")]
	public virtual void Encode(long val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selEncodeInt64ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selEncodeInt64ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeBytes:length:forKey:")]
	public virtual void EncodeBlock(IntPtr bytes, int length, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_IntPtr(base.Handle, selEncodeBytesLengthForKey_Handle, bytes, length, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_IntPtr(base.SuperHandle, selEncodeBytesLengthForKey_Handle, bytes, length, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("containsValueForKey:")]
	public virtual bool ContainsKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsValueForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeBoolForKey:")]
	public virtual bool DecodeBool(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeBoolForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selDecodeBoolForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeDoubleForKey:")]
	public virtual double DecodeDouble(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		double result = ((!IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeDoubleForKey_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDecodeDoubleForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeFloatForKey:")]
	public virtual float DecodeFloat(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		float result = ((!IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeFloatForKey_Handle, arg) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selDecodeFloatForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeInt32ForKey:")]
	public virtual int DecodeInt(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		int result = ((!IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeInt32ForKey_Handle, arg) : Messaging.int_objc_msgSend_IntPtr(base.Handle, selDecodeInt32ForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeInt64ForKey:")]
	public virtual long DecodeLong(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeInt64ForKey_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selDecodeInt64ForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeObjectForKey:")]
	public virtual NSObject DecodeObject(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecodeObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeBytesForKey:returnedLength:")]
	internal virtual IntPtr DecodeBytes(string key, IntPtr length_ptr)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDecodeBytesForKeyReturnedLength_Handle, arg, length_ptr) : Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDecodeBytesForKeyReturnedLength_Handle, arg, length_ptr));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("requiresSecureCoding")]
	public virtual bool RequiresSecureCoding()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRequiresSecureCodingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresSecureCodingHandle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AllowedClasses_var = null;
		}
	}
}
