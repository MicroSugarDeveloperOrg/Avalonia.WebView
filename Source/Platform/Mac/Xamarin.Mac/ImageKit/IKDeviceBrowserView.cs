using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Register("IKDeviceBrowserView", true)]
public class IKDeviceBrowserView : NSView
{
	[Register]
	internal class _IKDeviceBrowserViewDelegate : NSObject, IIKDeviceBrowserViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler<IKDeviceBrowserViewNSErrorEventArgs>? didEncounterError;

		internal EventHandler<IKDeviceBrowserViewICDeviceEventArgs>? selectionDidChange;

		public _IKDeviceBrowserViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("deviceBrowserView:didEncounterError:")]
		public void DidEncounterError(IKDeviceBrowserView deviceBrowserView, NSError error)
		{
			EventHandler<IKDeviceBrowserViewNSErrorEventArgs> eventHandler = didEncounterError;
			if (eventHandler != null)
			{
				IKDeviceBrowserViewNSErrorEventArgs e = new IKDeviceBrowserViewNSErrorEventArgs(error);
				eventHandler(deviceBrowserView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("deviceBrowserView:selectionDidChange:")]
		public void SelectionDidChange(IKDeviceBrowserView deviceBrowserView, ICDevice device)
		{
			EventHandler<IKDeviceBrowserViewICDeviceEventArgs> eventHandler = selectionDidChange;
			if (eventHandler != null)
			{
				IKDeviceBrowserViewICDeviceEventArgs e = new IKDeviceBrowserViewICDeviceEventArgs(device);
				eventHandler(deviceBrowserView, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysLocalCameras = "displaysLocalCameras";

	private static readonly IntPtr selDisplaysLocalCamerasHandle = Selector.GetHandle("displaysLocalCameras");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysLocalScanners = "displaysLocalScanners";

	private static readonly IntPtr selDisplaysLocalScannersHandle = Selector.GetHandle("displaysLocalScanners");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysNetworkCameras = "displaysNetworkCameras";

	private static readonly IntPtr selDisplaysNetworkCamerasHandle = Selector.GetHandle("displaysNetworkCameras");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysNetworkScanners = "displaysNetworkScanners";

	private static readonly IntPtr selDisplaysNetworkScannersHandle = Selector.GetHandle("displaysNetworkScanners");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedDevice = "selectedDevice";

	private static readonly IntPtr selSelectedDeviceHandle = Selector.GetHandle("selectedDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysLocalCameras_ = "setDisplaysLocalCameras:";

	private static readonly IntPtr selSetDisplaysLocalCameras_Handle = Selector.GetHandle("setDisplaysLocalCameras:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysLocalScanners_ = "setDisplaysLocalScanners:";

	private static readonly IntPtr selSetDisplaysLocalScanners_Handle = Selector.GetHandle("setDisplaysLocalScanners:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysNetworkCameras_ = "setDisplaysNetworkCameras:";

	private static readonly IntPtr selSetDisplaysNetworkCameras_Handle = Selector.GetHandle("setDisplaysNetworkCameras:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysNetworkScanners_ = "setDisplaysNetworkScanners:";

	private static readonly IntPtr selSetDisplaysNetworkScanners_Handle = Selector.GetHandle("setDisplaysNetworkScanners:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKDeviceBrowserView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IIKDeviceBrowserViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IIKDeviceBrowserViewDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysLocalCameras
	{
		[Export("displaysLocalCameras")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysLocalCamerasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysLocalCamerasHandle);
		}
		[Export("setDisplaysLocalCameras:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysLocalCameras_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysLocalCameras_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysLocalScanners
	{
		[Export("displaysLocalScanners")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysLocalScannersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysLocalScannersHandle);
		}
		[Export("setDisplaysLocalScanners:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysLocalScanners_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysLocalScanners_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysNetworkCameras
	{
		[Export("displaysNetworkCameras")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysNetworkCamerasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysNetworkCamerasHandle);
		}
		[Export("setDisplaysNetworkCameras:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysNetworkCameras_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysNetworkCameras_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysNetworkScanners
	{
		[Export("displaysNetworkScanners")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysNetworkScannersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysNetworkScannersHandle);
		}
		[Export("setDisplaysNetworkScanners:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysNetworkScanners_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysNetworkScanners_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKDeviceBrowserViewDisplayMode Mode
	{
		[Export("mode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKDeviceBrowserViewDisplayMode)Messaging.Int64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (IKDeviceBrowserViewDisplayMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICDevice SelectedDevice
	{
		[Export("selectedDevice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ICDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedDeviceHandle));
			}
			return Runtime.GetNSObject<ICDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedDeviceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_IKDeviceBrowserViewDelegate);

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

	public event EventHandler<IKDeviceBrowserViewICDeviceEventArgs> SelectionDidChange
	{
		add
		{
			_IKDeviceBrowserViewDelegate iKDeviceBrowserViewDelegate = EnsureIKDeviceBrowserViewDelegate();
			iKDeviceBrowserViewDelegate.selectionDidChange = (EventHandler<IKDeviceBrowserViewICDeviceEventArgs>)System.Delegate.Combine(iKDeviceBrowserViewDelegate.selectionDidChange, value);
		}
		remove
		{
			_IKDeviceBrowserViewDelegate iKDeviceBrowserViewDelegate = EnsureIKDeviceBrowserViewDelegate();
			iKDeviceBrowserViewDelegate.selectionDidChange = (EventHandler<IKDeviceBrowserViewICDeviceEventArgs>)System.Delegate.Remove(iKDeviceBrowserViewDelegate.selectionDidChange, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKDeviceBrowserView()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKDeviceBrowserView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKDeviceBrowserView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKDeviceBrowserView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKDeviceBrowserView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	internal virtual _IKDeviceBrowserViewDelegate CreateInternalEventDelegateType()
	{
		return new _IKDeviceBrowserViewDelegate();
	}

	internal _IKDeviceBrowserViewDelegate EnsureIKDeviceBrowserViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_IKDeviceBrowserViewDelegate iKDeviceBrowserViewDelegate = Delegate as _IKDeviceBrowserViewDelegate;
		if (iKDeviceBrowserViewDelegate == null)
		{
			iKDeviceBrowserViewDelegate = (_IKDeviceBrowserViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return iKDeviceBrowserViewDelegate;
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
