using ObjCRuntime;
using System.ComponentModel;

namespace Foundation;

[Register("NSPersonNameComponents", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSPersonNameComponents : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEncodeWithCoder_ = "encodeWithCoder:";

    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selFamilyName = "familyName";

    private static readonly IntPtr selFamilyNameHandle = Selector.GetHandle("familyName");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selGivenName = "givenName";

    private static readonly IntPtr selGivenNameHandle = Selector.GetHandle("givenName");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMiddleName = "middleName";

    private static readonly IntPtr selMiddleNameHandle = Selector.GetHandle("middleName");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selNamePrefix = "namePrefix";

    private static readonly IntPtr selNamePrefixHandle = Selector.GetHandle("namePrefix");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selNameSuffix = "nameSuffix";

    private static readonly IntPtr selNameSuffixHandle = Selector.GetHandle("nameSuffix");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selNickname = "nickname";

    private static readonly IntPtr selNicknameHandle = Selector.GetHandle("nickname");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPhoneticRepresentation = "phoneticRepresentation";

    private static readonly IntPtr selPhoneticRepresentationHandle = Selector.GetHandle("phoneticRepresentation");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetFamilyName_ = "setFamilyName:";

    private static readonly IntPtr selSetFamilyName_Handle = Selector.GetHandle("setFamilyName:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetGivenName_ = "setGivenName:";

    private static readonly IntPtr selSetGivenName_Handle = Selector.GetHandle("setGivenName:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetMiddleName_ = "setMiddleName:";

    private static readonly IntPtr selSetMiddleName_Handle = Selector.GetHandle("setMiddleName:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetNamePrefix_ = "setNamePrefix:";

    private static readonly IntPtr selSetNamePrefix_Handle = Selector.GetHandle("setNamePrefix:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetNameSuffix_ = "setNameSuffix:";

    private static readonly IntPtr selSetNameSuffix_Handle = Selector.GetHandle("setNameSuffix:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetNickname_ = "setNickname:";

    private static readonly IntPtr selSetNickname_Handle = Selector.GetHandle("setNickname:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetPhoneticRepresentation_ = "setPhoneticRepresentation:";

    private static readonly IntPtr selSetPhoneticRepresentation_Handle = Selector.GetHandle("setPhoneticRepresentation:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersonNameComponents");

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? FamilyName
    {
        [Export("familyName")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFamilyNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFamilyNameHandle));
        }
        [Export("setFamilyName:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFamilyName_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFamilyName_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? GivenName
    {
        [Export("givenName")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGivenNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGivenNameHandle));
        }
        [Export("setGivenName:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGivenName_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGivenName_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? MiddleName
    {
        [Export("middleName")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMiddleNameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMiddleNameHandle));
        }
        [Export("setMiddleName:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMiddleName_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMiddleName_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? NamePrefix
    {
        [Export("namePrefix")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNamePrefixHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNamePrefixHandle));
        }
        [Export("setNamePrefix:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNamePrefix_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNamePrefix_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? NameSuffix
    {
        [Export("nameSuffix")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameSuffixHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameSuffixHandle));
        }
        [Export("setNameSuffix:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNameSuffix_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNameSuffix_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? Nickname
    {
        [Export("nickname")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNicknameHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNicknameHandle));
        }
        [Export("setNickname:")]
        set
        {
            IntPtr arg = NSString.CreateNative(value);
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNickname_Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNickname_Handle, arg);
            }
            NSString.ReleaseNative(arg);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSPersonNameComponents? PhoneticRepresentation
    {
        [Export("phoneticRepresentation", ArgumentSemantic.Copy)]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhoneticRepresentationHandle));
            }
            return Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhoneticRepresentationHandle));
        }
        [Export("setPhoneticRepresentation:", ArgumentSemantic.Copy)]
        set
        {
            if (base.IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPhoneticRepresentation_Handle, value?.Handle ?? IntPtr.Zero);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPhoneticRepresentation_Handle, value?.Handle ?? IntPtr.Zero);
            }
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSPersonNameComponents()
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
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public NSPersonNameComponents(NSCoder coder)
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
    protected NSPersonNameComponents(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSPersonNameComponents(IntPtr handle)
        : base(handle)
    {
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
}