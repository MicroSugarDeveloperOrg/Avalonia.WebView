using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemMetadataOutput", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayerItemMetadataOutput : AVPlayerItemOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdvanceIntervalForDelegateInvocation = "advanceIntervalForDelegateInvocation";

	private static readonly IntPtr selAdvanceIntervalForDelegateInvocationHandle = Selector.GetHandle("advanceIntervalForDelegateInvocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateQueue = "delegateQueue";

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifiers_ = "initWithIdentifiers:";

	private static readonly IntPtr selInitWithIdentifiers_Handle = Selector.GetHandle("initWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAdvanceIntervalForDelegateInvocation_ = "setAdvanceIntervalForDelegateInvocation:";

	private static readonly IntPtr selSetAdvanceIntervalForDelegateInvocation_Handle = Selector.GetHandle("setAdvanceIntervalForDelegateInvocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_Queue_ = "setDelegate:queue:";

	private static readonly IntPtr selSetDelegate_Queue_Handle = Selector.GetHandle("setDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItemMetadataOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double AdvanceIntervalForDelegateInvocation
	{
		[Export("advanceIntervalForDelegateInvocation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAdvanceIntervalForDelegateInvocationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAdvanceIntervalForDelegateInvocationHandle);
		}
		[Export("setAdvanceIntervalForDelegateInvocation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAdvanceIntervalForDelegateInvocation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAdvanceIntervalForDelegateInvocation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVPlayerItemMetadataOutputPushDelegate? Delegate => WeakDelegate as IAVPlayerItemMetadataOutputPushDelegate;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue? DelegateQueue
	{
		[Export("delegateQueue")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemMetadataOutput()
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
	protected AVPlayerItemMetadataOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemMetadataOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifiers:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItemMetadataOutput(NSString[]? metadataIdentifiers)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((metadataIdentifiers == null) ? null : NSArray.FromNSObjects(metadataIdentifiers));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifiers_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithIdentifiers:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifiers_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithIdentifiers:");
		}
		nSArray?.Dispose();
	}

	[Export("setDelegate:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDelegate(IAVPlayerItemMetadataOutputPushDelegate? pushDelegate, DispatchQueue? delegateQueue)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDelegate_Queue_Handle, pushDelegate?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDelegate_Queue_Handle, pushDelegate?.Handle ?? IntPtr.Zero, (delegateQueue == null) ? IntPtr.Zero : delegateQueue.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
