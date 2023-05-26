using FileProvider;
using ObjCRuntime;
using System.ComponentModel;

namespace Foundation;

[Register("NSError", true)]
public class NSError : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCode = "code";

    private static readonly IntPtr selCodeHandle = Selector.GetHandle("code");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDomain = "domain";

    private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEncodeWithCoder_ = "encodeWithCoder:";

    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selErrorWithDomain_Code_UserInfo_ = "errorWithDomain:code:userInfo:";

    private static readonly IntPtr selErrorWithDomain_Code_UserInfo_Handle = Selector.GetHandle("errorWithDomain:code:userInfo:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selFileProviderErrorForCollisionWithItem_ = "fileProviderErrorForCollisionWithItem:";

    private static readonly IntPtr selFileProviderErrorForCollisionWithItem_Handle = Selector.GetHandle("fileProviderErrorForCollisionWithItem:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selFileProviderErrorForNonExistentItemWithIdentifier_ = "fileProviderErrorForNonExistentItemWithIdentifier:";

    private static readonly IntPtr selFileProviderErrorForNonExistentItemWithIdentifier_Handle = Selector.GetHandle("fileProviderErrorForNonExistentItemWithIdentifier:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selFileProviderErrorForOutOfDateItem_ = "fileProviderErrorForOutOfDateItem:";

    private static readonly IntPtr selFileProviderErrorForOutOfDateItem_Handle = Selector.GetHandle("fileProviderErrorForOutOfDateItem:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHelpAnchor = "helpAnchor";

    private static readonly IntPtr selHelpAnchorHandle = Selector.GetHandle("helpAnchor");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithDomain_Code_UserInfo_ = "initWithDomain:code:userInfo:";

    private static readonly IntPtr selInitWithDomain_Code_UserInfo_Handle = Selector.GetHandle("initWithDomain:code:userInfo:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedDescription = "localizedDescription";

    private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedFailureReason = "localizedFailureReason";

    private static readonly IntPtr selLocalizedFailureReasonHandle = Selector.GetHandle("localizedFailureReason");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedRecoveryOptions = "localizedRecoveryOptions";

    private static readonly IntPtr selLocalizedRecoveryOptionsHandle = Selector.GetHandle("localizedRecoveryOptions");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedRecoverySuggestion = "localizedRecoverySuggestion";

    private static readonly IntPtr selLocalizedRecoverySuggestionHandle = Selector.GetHandle("localizedRecoverySuggestion");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetUserInfoValueProviderForDomain_Provider_ = "setUserInfoValueProviderForDomain:provider:";

    private static readonly IntPtr selSetUserInfoValueProviderForDomain_Provider_Handle = Selector.GetHandle("setUserInfoValueProviderForDomain:provider:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selUserInfo = "userInfo";

    private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selUserInfoValueProviderForDomain_ = "userInfoValueProviderForDomain:";

    private static readonly IntPtr selUserInfoValueProviderForDomain_Handle = Selector.GetHandle("userInfoValueProviderForDomain:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSError");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _CFNetworkErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _CocoaErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _CoreLocationErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _DebugDescriptionErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _FilePathErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _HelpAnchorErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _LocalizedDescriptionKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _LocalizedFailureErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _LocalizedFailureReasonErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _LocalizedRecoveryOptionsErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _LocalizedRecoverySuggestionErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _MachErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _NSNetServicesErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _NSStreamSOCKSErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _NSStreamSocketSSLErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _NSUrlErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _OsStatusErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _PosixErrorDomain;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _RecoveryAttempterErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _StringEncodingErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _UnderlyingErrorKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _UrlErrorKey;

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual nint Code
    {
        [Export("code")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selCodeHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCodeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string Domain
    {
        [Export("domain")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string HelpAnchor
    {
        [Export("helpAnchor")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHelpAnchorHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHelpAnchorHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string LocalizedDescription
    {
        [Export("localizedDescription")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDescriptionHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDescriptionHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string LocalizedFailureReason
    {
        [Export("localizedFailureReason")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedFailureReasonHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedFailureReasonHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string[] LocalizedRecoveryOptions
    {
        [Export("localizedRecoveryOptions")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedRecoveryOptionsHandle));
            }
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedRecoveryOptionsHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string LocalizedRecoverySuggestion
    {
        [Export("localizedRecoverySuggestion")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedRecoverySuggestionHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedRecoverySuggestionHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSDictionary UserInfo
    {
        [Export("userInfo")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
            }
            return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
        }
    }

    [Field("kCFErrorDomainCFNetwork", "CFNetwork")]
    public static NSString CFNetworkErrorDomain
    {
        get
        {
            if (_CFNetworkErrorDomain == null)
            {
                _CFNetworkErrorDomain = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFErrorDomainCFNetwork");
            }
            return _CFNetworkErrorDomain;
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

    [Field("kCLErrorDomain", "CoreLocation")]
    public static NSString CoreLocationErrorDomain
    {
        get
        {
            if (_CoreLocationErrorDomain == null)
            {
                _CoreLocationErrorDomain = Dlfcn.GetStringConstant(Libraries.CoreLocation.Handle, "kCLErrorDomain");
            }
            return _CoreLocationErrorDomain;
        }
    }

    [Field("NSDebugDescriptionErrorKey", "Foundation")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    public static NSString DebugDescriptionErrorKey
    {
        [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
        get
        {
            if (_DebugDescriptionErrorKey == null)
            {
                _DebugDescriptionErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSDebugDescriptionErrorKey");
            }
            return _DebugDescriptionErrorKey;
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

    [Field("NSLocalizedFailureErrorKey", "Foundation")]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    public static NSString LocalizedFailureErrorKey
    {
        [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
        get
        {
            if (_LocalizedFailureErrorKey == null)
            {
                _LocalizedFailureErrorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSLocalizedFailureErrorKey");
            }
            return _LocalizedFailureErrorKey;
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

    [Field("NSNetServicesErrorDomain", "Foundation")]
    public static NSString NSNetServicesErrorDomain
    {
        get
        {
            if (_NSNetServicesErrorDomain == null)
            {
                _NSNetServicesErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSNetServicesErrorDomain");
            }
            return _NSNetServicesErrorDomain;
        }
    }

    [Field("NSStreamSOCKSErrorDomain", "Foundation")]
    public static NSString NSStreamSOCKSErrorDomain
    {
        get
        {
            if (_NSStreamSOCKSErrorDomain == null)
            {
                _NSStreamSOCKSErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSOCKSErrorDomain");
            }
            return _NSStreamSOCKSErrorDomain;
        }
    }

    [Field("NSStreamSocketSSLErrorDomain", "Foundation")]
    public static NSString NSStreamSocketSSLErrorDomain
    {
        get
        {
            if (_NSStreamSocketSSLErrorDomain == null)
            {
                _NSStreamSocketSSLErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStreamSocketSSLErrorDomain");
            }
            return _NSStreamSocketSSLErrorDomain;
        }
    }

    [Field("NSURLErrorDomain", "Foundation")]
    public static NSString NSUrlErrorDomain
    {
        get
        {
            if (_NSUrlErrorDomain == null)
            {
                _NSUrlErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLErrorDomain");
            }
            return _NSUrlErrorDomain;
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

    [Advice("Always specify a domain and error code when creating an NSError instance")]
    public NSError()
        : this(new NSString("Invalid .ctor used"), 0, null)
    {
    }

    public static NSError FromDomain(NSString domain, nint code)
    {
        return FromDomain(domain, code, null);
    }

    public NSError(NSString domain, nint code)
        : this(domain, code, null)
    {
    }

    public override string ToString()
    {
        return LocalizedDescription;
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public NSError(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected NSError(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSError(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithDomain:code:userInfo:")]
    [DesignatedInitializer]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSError(NSString domain, nint code, NSDictionary? userInfo)
        : base(NSObjectFlag.Empty)
    {
        if (domain == null)
        {
            throw new ArgumentNullException("domain");
        }
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr(base.Handle, selInitWithDomain_Code_UserInfo_Handle, domain.Handle, code, userInfo?.Handle ?? IntPtr.Zero), "initWithDomain:code:userInfo:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr(base.SuperHandle, selInitWithDomain_Code_UserInfo_Handle, domain.Handle, code, userInfo?.Handle ?? IntPtr.Zero), "initWithDomain:code:userInfo:");
        }
    }

    [Export("copyWithZone:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: Release]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }

    [Export("encodeWithCoder:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual void EncodeTo(NSCoder encoder)
    {
        if (encoder == null)
        {
            throw new ArgumentNullException("encoder");
        }
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
        }
    }

    [Export("errorWithDomain:code:userInfo:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSError FromDomain(NSString domain, nint code, NSDictionary? userInfo)
    {
        if (domain == null)
        {
            throw new ArgumentNullException("domain");
        }
        return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr(class_ptr, selErrorWithDomain_Code_UserInfo_Handle, domain.Handle, code, userInfo?.Handle ?? IntPtr.Zero));
    }

    [Export("fileProviderErrorForCollisionWithItem:")]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSError GetFileProviderError(INSFileProviderItem existingItem)
    {
        if (existingItem == null)
        {
            throw new ArgumentNullException("existingItem");
        }
        return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileProviderErrorForCollisionWithItem_Handle, existingItem.Handle));
    }

    [Export("fileProviderErrorForNonExistentItemWithIdentifier:")]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSError GetFileProviderError(string nonExistentItemIdentifier)
    {
        if (nonExistentItemIdentifier == null)
        {
            throw new ArgumentNullException("nonExistentItemIdentifier");
        }
        IntPtr arg = NSString.CreateNative(nonExistentItemIdentifier);
        NSError nSObject = Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileProviderErrorForNonExistentItemWithIdentifier_Handle, arg));
        NSString.ReleaseNative(arg);
        return nSObject;
    }

    [Export("fileProviderErrorForOutOfDateItem:")]
    [Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSError GetFileProviderErrorForOutOfDateItem(INSFileProviderItem updatedVersion)
    {
        if (updatedVersion == null)
        {
            throw new ArgumentNullException("updatedVersion");
        }
        return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileProviderErrorForOutOfDateItem_Handle, updatedVersion.Handle));
    }

    [Export("userInfoValueProviderForDomain:")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: DelegateProxy(typeof(Trampolines.SDNSErrorUserInfoValueProvider))]
    public static NSErrorUserInfoValueProvider? GetUserInfoValueProvider(string errorDomain)
    {
        if (errorDomain == null)
        {
            throw new ArgumentNullException("errorDomain");
        }
        IntPtr arg = NSString.CreateNative(errorDomain);
        IntPtr block = Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUserInfoValueProviderForDomain_Handle, arg);
        NSString.ReleaseNative(arg);
        return Trampolines.NIDNSErrorUserInfoValueProvider.Create(block);
    }

    [Export("setUserInfoValueProviderForDomain:provider:")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public unsafe static void SetUserInfoValueProvider(string errorDomain, [BlockProxy(typeof(Trampolines.NIDNSErrorUserInfoValueProvider))] NSErrorUserInfoValueProvider? provider)
    {
        if (errorDomain == null)
        {
            throw new ArgumentNullException("errorDomain");
        }
        IntPtr arg = NSString.CreateNative(errorDomain);
        BlockLiteral* ptr;
        if (provider == null)
        {
            ptr = null;
        }
        else
        {
            BlockLiteral blockLiteral = default(BlockLiteral);
            ptr = &blockLiteral;
            blockLiteral.SetupBlockUnsafe(Trampolines.SDNSErrorUserInfoValueProvider.Handler, provider);
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetUserInfoValueProviderForDomain_Provider_Handle, arg, (IntPtr)ptr);
        NSString.ReleaseNative(arg);
        if (ptr != null)
        {
            ptr->CleanupBlock();
        }
    }
}

