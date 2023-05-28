using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMappingModel", true)]
public class NSMappingModel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityMappings = "entityMappings";

	private static readonly IntPtr selEntityMappingsHandle = Selector.GetHandle("entityMappings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntityMappingsByName = "entityMappingsByName";

	private static readonly IntPtr selEntityMappingsByNameHandle = Selector.GetHandle("entityMappingsByName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInferredMappingModelForSourceModel_DestinationModel_Error_ = "inferredMappingModelForSourceModel:destinationModel:error:";

	private static readonly IntPtr selInferredMappingModelForSourceModel_DestinationModel_Error_Handle = Selector.GetHandle("inferredMappingModelForSourceModel:destinationModel:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMappingModelFromBundles_ForSourceModel_DestinationModel_ = "mappingModelFromBundles:forSourceModel:destinationModel:";

	private static readonly IntPtr selMappingModelFromBundles_ForSourceModel_DestinationModel_Handle = Selector.GetHandle("mappingModelFromBundles:forSourceModel:destinationModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEntityMappings_ = "setEntityMappings:";

	private static readonly IntPtr selSetEntityMappings_Handle = Selector.GetHandle("setEntityMappings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMappingModel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEntityMapping[] EntityMappings
	{
		[Export("entityMappings", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSEntityMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityMappingsHandle));
			}
			return NSArray.ArrayFromHandle<NSEntityMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityMappingsHandle));
		}
		[Export("setEntityMappings:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntityMappings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntityMappings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary EntityMappingsByName
	{
		[Export("entityMappingsByName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityMappingsByNameHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityMappingsByNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMappingModel()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMappingModel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMappingModel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMappingModel(NSUrl url)
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

	[Export("inferredMappingModelForSourceModel:destinationModel:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMappingModel? GetInferredMappingModel(NSManagedObjectModel source, NSManagedObjectModel destination, out NSError error)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		IntPtr arg = IntPtr.Zero;
		NSMappingModel nSObject = Runtime.GetNSObject<NSMappingModel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selInferredMappingModelForSourceModel_DestinationModel_Error_Handle, source.Handle, destination.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("mappingModelFromBundles:forSourceModel:destinationModel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMappingModel? MappingModelFromBundles(NSBundle[] bundles, NSManagedObjectModel sourceModel, NSManagedObjectModel destinationModel)
	{
		if (bundles == null)
		{
			throw new ArgumentNullException("bundles");
		}
		if (sourceModel == null)
		{
			throw new ArgumentNullException("sourceModel");
		}
		if (destinationModel == null)
		{
			throw new ArgumentNullException("destinationModel");
		}
		NSArray nSArray = NSArray.FromNSObjects(bundles);
		NSMappingModel nSObject = Runtime.GetNSObject<NSMappingModel>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selMappingModelFromBundles_ForSourceModel_DestinationModel_Handle, nSArray.Handle, sourceModel.Handle, destinationModel.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
