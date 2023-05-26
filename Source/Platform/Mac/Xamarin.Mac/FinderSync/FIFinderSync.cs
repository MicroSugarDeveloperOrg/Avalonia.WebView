using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace FinderSync;

[Register("FIFinderSync", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class FIFinderSync : NSObject, IFIFinderSyncProtocol, INativeObject, IDisposable, INSExtensionRequestHandling
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginObservingDirectoryAtURL_ = "beginObservingDirectoryAtURL:";

	private static readonly IntPtr selBeginObservingDirectoryAtURL_Handle = Selector.GetHandle("beginObservingDirectoryAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginRequestWithExtensionContext_ = "beginRequestWithExtensionContext:";

	private static readonly IntPtr selBeginRequestWithExtensionContext_Handle = Selector.GetHandle("beginRequestWithExtensionContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndObservingDirectoryAtURL_ = "endObservingDirectoryAtURL:";

	private static readonly IntPtr selEndObservingDirectoryAtURL_Handle = Selector.GetHandle("endObservingDirectoryAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuForMenuKind_ = "menuForMenuKind:";

	private static readonly IntPtr selMenuForMenuKind_Handle = Selector.GetHandle("menuForMenuKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestBadgeIdentifierForURL_ = "requestBadgeIdentifierForURL:";

	private static readonly IntPtr selRequestBadgeIdentifierForURL_Handle = Selector.GetHandle("requestBadgeIdentifierForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedServiceNamesForItemWithURL_ = "supportedServiceNamesForItemWithURL:";

	private static readonly IntPtr selSupportedServiceNamesForItemWithURL_Handle = Selector.GetHandle("supportedServiceNamesForItemWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarItemImage = "toolbarItemImage";

	private static readonly IntPtr selToolbarItemImageHandle = Selector.GetHandle("toolbarItemImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarItemName = "toolbarItemName";

	private static readonly IntPtr selToolbarItemNameHandle = Selector.GetHandle("toolbarItemName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolbarItemToolTip = "toolbarItemToolTip";

	private static readonly IntPtr selToolbarItemToolTipHandle = Selector.GetHandle("toolbarItemToolTip");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValuesForAttributes_ForItemWithURL_Completion_ = "valuesForAttributes:forItemWithURL:completion:";

	private static readonly IntPtr selValuesForAttributes_ForItemWithURL_Completion_Handle = Selector.GetHandle("valuesForAttributes:forItemWithURL:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("FIFinderSync");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSImage ToolbarItemImage
	{
		[Export("toolbarItemImage", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selToolbarItemImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolbarItemImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string ToolbarItemName
	{
		[Export("toolbarItemName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolbarItemNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolbarItemNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string ToolbarItemToolTip
	{
		[Export("toolbarItemToolTip")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selToolbarItemToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selToolbarItemToolTipHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public FIFinderSync()
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
	protected FIFinderSync(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal FIFinderSync(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginObservingDirectoryAtURL:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginObservingDirectory(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginObservingDirectoryAtURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginObservingDirectoryAtURL_Handle, url.Handle);
		}
	}

	[Export("beginRequestWithExtensionContext:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginRequestWithExtensionContext(NSExtensionContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginRequestWithExtensionContext_Handle, context.Handle);
		}
	}

	[Export("endObservingDirectoryAtURL:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndObservingDirectory(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndObservingDirectoryAtURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndObservingDirectoryAtURL_Handle, url.Handle);
		}
	}

	[Export("menuForMenuKind:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu? GetMenu(FIMenuKind menuKind)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selMenuForMenuKind_Handle, (ulong)menuKind));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selMenuForMenuKind_Handle, (ulong)menuKind));
	}

	[Export("valuesForAttributes:forItemWithURL:completion:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetValues(string[] attributes, NSUrl itemUrl, [BlockProxy(typeof(Trampolines.NIDGetValuesCompletionHandler))] GetValuesCompletionHandler completion)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		NSArray nSArray = NSArray.FromStrings(attributes);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGetValuesCompletionHandler.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selValuesForAttributes_ForItemWithURL_Completion_Handle, nSArray.Handle, itemUrl.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selValuesForAttributes_ForItemWithURL_Completion_Handle, nSArray.Handle, itemUrl.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSDictionary<NSString, NSObject>> GetValuesAsync(string[] attributes, NSUrl itemUrl)
	{
		TaskCompletionSource<NSDictionary<NSString, NSObject>> tcs = new TaskCompletionSource<NSDictionary<NSString, NSObject>>();
		GetValues(attributes, itemUrl, delegate(NSDictionary<NSString, NSObject> values_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(values_);
			}
		});
		return tcs.Task;
	}

	[Export("requestBadgeIdentifierForURL:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestBadgeIdentifier(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRequestBadgeIdentifierForURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRequestBadgeIdentifierForURL_Handle, url.Handle);
		}
	}

	[Export("supportedServiceNamesForItemWithURL:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] SupportedServiceNames(NSUrl itemUrl)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSupportedServiceNamesForItemWithURL_Handle, itemUrl.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSupportedServiceNamesForItemWithURL_Handle, itemUrl.Handle));
	}
}
