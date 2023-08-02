using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileCoordinator", true)]
public class NSFileCoordinator : NSObject
{
	private static readonly IntPtr selFilePresentersHandle = Selector.GetHandle("filePresenters");

	private static readonly IntPtr selAddFilePresenter_Handle = Selector.GetHandle("addFilePresenter:");

	private static readonly IntPtr selRemoveFilePresenter_Handle = Selector.GetHandle("removeFilePresenter:");

	private static readonly IntPtr selInitWithFilePresenter_Handle = Selector.GetHandle("initWithFilePresenter:");

	private static readonly IntPtr selCoordinateReadingItemAtURLOptionsErrorByAccessor_Handle = Selector.GetHandle("coordinateReadingItemAtURL:options:error:byAccessor:");

	private static readonly IntPtr selCoordinateWritingItemAtURLOptionsErrorByAccessor_Handle = Selector.GetHandle("coordinateWritingItemAtURL:options:error:byAccessor:");

	private static readonly IntPtr selCoordinateReadingItemAtURLOptionsWritingItemAtURLOptionsErrorByAccessor_Handle = Selector.GetHandle("coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:");

	private static readonly IntPtr selCoordinateWritingItemAtURLOptionsWritingItemAtURLOptionsErrorByAccessor_Handle = Selector.GetHandle("coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:");

	private static readonly IntPtr selPrepareForReadingItemsAtURLsOptionsWritingItemsAtURLsOptionsErrorByAccessor_Handle = Selector.GetHandle("prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:");

	private static readonly IntPtr selItemAtURLDidMoveToURL_Handle = Selector.GetHandle("itemAtURL:didMoveToURL:");

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	private static readonly IntPtr selItemAtURLWillMoveToURL_Handle = Selector.GetHandle("itemAtURL:willMoveToURL:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFileCoordinator");

