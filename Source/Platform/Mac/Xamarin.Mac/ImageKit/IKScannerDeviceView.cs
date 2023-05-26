using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKScannerDeviceView", true)]
public class IKScannerDeviceView : NSView
{
	[Register]
	private sealed class _IKScannerDeviceViewDelegate : IKScannerDeviceViewDelegate
	{
		internal EventHandler<IKScannerDeviceViewScanEventArgs> didScan;

		internal EventHandler<IKScannerDeviceViewErrorEventArgs> didEncounterError;

		[Preserve(Conditional = true)]
		public override void DidScan(IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error)
		{
			EventHandler<IKScannerDeviceViewScanEventArgs> eventHandler = didScan;
			if (eventHandler != null)
			{
				IKScannerDeviceViewScanEventArgs e = new IKScannerDeviceViewScanEventArgs(url, data, error);
				eventHandler(scannerDeviceView, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidEncounterError(IKScannerDeviceView scannerDeviceView, NSError error)
		{
			EventHandler<IKScannerDeviceViewErrorEventArgs> eventHandler = didEncounterError;
			if (eventHandler != null)
			{
				IKScannerDeviceViewErrorEventArgs e = new IKScannerDeviceViewErrorEventArgs(error);
				eventHandler(scannerDeviceView, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	private static readonly IntPtr selHasDisplayModeSimpleHandle = Selector.GetHandle("hasDisplayModeSimple");

	private static readonly IntPtr selSetHasDisplayModeSimple_Handle = Selector.GetHandle("setHasDisplayModeSimple:");

	private static readonly IntPtr selHasDisplayModeAdvancedHandle = Selector.GetHandle("hasDisplayModeAdvanced");

	private static readonly IntPtr selSetHasDisplayModeAdvanced_Handle = Selector.GetHandle("setHasDisplayModeAdvanced:");

	private static readonly IntPtr selTransferModeHandle = Selector.GetHandle("transferMode");

	private static readonly IntPtr selSetTransferMode_Handle = Selector.GetHandle("setTransferMode:");

	private static readonly IntPtr selScanControlLabelHandle = Selector.GetHandle("scanControlLabel");

	private static readonly IntPtr selSetScanControlLabel_Handle = Selector.GetHandle("setScanControlLabel:");

	private static readonly IntPtr selOverviewControlLabelHandle = Selector.GetHandle("overviewControlLabel");

	private static readonly IntPtr selSetOverviewControlLabel_Handle = Selector.GetHandle("setOverviewControlLabel:");

	private static readonly IntPtr selDisplaysDownloadsDirectoryControlHandle = Selector.GetHandle("displaysDownloadsDirectoryControl");

	private static readonly IntPtr selSetDisplaysDownloadsDirectoryControl_Handle = Selector.GetHandle("setDisplaysDownloadsDirectoryControl:");

	private static readonly IntPtr selDownloadsDirectoryHandle = Selector.GetHandle("downloadsDirectory");

	private static readonly IntPtr selSetDownloadsDirectory_Handle = Selector.GetHandle("setDownloadsDirectory:");

	private static readonly IntPtr selDocumentNameHandle = Selector.GetHandle("documentName");

	private static readonly IntPtr selSetDocumentName_Handle = Selector.GetHandle("setDocumentName:");

	private static readonly IntPtr selDisplaysPostProcessApplicationControlHandle = Selector.GetHandle("displaysPostProcessApplicationControl");

	private static readonly IntPtr selSetDisplaysPostProcessApplicationControl_Handle = Selector.GetHandle("setDisplaysPostProcessApplicationControl:");

	private static readonly IntPtr selPostProcessApplicationHandle = Selector.GetHandle("postProcessApplication");

	private static readonly IntPtr selSetPostProcessApplication_Handle = Selector.GetHandle("setPostProcessApplication:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKScannerDeviceView");

	private object __mt_WeakDelegate_var;

	private object __mt_DownloadsDirectory_var;

	private object __mt_PostProcessApplication_var;

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

	public IKScannerDeviceViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IKScannerDeviceViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual IKScannerDeviceViewDisplayMode DisplayMode
	{
		[Export("mode")]
		get
		{
			if (IsDirectBinding)
			{
				return (IKScannerDeviceViewDisplayMode)Messaging.int_objc_msgSend(base.Handle, selModeHandle);
			}
			return (IKScannerDeviceViewDisplayMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selModeHandle);
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

	public virtual bool HasDisplayModeSimple
	{
		[Export("hasDisplayModeSimple")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeSimpleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeSimpleHandle);
		}
		[Export("setHasDisplayModeSimple:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeSimple_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeSimple_Handle, value);
			}
		}
	}

	public virtual bool HasDisplayModeAdvanced
	{
		[Export("hasDisplayModeAdvanced")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeAdvancedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeAdvancedHandle);
		}
		[Export("setHasDisplayModeAdvanced:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeAdvanced_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeAdvanced_Handle, value);
			}
		}
	}

	public virtual IKScannerDeviceViewTransferMode TransferMode
	{
		[Export("transferMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (IKScannerDeviceViewTransferMode)Messaging.int_objc_msgSend(base.Handle, selTransferModeHandle);
			}
			return (IKScannerDeviceViewTransferMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTransferModeHandle);
		}
		[Export("setTransferMode:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTransferMode_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTransferMode_Handle, (int)value);
			}
		}
	}

	public virtual string ScanControlLabel
	{
		[Export("scanControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selScanControlLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScanControlLabelHandle));
		}
		[Export("setScanControlLabel:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScanControlLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScanControlLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string OverviewControlLabel
	{
		[Export("overviewControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOverviewControlLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOverviewControlLabelHandle));
		}
		[Export("setOverviewControlLabel:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOverviewControlLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOverviewControlLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool DisplaysDownloadsDirectoryControl
	{
		[Export("displaysDownloadsDirectoryControl")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysDownloadsDirectoryControlHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysDownloadsDirectoryControlHandle);
		}
		[Export("setDisplaysDownloadsDirectoryControl:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysDownloadsDirectoryControl_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysDownloadsDirectoryControl_Handle, value);
			}
		}
	}

	public virtual NSUrl DownloadsDirectory
	{
		[Export("downloadsDirectory", ArgumentSemantic.Retain)]
		get
		{
			return (NSUrl)(__mt_DownloadsDirectory_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadsDirectoryHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadsDirectoryHandle)))));
		}
		[Export("setDownloadsDirectory:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadsDirectory_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadsDirectory_Handle, value.Handle);
			}
			__mt_DownloadsDirectory_var = value;
		}
	}

	public virtual string DocumentName
	{
		[Export("documentName", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentNameHandle));
		}
		[Export("setDocumentName:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool DisplaysPostProcessApplicationControl
	{
		[Export("displaysPostProcessApplicationControl")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysPostProcessApplicationControlHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysPostProcessApplicationControlHandle);
		}
		[Export("setDisplaysPostProcessApplicationControl:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysPostProcessApplicationControl_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysPostProcessApplicationControl_Handle, value);
			}
		}
	}

	public virtual NSUrl PostProcessApplication
	{
		[Export("postProcessApplication", ArgumentSemantic.Retain)]
		get
		{
			return (NSUrl)(__mt_PostProcessApplication_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPostProcessApplicationHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPostProcessApplicationHandle)))));
		}
		[Export("setPostProcessApplication:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPostProcessApplication_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPostProcessApplication_Handle, value.Handle);
			}
			__mt_PostProcessApplication_var = value;
		}
	}

	public event EventHandler<IKScannerDeviceViewScanEventArgs> DidScan
	{
		add
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didScan = (EventHandler<IKScannerDeviceViewScanEventArgs>)System.Delegate.Combine(iKScannerDeviceViewDelegate.didScan, value);
		}
		remove
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didScan = (EventHandler<IKScannerDeviceViewScanEventArgs>)System.Delegate.Remove(iKScannerDeviceViewDelegate.didScan, value);
		}
	}

	public event EventHandler<IKScannerDeviceViewErrorEventArgs> DidEncounterError
	{
		add
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didEncounterError = (EventHandler<IKScannerDeviceViewErrorEventArgs>)System.Delegate.Combine(iKScannerDeviceViewDelegate.didEncounterError, value);
		}
		remove
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didEncounterError = (EventHandler<IKScannerDeviceViewErrorEventArgs>)System.Delegate.Remove(iKScannerDeviceViewDelegate.didEncounterError, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKScannerDeviceView()
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
	public IKScannerDeviceView(NSCoder coder)
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
	public IKScannerDeviceView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKScannerDeviceView(IntPtr handle)
		: base(handle)
	{
	}

	private _IKScannerDeviceViewDelegate EnsureIKScannerDeviceViewDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _IKScannerDeviceViewDelegate))
		{
			nSObject = (WeakDelegate = new _IKScannerDeviceViewDelegate());
		}
		return (_IKScannerDeviceViewDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_DownloadsDirectory_var = null;
			__mt_PostProcessApplication_var = null;
		}
	}
}
