using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKLocalSearch", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKLocalSearch : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_ = "initWithRequest:";

	private static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle("initWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSearching = "isSearching";

	private static readonly IntPtr selIsSearchingHandle = Selector.GetHandle("isSearching");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartWithCompletionHandler_ = "startWithCompletionHandler:";

	private static readonly IntPtr selStartWithCompletionHandler_Handle = Selector.GetHandle("startWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKLocalSearch");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSearching
	{
		[Export("isSearching")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSearchingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSearchingHandle);
		}
	}

	public virtual Task<MKLocalSearchResponse> StartAsync(CancellationToken token)
	{
		TaskCompletionSource<MKLocalSearchResponse> tcs = new TaskCompletionSource<MKLocalSearchResponse>();
		if (token.IsCancellationRequested)
		{
			tcs.SetCanceled();
		}
		else
		{
			CancellationTokenRegistration tcr = token.Register(delegate
			{
				Cancel();
				tcs.TrySetCanceled();
			});
			Start(delegate(MKLocalSearchResponse response, NSError error)
			{
				tcr.Dispose();
				if (token.IsCancellationRequested)
				{
					tcs.TrySetCanceled();
				}
				else if (error != null)
				{
					tcs.SetException(new NSErrorException(error));
				}
				else
				{
					tcs.SetResult(response);
				}
			});
		}
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKLocalSearch(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKLocalSearch(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKLocalSearch(MKLocalSearchRequest request)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRequest_Handle, request.Handle), "initWithRequest:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRequest_Handle, request.Handle), "initWithRequest:");
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
	public unsafe virtual void Start([BlockProxy(typeof(Trampolines.NIDMKLocalSearchCompletionHandler))] MKLocalSearchCompletionHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMKLocalSearchCompletionHandler.Handler, completionHandler);
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
	public virtual Task<MKLocalSearchResponse> StartAsync()
	{
		TaskCompletionSource<MKLocalSearchResponse> tcs = new TaskCompletionSource<MKLocalSearchResponse>();
		Start(delegate(MKLocalSearchResponse response_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(response_);
			}
		});
		return tcs.Task;
	}
}
