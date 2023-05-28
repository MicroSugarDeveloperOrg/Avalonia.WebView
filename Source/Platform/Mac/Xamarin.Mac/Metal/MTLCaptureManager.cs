using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLCaptureManager", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class MTLCaptureManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCaptureScope = "defaultCaptureScope";

	private static readonly IntPtr selDefaultCaptureScopeHandle = Selector.GetHandle("defaultCaptureScope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCapturing = "isCapturing";

	private static readonly IntPtr selIsCapturingHandle = Selector.GetHandle("isCapturing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewCaptureScopeWithCommandQueue_ = "newCaptureScopeWithCommandQueue:";

	private static readonly IntPtr selNewCaptureScopeWithCommandQueue_Handle = Selector.GetHandle("newCaptureScopeWithCommandQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewCaptureScopeWithDevice_ = "newCaptureScopeWithDevice:";

	private static readonly IntPtr selNewCaptureScopeWithDevice_Handle = Selector.GetHandle("newCaptureScopeWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultCaptureScope_ = "setDefaultCaptureScope:";

	private static readonly IntPtr selSetDefaultCaptureScope_Handle = Selector.GetHandle("setDefaultCaptureScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedCaptureManager = "sharedCaptureManager";

	private static readonly IntPtr selSharedCaptureManagerHandle = Selector.GetHandle("sharedCaptureManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartCaptureWithCommandQueue_ = "startCaptureWithCommandQueue:";

	private static readonly IntPtr selStartCaptureWithCommandQueue_Handle = Selector.GetHandle("startCaptureWithCommandQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartCaptureWithDescriptor_Error_ = "startCaptureWithDescriptor:error:";

	private static readonly IntPtr selStartCaptureWithDescriptor_Error_Handle = Selector.GetHandle("startCaptureWithDescriptor:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartCaptureWithDevice_ = "startCaptureWithDevice:";

	private static readonly IntPtr selStartCaptureWithDevice_Handle = Selector.GetHandle("startCaptureWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartCaptureWithScope_ = "startCaptureWithScope:";

	private static readonly IntPtr selStartCaptureWithScope_Handle = Selector.GetHandle("startCaptureWithScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopCapture = "stopCapture";

	private static readonly IntPtr selStopCaptureHandle = Selector.GetHandle("stopCapture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsDestination_ = "supportsDestination:";

	private static readonly IntPtr selSupportsDestination_Handle = Selector.GetHandle("supportsDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLCaptureManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLCaptureScope? DefaultCaptureScope
	{
		[Export("defaultCaptureScope", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLCaptureScope>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultCaptureScopeHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLCaptureScope>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultCaptureScopeHandle), owns: false);
		}
		[Export("setDefaultCaptureScope:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultCaptureScope_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultCaptureScope_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCapturing
	{
		[Export("isCapturing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCapturingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCapturingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLCaptureManager Shared
	{
		[Export("sharedCaptureManager")]
		get
		{
			return Runtime.GetNSObject<MTLCaptureManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedCaptureManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTLCaptureManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLCaptureManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("newCaptureScopeWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual IMTLCaptureScope CreateNewCaptureScope(IMTLDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		IMTLCaptureScope iMTLCaptureScope = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLCaptureScope>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewCaptureScopeWithDevice_Handle, device.Handle), owns: false) : Runtime.GetINativeObject<IMTLCaptureScope>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewCaptureScopeWithDevice_Handle, device.Handle), owns: false));
		if (iMTLCaptureScope != null)
		{
			Messaging.void_objc_msgSend(iMTLCaptureScope.Handle, Selector.GetHandle("release"));
		}
		return iMTLCaptureScope;
	}

	[Export("newCaptureScopeWithCommandQueue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual IMTLCaptureScope CreateNewCaptureScope(IMTLCommandQueue commandQueue)
	{
		if (commandQueue == null)
		{
			throw new ArgumentNullException("commandQueue");
		}
		IMTLCaptureScope iMTLCaptureScope = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLCaptureScope>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewCaptureScopeWithCommandQueue_Handle, commandQueue.Handle), owns: false) : Runtime.GetINativeObject<IMTLCaptureScope>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNewCaptureScopeWithCommandQueue_Handle, commandQueue.Handle), owns: false));
		if (iMTLCaptureScope != null)
		{
			Messaging.void_objc_msgSend(iMTLCaptureScope.Handle, Selector.GetHandle("release"));
		}
		return iMTLCaptureScope;
	}

	[Export("startCaptureWithDevice:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartCapture(IMTLDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartCaptureWithDevice_Handle, device.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartCaptureWithDevice_Handle, device.Handle);
		}
	}

	[Export("startCaptureWithCommandQueue:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartCapture(IMTLCommandQueue commandQueue)
	{
		if (commandQueue == null)
		{
			throw new ArgumentNullException("commandQueue");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartCaptureWithCommandQueue_Handle, commandQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartCaptureWithCommandQueue_Handle, commandQueue.Handle);
		}
	}

	[Export("startCaptureWithScope:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'StartCapture (MTLCaptureDescriptor, NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartCapture(IMTLCaptureScope captureScope)
	{
		if (captureScope == null)
		{
			throw new ArgumentNullException("captureScope");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartCaptureWithScope_Handle, captureScope.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartCaptureWithScope_Handle, captureScope.Handle);
		}
	}

	[Export("startCaptureWithDescriptor:error:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartCapture(MTLCaptureDescriptor descriptor, out NSError? error)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selStartCaptureWithDescriptor_Error_Handle, descriptor.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selStartCaptureWithDescriptor_Error_Handle, descriptor.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("stopCapture")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopCapture()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopCaptureHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopCaptureHandle);
		}
	}

	[Export("supportsDestination:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsDestination(MTLCaptureDestination destination)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selSupportsDestination_Handle, (long)destination);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selSupportsDestination_Handle, (long)destination);
	}
}
