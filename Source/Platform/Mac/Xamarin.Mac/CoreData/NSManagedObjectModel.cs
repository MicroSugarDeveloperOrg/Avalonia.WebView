using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObjectModel", true)]
public class NSManagedObjectModel : NSObject
{
	private static readonly IntPtr selEntitiesByNameHandle = Selector.GetHandle("entitiesByName");

	private static readonly IntPtr selEntitiesHandle = Selector.GetHandle("entities");

	private static readonly IntPtr selSetEntities_Handle = Selector.GetHandle("setEntities:");

	private static readonly IntPtr selConfigurationsHandle = Selector.GetHandle("configurations");

	private static readonly IntPtr selLocalizationDictionaryHandle = Selector.GetHandle("localizationDictionary");

	private static readonly IntPtr selSetLocalizationDictionary_Handle = Selector.GetHandle("setLocalizationDictionary:");

	private static readonly IntPtr selFetchRequestTemplatesByNameHandle = Selector.GetHandle("fetchRequestTemplatesByName");

	private static readonly IntPtr selVersionIdentifiersHandle = Selector.GetHandle("versionIdentifiers");

	private static readonly IntPtr selSetVersionIdentifiers_Handle = Selector.GetHandle("setVersionIdentifiers:");

	private static readonly IntPtr selEntityVersionHashesByNameHandle = Selector.GetHandle("entityVersionHashesByName");

	private static readonly IntPtr selMergedModelFromBundles_Handle = Selector.GetHandle("mergedModelFromBundles:");

