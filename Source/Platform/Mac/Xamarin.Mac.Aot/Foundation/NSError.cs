using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSError", true)]
public class NSError : NSObject
{
	private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

	private static readonly IntPtr selCodeHandle = Selector.GetHandle("code");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

	private static readonly IntPtr selErrorWithDomainCodeUserInfo_Handle = Selector.GetHandle("errorWithDomain:code:userInfo:");

	private static readonly IntPtr selInitWithDomainCodeUserInfo_Handle = Selector.GetHandle("initWithDomain:code:userInfo:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSError");

	private object __mt_UserInfo_var;

	private static NSString _CocoaErrorDomain;

	private static NSString _PosixErrorDomain;

	private static NSString _OsStatusErrorDomain;

	private static NSString _MachErrorDomain;

	private static NSString _UnderlyingErrorKey;

	private static NSString _LocalizedDescriptionKey;

	private static NSString _LocalizedFailureReasonErrorKey;

	private static NSString _LocalizedRecoverySuggestionErrorKey;

	private static NSString _LocalizedRecoveryOptionsErrorKey;

	private static NSString _RecoveryAttempterErrorKey;

	private static NSString _HelpAnchorErrorKey;

	private static NSString _StringEncodingErrorKey;

	private static NSString _UrlErrorKey;

	private static NSString _FilePathErrorKey;

	public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public NSError(NSCoder coder)
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
    public NSError(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public NSError(IntPtr handle)
        : base(handle)
    {
    }

    [Advice("Always specify a domain and error code when creating an NSError instance")]
    public NSError()
    : this(new NSString("Invalid .ctor used"), 0L, null)
    {
    }

    public NSError(NSString domain, int code)
        : this(domain, code, null)
    {
    }

    public virtual string Domain
	{
		[Export("domain")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	public virtual long Code
	{
		[Export("code")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selCodeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCodeHandle);
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
	}

	public virtual string LocalizedDescription
	{
		[Export("localizedDescription")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDescriptionHandle));
		}
	}

	[Field("NSCocoaErrorDomain", "Foundation")]
	public static NSString CocoaErrorDomain
	{
		get
		{
			if (_CocoaErrorDomain == null)
			{
				_CocoaErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSCocoaErrorDomain");
			}
			return _CocoaErrorDomain;
		}
	}

	[Field("NSPOSIXErrorDomain", "Foundation")]
	public static NSString PosixErrorDomain
	{
		get
		{
			if (_PosixErrorDomain == null)
			{
				_PosixErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSPOSIXErrorDomain");
			}
			return _PosixErrorDomain;
		}
	}

	[Field("NSOSStatusErrorDomain", "Foundation")]
	public static NSString OsStatusErrorDomain
	{
		get
		{
			if (_OsStatusErrorDomain == null)
			{
				_OsStatusErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSOSStatusErrorDomain");
			}
			return _OsStatusErrorDomain;
		}
	}

	[Field("NSMachErrorDomain", "Foundation")]
	public static NSString MachErrorDomain
	{
		get
		{
			if (_MachErrorDomain == null)
			{
				_MachErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSMachErrorDomain");
			}
			return _MachErrorDomain;
		}
	}

	[Field("NSUnderlyingErrorKey", "Foundation")]
	public static NSString UnderlyingErrorKey
	{
		get
		{
			if (_UnderlyingErrorKey == null)
			{
				_UnderlyingErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUnderlyingErrorKey");
			}
			return _UnderlyingErrorKey;
		}
	}

	[Field("NSLocalizedDescriptionKey", "Foundation")]
	public static NSString LocalizedDescriptionKey
	{
		get
		{
			if (_LocalizedDescriptionKey == null)
			{
				_LocalizedDescriptionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocalizedDescriptionKey");
			}
			return _LocalizedDescriptionKey;
		}
	}

	[Field("NSLocalizedFailureReasonErrorKey", "Foundation")]
	public static NSString LocalizedFailureReasonErrorKey
	{
		get
		{
			if (_LocalizedFailureReasonErrorKey == null)
			{
				_LocalizedFailureReasonErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocalizedFailureReasonErrorKey");
			}
			return _LocalizedFailureReasonErrorKey;
		}
	}

	[Field("NSLocalizedRecoverySuggestionErrorKey", "Foundation")]
	public static NSString LocalizedRecoverySuggestionErrorKey
	{
		get
		{
			if (_LocalizedRecoverySuggestionErrorKey == null)
			{
				_LocalizedRecoverySuggestionErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocalizedRecoverySuggestionErrorKey");
			}
			return _LocalizedRecoverySuggestionErrorKey;
		}
	}

	[Field("NSLocalizedRecoveryOptionsErrorKey", "Foundation")]
	public static NSString LocalizedRecoveryOptionsErrorKey
	{
		get
		{
			if (_LocalizedRecoveryOptionsErrorKey == null)
			{
				_LocalizedRecoveryOptionsErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocalizedRecoveryOptionsErrorKey");
			}
			return _LocalizedRecoveryOptionsErrorKey;
		}
	}

	[Field("NSRecoveryAttempterErrorKey", "Foundation")]
	public static NSString RecoveryAttempterErrorKey
	{
		get
		{
			if (_RecoveryAttempterErrorKey == null)
			{
				_RecoveryAttempterErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSRecoveryAttempterErrorKey");
			}
			return _RecoveryAttempterErrorKey;
		}
	}

	[Field("NSHelpAnchorErrorKey", "Foundation")]
	public static NSString HelpAnchorErrorKey
	{
		get
		{
			if (_HelpAnchorErrorKey == null)
			{
				_HelpAnchorErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSHelpAnchorErrorKey");
			}
			return _HelpAnchorErrorKey;
		}
	}

	[Field("NSStringEncodingErrorKey", "Foundation")]
	public static NSString StringEncodingErrorKey
	{
		get
		{
			if (_StringEncodingErrorKey == null)
			{
				_StringEncodingErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingErrorKey");
			}
			return _StringEncodingErrorKey;
		}
	}

	[Field("NSURLErrorKey", "Foundation")]
	public static NSString UrlErrorKey
	{
		get
		{
			if (_UrlErrorKey == null)
			{
				_UrlErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLErrorKey");
			}
			return _UrlErrorKey;
		}
	}

	[Field("NSFilePathErrorKey", "Foundation")]
	public static NSString FilePathErrorKey
	{
		get
		{
			if (_FilePathErrorKey == null)
			{
				_FilePathErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFilePathErrorKey");
			}
			return _FilePathErrorKey;
		}
	}

	public static NSError FromDomain(NSString domain, int code)
	{
		return FromDomain(domain, code, null);
	}

	public override string ToString()
	{
		return LocalizedDescription;
	}
     
    [Export("errorWithDomain:code:userInfo:")]
	public static NSError FromDomain(NSString domain, long code, NSDictionary userInfo)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		return (NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(class_ptr, selErrorWithDomainCodeUserInfo_Handle, domain.Handle, code, userInfo?.Handle ?? IntPtr.Zero));
	}

	[Export("initWithDomain:code:userInfo:")]
	public NSError(NSString domain, long code, NSDictionary userInfo)
		: base(NSObjectFlag.Empty)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selInitWithDomainCodeUserInfo_Handle, domain.Handle, code, userInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selInitWithDomainCodeUserInfo_Handle, domain.Handle, code, userInfo?.Handle ?? IntPtr.Zero);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_UserInfo_var = null;
		}
	}
}
