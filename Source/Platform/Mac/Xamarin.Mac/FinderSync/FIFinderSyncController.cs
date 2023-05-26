using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace FinderSync;

[Register("FIFinderSyncController", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class FIFinderSyncController : NSExtensionContext, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultController = "defaultController";

	private static readonly IntPtr selDefaultControllerHandle = Selector.GetHandle("defaultController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirectoryURLs = "directoryURLs";

	private static readonly IntPtr selDirectoryURLsHandle = Selector.GetHandle("directoryURLs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExtensionEnabled = "isExtensionEnabled";

	private static readonly IntPtr selIsExtensionEnabledHandle = Selector.GetHandle("isExtensionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastUsedDateForItemWithURL_ = "lastUsedDateForItemWithURL:";

	private static readonly IntPtr selLastUsedDateForItemWithURL_Handle = Selector.GetHandle("lastUsedDateForItemWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedItemURLs = "selectedItemURLs";

	private static readonly IntPtr selSelectedItemURLsHandle = Selector.GetHandle("selectedItemURLs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBadgeIdentifier_ForURL_ = "setBadgeIdentifier:forURL:";

	private static readonly IntPtr selSetBadgeIdentifier_ForURL_Handle = Selector.GetHandle("setBadgeIdentifier:forURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBadgeImage_Label_ForBadgeIdentifier_ = "setBadgeImage:label:forBadgeIdentifier:";

	private static readonly IntPtr selSetBadgeImage_Label_ForBadgeIdentifier_Handle = Selector.GetHandle("setBadgeImage:label:forBadgeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirectoryURLs_ = "setDirectoryURLs:";

	private static readonly IntPtr selSetDirectoryURLs_Handle = Selector.GetHandle("setDirectoryURLs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLastUsedDate_ForItemWithURL_Completion_ = "setLastUsedDate:forItemWithURL:completion:";

	private static readonly IntPtr selSetLastUsedDate_ForItemWithURL_Completion_Handle = Selector.GetHandle("setLastUsedDate:forItemWithURL:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTagData_ForItemWithURL_Completion_ = "setTagData:forItemWithURL:completion:";

	private static readonly IntPtr selSetTagData_ForItemWithURL_Completion_Handle = Selector.GetHandle("setTagData:forItemWithURL:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowExtensionManagementInterface = "showExtensionManagementInterface";

	private static readonly IntPtr selShowExtensionManagementInterfaceHandle = Selector.GetHandle("showExtensionManagementInterface");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagDataForItemWithURL_ = "tagDataForItemWithURL:";

	private static readonly IntPtr selTagDataForItemWithURL_Handle = Selector.GetHandle("tagDataForItemWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetedURL = "targetedURL";

	private static readonly IntPtr selTargetedURLHandle = Selector.GetHandle("targetedURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("FIFinderSyncController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static FIFinderSyncController DefaultController
	{
		[Export("defaultController")]
		get
		{
			return Runtime.GetNSObject<FIFinderSyncController>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet? DirectoryUrls
	{
		[Export("directoryURLs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryURLsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryURLsHandle));
		}
		[Export("setDirectoryURLs:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDirectoryURLs_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDirectoryURLs_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static bool ExtensionEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("isExtensionEnabled")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selIsExtensionEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[]? SelectedItemURLs
	{
		[Export("selectedItemURLs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedItemURLsHandle));
			}
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedItemURLsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? TargetedURL
	{
		[Export("targetedURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetedURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetedURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public FIFinderSyncController()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public FIFinderSyncController(NSCoder coder)
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
	protected FIFinderSyncController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal FIFinderSyncController(IntPtr handle)
		: base(handle)
	{
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

	[Export("lastUsedDateForItemWithURL:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? GetLastUsedDate(NSUrl itemUrl)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLastUsedDateForItemWithURL_Handle, itemUrl.Handle));
		}
		return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLastUsedDateForItemWithURL_Handle, itemUrl.Handle));
	}

	[Export("tagDataForItemWithURL:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetTagData(NSUrl itemUrl)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTagDataForItemWithURL_Handle, itemUrl.Handle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTagDataForItemWithURL_Handle, itemUrl.Handle));
	}

	[Export("setBadgeIdentifier:forURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBadgeIdentifier(string badgeID, NSUrl url)
	{
		if (badgeID == null)
		{
			throw new ArgumentNullException("badgeID");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = NSString.CreateNative(badgeID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetBadgeIdentifier_ForURL_Handle, arg, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetBadgeIdentifier_ForURL_Handle, arg, url.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setBadgeImage:label:forBadgeIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBadgeImage(NSImage image, string? label, string badgeID)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (badgeID == null)
		{
			throw new ArgumentNullException("badgeID");
		}
		IntPtr arg = NSString.CreateNative(label);
		IntPtr arg2 = NSString.CreateNative(badgeID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetBadgeImage_Label_ForBadgeIdentifier_Handle, image.Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetBadgeImage_Label_ForBadgeIdentifier_Handle, image.Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("setLastUsedDate:forItemWithURL:completion:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetLastUsedDate(NSDate lastUsedDate, NSUrl itemUrl, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion)
	{
		if (lastUsedDate == null)
		{
			throw new ArgumentNullException("lastUsedDate");
		}
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetLastUsedDate_ForItemWithURL_Completion_Handle, lastUsedDate.Handle, itemUrl.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetLastUsedDate_ForItemWithURL_Completion_Handle, lastUsedDate.Handle, itemUrl.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetLastUsedDateAsync(NSDate lastUsedDate, NSUrl itemUrl)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetLastUsedDate(lastUsedDate, itemUrl, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("setTagData:forItemWithURL:completion:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetTagData(NSData? tagData, NSUrl itemUrl, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetTagData_ForItemWithURL_Completion_Handle, tagData?.Handle ?? IntPtr.Zero, itemUrl.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetTagData_ForItemWithURL_Completion_Handle, tagData?.Handle ?? IntPtr.Zero, itemUrl.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetTagDataAsync(NSData? tagData, NSUrl itemUrl)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetTagData(tagData, itemUrl, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("showExtensionManagementInterface")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ShowExtensionManagementInterface()
	{
		Messaging.void_objc_msgSend(class_ptr, selShowExtensionManagementInterfaceHandle);
	}
}
