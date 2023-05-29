using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFilterGenerator", true)]
public class CIFilterGenerator : NSObject
{
	private static readonly IntPtr selExportedKeysHandle = Selector.GetHandle("exportedKeys");

	private static readonly IntPtr selClassAttributesHandle = Selector.GetHandle("classAttributes");

	private static readonly IntPtr selSetClassAttributes_Handle = Selector.GetHandle("setClassAttributes:");

	private static readonly IntPtr selFilterGeneratorHandle = Selector.GetHandle("filterGenerator");

	private static readonly IntPtr selFilterGeneratorWithContentsOfURL_Handle = Selector.GetHandle("filterGeneratorWithContentsOfURL:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selConnectObjectWithKeyToObjectWithKey_Handle = Selector.GetHandle("connectObject:withKey:toObject:withKey:");

	private static readonly IntPtr selDisconnectObjectWithKeyToObjectWithKey_Handle = Selector.GetHandle("disconnectObject:withKey:toObject:withKey:");

	private static readonly IntPtr selExportKeyFromObjectWithName_Handle = Selector.GetHandle("exportKey:fromObject:withName:");

	private static readonly IntPtr selRemoveExportedKey_Handle = Selector.GetHandle("removeExportedKey:");

	private static readonly IntPtr selSetAttributesForExportedKey_Handle = Selector.GetHandle("setAttributes:forExportedKey:");

	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	private static readonly IntPtr selRegisterFilterName_Handle = Selector.GetHandle("registerFilterName:");

	private static readonly IntPtr selWriteToURLAtomically_Handle = Selector.GetHandle("writeToURL:atomically:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIFilterGenerator");

	private object __mt_ExportedKeys_var;

	private object __mt_ClassAttributes_var;

	private static NSString _ExportedKey;

	private static NSString _ExportedKeyTargetObject;

	private static NSString _ExportedKeyName;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary ExportedKeys
	{
		[Export("exportedKeys")]
		get
		{
			return (NSDictionary)(__mt_ExportedKeys_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExportedKeysHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExportedKeysHandle)))));
		}
	}

	public virtual NSDictionary ClassAttributes
	{
		[Export("classAttributes")]
		get
		{
			return (NSDictionary)(__mt_ClassAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClassAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selClassAttributesHandle)))));
		}
		[Export("setClassAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClassAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClassAttributes_Handle, value.Handle);
			}
			__mt_ClassAttributes_var = value;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFilterGenerator(NSCoder coder)
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
	public CIFilterGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIFilterGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("filterGenerator")]
	public static CIFilterGenerator Create()
	{
		return (CIFilterGenerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFilterGeneratorHandle));
	}

	[Export("filterGeneratorWithContentsOfURL:")]
	public static CIFilterGenerator FromUrl(NSUrl aURL)
	{
		if (aURL == null)
		{
			throw new ArgumentNullException("aURL");
		}
		return (CIFilterGenerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFilterGeneratorWithContentsOfURL_Handle, aURL.Handle));
	}

	[Export("initWithContentsOfURL:")]
	public CIFilterGenerator(NSUrl aURL)
		: base(NSObjectFlag.Empty)
	{
		if (aURL == null)
		{
			throw new ArgumentNullException("aURL");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, aURL.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, aURL.Handle);
		}
	}

	[Export("connectObject:withKey:toObject:withKey:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selConnectObjectWithKeyToObjectWithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selConnectObjectWithKeyToObjectWithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("disconnectObject:withKey:toObject:withKey:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selDisconnectObjectWithKeyToObjectWithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDisconnectObjectWithKeyToObjectWithKey_Handle, sourceObject.Handle, arg, targetObject.Handle, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("exportKey:fromObject:withName:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selExportKeyFromObjectWithName_Handle, arg, targetObject.Handle, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selExportKeyFromObjectWithName_Handle, arg, targetObject.Handle, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("removeExportedKey:")]
	public virtual void RemoveExportedKey(string exportedKeyName)
	{
		if (exportedKeyName == null)
		{
			throw new ArgumentNullException("exportedKeyName");
		}
		IntPtr arg = NSString.CreateNative(exportedKeyName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveExportedKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveExportedKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setAttributes:forExportedKey:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttributesForExportedKey_Handle, attributes.Handle, exportedKey.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttributesForExportedKey_Handle, attributes.Handle, exportedKey.Handle);
		}
	}

	[Export("filter")]
	public virtual CIFilter CreateFilter()
	{
		if (IsDirectBinding)
		{
			return (CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle));
		}
		return (CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle));
	}

	[Export("registerFilterName:")]
	public virtual void RegisterFilterName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterFilterName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterFilterName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("writeToURL:atomically:")]
	public virtual bool Save(NSUrl toUrl, bool atomically)
	{
		if (toUrl == null)
		{
			throw new ArgumentNullException("toUrl");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToURLAtomically_Handle, toUrl.Handle, atomically);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToURLAtomically_Handle, toUrl.Handle, atomically);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ExportedKeys_var = null;
			__mt_ClassAttributes_var = null;
		}
	}
}
