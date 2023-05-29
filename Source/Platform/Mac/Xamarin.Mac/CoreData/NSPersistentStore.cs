using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentStore", true)]
public class NSPersistentStore : NSObject
{
	private static readonly IntPtr selPersistentStoreCoordinatorHandle = Selector.GetHandle("persistentStoreCoordinator");

	private static readonly IntPtr selConfigurationNameHandle = Selector.GetHandle("configurationName");

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selIsReadOnlyHandle = Selector.GetHandle("isReadOnly");

	private static readonly IntPtr selSetReadOnly_Handle = Selector.GetHandle("setReadOnly:");

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	private static readonly IntPtr selMetadataForPersistentStoreWithURLError_Handle = Selector.GetHandle("metadataForPersistentStoreWithURL:error:");

	private static readonly IntPtr selSetMetadataForPersistentStoreWithURLError_Handle = Selector.GetHandle("setMetadata:forPersistentStoreWithURL:error:");

	private static readonly IntPtr selInitWithPersistentStoreCoordinatorConfigurationNameURLOptions_Handle = Selector.GetHandle("initWithPersistentStoreCoordinator:configurationName:URL:options:");

	private static readonly IntPtr selDidAddToPersistentStoreCoordinator_Handle = Selector.GetHandle("didAddToPersistentStoreCoordinator:");

	private static readonly IntPtr selWillRemoveFromPersistentStoreCoordinator_Handle = Selector.GetHandle("willRemoveFromPersistentStoreCoordinator:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPersistentStore");

	private object __mt_PersistentStoreCoordinator_var;

	private object __mt_Options_var;

	private object __mt_Url_var;

	private object __mt_Metadata_var;

	private static NSString _SaveConflictsErrorKey;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPersistentStoreCoordinator PersistentStoreCoordinator
	{
		[Export("persistentStoreCoordinator")]
		get
		{
			return (NSPersistentStoreCoordinator)(__mt_PersistentStoreCoordinator_var = ((!IsDirectBinding) ? ((NSPersistentStoreCoordinator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreCoordinatorHandle))) : ((NSPersistentStoreCoordinator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreCoordinatorHandle)))));
		}
	}

	public virtual string ConfigurationName
	{
		[Export("configurationName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationNameHandle));
		}
	}

	public virtual NSDictionary Options
	{
		[Export("options")]
		get
		{
			return (NSDictionary)(__mt_Options_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle)))));
		}
	}

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
		[Export("setURL:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, value.Handle);
			}
			__mt_Url_var = value;
		}
	}

	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Type
	{
		[Export("type")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	public virtual bool ReadOnly
	{
		[Export("isReadOnly")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadOnlyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadOnlyHandle);
		}
		[Export("setReadOnly:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetReadOnly_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetReadOnly_Handle, value);
			}
		}
	}

	public virtual NSDictionary Metadata
	{
		[Export("metadata")]
		get
		{
			return (NSDictionary)(__mt_Metadata_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle)))));
		}
		[Export("setMetadata:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, value.Handle);
			}
			__mt_Metadata_var = value;
		}
	}

	[Field("NSPersistentStoreSaveConflictsErrorKey", "CoreData")]
	public static NSString SaveConflictsErrorKey
	{
		get
		{
			if (_SaveConflictsErrorKey == null)
			{
				_SaveConflictsErrorKey = Dlfcn.GetStringConstant(Libraries.CoreData.Handle, "NSPersistentStoreSaveConflictsErrorKey");
			}
			return _SaveConflictsErrorKey;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPersistentStore()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPersistentStore(NSCoder coder)
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
	public NSPersistentStore(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPersistentStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("metadataForPersistentStoreWithURL:error:")]
	public static NSDictionary MetadataForPersistentStoreWithUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSDictionary result = (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataForPersistentStoreWithURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("setMetadata:forPersistentStoreWithURL:error:")]
	public static bool SetMetadata(NSDictionary metadata, NSUrl url, out NSError error)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSetMetadataForPersistentStoreWithURLError_Handle, metadata.Handle, url.Handle, intPtr);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("initWithPersistentStoreCoordinator:configurationName:URL:options:")]
	public NSPersistentStore(NSPersistentStoreCoordinator root, string name, NSUrl url, NSDictionary options)
		: base(NSObjectFlag.Empty)
	{
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithPersistentStoreCoordinatorConfigurationNameURLOptions_Handle, root.Handle, arg, url.Handle, options.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithPersistentStoreCoordinatorConfigurationNameURLOptions_Handle, root.Handle, arg, url.Handle, options.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didAddToPersistentStoreCoordinator:")]
	public virtual void DidAddToPersistentStoreCoordinator(NSPersistentStoreCoordinator coordinator)
	{
		if (coordinator == null)
		{
			throw new ArgumentNullException("coordinator");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidAddToPersistentStoreCoordinator_Handle, coordinator.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidAddToPersistentStoreCoordinator_Handle, coordinator.Handle);
		}
	}

	[Export("willRemoveFromPersistentStoreCoordinator:")]
	public virtual void WillRemoveFromPersistentStoreCoordinator(NSPersistentStoreCoordinator coordinator)
	{
		if (coordinator == null)
		{
			throw new ArgumentNullException("coordinator");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillRemoveFromPersistentStoreCoordinator_Handle, coordinator.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillRemoveFromPersistentStoreCoordinator_Handle, coordinator.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PersistentStoreCoordinator_var = null;
			__mt_Options_var = null;
			__mt_Url_var = null;
			__mt_Metadata_var = null;
		}
	}
}
