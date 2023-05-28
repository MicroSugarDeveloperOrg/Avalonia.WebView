using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CloudKit;
using CoreGraphics;
using ObjCRuntime;

namespace Foundation;

[Register("NSItemProvider", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSItemProvider : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanLoadObjectOfClass_ = "canLoadObjectOfClass:";

	private static readonly IntPtr selCanLoadObjectOfClass_Handle = Selector.GetHandle("canLoadObjectOfClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainerFrame = "containerFrame";

	private static readonly IntPtr selContainerFrameHandle = Selector.GetHandle("containerFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasItemConformingToTypeIdentifier_ = "hasItemConformingToTypeIdentifier:";

	private static readonly IntPtr selHasItemConformingToTypeIdentifier_Handle = Selector.GetHandle("hasItemConformingToTypeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasRepresentationConformingToTypeIdentifier_FileOptions_ = "hasRepresentationConformingToTypeIdentifier:fileOptions:";

	private static readonly IntPtr selHasRepresentationConformingToTypeIdentifier_FileOptions_Handle = Selector.GetHandle("hasRepresentationConformingToTypeIdentifier:fileOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithItem_TypeIdentifier_ = "initWithItem:typeIdentifier:";

	private static readonly IntPtr selInitWithItem_TypeIdentifier_Handle = Selector.GetHandle("initWithItem:typeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithObject_ = "initWithObject:";

	private static readonly IntPtr selInitWithObject_Handle = Selector.GetHandle("initWithObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadDataRepresentationForTypeIdentifier_CompletionHandler_ = "loadDataRepresentationForTypeIdentifier:completionHandler:";

	private static readonly IntPtr selLoadDataRepresentationForTypeIdentifier_CompletionHandler_Handle = Selector.GetHandle("loadDataRepresentationForTypeIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFileRepresentationForTypeIdentifier_CompletionHandler_ = "loadFileRepresentationForTypeIdentifier:completionHandler:";

	private static readonly IntPtr selLoadFileRepresentationForTypeIdentifier_CompletionHandler_Handle = Selector.GetHandle("loadFileRepresentationForTypeIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_ = "loadInPlaceFileRepresentationForTypeIdentifier:completionHandler:";

	private static readonly IntPtr selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_Handle = Selector.GetHandle("loadInPlaceFileRepresentationForTypeIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadItemForTypeIdentifier_Options_CompletionHandler_ = "loadItemForTypeIdentifier:options:completionHandler:";

	private static readonly IntPtr selLoadItemForTypeIdentifier_Options_CompletionHandler_Handle = Selector.GetHandle("loadItemForTypeIdentifier:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadObjectOfClass_CompletionHandler_ = "loadObjectOfClass:completionHandler:";

	private static readonly IntPtr selLoadObjectOfClass_CompletionHandler_Handle = Selector.GetHandle("loadObjectOfClass:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadPreviewImageWithOptions_CompletionHandler_ = "loadPreviewImageWithOptions:completionHandler:";

	private static readonly IntPtr selLoadPreviewImageWithOptions_CompletionHandler_Handle = Selector.GetHandle("loadPreviewImageWithOptions:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredPresentationSize = "preferredPresentationSize";

	private static readonly IntPtr selPreferredPresentationSizeHandle = Selector.GetHandle("preferredPresentationSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterCloudKitShare_Container_ = "registerCloudKitShare:container:";

	private static readonly IntPtr selRegisterCloudKitShare_Container_Handle = Selector.GetHandle("registerCloudKitShare:container:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterCloudKitShareWithPreparationHandler_ = "registerCloudKitShareWithPreparationHandler:";

	private static readonly IntPtr selRegisterCloudKitShareWithPreparationHandler_Handle = Selector.GetHandle("registerCloudKitShareWithPreparationHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_ = "registerDataRepresentationForTypeIdentifier:visibility:loadHandler:";

	private static readonly IntPtr selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_Handle = Selector.GetHandle("registerDataRepresentationForTypeIdentifier:visibility:loadHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_ = "registerFileRepresentationForTypeIdentifier:fileOptions:visibility:loadHandler:";

	private static readonly IntPtr selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_Handle = Selector.GetHandle("registerFileRepresentationForTypeIdentifier:fileOptions:visibility:loadHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterItemForTypeIdentifier_LoadHandler_ = "registerItemForTypeIdentifier:loadHandler:";

	private static readonly IntPtr selRegisterItemForTypeIdentifier_LoadHandler_Handle = Selector.GetHandle("registerItemForTypeIdentifier:loadHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterObject_Visibility_ = "registerObject:visibility:";

	private static readonly IntPtr selRegisterObject_Visibility_Handle = Selector.GetHandle("registerObject:visibility:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterObjectOfClass_Visibility_LoadHandler_ = "registerObjectOfClass:visibility:loadHandler:";

	private static readonly IntPtr selRegisterObjectOfClass_Visibility_LoadHandler_Handle = Selector.GetHandle("registerObjectOfClass:visibility:loadHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredTypeIdentifiers = "registeredTypeIdentifiers";

	private static readonly IntPtr selRegisteredTypeIdentifiersHandle = Selector.GetHandle("registeredTypeIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisteredTypeIdentifiersWithFileOptions_ = "registeredTypeIdentifiersWithFileOptions:";

	private static readonly IntPtr selRegisteredTypeIdentifiersWithFileOptions_Handle = Selector.GetHandle("registeredTypeIdentifiersWithFileOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviewImageHandler_ = "setPreviewImageHandler:";

	private static readonly IntPtr selSetPreviewImageHandler_Handle = Selector.GetHandle("setPreviewImageHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSuggestedName_ = "setSuggestedName:";

	private static readonly IntPtr selSetSuggestedName_Handle = Selector.GetHandle("setSuggestedName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceFrame = "sourceFrame";

	private static readonly IntPtr selSourceFrameHandle = Selector.GetHandle("sourceFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuggestedName = "suggestedName";

	private static readonly IntPtr selSuggestedNameHandle = Selector.GetHandle("suggestedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSItemProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PreferredImageSizeKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGRect ContainerFrame
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("containerFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selContainerFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContainerFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGSize PreferredPresentationSize
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("preferredPresentationSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selPreferredPresentationSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selPreferredPresentationSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] RegisteredTypeIdentifiers
	{
		[Export("registeredTypeIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRegisteredTypeIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRegisteredTypeIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual CGRect SourceFrame
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("sourceFrame")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selSourceFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSourceFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual string? SuggestedName
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("suggestedName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSuggestedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuggestedNameHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setSuggestedName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSuggestedName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSuggestedName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("NSItemProviderErrorDomain", "Foundation")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSItemProviderErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("NSItemProviderPreferredImageSizeKey", "Foundation")]
	public static NSString PreferredImageSizeKey
	{
		get
		{
			if (_PreferredImageSizeKey == null)
			{
				_PreferredImageSizeKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSItemProviderPreferredImageSizeKey");
			}
			return _PreferredImageSizeKey;
		}
	}

	[Obsolete("Use RegisterCloudKitShare (CloudKitRegistrationPreparationAction) instead.")]
	public virtual void RegisterCloudKitShare(Action<CloudKitRegistrationPreparationHandler> preparationHandler)
	{
		CloudKitRegistrationPreparationAction preparationHandler2 = delegate(CloudKitRegistrationPreparationHandler handler)
		{
			preparationHandler(handler);
		};
		RegisterCloudKitShare(preparationHandler2);
	}

	public virtual Task<CloudKitRegistrationPreparationHandler> RegisterCloudKitShareAsync()
	{
		TaskCompletionSource<CloudKitRegistrationPreparationHandler> tcs = new TaskCompletionSource<CloudKitRegistrationPreparationHandler>();
		CloudKitRegistrationPreparationAction preparationHandler = delegate(CloudKitRegistrationPreparationHandler handler)
		{
			tcs.SetResult(handler);
		};
		RegisterCloudKitShare(preparationHandler);
		return tcs.Task;
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public NSProgress LoadObject<T>(Action<T, NSError> completionHandler) where T : NSObject, INSItemProviderReading
	{
		return LoadObject(new Class(typeof(T)), delegate(INSItemProviderReading rv, NSError err)
		{
			T val = rv as T;
			if (val == null && rv != null)
			{
				val = Runtime.ConstructNSObject<T>(rv.Handle);
			}
			completionHandler(val, err);
		});
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public Task<T> LoadObjectAsync<T>() where T : NSObject, INSItemProviderReading
	{
		Task<INSItemProviderReading> task = LoadObjectAsync(new Class(typeof(T)));
		return task.ContinueWith(delegate(Task<INSItemProviderReading> v)
		{
			T val = v.Result as T;
			if (val == null && v.Result != null)
			{
				val = Runtime.ConstructNSObject<T>(v.Result.Handle);
			}
			return val;
		});
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public Task<T> LoadObjectAsync<T>(out NSProgress result) where T : NSObject, INSItemProviderReading
	{
		Task<INSItemProviderReading> task = LoadObjectAsync(new Class(typeof(T)), out result);
		return task.ContinueWith(delegate(Task<INSItemProviderReading> v)
		{
			T val = v.Result as T;
			if (val == null && v.Result != null)
			{
				val = Runtime.ConstructNSObject<T>(v.Result.Handle);
			}
			return val;
		});
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSItemProvider()
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
	protected NSItemProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSItemProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItem:typeIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSItemProvider(NSObject? item, string typeIdentifier)
		: base(NSObjectFlag.Empty)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithItem_TypeIdentifier_Handle, item?.Handle ?? IntPtr.Zero, arg), "initWithItem:typeIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithItem_TypeIdentifier_Handle, item?.Handle ?? IntPtr.Zero, arg), "initWithItem:typeIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSItemProvider(NSUrl fileUrl)
		: base(NSObjectFlag.Empty)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, fileUrl.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, fileUrl.Handle), "initWithContentsOfURL:");
		}
	}

	[Export("initWithObject:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSItemProvider(INSItemProviderWriting @object)
		: base(NSObjectFlag.Empty)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithObject_Handle, @object.Handle), "initWithObject:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithObject_Handle, @object.Handle), "initWithObject:");
		}
	}

	[Export("canLoadObjectOfClass:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanLoadObject(Class aClass)
	{
		if (aClass == null)
		{
			throw new ArgumentNullException("aClass");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanLoadObjectOfClass_Handle, aClass.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanLoadObjectOfClass_Handle, aClass.Handle);
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CanLoadObject(Type type)
	{
		return CanLoadObject(new Class(type));
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

	[Export("registeredTypeIdentifiersWithFileOptions:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetRegisteredTypeIdentifiers(NSItemProviderFileOptions fileOptions)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selRegisteredTypeIdentifiersWithFileOptions_Handle, (long)fileOptions));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selRegisteredTypeIdentifiersWithFileOptions_Handle, (long)fileOptions));
	}

	[Export("hasRepresentationConformingToTypeIdentifier:fileOptions:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasConformingRepresentation(string typeIdentifier, NSItemProviderFileOptions fileOptions)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selHasRepresentationConformingToTypeIdentifier_FileOptions_Handle, arg, (long)fileOptions) : Messaging.bool_objc_msgSend_IntPtr_Int64(base.Handle, selHasRepresentationConformingToTypeIdentifier_FileOptions_Handle, arg, (long)fileOptions));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasItemConformingToTypeIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasItemConformingTo(string typeIdentifier)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasItemConformingToTypeIdentifier_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasItemConformingToTypeIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("loadDataRepresentationForTypeIdentifier:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress LoadDataRepresentation(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadDataRepresentationForTypeIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadDataRepresentationForTypeIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataRepresentationAsync(string typeIdentifier)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		LoadDataRepresentation(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
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

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataRepresentationAsync(string typeIdentifier, out NSProgress result)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		result = LoadDataRepresentation(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
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

	[Export("loadFileRepresentationForTypeIdentifier:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress LoadFileRepresentation(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V6))] Action<NSUrl, NSError> completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V6.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadFileRepresentationForTypeIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadFileRepresentationForTypeIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrl> LoadFileRepresentationAsync(string typeIdentifier)
	{
		TaskCompletionSource<NSUrl> tcs = new TaskCompletionSource<NSUrl>();
		LoadFileRepresentation(typeIdentifier, delegate(NSUrl arg1_, NSError arg2_)
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

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrl> LoadFileRepresentationAsync(string typeIdentifier, out NSProgress result)
	{
		TaskCompletionSource<NSUrl> tcs = new TaskCompletionSource<NSUrl>();
		result = LoadFileRepresentation(typeIdentifier, delegate(NSUrl arg1_, NSError arg2_)
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

	[Export("loadInPlaceFileRepresentationForTypeIdentifier:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress LoadInPlaceFileRepresentation(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDLoadInPlaceFileRepresentationHandler))] LoadInPlaceFileRepresentationHandler completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDLoadInPlaceFileRepresentationHandler.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadInPlaceFileRepresentationForTypeIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<LoadInPlaceResult> LoadInPlaceFileRepresentationAsync(string typeIdentifier)
	{
		TaskCompletionSource<LoadInPlaceResult> tcs = new TaskCompletionSource<LoadInPlaceResult>();
		LoadInPlaceFileRepresentation(typeIdentifier, delegate(NSUrl fileUrl_, bool isInPlace_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new LoadInPlaceResult(fileUrl_, isInPlace_));
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<LoadInPlaceResult> LoadInPlaceFileRepresentationAsync(string typeIdentifier, out NSProgress result)
	{
		TaskCompletionSource<LoadInPlaceResult> tcs = new TaskCompletionSource<LoadInPlaceResult>();
		result = LoadInPlaceFileRepresentation(typeIdentifier, delegate(NSUrl fileUrl_, bool isInPlace_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new LoadInPlaceResult(fileUrl_, isInPlace_));
			}
		});
		return tcs.Task;
	}

	[Export("loadItemForTypeIdentifier:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadItem(string typeIdentifier, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V42))] Action<NSObject, NSError>? completionHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V42.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selLoadItemForTypeIdentifier_Options_CompletionHandler_Handle, arg, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selLoadItemForTypeIdentifier_Options_CompletionHandler_Handle, arg, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSObject> LoadItemAsync(string typeIdentifier, NSDictionary? options)
	{
		TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
		LoadItem(typeIdentifier, options, delegate(NSObject arg1_, NSError arg2_)
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

	[Export("loadObjectOfClass:completionHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress LoadObject(Class aClass, [BlockProxy(typeof(Trampolines.NIDActionArity2V43))] Action<INSItemProviderReading, NSError> completionHandler)
	{
		if (aClass == null)
		{
			throw new ArgumentNullException("aClass");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V43.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadObjectOfClass_CompletionHandler_Handle, aClass.Handle, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadObjectOfClass_CompletionHandler_Handle, aClass.Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<INSItemProviderReading> LoadObjectAsync(Class aClass)
	{
		TaskCompletionSource<INSItemProviderReading> tcs = new TaskCompletionSource<INSItemProviderReading>();
		LoadObject(aClass, delegate(INSItemProviderReading arg1_, NSError arg2_)
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

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<INSItemProviderReading> LoadObjectAsync(Class aClass, out NSProgress result)
	{
		TaskCompletionSource<INSItemProviderReading> tcs = new TaskCompletionSource<INSItemProviderReading>();
		result = LoadObject(aClass, delegate(INSItemProviderReading arg1_, NSError arg2_)
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

	[Export("loadPreviewImageWithOptions:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadPreviewImage(NSDictionary options, [BlockProxy(typeof(Trampolines.NIDActionArity2V42))] Action<NSObject, NSError> completionHandler)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V42.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadPreviewImageWithOptions_CompletionHandler_Handle, options.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadPreviewImageWithOptions_CompletionHandler_Handle, options.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSObject> LoadPreviewImageAsync(NSDictionary options)
	{
		TaskCompletionSource<NSObject> tcs = new TaskCompletionSource<NSObject>();
		LoadPreviewImage(options, delegate(NSObject arg1_, NSError arg2_)
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

	[Export("registerCloudKitShareWithPreparationHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RegisterCloudKitShare([BlockProxy(typeof(Trampolines.NIDCloudKitRegistrationPreparationAction))] CloudKitRegistrationPreparationAction preparationHandler)
	{
		if (preparationHandler == null)
		{
			throw new ArgumentNullException("preparationHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDCloudKitRegistrationPreparationAction.Handler, preparationHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterCloudKitShareWithPreparationHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterCloudKitShareWithPreparationHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("registerCloudKitShare:container:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterCloudKitShare(CKShare share, CKContainer container)
	{
		if (share == null)
		{
			throw new ArgumentNullException("share");
		}
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterCloudKitShare_Container_Handle, share.Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterCloudKitShare_Container_Handle, share.Handle, container.Handle);
		}
	}

	[Export("registerDataRepresentationForTypeIdentifier:visibility:loadHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RegisterDataRepresentation(string typeIdentifier, NSItemProviderRepresentationVisibility visibility, [BlockProxy(typeof(Trampolines.NIDRegisterDataRepresentationLoadHandler))] RegisterDataRepresentationLoadHandler loadHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (loadHandler == null)
		{
			throw new ArgumentNullException("loadHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDRegisterDataRepresentationLoadHandler.Handler, loadHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_Handle, arg, (long)visibility, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selRegisterDataRepresentationForTypeIdentifier_Visibility_LoadHandler_Handle, arg, (long)visibility, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("registerFileRepresentationForTypeIdentifier:fileOptions:visibility:loadHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RegisterFileRepresentation(string typeIdentifier, NSItemProviderFileOptions fileOptions, NSItemProviderRepresentationVisibility visibility, [BlockProxy(typeof(Trampolines.NIDRegisterFileRepresentationLoadHandler))] RegisterFileRepresentationLoadHandler loadHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (loadHandler == null)
		{
			throw new ArgumentNullException("loadHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDRegisterFileRepresentationLoadHandler.Handler, loadHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_Int64_IntPtr(base.Handle, selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_Handle, arg, (long)fileOptions, (long)visibility, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_Int64_IntPtr(base.SuperHandle, selRegisterFileRepresentationForTypeIdentifier_FileOptions_Visibility_LoadHandler_Handle, arg, (long)fileOptions, (long)visibility, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("registerItemForTypeIdentifier:loadHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RegisterItemForTypeIdentifier(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDNSItemProviderLoadHandler))] NSItemProviderLoadHandler loadHandler)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		if (loadHandler == null)
		{
			throw new ArgumentNullException("loadHandler");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSItemProviderLoadHandler.Handler, loadHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterItemForTypeIdentifier_LoadHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterItemForTypeIdentifier_LoadHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("registerObject:visibility:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterObject(INSItemProviderWriting @object, NSItemProviderRepresentationVisibility visibility)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selRegisterObject_Visibility_Handle, @object.Handle, (long)visibility);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selRegisterObject_Visibility_Handle, @object.Handle, (long)visibility);
		}
	}

	[Export("registerObjectOfClass:visibility:loadHandler:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RegisterObject(Class aClass, NSItemProviderRepresentationVisibility visibility, [BlockProxy(typeof(Trampolines.NIDRegisterObjectRepresentationLoadHandler))] RegisterObjectRepresentationLoadHandler loadHandler)
	{
		if (aClass == null)
		{
			throw new ArgumentNullException("aClass");
		}
		if (loadHandler == null)
		{
			throw new ArgumentNullException("loadHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDRegisterObjectRepresentationLoadHandler.Handler, loadHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selRegisterObjectOfClass_Visibility_LoadHandler_Handle, aClass.Handle, (long)visibility, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selRegisterObjectOfClass_Visibility_LoadHandler_Handle, aClass.Handle, (long)visibility, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RegisterObject(Type type, NSItemProviderRepresentationVisibility visibility, [BlockProxy(typeof(Trampolines.NIDRegisterObjectRepresentationLoadHandler))] RegisterObjectRepresentationLoadHandler loadHandler)
	{
		RegisterObject(new Class(type), visibility, loadHandler);
	}

	[Export("setPreviewImageHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetPreviewImageHandler([BlockProxy(typeof(Trampolines.NIDNSItemProviderLoadHandler))] NSItemProviderLoadHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSItemProviderLoadHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreviewImageHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreviewImageHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
