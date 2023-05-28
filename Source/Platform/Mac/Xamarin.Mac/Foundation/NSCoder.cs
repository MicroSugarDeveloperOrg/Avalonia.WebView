using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSCoder", true)]
public class NSCoder : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedClasses = "allowedClasses";

	private static readonly IntPtr selAllowedClassesHandle = Selector.GetHandle("allowedClasses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsValueForKey_ = "containsValueForKey:";

	private static readonly IntPtr selContainsValueForKey_Handle = Selector.GetHandle("containsValueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeBoolForKey_ = "decodeBoolForKey:";

	private static readonly IntPtr selDecodeBoolForKey_Handle = Selector.GetHandle("decodeBoolForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeBytesForKey_ReturnedLength_ = "decodeBytesForKey:returnedLength:";

	private static readonly IntPtr selDecodeBytesForKey_ReturnedLength_Handle = Selector.GetHandle("decodeBytesForKey:returnedLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeBytesWithReturnedLength_ = "decodeBytesWithReturnedLength:";

	private static readonly IntPtr selDecodeBytesWithReturnedLength_Handle = Selector.GetHandle("decodeBytesWithReturnedLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeDoubleForKey_ = "decodeDoubleForKey:";

	private static readonly IntPtr selDecodeDoubleForKey_Handle = Selector.GetHandle("decodeDoubleForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeFloatForKey_ = "decodeFloatForKey:";

	private static readonly IntPtr selDecodeFloatForKey_Handle = Selector.GetHandle("decodeFloatForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeInt32ForKey_ = "decodeInt32ForKey:";

	private static readonly IntPtr selDecodeInt32ForKey_Handle = Selector.GetHandle("decodeInt32ForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeInt64ForKey_ = "decodeInt64ForKey:";

	private static readonly IntPtr selDecodeInt64ForKey_Handle = Selector.GetHandle("decodeInt64ForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeIntegerForKey_ = "decodeIntegerForKey:";

	private static readonly IntPtr selDecodeIntegerForKey_Handle = Selector.GetHandle("decodeIntegerForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeObject = "decodeObject";

	private static readonly IntPtr selDecodeObjectHandle = Selector.GetHandle("decodeObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeObjectForKey_ = "decodeObjectForKey:";

	private static readonly IntPtr selDecodeObjectForKey_Handle = Selector.GetHandle("decodeObjectForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeTopLevelObjectAndReturnError_ = "decodeTopLevelObjectAndReturnError:";

	private static readonly IntPtr selDecodeTopLevelObjectAndReturnError_Handle = Selector.GetHandle("decodeTopLevelObjectAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeTopLevelObjectForKey_Error_ = "decodeTopLevelObjectForKey:error:";

	private static readonly IntPtr selDecodeTopLevelObjectForKey_Error_Handle = Selector.GetHandle("decodeTopLevelObjectForKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeTopLevelObjectOfClass_ForKey_Error_ = "decodeTopLevelObjectOfClass:forKey:error:";

	private static readonly IntPtr selDecodeTopLevelObjectOfClass_ForKey_Error_Handle = Selector.GetHandle("decodeTopLevelObjectOfClass:forKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeTopLevelObjectOfClasses_ForKey_Error_ = "decodeTopLevelObjectOfClasses:forKey:error:";

	private static readonly IntPtr selDecodeTopLevelObjectOfClasses_ForKey_Error_Handle = Selector.GetHandle("decodeTopLevelObjectOfClasses:forKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodingFailurePolicy = "decodingFailurePolicy";

	private static readonly IntPtr selDecodingFailurePolicyHandle = Selector.GetHandle("decodingFailurePolicy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBool_ForKey_ = "encodeBool:forKey:";

	private static readonly IntPtr selEncodeBool_ForKey_Handle = Selector.GetHandle("encodeBool:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeBytes_Length_ForKey_ = "encodeBytes:length:forKey:";

	private static readonly IntPtr selEncodeBytes_Length_ForKey_Handle = Selector.GetHandle("encodeBytes:length:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeConditionalObject_ForKey_ = "encodeConditionalObject:forKey:";

	private static readonly IntPtr selEncodeConditionalObject_ForKey_Handle = Selector.GetHandle("encodeConditionalObject:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeDouble_ForKey_ = "encodeDouble:forKey:";

	private static readonly IntPtr selEncodeDouble_ForKey_Handle = Selector.GetHandle("encodeDouble:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeFloat_ForKey_ = "encodeFloat:forKey:";

	private static readonly IntPtr selEncodeFloat_ForKey_Handle = Selector.GetHandle("encodeFloat:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeInt32_ForKey_ = "encodeInt32:forKey:";

	private static readonly IntPtr selEncodeInt32_ForKey_Handle = Selector.GetHandle("encodeInt32:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeInt64_ForKey_ = "encodeInt64:forKey:";

	private static readonly IntPtr selEncodeInt64_ForKey_Handle = Selector.GetHandle("encodeInt64:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeInteger_ForKey_ = "encodeInteger:forKey:";

	private static readonly IntPtr selEncodeInteger_ForKey_Handle = Selector.GetHandle("encodeInteger:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeObject_ = "encodeObject:";

	private static readonly IntPtr selEncodeObject_Handle = Selector.GetHandle("encodeObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeObject_ForKey_ = "encodeObject:forKey:";

	private static readonly IntPtr selEncodeObject_ForKey_Handle = Selector.GetHandle("encodeObject:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRootObject_ = "encodeRootObject:";

	private static readonly IntPtr selEncodeRootObject_Handle = Selector.GetHandle("encodeRootObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFailWithError_ = "failWithError:";

	private static readonly IntPtr selFailWithError_Handle = Selector.GetHandle("failWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresSecureCoding = "requiresSecureCoding";

	private static readonly IntPtr selRequiresSecureCodingHandle = Selector.GetHandle("requiresSecureCoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSystemVersion = "systemVersion";

	private static readonly IntPtr selSystemVersionHandle = Selector.GetHandle("systemVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCoder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet AllowedClasses
	{
		[Export("allowedClasses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedClassesHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedClassesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSDecodingFailurePolicy DecodingFailurePolicy
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("decodingFailurePolicy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSDecodingFailurePolicy)Messaging.Int64_objc_msgSend(base.Handle, selDecodingFailurePolicyHandle);
			}
			return (NSDecodingFailurePolicy)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDecodingFailurePolicyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSError? Error
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("error", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint SystemVersion
	{
		[Export("systemVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selSystemVersionHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selSystemVersionHandle);
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

	public byte[] DecodeBytes(string key)
	{
		nuint length = (byte)0;
		IntPtr intPtr = DecodeBytes(key, out length);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		byte[] array = new byte[(int)length];
		Marshal.Copy(intPtr, array, 0, (int)length);
		return array;
	}

	public byte[] DecodeBytes()
	{
		nuint length = (byte)0;
		IntPtr intPtr = DecodeBytes(out length);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		byte[] array = new byte[(int)length];
		Marshal.Copy(intPtr, array, 0, (int)length);
		return array;
	}

	public bool TryDecode(string key, out bool result)
	{
		if (ContainsKey(key))
		{
			result = DecodeBool(key);
			return true;
		}
		result = false;
		return false;
	}

	public bool TryDecode(string key, out double result)
	{
		if (ContainsKey(key))
		{
			result = DecodeDouble(key);
			return true;
		}
		result = 0.0;
		return false;
	}

	public bool TryDecode(string key, out float result)
	{
		if (ContainsKey(key))
		{
			result = DecodeFloat(key);
			return true;
		}
		result = 0f;
		return false;
	}

	public bool TryDecode(string key, out int result)
	{
		if (ContainsKey(key))
		{
			result = DecodeInt(key);
			return true;
		}
		result = 0;
		return false;
	}

	public bool TryDecode(string key, out long result)
	{
		if (ContainsKey(key))
		{
			result = DecodeLong(key);
			return true;
		}
		result = 0L;
		return false;
	}

	public bool TryDecode(string key, out nint result)
	{
		if (ContainsKey(key))
		{
			result = DecodeNInt(key);
			return true;
		}
		result = 0;
		return false;
	}

	public bool TryDecode(string key, out NSObject result)
	{
		if (ContainsKey(key))
		{
			result = DecodeObject(key);
			return true;
		}
		result = null;
		return false;
	}

	public bool TryDecode(string key, out byte[] result)
	{
		if (ContainsKey(key))
		{
			result = DecodeBytes(key);
			return true;
		}
		result = null;
		return false;
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public NSObject DecodeTopLevelObject(Type type, string key, out NSError error)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		return DecodeTopLevelObject(new Class(type), key, out error);
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public NSObject DecodeTopLevelObject(Type[] types, string key, out NSError error)
	{
		NSSet<Class> setOfClasses = null;
		if (types != null)
		{
			Class[] array = new Class[types.Length];
			for (int i = 0; i < types.Length; i++)
			{
				array[i] = new Class(types[i]);
			}
			setOfClasses = new NSSet<Class>(array);
		}
		return DecodeTopLevelObject(setOfClasses, key, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCoder()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCoder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCoder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("containsValueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsKey(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsValueForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsValueForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeBoolForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DecodeBool(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeBoolForKey_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selDecodeBoolForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeBytesForKey:returnedLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr DecodeBytes(string key, out nuint length)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_out_nuint(base.SuperHandle, selDecodeBytesForKey_ReturnedLength_Handle, arg, out length) : Messaging.IntPtr_objc_msgSend_IntPtr_out_nuint(base.Handle, selDecodeBytesForKey_ReturnedLength_Handle, arg, out length));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeBytesWithReturnedLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr DecodeBytes(out nuint length)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_out_nuint(base.Handle, selDecodeBytesWithReturnedLength_Handle, out length);
		}
		return Messaging.IntPtr_objc_msgSendSuper_out_nuint(base.SuperHandle, selDecodeBytesWithReturnedLength_Handle, out length);
	}

	[Export("decodeDoubleForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double DecodeDouble(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		double result = ((!base.IsDirectBinding) ? Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeDoubleForKey_Handle, arg) : Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDecodeDoubleForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeFloatForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float DecodeFloat(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		float result = ((!base.IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeFloatForKey_Handle, arg) : Messaging.float_objc_msgSend_IntPtr(base.Handle, selDecodeFloatForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeInt32ForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int DecodeInt(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeInt32ForKey_Handle, arg) : Messaging.int_objc_msgSend_IntPtr(base.Handle, selDecodeInt32ForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeInt64ForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long DecodeLong(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		long result = ((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeInt64ForKey_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selDecodeInt64ForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeIntegerForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DecodeNInt(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeIntegerForKey_Handle, arg) : Messaging.nint_objc_msgSend_IntPtr(base.Handle, selDecodeIntegerForKey_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeObject")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodeObject()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDecodeObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDecodeObjectHandle));
	}

	[Export("decodeObjectForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodeObject(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDecodeObjectForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDecodeObjectForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("decodeTopLevelObjectAndReturnError:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodeTopLevelObject(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selDecodeTopLevelObjectAndReturnError_Handle, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selDecodeTopLevelObjectAndReturnError_Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("decodeTopLevelObjectForKey:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodeTopLevelObject(string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selDecodeTopLevelObjectForKey_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selDecodeTopLevelObjectForKey_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("decodeTopLevelObjectOfClass:forKey:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodeTopLevelObject(Class klass, string key, out NSError error)
	{
		if (klass == null)
		{
			throw new ArgumentNullException("klass");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selDecodeTopLevelObjectOfClass_ForKey_Error_Handle, klass.Handle, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selDecodeTopLevelObjectOfClass_ForKey_Error_Handle, klass.Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("decodeTopLevelObjectOfClasses:forKey:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodeTopLevelObject(NSSet<Class>? setOfClasses, string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selDecodeTopLevelObjectOfClasses_ForKey_Error_Handle, setOfClasses?.Handle ?? IntPtr.Zero, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selDecodeTopLevelObjectOfClasses_ForKey_Error_Handle, setOfClasses?.Handle ?? IntPtr.Zero, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("encodeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(NSObject? obj)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeObject_Handle, obj?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeObject_Handle, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("encodeObject:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(NSObject? val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeObject_ForKey_Handle, val?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeObject_ForKey_Handle, val?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeBool:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(bool val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selEncodeBool_ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selEncodeBool_ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeDouble:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(double val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_IntPtr(base.Handle, selEncodeDouble_ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_IntPtr(base.SuperHandle, selEncodeDouble_ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeFloat:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(float val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selEncodeFloat_ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selEncodeFloat_ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeInt32:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(int val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_IntPtr(base.Handle, selEncodeInt32_ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selEncodeInt32_ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeInt64:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(long val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selEncodeInt64_ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selEncodeInt64_ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeInteger:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(nint val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selEncodeInteger_ForKey_Handle, val, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selEncodeInteger_ForKey_Handle, val, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeBytes:length:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeBlock(IntPtr bytes, nint length, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selEncodeBytes_Length_ForKey_Handle, bytes, length, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selEncodeBytes_Length_ForKey_Handle, bytes, length, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeConditionalObject:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeConditionalObject(NSObject? val, string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeConditionalObject_ForKey_Handle, val?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeConditionalObject_ForKey_Handle, val?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("encodeRootObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRoot(NSObject? obj)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRootObject_Handle, obj?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRootObject_Handle, obj?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("failWithError:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Fail(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFailWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFailWithError_Handle, error.Handle);
		}
	}

	[Export("requiresSecureCoding")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RequiresSecureCoding()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRequiresSecureCodingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresSecureCodingHandle);
	}
}