	private static object __mt_FilePresenters_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSFilePresenter[] FilePresenters
	{
		[Export("filePresenters")]
		get
		{
			return (NSFilePresenter[])(__mt_FilePresenters_var_static = NSArray.ArrayFromHandle<NSFilePresenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selFilePresentersHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileCoordinator()
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
	public NSFileCoordinator(NSCoder coder)
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
	public NSFileCoordinator(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileCoordinator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addFilePresenter:")]
	public static void AddFilePresenter(NSFilePresenter filePresenter)
	{
		if (filePresenter == null)
		{
			throw new ArgumentNullException("filePresenter");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selAddFilePresenter_Handle, filePresenter.Handle);
		_ = FilePresenters;
	}

	[Export("removeFilePresenter:")]
	public static void RemoveFilePresenter(NSFilePresenter filePresenter)
	{
		if (filePresenter == null)
		{
			throw new ArgumentNullException("filePresenter");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveFilePresenter_Handle, filePresenter.Handle);
		_ = FilePresenters;
	}

	[Export("initWithFilePresenter:")]
	public NSFileCoordinator(NSFilePresenter filePresenterOrNil)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFilePresenter_Handle, filePresenterOrNil?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFilePresenter_Handle, filePresenterOrNil?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("coordinateReadingItemAtURL:options:error:byAccessor:")]
	public unsafe virtual void CoordinateRead(NSUrl itemUrl, NSFileCoordinatorReadingOptions options, out NSError error, NSFileCoordinatorWorker worker)
	{
		if (itemUrl == null)
		{
			throw new ArgumentNullException("itemUrl");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (worker == null)
		{
			throw new ArgumentNullException("worker");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSFileCoordinatorWorker.Handler, worker);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selCoordinateReadingItemAtURLOptionsErrorByAccessor_Handle, itemUrl.Handle, (ulong)options, intPtr, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selCoordinateReadingItemAtURLOptionsErrorByAccessor_Handle, itemUrl.Handle, (ulong)options, intPtr, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("coordinateWritingItemAtURL:options:error:byAccessor:")]
	public unsafe virtual void CoordinateWrite(NSUrl url, NSFileCoordinatorWritingOptions options, out NSError error, NSFileCoordinatorWorker worker)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (worker == null)
		{
			throw new ArgumentNullException("worker");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSFileCoordinatorWorker.Handler, worker);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selCoordinateWritingItemAtURLOptionsErrorByAccessor_Handle, url.Handle, (ulong)options, intPtr, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selCoordinateWritingItemAtURLOptionsErrorByAccessor_Handle, url.Handle, (ulong)options, intPtr, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("coordinateReadingItemAtURL:options:writingItemAtURL:options:error:byAccessor:")]
	public unsafe virtual void CoordinateReadWrite(NSUrl readingURL, NSFileCoordinatorReadingOptions readingOptions, NSUrl writingURL, NSFileCoordinatorWritingOptions writingOptions, out NSError error, NSFileCoordinatorWorkerRW readWriteWorker)
	{
		if (readingURL == null)
		{
			throw new ArgumentNullException("readingURL");
		}
		if (writingURL == null)
		{
			throw new ArgumentNullException("writingURL");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (readWriteWorker == null)
		{
			throw new ArgumentNullException("readWriteWorker");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSFileCoordinatorWorkerRW.Handler, readWriteWorker);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selCoordinateReadingItemAtURLOptionsWritingItemAtURLOptionsErrorByAccessor_Handle, readingURL.Handle, (ulong)readingOptions, writingURL.Handle, (ulong)writingOptions, intPtr, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selCoordinateReadingItemAtURLOptionsWritingItemAtURLOptionsErrorByAccessor_Handle, readingURL.Handle, (ulong)readingOptions, writingURL.Handle, (ulong)writingOptions, intPtr, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("coordinateWritingItemAtURL:options:writingItemAtURL:options:error:byAccessor:")]
	public unsafe virtual void CoordinateWriteWrite(NSUrl writingURL, NSFileCoordinatorWritingOptions writingOptions, NSUrl writingURL2, NSFileCoordinatorWritingOptions writingOptions2, out NSError error, NSFileCoordinatorWorkerRW writeWriteWorker)
	{
		if (writingURL == null)
		{
			throw new ArgumentNullException("writingURL");
		}
		if (writingURL2 == null)
		{
			throw new ArgumentNullException("writingURL2");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (writeWriteWorker == null)
		{
			throw new ArgumentNullException("writeWriteWorker");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSFileCoordinatorWorkerRW.Handler, writeWriteWorker);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selCoordinateWritingItemAtURLOptionsWritingItemAtURLOptionsErrorByAccessor_Handle, writingURL.Handle, (ulong)writingOptions, writingURL2.Handle, (ulong)writingOptions2, intPtr, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selCoordinateWritingItemAtURLOptionsWritingItemAtURLOptionsErrorByAccessor_Handle, writingURL.Handle, (ulong)writingOptions, writingURL2.Handle, (ulong)writingOptions2, intPtr, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("prepareForReadingItemsAtURLs:options:writingItemsAtURLs:options:error:byAccessor:")]
	public unsafe virtual void CoordinateBatc(NSUrl[] readingURLs, NSFileCoordinatorReadingOptions readingOptions, NSUrl[] writingURLs, NSFileCoordinatorWritingOptions writingOptions, out NSError error, NSAction batchHandler)
	{
		if (readingURLs == null)
		{
			throw new ArgumentNullException("readingURLs");
		}
		if (writingURLs == null)
		{
			throw new ArgumentNullException("writingURLs");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (batchHandler == null)
		{
			throw new ArgumentNullException("batchHandler");
		}
		NSArray nSArray = NSArray.FromNSObjects(readingURLs);
		NSArray nSArray2 = NSArray.FromNSObjects(writingURLs);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, batchHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selPrepareForReadingItemsAtURLsOptionsWritingItemsAtURLsOptionsErrorByAccessor_Handle, nSArray.Handle, (ulong)readingOptions, nSArray2.Handle, (ulong)writingOptions, intPtr, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selPrepareForReadingItemsAtURLsOptionsWritingItemsAtURLsOptionsErrorByAccessor_Handle, nSArray.Handle, (ulong)readingOptions, nSArray2.Handle, (ulong)writingOptions, intPtr, (IntPtr)ptr);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		ptr->CleanupBlock();
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("itemAtURL:didMoveToURL:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selItemAtURLDidMoveToURL_Handle, fromUrl.Handle, toUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selItemAtURLDidMoveToURL_Handle, fromUrl.Handle, toUrl.Handle);
		}
	}

	[Export("cancel")]
	public virtual void Cancel()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("itemAtURL:willMoveToURL:")]
	[MountainLion]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selItemAtURLWillMoveToURL_Handle, oldUrl.Handle, newUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selItemAtURLWillMoveToURL_Handle, oldUrl.Handle, newUrl.Handle);
		}
	}
}
