using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemMetadataCollector", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
public class AVPlayerItemMetadataCollector : AVPlayerItemMediaDataCollector
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegateQueue = "delegateQueue";

	private static readonly IntPtr selDelegateQueueHandle = Selector.GetHandle("delegateQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifiers_ClassifyingLabels_ = "initWithIdentifiers:classifyingLabels:";

	private static readonly IntPtr selInitWithIdentifiers_ClassifyingLabels_Handle = Selector.GetHandle("initWithIdentifiers:classifyingLabels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_Queue_ = "setDelegate:queue:";

	private static readonly IntPtr selSetDelegate_Queue_Handle = Selector.GetHandle("setDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItemMetadataCollector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVPlayerItemMetadataCollectorPushDelegate? Delegate => WeakDelegate as IAVPlayerItemMetadataCollectorPushDelegate;

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
	protected AVPlayerItemMetadataCollector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemMetadataCollector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifiers:classifyingLabels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerItemMetadataCollector(string[]? identifiers, string[]? classifyingLabels)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((identifiers == null) ? null : NSArray.FromStrings(identifiers));
		NSArray nSArray2 = ((classifyingLabels == null) ? null : NSArray.FromStrings(classifyingLabels));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithIdentifiers_ClassifyingLabels_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithIdentifiers:classifyingLabels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifiers_ClassifyingLabels_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero), "initWithIdentifiers:classifyingLabels:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
	}

	[Export("setDelegate:queue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDelegate(IAVPlayerItemMetadataCollectorPushDelegate? pushDelegate, DispatchQueue? delegateQueue)
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
