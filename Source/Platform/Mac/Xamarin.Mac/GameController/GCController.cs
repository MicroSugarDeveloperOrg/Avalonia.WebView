using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameController;

[Register("GCController", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GCController : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidConnect(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidConnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidConnect(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidConnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidDisconnect(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidDisconnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidDisconnect(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidDisconnectNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	public const int PlayerIndexUnset = -1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapture = "capture";

	private static readonly IntPtr selCaptureHandle = Selector.GetHandle("capture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControllerPausedHandler = "controllerPausedHandler";

	private static readonly IntPtr selControllerPausedHandlerHandle = Selector.GetHandle("controllerPausedHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControllerWithExtendedGamepad = "controllerWithExtendedGamepad";

	private static readonly IntPtr selControllerWithExtendedGamepadHandle = Selector.GetHandle("controllerWithExtendedGamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControllerWithMicroGamepad = "controllerWithMicroGamepad";

	private static readonly IntPtr selControllerWithMicroGamepadHandle = Selector.GetHandle("controllerWithMicroGamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControllers = "controllers";

	private static readonly IntPtr selControllersHandle = Selector.GetHandle("controllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedGamepad = "extendedGamepad";

	private static readonly IntPtr selExtendedGamepadHandle = Selector.GetHandle("extendedGamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGamepad = "gamepad";

	private static readonly IntPtr selGamepadHandle = Selector.GetHandle("gamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandlerQueue = "handlerQueue";

	private static readonly IntPtr selHandlerQueueHandle = Selector.GetHandle("handlerQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAttachedToDevice = "isAttachedToDevice";

	private static readonly IntPtr selIsAttachedToDeviceHandle = Selector.GetHandle("isAttachedToDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSnapshot = "isSnapshot";

	private static readonly IntPtr selIsSnapshotHandle = Selector.GetHandle("isSnapshot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMicroGamepad = "microGamepad";

	private static readonly IntPtr selMicroGamepadHandle = Selector.GetHandle("microGamepad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMotion = "motion";

	private static readonly IntPtr selMotionHandle = Selector.GetHandle("motion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerIndex = "playerIndex";

	private static readonly IntPtr selPlayerIndexHandle = Selector.GetHandle("playerIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProductCategory = "productCategory";

	private static readonly IntPtr selProductCategoryHandle = Selector.GetHandle("productCategory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetControllerPausedHandler_ = "setControllerPausedHandler:";

	private static readonly IntPtr selSetControllerPausedHandler_Handle = Selector.GetHandle("setControllerPausedHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHandlerQueue_ = "setHandlerQueue:";

	private static readonly IntPtr selSetHandlerQueue_Handle = Selector.GetHandle("setHandlerQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayerIndex_ = "setPlayerIndex:";

	private static readonly IntPtr selSetPlayerIndex_Handle = Selector.GetHandle("setPlayerIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartWirelessControllerDiscoveryWithCompletionHandler_ = "startWirelessControllerDiscoveryWithCompletionHandler:";

	private static readonly IntPtr selStartWirelessControllerDiscoveryWithCompletionHandler_Handle = Selector.GetHandle("startWirelessControllerDiscoveryWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopWirelessControllerDiscovery = "stopWirelessControllerDiscovery";

	private static readonly IntPtr selStopWirelessControllerDiscoveryHandle = Selector.GetHandle("stopWirelessControllerDiscovery");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVendorName = "vendorName";

	private static readonly IntPtr selVendorNameHandle = Selector.GetHandle("vendorName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GCController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidConnectNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidDisconnectNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AttachedToDevice
	{
		[Export("isAttachedToDevice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAttachedToDeviceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAttachedToDeviceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
	public unsafe virtual Action<GCController>? ControllerPausedHandler
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
		[Export("controllerPausedHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity1V42))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selControllerPausedHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selControllerPausedHandlerHandle));
			return Trampolines.NIDActionArity1V42.Create(block);
		}
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use the Menu button found on the controller's profile, if it exists.")]
		[Export("setControllerPausedHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity1V42))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V42.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetControllerPausedHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetControllerPausedHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GCController[] Controllers
	{
		[Export("controllers")]
		get
		{
			return NSArray.ArrayFromHandle<GCController>(Messaging.IntPtr_objc_msgSend(class_ptr, selControllersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCExtendedGamepad? ExtendedGamepad
	{
		[Export("extendedGamepad", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCExtendedGamepad>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedGamepadHandle));
			}
			return Runtime.GetNSObject<GCExtendedGamepad>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedGamepadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, null)]
	public virtual GCGamepad? Gamepad
	{
		[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, null)]
		[Export("gamepad", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCGamepad>(Messaging.IntPtr_objc_msgSend(base.Handle, selGamepadHandle));
			}
			return Runtime.GetNSObject<GCGamepad>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGamepadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual DispatchQueue HandlerQueue
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("handlerQueue", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHandlerQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selHandlerQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setHandlerQueue:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHandlerQueue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHandlerQueue_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual GCMicroGamepad? MicroGamepad
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("microGamepad", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCMicroGamepad>(Messaging.IntPtr_objc_msgSend(base.Handle, selMicroGamepadHandle));
			}
			return Runtime.GetNSObject<GCMicroGamepad>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMicroGamepadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GCMotion? Motion
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("motion", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GCMotion>(Messaging.IntPtr_objc_msgSend(base.Handle, selMotionHandle));
			}
			return Runtime.GetNSObject<GCMotion>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMotionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PlayerIndex
	{
		[Export("playerIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPlayerIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPlayerIndexHandle);
		}
		[Export("setPlayerIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPlayerIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPlayerIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual string ProductCategory
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("productCategory")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProductCategoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProductCategoryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool Snapshot
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isSnapshot")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSnapshotHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSnapshotHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? VendorName
	{
		[Export("vendorName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVendorNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVendorNameHandle));
		}
	}

	[Field("GCControllerDidConnectNotification", "GameController")]
	[Advice("Use GCController.Notifications.ObserveDidConnect helper method instead.")]
	public static NSString DidConnectNotification
	{
		get
		{
			if (_DidConnectNotification == null)
			{
				_DidConnectNotification = Dlfcn.GetStringConstant(Libraries.GameController.Handle, "GCControllerDidConnectNotification");
			}
			return _DidConnectNotification;
		}
	}

	[Field("GCControllerDidDisconnectNotification", "GameController")]
	[Advice("Use GCController.Notifications.ObserveDidDisconnect helper method instead.")]
	public static NSString DidDisconnectNotification
	{
		get
		{
			if (_DidDisconnectNotification == null)
			{
				_DidDisconnectNotification = Dlfcn.GetStringConstant(Libraries.GameController.Handle, "GCControllerDidDisconnectNotification");
			}
			return _DidDisconnectNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GCController()
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
	protected GCController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GCController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("capture")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GCController Capture()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSend(base.Handle, selCaptureHandle));
		}
		return Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCaptureHandle));
	}

	[Export("controllerWithExtendedGamepad")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GCController GetExtendedGamepadController()
	{
		return Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSend(class_ptr, selControllerWithExtendedGamepadHandle));
	}

	[Export("controllerWithMicroGamepad")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GCController GetMicroGamepadController()
	{
		return Runtime.GetNSObject<GCController>(Messaging.IntPtr_objc_msgSend(class_ptr, selControllerWithMicroGamepadHandle));
	}

	[Export("startWirelessControllerDiscoveryWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void StartWirelessControllerDiscovery([BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selStartWirelessControllerDiscoveryWithCompletionHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task StartWirelessControllerDiscoveryAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StartWirelessControllerDiscovery(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("stopWirelessControllerDiscovery")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StopWirelessControllerDiscovery()
	{
		Messaging.void_objc_msgSend(class_ptr, selStopWirelessControllerDiscoveryHandle);
	}
}
