using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreServices;

public class CFHTTPStream : CFReadStream
{
	private static readonly NSString _AttemptPersistentConnection;

	private static readonly NSString _FinalURL;

	private static readonly NSString _FinalRequest;

	private static readonly NSString _Proxy;

	private static readonly NSString _RequestBytesWrittenCount;

	private static readonly NSString _ResponseHeader;

	private static readonly NSString _ShouldAutoredirect;

	public CFUrl FinalURL
	{
		get
		{
			IntPtr property = GetProperty(_FinalURL);
			if (property == IntPtr.Zero)
			{
				return null;
			}
			if (CFType.GetTypeID(property) != CFUrl.GetTypeID())
			{
				CFObject.CFRelease(property);
				throw new InvalidCastException();
			}
			return new CFUrl(property);
		}
	}

	public bool AttemptPersistentConnection
	{
		get
		{
			IntPtr property = GetProperty(_AttemptPersistentConnection);
			if (property == IntPtr.Zero)
			{
				return false;
			}
			if (property == CFBoolean.False.Handle)
			{
				return false;
			}
			if (property == CFBoolean.True.Handle)
			{
				return true;
			}
			throw new InvalidCastException();
		}
		set
		{
			SetProperty(_AttemptPersistentConnection, CFBoolean.FromBoolean(value));
		}
	}

	public int RequestBytesWrittenCount
	{
		get
		{
			IntPtr property = GetProperty(_RequestBytesWrittenCount);
			if (property == IntPtr.Zero)
			{
				return 0;
			}
			using NSNumber nSNumber = new NSNumber(property);
			return nSNumber.Int32Value;
		}
	}

	public bool ShouldAutoredirect
	{
		get
		{
			IntPtr property = GetProperty(_ShouldAutoredirect);
			if (property == IntPtr.Zero)
			{
				return false;
			}
			if (property == CFBoolean.False.Handle)
			{
				return false;
			}
			if (property == CFBoolean.True.Handle)
			{
				return true;
			}
			throw new InvalidCastException();
		}
		set
		{
			SetProperty(_ShouldAutoredirect, CFBoolean.FromBoolean(value));
		}
	}

	internal CFDictionary Proxy
	{
		set
		{
			SetProperty(_Proxy, value);
		}
	}

	static CFHTTPStream()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork", 0);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException();
		}
		try
		{
			_AttemptPersistentConnection = GetStringConstant(intPtr, "kCFStreamPropertyHTTPAttemptPersistentConnection");
			_FinalURL = GetStringConstant(intPtr, "kCFStreamPropertyHTTPFinalURL");
			_FinalRequest = GetStringConstant(intPtr, "kCFStreamPropertyHTTPFinalRequest");
			_Proxy = GetStringConstant(intPtr, "kCFStreamPropertyHTTPProxy");
			_RequestBytesWrittenCount = GetStringConstant(intPtr, "kCFStreamPropertyHTTPRequestBytesWrittenCount");
			_ResponseHeader = GetStringConstant(intPtr, "kCFStreamPropertyHTTPResponseHeader");
			_ShouldAutoredirect = GetStringConstant(intPtr, "kCFStreamPropertyHTTPShouldAutoredirect");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	private static NSString GetStringConstant(IntPtr handle, string name)
	{
		NSString stringConstant = Dlfcn.GetStringConstant(handle, name);
		if (stringConstant == null)
		{
			throw new InvalidOperationException($"Cannot get '{name}' property.");
		}
		return stringConstant;
	}

	internal CFHTTPStream(IntPtr handle)
		: base(handle)
	{
	}

	public CFHTTPMessage GetFinalRequest()
	{
		IntPtr property = GetProperty(_FinalRequest);
		if (property == IntPtr.Zero)
		{
			return null;
		}
		if (CFType.GetTypeID(property) != CFHTTPMessage.GetTypeID())
		{
			CFObject.CFRelease(property);
			throw new InvalidCastException();
		}
		return new CFHTTPMessage(property);
	}

	public CFHTTPMessage GetResponseHeader()
	{
		IntPtr property = GetProperty(_ResponseHeader);
		if (property == IntPtr.Zero)
		{
			return null;
		}
		if (CFType.GetTypeID(property) != CFHTTPMessage.GetTypeID())
		{
			CFObject.CFRelease(property);
			throw new InvalidCastException();
		}
		return new CFHTTPMessage(property);
	}
}
