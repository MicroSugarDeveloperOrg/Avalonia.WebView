using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSManagedObjectModel", true)]
public class NSManagedObjectModel : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfigurations = "configurations";

	private static readonly IntPtr selConfigurationsHandle = Selector.GetHandle("configurations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntities = "entities";

	private static readonly IntPtr selEntitiesHandle = Selector.GetHandle("entities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntitiesByName = "entitiesByName";

	private static readonly IntPtr selEntitiesByNameHandle = Selector.GetHandle("entitiesByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntitiesForConfiguration_ = "entitiesForConfiguration:";

	private static readonly IntPtr selEntitiesForConfiguration_Handle = Selector.GetHandle("entitiesForConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityVersionHashesByName = "entityVersionHashesByName";

	private static readonly IntPtr selEntityVersionHashesByNameHandle = Selector.GetHandle("entityVersionHashesByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequestFromTemplateWithName_SubstitutionVariables_ = "fetchRequestFromTemplateWithName:substitutionVariables:";

	private static readonly IntPtr selFetchRequestFromTemplateWithName_SubstitutionVariables_Handle = Selector.GetHandle("fetchRequestFromTemplateWithName:substitutionVariables:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequestTemplateForName_ = "fetchRequestTemplateForName:";

	private static readonly IntPtr selFetchRequestTemplateForName_Handle = Selector.GetHandle("fetchRequestTemplateForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequestTemplatesByName = "fetchRequestTemplatesByName";

	private static readonly IntPtr selFetchRequestTemplatesByNameHandle = Selector.GetHandle("fetchRequestTemplatesByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsConfiguration_CompatibleWithStoreMetadata_ = "isConfiguration:compatibleWithStoreMetadata:";

	private static readonly IntPtr selIsConfiguration_CompatibleWithStoreMetadata_Handle = Selector.GetHandle("isConfiguration:compatibleWithStoreMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizationDictionary = "localizationDictionary";

	private static readonly IntPtr selLocalizationDictionaryHandle = Selector.GetHandle("localizationDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergedModelFromBundles_ = "mergedModelFromBundles:";

	private static readonly IntPtr selMergedModelFromBundles_Handle = Selector.GetHandle("mergedModelFromBundles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMergedModelFromBundles_ForStoreMetadata_ = "mergedModelFromBundles:forStoreMetadata:";

	private static readonly IntPtr selMergedModelFromBundles_ForStoreMetadata_Handle = Selector.GetHandle("mergedModelFromBundles:forStoreMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelByMergingModels_ = "modelByMergingModels:";

	private static readonly IntPtr selModelByMergingModels_Handle = Selector.GetHandle("modelByMergingModels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelByMergingModels_ForStoreMetadata_ = "modelByMergingModels:forStoreMetadata:";

	private static readonly IntPtr selModelByMergingModels_ForStoreMetadata_Handle = Selector.GetHandle("modelByMergingModels:forStoreMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntities_ = "setEntities:";

	private static readonly IntPtr selSetEntities_Handle = Selector.GetHandle("setEntities:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntities_ForConfiguration_ = "setEntities:forConfiguration:";

	private static readonly IntPtr selSetEntities_ForConfiguration_Handle = Selector.GetHandle("setEntities:forConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchRequestTemplate_ForName_ = "setFetchRequestTemplate:forName:";

	private static readonly IntPtr selSetFetchRequestTemplate_ForName_Handle = Selector.GetHandle("setFetchRequestTemplate:forName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizationDictionary_ = "setLocalizationDictionary:";

	private static readonly IntPtr selSetLocalizationDictionary_Handle = Selector.GetHandle("setLocalizationDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVersionIdentifiers_ = "setVersionIdentifiers:";

	private static readonly IntPtr selSetVersionIdentifiers_Handle = Selector.GetHandle("setVersionIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersionIdentifiers = "versionIdentifiers";

	private static readonly IntPtr selVersionIdentifiersHandle = Selector.GetHandle("versionIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSManagedObjectModel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Configurations
	{
		[Export("configurations", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityDescription[] Entities
	{
		[Export("entities", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntitiesHandle));
			}
			return NSArray.ArrayFromHandle<NSEntityDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntitiesHandle));
		}
		[Export("setEntities:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntities_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntities_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary EntitiesByName
	{
		[Export("entitiesByName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntitiesByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntitiesByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary EntityVersionHashesByName
	{
		[Export("entityVersionHashesByName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityVersionHashesByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityVersionHashesByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FetchRequestTemplatesByName
	{
		[Export("fetchRequestTemplatesByName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRequestTemplatesByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRequestTemplatesByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? LocalizationDictionary
	{
		[Export("localizationDictionary", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizationDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizationDictionaryHandle));
		}
		[Export("setLocalizationDictionary:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizationDictionary_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizationDictionary_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet VersionIdentifiers
	{
		[Export("versionIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionIdentifiersHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionIdentifiersHandle));
		}
		[Export("setVersionIdentifiers:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVersionIdentifiers_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVersionIdentifiers_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSManagedObjectModel(NSCoder coder)
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
	protected NSManagedObjectModel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSManagedObjectModel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSManagedObjectModel()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSManagedObjectModel(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
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

	[Export("entitiesForConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? EntitiesForConfiguration(string? configuration)
	{
		IntPtr arg = NSString.CreateNative(configuration);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEntitiesForConfiguration_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEntitiesForConfiguration_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fetchRequestFromTemplateWithName:substitutionVariables:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchRequest? FetchRequestFromTemplateWithName(string name, NSDictionary variables)
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
		NSFetchRequest result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchRequestFromTemplateWithName_SubstitutionVariables_Handle, arg, variables.Handle)) : Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchRequestFromTemplateWithName_SubstitutionVariables_Handle, arg, variables.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fetchRequestTemplateForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchRequest? FetchRequestTemplateForName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFetchRequest result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchRequestTemplateForName_Handle, arg)) : Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFetchRequestTemplateForName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isConfiguration:compatibleWithStoreMetadata:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsConfiguration(string? configuration, NSDictionary metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		IntPtr arg = NSString.CreateNative(configuration);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsConfiguration_CompatibleWithStoreMetadata_Handle, arg, metadata.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsConfiguration_CompatibleWithStoreMetadata_Handle, arg, metadata.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("mergedModelFromBundles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSManagedObjectModel? MergedModelFromBundles(NSBundle[]? bundles)
	{
		NSArray nSArray = ((bundles == null) ? null : NSArray.FromNSObjects(bundles));
		NSManagedObjectModel nSObject = Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selMergedModelFromBundles_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return nSObject;
	}

	[Export("mergedModelFromBundles:forStoreMetadata:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSManagedObjectModel? MergedModelFromBundles(NSBundle[]? bundles, NSDictionary metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		NSArray nSArray = ((bundles == null) ? null : NSArray.FromNSObjects(bundles));
		NSManagedObjectModel nSObject = Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMergedModelFromBundles_ForStoreMetadata_Handle, nSArray?.Handle ?? IntPtr.Zero, metadata.Handle));
		nSArray?.Dispose();
		return nSObject;
	}

	[Export("modelByMergingModels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSManagedObjectModel? ModelByMergingModels(NSManagedObjectModel[]? models)
	{
		NSArray nSArray = ((models == null) ? null : NSArray.FromNSObjects(models));
		NSManagedObjectModel nSObject = Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selModelByMergingModels_Handle, nSArray?.Handle ?? IntPtr.Zero));
		nSArray?.Dispose();
		return nSObject;
	}

	[Export("modelByMergingModels:forStoreMetadata:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSManagedObjectModel? ModelByMergingModels(NSManagedObjectModel[] models, NSDictionary metadata)
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
		NSManagedObjectModel nSObject = Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selModelByMergingModels_ForStoreMetadata_Handle, nSArray.Handle, metadata.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("setEntities:forConfiguration:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetEntities_ForConfiguration_Handle, nSArray.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetEntities_ForConfiguration_Handle, nSArray.Handle, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("setFetchRequestTemplate:forName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFetchRequestTemplate(NSFetchRequest? fetchRequestTemplate, string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetFetchRequestTemplate_ForName_Handle, fetchRequestTemplate?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetFetchRequestTemplate_ForName_Handle, fetchRequestTemplate?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