	private static readonly IntPtr selModelByMergingModels_Handle = Selector.GetHandle("modelByMergingModels:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selEntitiesForConfiguration_Handle = Selector.GetHandle("entitiesForConfiguration:");

	private static readonly IntPtr selSetEntitiesForConfiguration_Handle = Selector.GetHandle("setEntities:forConfiguration:");

	private static readonly IntPtr selSetFetchRequestTemplateForName_Handle = Selector.GetHandle("setFetchRequestTemplate:forName:");

	private static readonly IntPtr selFetchRequestTemplateForName_Handle = Selector.GetHandle("fetchRequestTemplateForName:");

	private static readonly IntPtr selFetchRequestFromTemplateWithNameSubstitutionVariables_Handle = Selector.GetHandle("fetchRequestFromTemplateWithName:substitutionVariables:");

	private static readonly IntPtr selMergedModelFromBundlesForStoreMetadata_Handle = Selector.GetHandle("mergedModelFromBundles:forStoreMetadata:");

	private static readonly IntPtr selModelByMergingModelsForStoreMetadata_Handle = Selector.GetHandle("modelByMergingModels:forStoreMetadata:");

	private static readonly IntPtr selIsConfigurationCompatibleWithStoreMetadata_Handle = Selector.GetHandle("isConfiguration:compatibleWithStoreMetadata:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSManagedObjectModel");

	private object __mt_EntitiesByName_var;

	private object __mt_Entities_var;

	private object __mt_LocalizationDictionary_var;

	private object __mt_FetchRequestTemplatesByName_var;

	private object __mt_VersionIdentifiers_var;

	private object __mt_EntityVersionHashesByName_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDictionary EntitiesByName
	{
		[Export("entitiesByName")]
		get
		{
			return (NSDictionary)(__mt_EntitiesByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntitiesByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntitiesByNameHandle)))));
		}
	}

	public virtual NSEntityDescription[] Entities
	{
		[Export("entities")]
		get
		{
			return (NSEntityDescription[])(__mt_Entities_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntitiesHandle)) : NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntitiesHandle))));
		}
		[Export("setEntities:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntities_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntities_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Entities_var = value;
		}
	}

	public virtual string[] Configurations
	{
		[Export("configurations")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationsHandle));
		}
	}

	public virtual NSDictionary LocalizationDictionary
	{
		[Export("localizationDictionary")]
		get
		{
			return (NSDictionary)(__mt_LocalizationDictionary_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizationDictionaryHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizationDictionaryHandle)))));
		}
		[Export("setLocalizationDictionary:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizationDictionary_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizationDictionary_Handle, value.Handle);
			}
			__mt_LocalizationDictionary_var = value;
		}
	}

	public virtual NSDictionary FetchRequestTemplatesByName
	{
		[Export("fetchRequestTemplatesByName")]
		get
		{
			return (NSDictionary)(__mt_FetchRequestTemplatesByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRequestTemplatesByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRequestTemplatesByNameHandle)))));
		}
	}

	public virtual NSSet VersionIdentifiers
	{
		[Export("versionIdentifiers")]
		get
		{
			return (NSSet)(__mt_VersionIdentifiers_var = ((!IsDirectBinding) ? ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionIdentifiersHandle))) : ((NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionIdentifiersHandle)))));
		}
		[Export("setVersionIdentifiers:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVersionIdentifiers_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVersionIdentifiers_Handle, value.Handle);
			}
			__mt_VersionIdentifiers_var = value;
		}
	}

	public virtual NSDictionary EntityVersionHashesByName
	{
		[Export("entityVersionHashesByName")]
		get
		{
			return (NSDictionary)(__mt_EntityVersionHashesByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityVersionHashesByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityVersionHashesByNameHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSManagedObjectModel()
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
	public NSManagedObjectModel(NSCoder coder)
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
	public NSManagedObjectModel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSManagedObjectModel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("mergedModelFromBundles:")]
	public static NSManagedObjectModel MergedModelFromBundles(NSBundle[] bundles)
	{
		if (bundles == null)
		{
			throw new ArgumentNullException("bundles");
		}
		NSArray nSArray = NSArray.FromNSObjects(bundles);
		NSManagedObjectModel result = (NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selMergedModelFromBundles_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("modelByMergingModels:")]
	public static NSManagedObjectModel ModelByMergingModels(NSManagedObjectModel[] models)
	{
		if (models == null)
		{
			throw new ArgumentNullException("models");
		}
		NSArray nSArray = NSArray.FromNSObjects(models);
		NSManagedObjectModel result = (NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selModelByMergingModels_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("initWithContentsOfURL:")]
	public NSManagedObjectModel(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle);
		}
	}

	[Export("entitiesForConfiguration:")]
	public virtual string[] EntitiesForConfiguration(string configuration)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		IntPtr arg = NSString.CreateNative(configuration);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEntitiesForConfiguration_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEntitiesForConfiguration_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setEntities:forConfiguration:")]
	public virtual void SetEntities(NSEntityDescription[] entities, string configuration)
	{
		if (entities == null)
		{
			throw new ArgumentNullException("entities");
		}
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		NSArray nSArray = NSArray.FromNSObjects(entities);
		IntPtr arg = NSString.CreateNative(configuration);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetEntitiesForConfiguration_Handle, nSArray.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetEntitiesForConfiguration_Handle, nSArray.Handle, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("setFetchRequestTemplate:forName:")]
	public virtual void SetFetchRequestTemplate(NSFetchRequest fetchRequestTemplate, string name)
	{
		if (fetchRequestTemplate == null)
		{
			throw new ArgumentNullException("fetchRequestTemplate");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetFetchRequestTemplateForName_Handle, fetchRequestTemplate.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetFetchRequestTemplateForName_Handle, fetchRequestTemplate.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("fetchRequestTemplateForName:")]
	public virtual NSFetchRequest FetchRequestTemplateForName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFetchRequest result = ((!IsDirectBinding) ? ((NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchRequestTemplateForName_Handle, arg))) : ((NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFetchRequestTemplateForName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fetchRequestFromTemplateWithName:substitutionVariables:")]
	public virtual NSFetchRequest FetchRequestFromTemplateWithName(string name, NSDictionary variables)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (variables == null)
		{
			throw new ArgumentNullException("variables");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFetchRequest result = ((!IsDirectBinding) ? ((NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchRequestFromTemplateWithNameSubstitutionVariables_Handle, arg, variables.Handle))) : ((NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchRequestFromTemplateWithNameSubstitutionVariables_Handle, arg, variables.Handle))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("mergedModelFromBundles:forStoreMetadata:")]
	public static NSManagedObjectModel MergedModelFromBundles(NSBundle[] bundles, NSDictionary metadata)
	{
		if (bundles == null)
		{
			throw new ArgumentNullException("bundles");
		}
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		NSArray nSArray = NSArray.FromNSObjects(bundles);
		NSManagedObjectModel result = (NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMergedModelFromBundlesForStoreMetadata_Handle, nSArray.Handle, metadata.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("modelByMergingModels:forStoreMetadata:")]
	public static NSManagedObjectModel ModelByMergingModels(NSManagedObjectModel[] models, NSDictionary metadata)
	{
		if (models == null)
		{
			throw new ArgumentNullException("models");
		}
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		NSArray nSArray = NSArray.FromNSObjects(models);
		NSManagedObjectModel result = (NSManagedObjectModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selModelByMergingModelsForStoreMetadata_Handle, nSArray.Handle, metadata.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("isConfiguration:compatibleWithStoreMetadata:")]
	public virtual bool IsConfiguration(string configuration, NSDictionary metadata)
	{
		if (configuration == null)
		{
			throw new ArgumentNullException("configuration");
		}
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		IntPtr arg = NSString.CreateNative(configuration);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsConfigurationCompatibleWithStoreMetadata_Handle, arg, metadata.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsConfigurationCompatibleWithStoreMetadata_Handle, arg, metadata.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_EntitiesByName_var = null;
			__mt_Entities_var = null;
			__mt_LocalizationDictionary_var = null;
			__mt_FetchRequestTemplatesByName_var = null;
			__mt_VersionIdentifiers_var = null;
			__mt_EntityVersionHashesByName_var = null;
		}
	}
}
