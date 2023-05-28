using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileCoordinator", true)]
public class NSFileCoordinator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFilePresenter_ = "addFilePresenter:";

	private static readonly IntPtr selAddFilePresenter_Handle = Selector.GetHandle("addFilePresenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinateAccessWithIntents_Queue_ByAccessor_ = "coordinateAccessWithIntents:queue:byAccessor:";

	private static readonly IntPtr selCoordinateAccessWithIntents_Queue_ByAccessor_Handle = Selector.GetHandle("coordinateAccessWithIntents:queue:byAccessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinateReadingItemAtURL_Options_Error_ByAccessor_ = "coordinateReadingItemAtURL:options:error:byAccessor:";

	private static readonly IntPtr selCoordinateReadingItemAtURL_Options_Error_ByAccessor_Handle = Selector.GetHandle("coordinateReadingItemAtURL:options:error:byAccessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_ = "coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:";

	private static readonly IntPtr selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_Handle = Selector.GetHandle("coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinateWritingItemAtURL_Options_Error_ByAccessor_ = "coordinateWritingItemAtURL:options:error:byAccessor:";

	private static readonly IntPtr selCoordinateWritingItemAtURL_Options_Error_ByAccessor_Handle = Selector.GetHandle("coordinateWritingItemAtURL:options:error:byAccessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_ = "coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:";

	private static readonly IntPtr selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_Handle = Selector.GetHandle("coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilePresenters = "filePresenters";

	private static readonly IntPtr selFilePresentersHandle = Selector.GetHandle("filePresenters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFilePresenter_ = "initWithFilePresenter:";

	private static readonly IntPtr selInitWithFilePresenter_Handle = Selector.GetHandle("initWithFilePresenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtURL_DidChangeUbiquityAttributes_ = "itemAtURL:didChangeUbiquityAttributes:";

	private static readonly IntPtr selItemAtURL_DidChangeUbiquityAttributes_Handle = Selector.GetHandle("itemAtURL:didChangeUbiquityAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtURL_DidMoveToURL_ = "itemAtURL:didMoveToURL:";

	private static readonly IntPtr selItemAtURL_DidMoveToURL_Handle = Selector.GetHandle("itemAtURL:didMoveToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtURL_WillMoveToURL_ = "itemAtURL:willMoveToURL:";

	private static readonly IntPtr selItemAtURL_WillMoveToURL_Handle = Selector.GetHandle("itemAtURL:willMoveToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_ = "prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:";

	private static readonly IntPtr selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_Handle = Selector.GetHandle("prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPurposeIdentifier = "purposeIdentifier";

	private static readonly IntPtr selPurposeIdentifierHandle = Selector.GetHandle("purposeIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFilePresenter_ = "removeFilePresenter:";

	private static readonly IntPtr selRemoveFilePresenter_Handle = Selector.GetHandle("removeFilePresenter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPurposeIdentifier_ = "setPurposeIdentifier:";

	private static readonly IntPtr selSetPurposeIdentifier_Handle = Selector.GetHandle("setPurposeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFileCoordinator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSFilePresenter[] FilePresenters
	{
		[Export("filePresenters", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.ArrayFromHandle<INSFilePresenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selFilePresentersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PurposeIdentifier
	{
		[Export("purposeIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPurposeIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPurposeIdentifierHandle));
		}
		[Export("setPurposeIdentifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPurposeIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPurposeIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileCoordinator()
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
	protected NSFileCoordinator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileCoordinator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFilePresenter:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileCoordinator(INSFilePresenter? filePresenterOrNil)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFilePresenter_Handle, filePresenterOrNil?.Handle ?? IntPtr.Zero), "initWithFilePresenter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFilePresenter_Handle, filePresenterOrNil?.Handle ?? IntPtr.Zero), "initWithFilePresenter:");
		}
	}

	[Obsolete("Use '.ctor(INSFilePresenter)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileCoordinator(NSFilePresenter? filePresenterOrNil)
		: this((INSFilePresenter?)filePresenterOrNil)
	{
	}

	[Export("addFilePresenter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddFilePresenter(INSFilePresenter filePresenter)
	{
		if (filePresenter != null)
		{
			if (!(filePresenter is NSObject))
			{
				throw new ArgumentException("The object passed of type " + filePresenter.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selAddFilePresenter_Handle, filePresenter.Handle);
			return;
		}
		throw new ArgumentNullException("filePresenter");
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("coordinateAccessWithIntents:queue:byAccessor:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CoordinateAccess(NSFileAccessIntent[] intents, NSOperationQueue executionQueue, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> accessor)
	{
		if (intents == null)
		{
			throw new ArgumentNullException("intents");
		}
		if (executionQueue == null)
		{
			throw new ArgumentNullException("executionQueue");
		}
		if (accessor == null)
		{
			throw new ArgumentNullException("accessor");
		}
		NSArray nSArray = NSArray.FromNSObjects(intents);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, accessor);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCoordinateAccessWithIntents_Queue_ByAccessor_Handle, nSArray.Handle, executionQueue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCoordinateAccessWithIntents_Queue_ByAccessor_Handle, nSArray.Handle, executionQueue.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Export("prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CoordinateBatc(NSUrl[] readingURLs, NSFileCoordinatorReadingOptions readingOptions, NSUrl[] writingURLs, NSFileCoordinatorWritingOptions writingOptions, out NSError error, [BlockProxy(typeof(Trampolines.NIDAction))] Action batchHandler)
	{
		if (readingURLs == null)
		{
			throw new ArgumentNullException("readingURLs");
		}
		if (writingURLs == null)
		{
			throw new ArgumentNullException("writingURLs");
		}
		if (batchHandler == null)
		{
			throw new ArgumentNullException("batchHandler");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(readingURLs);
		NSArray nSArray2 = NSArray.FromNSObjects(writingURLs);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, batchHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr(base.Handle, selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_Handle, nSArray.Handle, (ulong)readingOptions, nSArray2.Handle, (ulong)writingOptions, ref arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr(base.SuperHandle, selPrepareForReadingItemsAtURLs_Options_WritingItemsAtURLs_Options_Error_ByAccessor_Handle, nSArray.Handle, (ulong)readingOptions, nSArray2.Handle, (ulong)writingOptions, ref arg, (IntPtr)ptr);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("coordinateReadingItemAtURL:options:error:byAccessor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CoordinateRead(NSUrl itemUrl, NSFileCoordinatorReadingOptions options, out NSError error, [BlockProxy(typeof(Trampolines.NIDActionArity1V29))] Action<NSUrl> worker)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		if (worker == null)
		{
			throw new ArgumentNullException("worker");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V29.Handler, worker);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_ref_IntPtr_IntPtr(base.Handle, selCoordinateReadingItemAtURL_Options_Error_ByAccessor_Handle, itemUrl.Handle, (ulong)options, ref arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr_IntPtr(base.SuperHandle, selCoordinateReadingItemAtURL_Options_Error_ByAccessor_Handle, itemUrl.Handle, (ulong)options, ref arg, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CoordinateReadWrite(NSUrl readingURL, NSFileCoordinatorReadingOptions readingOptions, NSUrl writingURL, NSFileCoordinatorWritingOptions writingOptions, out NSError error, [BlockProxy(typeof(Trampolines.NIDNSFileCoordinatorWorkerRW))] NSFileCoordinatorWorkerRW readWriteWorker)
	{
		if (readingURL == null)
		{
			throw new ArgumentNullException("readingURL");
		}
		if (writingURL == null)
		{
			throw new ArgumentNullException("writingURL");
		}
		if (readWriteWorker == null)
		{
			throw new ArgumentNullException("readWriteWorker");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFileCoordinatorWorkerRW.Handler, readWriteWorker);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr(base.Handle, selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_Handle, readingURL.Handle, (ulong)readingOptions, writingURL.Handle, (ulong)writingOptions, ref arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr(base.SuperHandle, selCoordinateReadingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_Handle, readingURL.Handle, (ulong)readingOptions, writingURL.Handle, (ulong)writingOptions, ref arg, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("coordinateWritingItemAtURL:options:error:byAccessor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CoordinateWrite(NSUrl url, NSFileCoordinatorWritingOptions options, out NSError error, [BlockProxy(typeof(Trampolines.NIDActionArity1V29))] Action<NSUrl> worker)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (worker == null)
		{
			throw new ArgumentNullException("worker");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V29.Handler, worker);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_ref_IntPtr_IntPtr(base.Handle, selCoordinateWritingItemAtURL_Options_Error_ByAccessor_Handle, url.Handle, (ulong)options, ref arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr_IntPtr(base.SuperHandle, selCoordinateWritingItemAtURL_Options_Error_ByAccessor_Handle, url.Handle, (ulong)options, ref arg, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CoordinateWriteWrite(NSUrl writingURL, NSFileCoordinatorWritingOptions writingOptions, NSUrl writingURL2, NSFileCoordinatorWritingOptions writingOptions2, out NSError error, [BlockProxy(typeof(Trampolines.NIDNSFileCoordinatorWorkerRW))] NSFileCoordinatorWorkerRW writeWriteWorker)
	{
		if (writingURL == null)
		{
			throw new ArgumentNullException("writingURL");
		}
		if (writingURL2 == null)
		{
			throw new ArgumentNullException("writingURL2");
		}
		if (writeWriteWorker == null)
		{
			throw new ArgumentNullException("writeWriteWorker");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFileCoordinatorWorkerRW.Handler, writeWriteWorker);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr(base.Handle, selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_Handle, writingURL.Handle, (ulong)writingOptions, writingURL2.Handle, (ulong)writingOptions2, ref arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr(base.SuperHandle, selCoordinateWritingItemAtURL_Options_WritingItemAtURL_Options_Error_ByAccessor_Handle, writingURL.Handle, (ulong)writingOptions, writingURL2.Handle, (ulong)writingOptions2, ref arg, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("itemAtURL:didMoveToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemMoved(NSUrl fromUrl, NSUrl toUrl)
	{
		if (fromUrl == null)
		{
			throw new ArgumentNullException("fromUrl");
		}
		if (toUrl == null)
		{
			throw new ArgumentNullException("toUrl");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selItemAtURL_DidMoveToURL_Handle, fromUrl.Handle, toUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selItemAtURL_DidMoveToURL_Handle, fromUrl.Handle, toUrl.Handle);
		}
	}

	[Export("itemAtURL:didChangeUbiquityAttributes:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ItemUbiquityAttributesChanged(NSUrl url, NSSet<NSString> attributes)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selItemAtURL_DidChangeUbiquityAttributes_Handle, url.Handle, attributes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selItemAtURL_DidChangeUbiquityAttributes_Handle, url.Handle, attributes.Handle);
		}
	}

	[Export("removeFilePresenter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveFilePresenter(INSFilePresenter filePresenter)
	{
		if (filePresenter != null)
		{
			if (!(filePresenter is NSObject))
			{
				throw new ArgumentException("The object passed of type " + filePresenter.GetType()?.ToString() + " does not derive from NSObject");
			}
			Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveFilePresenter_Handle, filePresenter.Handle);
			return;
		}
		throw new ArgumentNullException("filePresenter");
	}

	[Export("itemAtURL:willMoveToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillMove(NSUrl oldUrl, NSUrl newUrl)
	{
		if (oldUrl == null)
		{
			throw new ArgumentNullException("oldUrl");
		}
		if (newUrl == null)
		{
			throw new ArgumentNullException("newUrl");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selItemAtURL_WillMoveToURL_Handle, oldUrl.Handle, newUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selItemAtURL_WillMoveToURL_Handle, oldUrl.Handle, newUrl.Handle);
		}
	}
}
