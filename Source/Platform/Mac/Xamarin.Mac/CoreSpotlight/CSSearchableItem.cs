using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Register("CSSearchableItem", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CSSearchableItem : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeSet = "attributeSet";

	private static readonly IntPtr selAttributeSetHandle = Selector.GetHandle("attributeSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDomainIdentifier = "domainIdentifier";

	private static readonly IntPtr selDomainIdentifierHandle = Selector.GetHandle("domainIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpirationDate = "expirationDate";

	private static readonly IntPtr selExpirationDateHandle = Selector.GetHandle("expirationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUniqueIdentifier_DomainIdentifier_AttributeSet_ = "initWithUniqueIdentifier:domainIdentifier:attributeSet:";

	private static readonly IntPtr selInitWithUniqueIdentifier_DomainIdentifier_AttributeSet_Handle = Selector.GetHandle("initWithUniqueIdentifier:domainIdentifier:attributeSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeSet_ = "setAttributeSet:";

	private static readonly IntPtr selSetAttributeSet_Handle = Selector.GetHandle("setAttributeSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDomainIdentifier_ = "setDomainIdentifier:";

	private static readonly IntPtr selSetDomainIdentifier_Handle = Selector.GetHandle("setDomainIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExpirationDate_ = "setExpirationDate:";

	private static readonly IntPtr selSetExpirationDate_Handle = Selector.GetHandle("setExpirationDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUniqueIdentifier_ = "setUniqueIdentifier:";

	private static readonly IntPtr selSetUniqueIdentifier_Handle = Selector.GetHandle("setUniqueIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniqueIdentifier = "uniqueIdentifier";

	private static readonly IntPtr selUniqueIdentifierHandle = Selector.GetHandle("uniqueIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CSSearchableItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActionType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActivityIdentifier;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContinuationActionType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _QueryString;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CSSearchableItemAttributeSet AttributeSet
	{
		[Export("attributeSet", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CSSearchableItemAttributeSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeSetHandle));
			}
			return Runtime.GetNSObject<CSSearchableItemAttributeSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeSetHandle));
		}
		[Export("setAttributeSet:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeSet_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeSet_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? DomainIdentifier
	{
		[Export("domainIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainIdentifierHandle));
		}
		[Export("setDomainIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDomainIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDomainIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? ExpirationDate
	{
		[Export("expirationDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selExpirationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExpirationDateHandle));
		}
		[Export("setExpirationDate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExpirationDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExpirationDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UniqueIdentifier
	{
		[Export("uniqueIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniqueIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniqueIdentifierHandle));
		}
		[Export("setUniqueIdentifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUniqueIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUniqueIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("CSSearchableItemActionType", "CoreSpotlight")]
	public static NSString ActionType
	{
		get
		{
			if (_ActionType == null)
			{
				_ActionType = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSSearchableItemActionType");
			}
			return _ActionType;
		}
	}

	[Field("CSSearchableItemActivityIdentifier", "CoreSpotlight")]
	public static NSString ActivityIdentifier
	{
		get
		{
			if (_ActivityIdentifier == null)
			{
				_ActivityIdentifier = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSSearchableItemActivityIdentifier");
			}
			return _ActivityIdentifier;
		}
	}

	[Field("CSQueryContinuationActionType", "CoreSpotlight")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString ContinuationActionType
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ContinuationActionType == null)
			{
				_ContinuationActionType = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSQueryContinuationActionType");
			}
			return _ContinuationActionType;
		}
	}

	[Field("CSSearchQueryString", "CoreSpotlight")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public static NSString QueryString
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_QueryString == null)
			{
				_QueryString = Dlfcn.GetStringConstant(Libraries.CoreSpotlight.Handle, "CSSearchQueryString");
			}
			return _QueryString;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CSSearchableItem()
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
	public CSSearchableItem(NSCoder coder)
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
	protected CSSearchableItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CSSearchableItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUniqueIdentifier:domainIdentifier:attributeSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CSSearchableItem(string? uniqueIdentifier, string? domainIdentifier, CSSearchableItemAttributeSet attributeSet)
		: base(NSObjectFlag.Empty)
	{
		if (attributeSet == null)
		{
			throw new ArgumentNullException("attributeSet");
		}
		IntPtr arg = NSString.CreateNative(uniqueIdentifier);
		IntPtr arg2 = NSString.CreateNative(domainIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithUniqueIdentifier_DomainIdentifier_AttributeSet_Handle, arg, arg2, attributeSet.Handle), "initWithUniqueIdentifier:domainIdentifier:attributeSet:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithUniqueIdentifier_DomainIdentifier_AttributeSet_Handle, arg, arg2, attributeSet.Handle), "initWithUniqueIdentifier:domainIdentifier:attributeSet:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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
