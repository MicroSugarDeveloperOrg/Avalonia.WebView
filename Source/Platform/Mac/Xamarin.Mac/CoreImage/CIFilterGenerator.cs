using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFilterGenerator", true)]
public class CIFilterGenerator : NSObject, ICIFilterConstructor, INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassAttributes = "classAttributes";

	private static readonly IntPtr selClassAttributesHandle = Selector.GetHandle("classAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectObject_WithKey_ToObject_WithKey_ = "connectObject:withKey:toObject:withKey:";

	private static readonly IntPtr selConnectObject_WithKey_ToObject_WithKey_Handle = Selector.GetHandle("connectObject:withKey:toObject:withKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnectObject_WithKey_ToObject_WithKey_ = "disconnectObject:withKey:toObject:withKey:";

	private static readonly IntPtr selDisconnectObject_WithKey_ToObject_WithKey_Handle = Selector.GetHandle("disconnectObject:withKey:toObject:withKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportKey_FromObject_WithName_ = "exportKey:fromObject:withName:";

	private static readonly IntPtr selExportKey_FromObject_WithName_Handle = Selector.GetHandle("exportKey:fromObject:withName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportedKeys = "exportedKeys";

	private static readonly IntPtr selExportedKeysHandle = Selector.GetHandle("exportedKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilter = "filter";

	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterGenerator = "filterGenerator";

	private static readonly IntPtr selFilterGeneratorHandle = Selector.GetHandle("filterGenerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterGeneratorWithContentsOfURL_ = "filterGeneratorWithContentsOfURL:";

	private static readonly IntPtr selFilterGeneratorWithContentsOfURL_Handle = Selector.GetHandle("filterGeneratorWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterWithName_ = "filterWithName:";

	private static readonly IntPtr selFilterWithName_Handle = Selector.GetHandle("filterWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterFilterName_ = "registerFilterName:";

	private static readonly IntPtr selRegisterFilterName_Handle = Selector.GetHandle("registerFilterName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveExportedKey_ = "removeExportedKey:";

	private static readonly IntPtr selRemoveExportedKey_Handle = Selector.GetHandle("removeExportedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributes_ForExportedKey_ = "setAttributes:forExportedKey:";

	private static readonly IntPtr selSetAttributes_ForExportedKey_Handle = Selector.GetHandle("setAttributes:forExportedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClassAttributes_ = "setClassAttributes:";

	private static readonly IntPtr selSetClassAttributes_Handle = Selector.GetHandle("setClassAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Atomically_ = "writeToURL:atomically:";

	private static readonly IntPtr selWriteToURL_Atomically_Handle = Selector.GetHandle("writeToURL:atomically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIFilterGenerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExportedKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExportedKeyName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExportedKeyTargetObject;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ClassAttributes
	{
		[Export("classAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selClassAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClassAttributesHandle));
		}
		[Export("setClassAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClassAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClassAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ExportedKeys
	{
		[Export("exportedKeys")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selExportedKeysHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExportedKeysHandle));
		}
	}

	[Field("kCIFilterGeneratorExportedKey", "Quartz")]
	public static NSString ExportedKey
	{
		get
		{
			if (_ExportedKey == null)
			{
				_ExportedKey = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIFilterGeneratorExportedKey");
			}
			return _ExportedKey;
		}
	}

	[Field("kCIFilterGeneratorExportedKeyName", "Quartz")]
	public static NSString ExportedKeyName
	{
		get
		{
			if (_ExportedKeyName == null)
			{
				_ExportedKeyName = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIFilterGeneratorExportedKeyName");
			}
			return _ExportedKeyName;
		}
	}

	[Field("kCIFilterGeneratorExportedKeyTargetObject", "Quartz")]
	public static NSString ExportedKeyTargetObject
	{
		get
		{
			if (_ExportedKeyTargetObject == null)
			{
				_ExportedKeyTargetObject = Dlfcn.GetStringConstant(Libraries.Quartz.Handle, "kCIFilterGeneratorExportedKeyTargetObject");
			}
			return _ExportedKeyTargetObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFilterGenerator(NSCoder coder)
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
	protected CIFilterGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIFilterGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIFilterGenerator(NSUrl aURL)
		: base(NSObjectFlag.Empty)
	{
		if (aURL == null)
		{
			throw new ArgumentNullException("aURL");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, aURL.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, aURL.Handle), "initWithContentsOfURL:");
		}
	}

	[Export("connectObject:withKey:toObject:withKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectObject(NSObject sourceObject, string withSourceKey, NSObject targetObject, string targetKey)
	{
		if (sourceObject == null)
		{
			throw new ArgumentNullException("sourceObject");
		}
		if (withSourceKey == null)
		{
			throw new ArgumentNullException("withSourceKey");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		if (targetKey == null)
		{
			throw new ArgumentNullException("targetKey");
		}
		IntPtr arg = NSString.CreateNative(withSourceKey);
		IntPtr arg2 = NSString.CreateNative(targetKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selConnectObject_WithKey_ToObject_WithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selConnectObject_WithKey_ToObject_WithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
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

	[Export("filterGenerator")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilterGenerator Create()
	{
		return Runtime.GetNSObject<CIFilterGenerator>(Messaging.IntPtr_objc_msgSend(class_ptr, selFilterGeneratorHandle));
	}

	[Export("filter")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter CreateFilter()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle));
		}
		return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle));
	}

	[Export("disconnectObject:withKey:toObject:withKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisconnectObject(NSObject sourceObject, string sourceKey, NSObject targetObject, string targetKey)
	{
		if (sourceObject == null)
		{
			throw new ArgumentNullException("sourceObject");
		}
		if (sourceKey == null)
		{
			throw new ArgumentNullException("sourceKey");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		if (targetKey == null)
		{
			throw new ArgumentNullException("targetKey");
		}
		IntPtr arg = NSString.CreateNative(sourceKey);
		IntPtr arg2 = NSString.CreateNative(targetKey);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selDisconnectObject_WithKey_ToObject_WithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDisconnectObject_WithKey_ToObject_WithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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

	[Export("exportKey:fromObject:withName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExportKey(string key, NSObject targetObject, string exportedKeyName)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (targetObject == null)
		{
			throw new ArgumentNullException("targetObject");
		}
		if (exportedKeyName == null)
		{
			throw new ArgumentNullException("exportedKeyName");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(exportedKeyName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selExportKey_FromObject_WithName_Handle, arg, targetObject.Handle, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selExportKey_FromObject_WithName_Handle, arg, targetObject.Handle, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("filterWithName:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter? FilterWithName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		CIFilter result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFilterWithName_Handle, arg)) : Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFilterWithName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("filterGeneratorWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFilterGenerator FromUrl(NSUrl aURL)
	{
		if (aURL == null)
		{
			throw new ArgumentNullException("aURL");
		}
		return Runtime.GetNSObject<CIFilterGenerator>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterGeneratorWithContentsOfURL_Handle, aURL.Handle));
	}

	[Export("registerFilterName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterFilterName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterFilterName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterFilterName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeExportedKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveExportedKey(string exportedKeyName)
	{
		if (exportedKeyName == null)
		{
			throw new ArgumentNullException("exportedKeyName");
		}
		IntPtr arg = NSString.CreateNative(exportedKeyName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveExportedKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveExportedKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("writeToURL:atomically:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Save(NSUrl toUrl, bool atomically)
	{
		if (toUrl == null)
		{
			throw new ArgumentNullException("toUrl");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToURL_Atomically_Handle, toUrl.Handle, atomically);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToURL_Atomically_Handle, toUrl.Handle, atomically);
	}

	[Export("setAttributes:forExportedKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttributesforExportedKey(NSDictionary attributes, NSString exportedKey)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (exportedKey == null)
		{
			throw new ArgumentNullException("exportedKey");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttributes_ForExportedKey_Handle, attributes.Handle, exportedKey.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttributes_ForExportedKey_Handle, attributes.Handle, exportedKey.Handle);
		}
	}
}
