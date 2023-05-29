using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKDeviceBrowserView", true)]
public class IKDeviceBrowserView : NSView
{
	[Register]
	private sealed class _IKDeviceBrowserViewDelegate : IKDeviceBrowserViewDelegate
	{
		internal EventHandler<IKDeviceBrowserViewNSErrorEventArgs> didEncounterError;

		[Preserve(Conditional = true)]
		public override void DidEncounterError(IKDeviceBrowserView deviceBrowserView, NSError error)
		{
			EventHandler<IKDeviceBrowserViewNSErrorEventArgs> eventHandler = didEncounterError;
			if (eventHandler != null)
			{
				IKDeviceBrowserViewNSErrorEventArgs e = new IKDeviceBrowserViewNSErrorEventArgs(error);
				eventHandler(deviceBrowserView, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selDisplaysLocalCamerasHandle = Selector.GetHandle("displaysLocalCameras");

	private static readonly IntPtr selSetDisplaysLocalCameras_Handle = Selector.GetHandle("setDisplaysLocalCameras:");

	private static readonly IntPtr selDisplaysNetworkCamerasHandle = Selector.GetHandle("displaysNetworkCameras");

	private static readonly IntPtr selSetDisplaysNetworkCameras_Handle = Selector.GetHandle("setDisplaysNetworkCameras:");

	private static readonly IntPtr selDisplaysLocalScannersHandle = Selector.GetHandle("displaysLocalScanners");

	private static readonly IntPtr selSetDisplaysLocalScanners_Handle = Selector.GetHandle("setDisplaysLocalScanners:");

	private static readonly IntPtr selDisplaysNetworkScannersHandle = Selector.GetHandle("displaysNetworkScanners");

	private static readonly IntPtr selSetDisplaysNetworkScanners_Handle = Selector.GetHandle("setDisplaysNetworkScanners:");

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKDeviceBrowserView");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public IKDeviceBrowserViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IKDeviceBrowserViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool DisplaysLocalCameras
	{
		[Export("displaysLocalCameras")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysLocalCamerasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysLocalCamerasHandle);
		}
		[Export("setDisplaysLocalCameras:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysLocalCameras_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysLocalCameras_Handle, value);
			}
		}
	}

	public virtual bool DisplaysNetworkCameras
	{
		[Export("displaysNetworkCameras")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysNetworkCamerasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysNetworkCamerasHandle);
		}
		[Export("setDisplaysNetworkCameras:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysNetworkCameras_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysNetworkCameras_Handle, value);
			}
		}
	}

	public virtual bool DisplaysLocalScanners
	{
		[Export("displaysLocalScanners")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysLocalScannersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysLocalScannersHandle);
		}
		[Export("setDisplaysLocalScanners:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysLocalScanners_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysLocalScanners_Handle, value);
			}
		}
	}

	public virtual bool DisplaysNetworkScanners
	{
		[Export("displaysNetworkScanners")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysNetworkScannersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysNetworkScannersHandle);
		}
		[Export("setDisplaysNetworkScanners:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysNetworkScanners_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysNetworkScanners_Handle, value);
			}
		}
	}

	public virtual IKDeviceBrowserViewDisplayMode Mode
	{
		[Export("mode")]
		get
		{
			if (IsDirectBinding)
			{
				return (IKDeviceBrowserViewDisplayMode)Messaging.int_objc_msgSend(base.Handle, selModeHandle);
			}
			return (IKDeviceBrowserViewDisplayMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetMode_Handle, (int)value);
			}
		}
	}

	public event EventHandler<IKDeviceBrowserViewNSErrorEventArgs> DidEncounterError
	{
		add
		{
			_IKDeviceBrowserViewDelegate iKDeviceBrowserViewDelegate = EnsureIKDeviceBrowserViewDelegate();
			iKDeviceBrowserViewDelegate.didEncounterError = (EventHandler<IKDeviceBrowserViewNSErrorEventArgs>)System.Delegate.Combine(iKDeviceBrowserViewDelegate.didEncounterError, value);
		}
		remove
		{
			_IKDeviceBrowserViewDelegate iKDeviceBrowserViewDelegate = EnsureIKDeviceBrowserViewDelegate();
			iKDeviceBrowserViewDelegate.didEncounterError = (EventHandler<IKDeviceBrowserViewNSErrorEventArgs>)System.Delegate.Remove(iKDeviceBrowserViewDelegate.didEncounterError, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKDeviceBrowserView()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKDeviceBrowserView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKDeviceBrowserView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKDeviceBrowserView(IntPtr handle)
		: base(handle)
	{
	}

	private _IKDeviceBrowserViewDelegate EnsureIKDeviceBrowserViewDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _IKDeviceBrowserViewDelegate))
		{
			nSObject = (WeakDelegate = new _IKDeviceBrowserViewDelegate());
		}
		return (_IKDeviceBrowserViewDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
