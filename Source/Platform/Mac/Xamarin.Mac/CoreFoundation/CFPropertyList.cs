using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFPropertyList : INativeObject, IDisposable
{
	private static nint CFDataTypeID = CFData.GetTypeID();

	private static nint CFStringTypeID = CFString.GetTypeID();

	private static nint CFArrayTypeID = CFArray.GetTypeID();

	private static nint CFDictionaryTypeID = CFDictionary.GetTypeID();

	private static nint CFBooleanTypeID = CFBoolean.GetTypeID();

	private static nint CFDateTypeID = CFDateGetTypeID();

	private static nint CFNumberTypeID = CFNumberGetTypeID();

	private IntPtr handle;

	public IntPtr Handle => handle;

	public object Value
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			nint typeID = CFType.GetTypeID(handle);
			if (typeID == CFDataTypeID)
			{
				return Runtime.GetNSObject<NSData>(handle);
			}
			if (typeID == CFStringTypeID)
			{
				return Runtime.GetNSObject<NSString>(handle);
			}
			if (typeID == CFArrayTypeID)
			{
				return Runtime.GetNSObject<NSArray>(handle);
			}
			if (typeID == CFDictionaryTypeID)
			{
				return Runtime.GetNSObject<NSDictionary>(handle);
			}
			if (typeID == CFDateTypeID)
			{
				return Runtime.GetNSObject<NSDate>(handle);
			}
			if (typeID == CFBooleanTypeID)
			{
				return (bool)Runtime.GetNSObject<NSNumber>(handle);
			}
			if (typeID == CFNumberTypeID)
			{
				return Runtime.GetNSObject<NSNumber>(handle);
			}
			return null;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFDateGetTypeID();

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFNumberGetTypeID();

	public CFPropertyList(IntPtr handle, bool owns)
	{
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	public CFPropertyList(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFPropertyListCreateWithData(IntPtr allocator, IntPtr dataRef, nuint options, out nint format, out IntPtr error);

	public static (CFPropertyList PropertyList, CFPropertyListFormat Format, NSError Error) FromData(NSData data, CFPropertyListMutabilityOptions options = CFPropertyListMutabilityOptions.Immutable)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (data.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("data");
		}
		nint format;
		IntPtr error;
		IntPtr intPtr = CFPropertyListCreateWithData(IntPtr.Zero, data.Handle, (nuint)(ulong)options, out format, out error);
		if (intPtr != IntPtr.Zero)
		{
			return (new CFPropertyList(intPtr, owns: true), (CFPropertyListFormat)(long)format, null);
		}
		return (null, CFPropertyListFormat.XmlFormat1, new NSError(error));
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFPropertyListCreateDeepCopy(IntPtr allocator, IntPtr propertyList, nuint mutabilityOption);

	public CFPropertyList DeepCopy(CFPropertyListMutabilityOptions options = CFPropertyListMutabilityOptions.MutableContainersAndLeaves)
	{
		return new CFPropertyList(CFPropertyListCreateDeepCopy(IntPtr.Zero, handle, (nuint)(ulong)options), owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFPropertyListCreateData(IntPtr allocator, IntPtr propertyList, nint format, nuint options, out IntPtr error);

	public (NSData Data, NSError Error) AsData(CFPropertyListFormat format = CFPropertyListFormat.BinaryFormat1)
	{
		IntPtr error;
		IntPtr intPtr = CFPropertyListCreateData(IntPtr.Zero, handle, (nint)(long)format, (byte)0, out error);
		if (intPtr == IntPtr.Zero)
		{
			return (null, new NSError(error));
		}
		return (Runtime.GetNSObject<NSData>(intPtr, owns: true), null);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFPropertyListIsValid(IntPtr plist, nint format);

	public bool IsValid(CFPropertyListFormat format)
	{
		return CFPropertyListIsValid(handle, (nint)(long)format);
	}

	~CFPropertyList()
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
}
