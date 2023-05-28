using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSAsynchronousFetchRequest", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSAsynchronousFetchRequest : NSPersistentStoreRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedResultCount = "estimatedResultCount";

	private static readonly IntPtr selEstimatedResultCountHandle = Selector.GetHandle("estimatedResultCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchRequest = "fetchRequest";

	private static readonly IntPtr selFetchRequestHandle = Selector.GetHandle("fetchRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFetchRequest_CompletionBlock_ = "initWithFetchRequest:completionBlock:";

	private static readonly IntPtr selInitWithFetchRequest_CompletionBlock_Handle = Selector.GetHandle("initWithFetchRequest:completionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEstimatedResultCount_ = "setEstimatedResultCount:";

	private static readonly IntPtr selSetEstimatedResultCount_Handle = Selector.GetHandle("setEstimatedResultCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAsynchronousFetchRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint EstimatedResultCount
	{
		[Export("estimatedResultCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selEstimatedResultCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selEstimatedResultCountHandle);
		}
		[Export("setEstimatedResultCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetEstimatedResultCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetEstimatedResultCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFetchRequest FetchRequest
	{
		[Export("fetchRequest", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRequestHandle));
			}
			return Runtime.GetNSObject<NSFetchRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAsynchronousFetchRequest()
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
	protected NSAsynchronousFetchRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAsynchronousFetchRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFetchRequest:completionBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSAsynchronousFetchRequest(NSFetchRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity1V22))] Action<NSAsynchronousFetchResult>? completion)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V22.Handler, completion);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithFetchRequest_CompletionBlock_Handle, request.Handle, (IntPtr)ptr), "initWithFetchRequest:completionBlock:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithFetchRequest_CompletionBlock_Handle, request.Handle, (IntPtr)ptr), "initWithFetchRequest:completionBlock:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}
