using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKFetchShareMetadataOperation", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKFetchShareMetadataOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchShareMetadataCompletionBlock = "fetchShareMetadataCompletionBlock";

	private static readonly IntPtr selFetchShareMetadataCompletionBlockHandle = Selector.GetHandle("fetchShareMetadataCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithShareURLs_ = "initWithShareURLs:";

	private static readonly IntPtr selInitWithShareURLs_Handle = Selector.GetHandle("initWithShareURLs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerShareMetadataBlock = "perShareMetadataBlock";

	private static readonly IntPtr selPerShareMetadataBlockHandle = Selector.GetHandle("perShareMetadataBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootRecordDesiredKeys = "rootRecordDesiredKeys";

	private static readonly IntPtr selRootRecordDesiredKeysHandle = Selector.GetHandle("rootRecordDesiredKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchShareMetadataCompletionBlock_ = "setFetchShareMetadataCompletionBlock:";

	private static readonly IntPtr selSetFetchShareMetadataCompletionBlock_Handle = Selector.GetHandle("setFetchShareMetadataCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerShareMetadataBlock_ = "setPerShareMetadataBlock:";

	private static readonly IntPtr selSetPerShareMetadataBlock_Handle = Selector.GetHandle("setPerShareMetadataBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRootRecordDesiredKeys_ = "setRootRecordDesiredKeys:";

	private static readonly IntPtr selSetRootRecordDesiredKeys_Handle = Selector.GetHandle("setRootRecordDesiredKeys:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShareURLs_ = "setShareURLs:";

	private static readonly IntPtr selSetShareURLs_Handle = Selector.GetHandle("setShareURLs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldFetchRootRecord_ = "setShouldFetchRootRecord:";

	private static readonly IntPtr selSetShouldFetchRootRecord_Handle = Selector.GetHandle("setShouldFetchRootRecord:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShareURLs = "shareURLs";

	private static readonly IntPtr selShareURLsHandle = Selector.GetHandle("shareURLs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldFetchRootRecord = "shouldFetchRootRecord";

	private static readonly IntPtr selShouldFetchRootRecordHandle = Selector.GetHandle("shouldFetchRootRecord");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKFetchShareMetadataOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<NSError>? FetchShareMetadataCompleted
	{
		[Export("fetchShareMetadataCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V11))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchShareMetadataCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFetchShareMetadataCompletionBlockHandle));
			return Trampolines.NIDActionArity1V11.Create(block);
		}
		[Export("setFetchShareMetadataCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V11))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchShareMetadataCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchShareMetadataCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKFetchPerShareMetadataHandler? PerShareMetadata
	{
		[Export("perShareMetadataBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKFetchPerShareMetadataHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerShareMetadataBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPerShareMetadataBlockHandle));
			return Trampolines.NIDCKFetchPerShareMetadataHandler.Create(block);
		}
		[Export("setPerShareMetadataBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKFetchPerShareMetadataHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKFetchPerShareMetadataHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPerShareMetadataBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPerShareMetadataBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? RootRecordDesiredKeys
	{
		[Export("rootRecordDesiredKeys", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRootRecordDesiredKeysHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootRecordDesiredKeysHandle));
		}
		[Export("setRootRecordDesiredKeys:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRootRecordDesiredKeys_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRootRecordDesiredKeys_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[]? ShareUrls
	{
		[Export("shareURLs", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selShareURLsHandle));
			}
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShareURLsHandle));
		}
		[Export("setShareURLs:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShareURLs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShareURLs_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldFetchRootRecord
	{
		[Export("shouldFetchRootRecord")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldFetchRootRecordHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldFetchRootRecordHandle);
		}
		[Export("setShouldFetchRootRecord:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldFetchRootRecord_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldFetchRootRecord_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKFetchShareMetadataOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKFetchShareMetadataOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchShareMetadataOperation()
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

	[Export("initWithShareURLs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKFetchShareMetadataOperation(NSUrl[] shareUrls)
		: base(NSObjectFlag.Empty)
	{
		if (shareUrls == null)
		{
			throw new ArgumentNullException("shareUrls");
		}
		NSArray nSArray = NSArray.FromNSObjects(shareUrls);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithShareURLs_Handle, nSArray.Handle), "initWithShareURLs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithShareURLs_Handle, nSArray.Handle), "initWithShareURLs:");
		}
		nSArray.Dispose();
	}
}
