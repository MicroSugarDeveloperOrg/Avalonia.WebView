using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLSharedEventListener", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
public class MTLSharedEventListener : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDispatchQueue = "dispatchQueue";

	private static readonly IntPtr selDispatchQueueHandle = Selector.GetHandle("dispatchQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDispatchQueue_ = "initWithDispatchQueue:";

	private static readonly IntPtr selInitWithDispatchQueue_Handle = Selector.GetHandle("initWithDispatchQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLSharedEventListener");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue DispatchQueue
	{
		[Export("dispatchQueue")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDispatchQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDispatchQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLSharedEventListener()
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
	protected MTLSharedEventListener(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLSharedEventListener(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDispatchQueue:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLSharedEventListener(DispatchQueue dispatchQueue)
		: base(NSObjectFlag.Empty)
	{
		if (dispatchQueue == null)
		{
			throw new ArgumentNullException("dispatchQueue");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDispatchQueue_Handle, dispatchQueue.Handle), "initWithDispatchQueue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDispatchQueue_Handle, dispatchQueue.Handle), "initWithDispatchQueue:");
		}
	}
}
