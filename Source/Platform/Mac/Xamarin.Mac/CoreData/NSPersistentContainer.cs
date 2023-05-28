using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSPersistentContainer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSPersistentContainer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDirectoryURL = "defaultDirectoryURL";

	private static readonly IntPtr selDefaultDirectoryURLHandle = Selector.GetHandle("defaultDirectoryURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ = "initWithName:";

	private static readonly IntPtr selInitWithName_Handle = Selector.GetHandle("initWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_ManagedObjectModel_ = "initWithName:managedObjectModel:";

	private static readonly IntPtr selInitWithName_ManagedObjectModel_Handle = Selector.GetHandle("initWithName:managedObjectModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadPersistentStoresWithCompletionHandler_ = "loadPersistentStoresWithCompletionHandler:";

	private static readonly IntPtr selLoadPersistentStoresWithCompletionHandler_Handle = Selector.GetHandle("loadPersistentStoresWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selManagedObjectModel = "managedObjectModel";

	private static readonly IntPtr selManagedObjectModelHandle = Selector.GetHandle("managedObjectModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewBackgroundContext = "newBackgroundContext";

	private static readonly IntPtr selNewBackgroundContextHandle = Selector.GetHandle("newBackgroundContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformBackgroundTask_ = "performBackgroundTask:";

	private static readonly IntPtr selPerformBackgroundTask_Handle = Selector.GetHandle("performBackgroundTask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentContainerWithName_ = "persistentContainerWithName:";

	private static readonly IntPtr selPersistentContainerWithName_Handle = Selector.GetHandle("persistentContainerWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentContainerWithName_ManagedObjectModel_ = "persistentContainerWithName:managedObjectModel:";

	private static readonly IntPtr selPersistentContainerWithName_ManagedObjectModel_Handle = Selector.GetHandle("persistentContainerWithName:managedObjectModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStoreCoordinator = "persistentStoreCoordinator";

	private static readonly IntPtr selPersistentStoreCoordinatorHandle = Selector.GetHandle("persistentStoreCoordinator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistentStoreDescriptions = "persistentStoreDescriptions";

	private static readonly IntPtr selPersistentStoreDescriptionsHandle = Selector.GetHandle("persistentStoreDescriptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPersistentStoreDescriptions_ = "setPersistentStoreDescriptions:";

	private static readonly IntPtr selSetPersistentStoreDescriptions_Handle = Selector.GetHandle("setPersistentStoreDescriptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewContext = "viewContext";

	private static readonly IntPtr selViewContextHandle = Selector.GetHandle("viewContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersistentContainer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl DefaultDirectoryUrl
	{
		[Export("defaultDirectoryURL")]
		get
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultDirectoryURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectModel ManagedObjectModel
	{
		[Export("managedObjectModel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSend(base.Handle, selManagedObjectModelHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectModel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selManagedObjectModelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContext NewBackgroundContext
	{
		[Export("newBackgroundContext")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selNewBackgroundContextHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNewBackgroundContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStoreCoordinator PersistentStoreCoordinator
	{
		[Export("persistentStoreCoordinator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPersistentStoreCoordinator>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreCoordinatorHandle));
			}
			return Runtime.GetNSObject<NSPersistentStoreCoordinator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreCoordinatorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersistentStoreDescription[] PersistentStoreDescriptions
	{
		[Export("persistentStoreDescriptions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPersistentStoreDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selPersistentStoreDescriptionsHandle));
			}
			return NSArray.ArrayFromHandle<NSPersistentStoreDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPersistentStoreDescriptionsHandle));
		}
		[Export("setPersistentStoreDescriptions:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPersistentStoreDescriptions_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPersistentStoreDescriptions_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSManagedObjectContext ViewContext
	{
		[Export("viewContext", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewContextHandle));
			}
			return Runtime.GetNSObject<NSManagedObjectContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPersistentContainer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersistentContainer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentContainer(string name)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithName_Handle, arg), "initWithName:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithName_Handle, arg), "initWithName:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:managedObjectModel:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPersistentContainer(string name, NSManagedObjectModel model)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_ManagedObjectModel_Handle, arg, model.Handle), "initWithName:managedObjectModel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_ManagedObjectModel_Handle, arg, model.Handle), "initWithName:managedObjectModel:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("persistentContainerWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentContainer GetPersistentContainer(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSPersistentContainer nSObject = Runtime.GetNSObject<NSPersistentContainer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPersistentContainerWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("persistentContainerWithName:managedObjectModel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPersistentContainer GetPersistentContainer(string name, NSManagedObjectModel model)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSPersistentContainer nSObject = Runtime.GetNSObject<NSPersistentContainer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPersistentContainerWithName_ManagedObjectModel_Handle, arg, model.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("loadPersistentStoresWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadPersistentStores([BlockProxy(typeof(Trampolines.NIDActionArity2V37))] Action<NSPersistentStoreDescription, NSError> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V37.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadPersistentStoresWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadPersistentStoresWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSPersistentStoreDescription> LoadPersistentStoresAsync()
	{
		TaskCompletionSource<NSPersistentStoreDescription> tcs = new TaskCompletionSource<NSPersistentStoreDescription>();
		LoadPersistentStores(delegate(NSPersistentStoreDescription arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("performBackgroundTask:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Perform([BlockProxy(typeof(Trampolines.NIDActionArity1V23))] Action<NSManagedObjectContext> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V23.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformBackgroundTask_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformBackgroundTask_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
