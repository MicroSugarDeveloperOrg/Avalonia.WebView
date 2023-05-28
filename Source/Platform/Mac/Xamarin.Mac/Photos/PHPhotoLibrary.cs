using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHPhotoLibrary", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHPhotoLibrary : NSObject
{
	private class __phlib_observer : PHPhotoLibraryChangeObserver
	{
		private Action<PHChange> observer;

		public __phlib_observer(Action<PHChange> observer)
		{
			this.observer = observer;
		}

		public override void PhotoLibraryDidChange(PHChange changeInstance)
		{
			observer(changeInstance);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthorizationStatus = "authorizationStatus";

	private static readonly IntPtr selAuthorizationStatusHandle = Selector.GetHandle("authorizationStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformChanges_CompletionHandler_ = "performChanges:completionHandler:";

	private static readonly IntPtr selPerformChanges_CompletionHandler_Handle = Selector.GetHandle("performChanges:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformChangesAndWait_Error_ = "performChangesAndWait:error:";

	private static readonly IntPtr selPerformChangesAndWait_Error_Handle = Selector.GetHandle("performChangesAndWait:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterAvailabilityObserver_ = "registerAvailabilityObserver:";

	private static readonly IntPtr selRegisterAvailabilityObserver_Handle = Selector.GetHandle("registerAvailabilityObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterChangeObserver_ = "registerChangeObserver:";

	private static readonly IntPtr selRegisterChangeObserver_Handle = Selector.GetHandle("registerChangeObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAuthorization_ = "requestAuthorization:";

	private static readonly IntPtr selRequestAuthorization_Handle = Selector.GetHandle("requestAuthorization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedPhotoLibrary = "sharedPhotoLibrary";

	private static readonly IntPtr selSharedPhotoLibraryHandle = Selector.GetHandle("sharedPhotoLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnavailabilityReason = "unavailabilityReason";

	private static readonly IntPtr selUnavailabilityReasonHandle = Selector.GetHandle("unavailabilityReason");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterAvailabilityObserver_ = "unregisterAvailabilityObserver:";

	private static readonly IntPtr selUnregisterAvailabilityObserver_Handle = Selector.GetHandle("unregisterAvailabilityObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterChangeObserver_ = "unregisterChangeObserver:";

	private static readonly IntPtr selUnregisterChangeObserver_Handle = Selector.GetHandle("unregisterChangeObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHPhotoLibrary");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAuthorizationStatus AuthorizationStatus
	{
		[Export("authorizationStatus")]
		get
		{
			return (PHAuthorizationStatus)Messaging.Int64_objc_msgSend(class_ptr, selAuthorizationStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHPhotoLibrary SharedPhotoLibrary
	{
		[Export("sharedPhotoLibrary")]
		get
		{
			return Runtime.GetNSObject<PHPhotoLibrary>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedPhotoLibraryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual NSError? UnavailabilityReason
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("unavailabilityReason", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selUnavailabilityReasonHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUnavailabilityReasonHandle));
		}
	}

	public object RegisterChangeObserver(Action<PHChange> changeObserver)
	{
		__phlib_observer _phlib_observer = new __phlib_observer(changeObserver);
		RegisterChangeObserver(_phlib_observer);
		return _phlib_observer;
	}

	public void UnregisterChangeObserver(object registeredToken)
	{
		if (!(registeredToken is __phlib_observer))
		{
			throw new ArgumentException("registeredToken should be a value returned by RegisterChangeObserver(PHChange)");
		}
		UnregisterChangeObserver(registeredToken as __phlib_observer);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHPhotoLibrary(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHPhotoLibrary(IntPtr handle)
		: base(handle)
	{
	}

	[Export("performChanges:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformChanges([BlockProxy(typeof(Trampolines.NIDAction))] Action changeHandler, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> completionHandler)
	{
		if (changeHandler == null)
		{
			throw new ArgumentNullException("changeHandler");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, changeHandler);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr2 = &blockLiteral2;
		blockLiteral2.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPerformChanges_CompletionHandler_Handle, (IntPtr)ptr, (IntPtr)ptr2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPerformChanges_CompletionHandler_Handle, (IntPtr)ptr, (IntPtr)ptr2);
		}
		ptr->CleanupBlock();
		ptr2->CleanupBlock();
	}

	[Export("performChangesAndWait:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual bool PerformChangesAndWait([BlockProxy(typeof(Trampolines.NIDAction))] Action changeHandler, out NSError error)
	{
		if (changeHandler == null)
		{
			throw new ArgumentNullException("changeHandler");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, changeHandler);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPerformChangesAndWait_Error_Handle, (IntPtr)ptr, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPerformChangesAndWait_Error_Handle, (IntPtr)ptr, ref arg));
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("registerAvailabilityObserver:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Register(IPHPhotoLibraryAvailabilityObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterAvailabilityObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterAvailabilityObserver_Handle, observer.Handle);
		}
	}

	[Export("registerChangeObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterChangeObserver(IPHPhotoLibraryChangeObserver observer)
	{
		if (observer != null)
		{
			if (!(observer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + observer.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterChangeObserver_Handle, observer.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterChangeObserver_Handle, observer.Handle);
			}
			return;
		}
		throw new ArgumentNullException("observer");
	}

	[Export("requestAuthorization:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RequestAuthorization([BlockProxy(typeof(Trampolines.NIDActionArity1V71))] Action<PHAuthorizationStatus> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V71.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRequestAuthorization_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<PHAuthorizationStatus> RequestAuthorizationAsync()
	{
		TaskCompletionSource<PHAuthorizationStatus> tcs = new TaskCompletionSource<PHAuthorizationStatus>();
		RequestAuthorization(delegate(PHAuthorizationStatus obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("unregisterAvailabilityObserver:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unregister(IPHPhotoLibraryAvailabilityObserver observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnregisterAvailabilityObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnregisterAvailabilityObserver_Handle, observer.Handle);
		}
	}

	[Export("unregisterChangeObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnregisterChangeObserver(IPHPhotoLibraryChangeObserver observer)
	{
		if (observer != null)
		{
			if (!(observer is NSObject))
			{
				throw new ArgumentException("The object passed of type " + observer.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnregisterChangeObserver_Handle, observer.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnregisterChangeObserver_Handle, observer.Handle);
			}
			return;
		}
		throw new ArgumentNullException("observer");
	}
}
