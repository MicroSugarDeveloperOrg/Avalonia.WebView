using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Register("MKDirections", true)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class MKDirections : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalculateDirectionsWithCompletionHandler_ = "calculateDirectionsWithCompletionHandler:";

	private static readonly IntPtr selCalculateDirectionsWithCompletionHandler_Handle = Selector.GetHandle("calculateDirectionsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalculateETAWithCompletionHandler_ = "calculateETAWithCompletionHandler:";

	private static readonly IntPtr selCalculateETAWithCompletionHandler_Handle = Selector.GetHandle("calculateETAWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRequest_ = "initWithRequest:";

	private static readonly IntPtr selInitWithRequest_Handle = Selector.GetHandle("initWithRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCalculating = "isCalculating";

	private static readonly IntPtr selIsCalculatingHandle = Selector.GetHandle("isCalculating");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MKDirections");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Calculating
	{
		[Export("isCalculating")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCalculatingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCalculatingHandle);
		}
	}

	[Obsolete("iOS9 does not allow creating an empty instance")]
	public MKDirections()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MKDirections(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MKDirections(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRequest:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MKDirections(MKDirectionsRequest request)
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

	[Export("calculateDirectionsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CalculateDirections([BlockProxy(typeof(Trampolines.NIDMKDirectionsHandler))] MKDirectionsHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMKDirectionsHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCalculateDirectionsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCalculateDirectionsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MKDirectionsResponse> CalculateDirectionsAsync()
	{
		TaskCompletionSource<MKDirectionsResponse> tcs = new TaskCompletionSource<MKDirectionsResponse>();
		CalculateDirections(delegate(MKDirectionsResponse response_, NSError error_)
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

	[Export("calculateETAWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CalculateETA([BlockProxy(typeof(Trampolines.NIDMKETAHandler))] MKETAHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMKETAHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCalculateETAWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCalculateETAWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MKETAResponse> CalculateETAAsync()
	{
		TaskCompletionSource<MKETAResponse> tcs = new TaskCompletionSource<MKETAResponse>();
		CalculateETA(delegate(MKETAResponse response_, NSError error_)
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
}
