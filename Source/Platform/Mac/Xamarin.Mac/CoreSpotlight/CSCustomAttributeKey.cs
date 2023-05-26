using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreSpotlight;

[Register("CSCustomAttributeKey", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class CSCustomAttributeKey : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKeyName_ = "initWithKeyName:";

	private static readonly IntPtr selInitWithKeyName_Handle = Selector.GetHandle("initWithKeyName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKeyName_Searchable_SearchableByDefault_Unique_MultiValued_ = "initWithKeyName:searchable:searchableByDefault:unique:multiValued:";

	private static readonly IntPtr selInitWithKeyName_Searchable_SearchableByDefault_Unique_MultiValued_Handle = Selector.GetHandle("initWithKeyName:searchable:searchableByDefault:unique:multiValued:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMultiValued = "isMultiValued";

	private static readonly IntPtr selIsMultiValuedHandle = Selector.GetHandle("isMultiValued");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSearchable = "isSearchable";

	private static readonly IntPtr selIsSearchableHandle = Selector.GetHandle("isSearchable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSearchableByDefault = "isSearchableByDefault";

	private static readonly IntPtr selIsSearchableByDefaultHandle = Selector.GetHandle("isSearchableByDefault");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUnique = "isUnique";

	private static readonly IntPtr selIsUniqueHandle = Selector.GetHandle("isUnique");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyName = "keyName";

	private static readonly IntPtr selKeyNameHandle = Selector.GetHandle("keyName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CSCustomAttributeKey");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string KeyName
	{
		[Export("keyName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MultiValued
	{
		[Export("isMultiValued")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMultiValuedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMultiValuedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Searchable
	{
		[Export("isSearchable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSearchableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSearchableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SearchableByDefault
	{
		[Export("isSearchableByDefault")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSearchableByDefaultHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSearchableByDefaultHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Unique
	{
		[Export("isUnique")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUniqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUniqueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CSCustomAttributeKey(NSCoder coder)
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
	protected CSCustomAttributeKey(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CSCustomAttributeKey(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithKeyName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CSCustomAttributeKey(string keyName)
		: base(NSObjectFlag.Empty)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		IntPtr arg = NSString.CreateNative(keyName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithKeyName_Handle, arg), "initWithKeyName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithKeyName_Handle, arg), "initWithKeyName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithKeyName:searchable:searchableByDefault:unique:multiValued:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CSCustomAttributeKey(string keyName, bool searchable, bool searchableByDefault, bool unique, bool multiValued)
		: base(NSObjectFlag.Empty)
	{
		if (keyName == null)
		{
			throw new ArgumentNullException("keyName");
		}
		IntPtr arg = NSString.CreateNative(keyName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_bool_bool_bool(base.Handle, selInitWithKeyName_Searchable_SearchableByDefault_Unique_MultiValued_Handle, arg, searchable, searchableByDefault, unique, multiValued), "initWithKeyName:searchable:searchableByDefault:unique:multiValued:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_bool_bool_bool(base.SuperHandle, selInitWithKeyName_Searchable_SearchableByDefault_Unique_MultiValued_Handle, arg, searchable, searchableByDefault, unique, multiValued), "initWithKeyName:searchable:searchableByDefault:unique:multiValued:");
		}
		NSString.ReleaseNative(arg);
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
