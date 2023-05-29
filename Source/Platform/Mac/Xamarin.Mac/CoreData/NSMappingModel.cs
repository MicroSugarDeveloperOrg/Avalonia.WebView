using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSMappingModel", true)]
public class NSMappingModel : NSObject
{
	private static readonly IntPtr selEntityMappingsHandle = Selector.GetHandle("entityMappings");

	private static readonly IntPtr selSetEntityMappings_Handle = Selector.GetHandle("setEntityMappings:");

	private static readonly IntPtr selEntityMappingsByNameHandle = Selector.GetHandle("entityMappingsByName");

	private static readonly IntPtr selMappingModelFromBundlesForSourceModelDestinationModel_Handle = Selector.GetHandle("mappingModelFromBundles:forSourceModel:destinationModel:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMappingModel");

	private object __mt_EntityMappings_var;

	private object __mt_EntityMappingsByName_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSEntityMapping[] EntityMappings
	{
		[Export("entityMappings")]
		get
		{
			return (NSEntityMapping[])(__mt_EntityMappings_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSEntityMapping>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityMappingsHandle)) : NSArray.ArrayFromHandle<NSEntityMapping>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityMappingsHandle))));
		}
		[Export("setEntityMappings:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEntityMappings_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEntityMappings_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_EntityMappings_var = value;
		}
	}

	public virtual NSDictionary EntityMappingsByName
	{
		[Export("entityMappingsByName")]
		get
		{
			return (NSDictionary)(__mt_EntityMappingsByName_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntityMappingsByNameHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntityMappingsByNameHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMappingModel()
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
	public NSMappingModel(NSCoder coder)
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
	public NSMappingModel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMappingModel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("mappingModelFromBundles:forSourceModel:destinationModel:")]
	public static NSMappingModel MappingModelFromBundles(NSBundle[] bundles, NSManagedObjectModel sourceModel, NSManagedObjectModel destinationModel)
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
		NSMappingModel result = (NSMappingModel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selMappingModelFromBundlesForSourceModelDestinationModel_Handle, nSArray.Handle, sourceModel.Handle, destinationModel.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("initWithContentsOfURL:")]
	public NSMappingModel(NSUrl url)
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_EntityMappings_var = null;
			__mt_EntityMappingsByName_var = null;
		}
	}
}
