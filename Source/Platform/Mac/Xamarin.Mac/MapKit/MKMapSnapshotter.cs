using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKMapSnapshotter", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKMapSnapshotter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOptions_ = "initWithOptions:";

	private static readonly IntPtr selInitWithOptions_Handle = Selector.GetHandle("initWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoading = "isLoading";

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartWithCompletionHandler_ = "startWithCompletionHandler:";

	private static readonly IntPtr selStartWithCompletionHandler_Handle = Selector.GetHandle("startWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartWithQueue_CompletionHandler_ = "startWithQueue:completionHandler:";

	private static readonly IntPtr selStartWithQueue_CompletionHandler_Handle = Selector.GetHandle("startWithQueue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKMapSnapshotter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Loading
	{
		[Export("isLoading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MKMapSnapshotter()
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
	protected MKMapSnapshotter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKMapSnapshotter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithOptions:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKMapSnapshotter(MKMapSnapshotOptions options)
		: base(NSObjectFlag.Empty)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOptions_Handle, options.Handle), "initWithOptions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOptions_Handle, options.Handle), "initWithOptions:");
		}
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

	[Export("startWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Start([BlockProxy(typeof(Trampolines.NIDMKMapSnapshotCompletionHandler))] MKMapSnapshotCompletionHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMKMapSnapshotCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MKMapSnapshot> StartAsync()
	{
		TaskCompletionSource<MKMapSnapshot> tcs = new TaskCompletionSource<MKMapSnapshot>();
		Start(delegate(MKMapSnapshot snapshot_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(snapshot_);
			}
		});
		return tcs.Task;
	}

	[Export("startWithQueue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Start(DispatchQueue queue, [BlockProxy(typeof(Trampolines.NIDMKMapSnapshotCompletionHandler))] MKMapSnapshotCompletionHandler completionHandler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMKMapSnapshotCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartWithQueue_CompletionHandler_Handle, queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartWithQueue_CompletionHandler_Handle, queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MKMapSnapshot> StartAsync(DispatchQueue queue)
	{
		TaskCompletionSource<MKMapSnapshot> tcs = new TaskCompletionSource<MKMapSnapshot>();
		Start(queue, delegate(MKMapSnapshot snapshot_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(snapshot_);
			}
		});
		return tcs.Task;
	}
}
