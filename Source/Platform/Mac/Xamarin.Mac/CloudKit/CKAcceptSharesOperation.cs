using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKAcceptSharesOperation", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class CKAcceptSharesOperation : CKOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptSharesCompletionBlock = "acceptSharesCompletionBlock";

	private static readonly IntPtr selAcceptSharesCompletionBlockHandle = Selector.GetHandle("acceptSharesCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithShareMetadatas_ = "initWithShareMetadatas:";

	private static readonly IntPtr selInitWithShareMetadatas_Handle = Selector.GetHandle("initWithShareMetadatas:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerShareCompletionBlock = "perShareCompletionBlock";

	private static readonly IntPtr selPerShareCompletionBlockHandle = Selector.GetHandle("perShareCompletionBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceptSharesCompletionBlock_ = "setAcceptSharesCompletionBlock:";

	private static readonly IntPtr selSetAcceptSharesCompletionBlock_Handle = Selector.GetHandle("setAcceptSharesCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPerShareCompletionBlock_ = "setPerShareCompletionBlock:";

	private static readonly IntPtr selSetPerShareCompletionBlock_Handle = Selector.GetHandle("setPerShareCompletionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShareMetadatas_ = "setShareMetadatas:";

	private static readonly IntPtr selSetShareMetadatas_Handle = Selector.GetHandle("setShareMetadatas:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShareMetadatas = "shareMetadatas";

	private static readonly IntPtr selShareMetadatasHandle = Selector.GetHandle("shareMetadatas");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKAcceptSharesOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Action<NSError>? AcceptSharesCompleted
	{
		[Export("acceptSharesCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V11))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAcceptSharesCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAcceptSharesCompletionBlockHandle));
			return Trampolines.NIDActionArity1V11.Create(block);
		}
		[Export("setAcceptSharesCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V11))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAcceptSharesCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAcceptSharesCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual CKAcceptPerShareCompletionHandler? PerShareCompleted
	{
		[Export("perShareCompletionBlock", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDCKAcceptPerShareCompletionHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPerShareCompletionBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPerShareCompletionBlockHandle));
			return Trampolines.NIDCKAcceptPerShareCompletionHandler.Create(block);
		}
		[Export("setPerShareCompletionBlock:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDCKAcceptPerShareCompletionHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDCKAcceptPerShareCompletionHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPerShareCompletionBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPerShareCompletionBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CKShareMetadata[]? ShareMetadatas
	{
		[Export("shareMetadatas", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CKShareMetadata>(Messaging.IntPtr_objc_msgSend(base.Handle, selShareMetadatasHandle));
			}
			return NSArray.ArrayFromHandle<CKShareMetadata>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShareMetadatasHandle));
		}
		[Export("setShareMetadatas:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShareMetadatas_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShareMetadatas_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKAcceptSharesOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKAcceptSharesOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKAcceptSharesOperation()
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

	[Export("initWithShareMetadatas:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CKAcceptSharesOperation(CKShareMetadata[] shareMetadatas)
		: base(NSObjectFlag.Empty)
	{
		if (shareMetadatas == null)
		{
			throw new ArgumentNullException("shareMetadatas");
		}
		NSArray nSArray = NSArray.FromNSObjects(shareMetadatas);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithShareMetadatas_Handle, nSArray.Handle), "initWithShareMetadatas:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithShareMetadatas_Handle, nSArray.Handle), "initWithShareMetadatas:");
		}
		nSArray.Dispose();
	}
}
