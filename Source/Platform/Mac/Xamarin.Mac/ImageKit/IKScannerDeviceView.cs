using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Register("IKScannerDeviceView", true)]
public class IKScannerDeviceView : NSView
{
	[Register]
	internal class _IKScannerDeviceViewDelegate : NSObject, IIKScannerDeviceViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler<IKScannerDeviceViewErrorEventArgs>? didEncounterError;

		internal EventHandler<IKScannerDeviceViewScanEventArgs>? didScan;

		internal EventHandler<IKScannerDeviceViewScanBandDataEventArgs>? didScanToBandData;

		internal EventHandler<IKScannerDeviceViewScanUrlEventArgs>? didScanToUrl;

		public _IKScannerDeviceViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("scannerDeviceView:didEncounterError:")]
		public void DidEncounterError(IKScannerDeviceView scannerDeviceView, NSError error)
		{
			EventHandler<IKScannerDeviceViewErrorEventArgs> eventHandler = didEncounterError;
			if (eventHandler != null)
			{
				IKScannerDeviceViewErrorEventArgs e = new IKScannerDeviceViewErrorEventArgs(error);
				eventHandler(scannerDeviceView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("scannerDeviceView:didScanToURL:fileData:error:")]
		public void DidScan(IKScannerDeviceView scannerDeviceView, NSUrl url, NSData data, NSError error)
		{
			EventHandler<IKScannerDeviceViewScanEventArgs> eventHandler = didScan;
			if (eventHandler != null)
			{
				IKScannerDeviceViewScanEventArgs e = new IKScannerDeviceViewScanEventArgs(url, data, error);
				eventHandler(scannerDeviceView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("scannerDeviceView:didScanToBandData:scanInfo:error:")]
		public void DidScanToBandData(IKScannerDeviceView scannerDeviceView, ICScannerBandData data, NSDictionary scanInfo, NSError error)
		{
			EventHandler<IKScannerDeviceViewScanBandDataEventArgs> eventHandler = didScanToBandData;
			if (eventHandler != null)
			{
				IKScannerDeviceViewScanBandDataEventArgs e = new IKScannerDeviceViewScanBandDataEventArgs(data, scanInfo, error);
				eventHandler(scannerDeviceView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("scannerDeviceView:didScanToURL:error:")]
		public void DidScanToUrl(IKScannerDeviceView scannerDeviceView, NSUrl url, NSError error)
		{
			EventHandler<IKScannerDeviceViewScanUrlEventArgs> eventHandler = didScanToUrl;
			if (eventHandler != null)
			{
				IKScannerDeviceViewScanUrlEventArgs e = new IKScannerDeviceViewScanUrlEventArgs(url, error);
				eventHandler(scannerDeviceView, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysDownloadsDirectoryControl = "displaysDownloadsDirectoryControl";

	private static readonly IntPtr selDisplaysDownloadsDirectoryControlHandle = Selector.GetHandle("displaysDownloadsDirectoryControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysPostProcessApplicationControl = "displaysPostProcessApplicationControl";

	private static readonly IntPtr selDisplaysPostProcessApplicationControlHandle = Selector.GetHandle("displaysPostProcessApplicationControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentName = "documentName";

	private static readonly IntPtr selDocumentNameHandle = Selector.GetHandle("documentName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadsDirectory = "downloadsDirectory";

	private static readonly IntPtr selDownloadsDirectoryHandle = Selector.GetHandle("downloadsDirectory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDisplayModeAdvanced = "hasDisplayModeAdvanced";

	private static readonly IntPtr selHasDisplayModeAdvancedHandle = Selector.GetHandle("hasDisplayModeAdvanced");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDisplayModeSimple = "hasDisplayModeSimple";

	private static readonly IntPtr selHasDisplayModeSimpleHandle = Selector.GetHandle("hasDisplayModeSimple");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverviewControlLabel = "overviewControlLabel";

	private static readonly IntPtr selOverviewControlLabelHandle = Selector.GetHandle("overviewControlLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostProcessApplication = "postProcessApplication";

	private static readonly IntPtr selPostProcessApplicationHandle = Selector.GetHandle("postProcessApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScanControlLabel = "scanControlLabel";

	private static readonly IntPtr selScanControlLabelHandle = Selector.GetHandle("scanControlLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScannerDevice = "scannerDevice";

	private static readonly IntPtr selScannerDeviceHandle = Selector.GetHandle("scannerDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysDownloadsDirectoryControl_ = "setDisplaysDownloadsDirectoryControl:";

	private static readonly IntPtr selSetDisplaysDownloadsDirectoryControl_Handle = Selector.GetHandle("setDisplaysDownloadsDirectoryControl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysPostProcessApplicationControl_ = "setDisplaysPostProcessApplicationControl:";

	private static readonly IntPtr selSetDisplaysPostProcessApplicationControl_Handle = Selector.GetHandle("setDisplaysPostProcessApplicationControl:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentName_ = "setDocumentName:";

	private static readonly IntPtr selSetDocumentName_Handle = Selector.GetHandle("setDocumentName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDownloadsDirectory_ = "setDownloadsDirectory:";

	private static readonly IntPtr selSetDownloadsDirectory_Handle = Selector.GetHandle("setDownloadsDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasDisplayModeAdvanced_ = "setHasDisplayModeAdvanced:";

	private static readonly IntPtr selSetHasDisplayModeAdvanced_Handle = Selector.GetHandle("setHasDisplayModeAdvanced:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasDisplayModeSimple_ = "setHasDisplayModeSimple:";

	private static readonly IntPtr selSetHasDisplayModeSimple_Handle = Selector.GetHandle("setHasDisplayModeSimple:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverviewControlLabel_ = "setOverviewControlLabel:";

	private static readonly IntPtr selSetOverviewControlLabel_Handle = Selector.GetHandle("setOverviewControlLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPostProcessApplication_ = "setPostProcessApplication:";

	private static readonly IntPtr selSetPostProcessApplication_Handle = Selector.GetHandle("setPostProcessApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScanControlLabel_ = "setScanControlLabel:";

	private static readonly IntPtr selSetScanControlLabel_Handle = Selector.GetHandle("setScanControlLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScannerDevice_ = "setScannerDevice:";

	private static readonly IntPtr selSetScannerDevice_Handle = Selector.GetHandle("setScannerDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransferMode_ = "setTransferMode:";

	private static readonly IntPtr selSetTransferMode_Handle = Selector.GetHandle("setTransferMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransferMode = "transferMode";

	private static readonly IntPtr selTransferModeHandle = Selector.GetHandle("transferMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKScannerDeviceView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ScannerDevice_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IIKScannerDeviceViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IIKScannerDeviceViewDelegate;
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
	public virtual IKScannerDeviceViewDisplayMode DisplayMode
	{
		[Export("mode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKScannerDeviceViewDisplayMode)Messaging.Int64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (IKScannerDeviceViewDisplayMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
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
	public virtual bool DisplaysDownloadsDirectoryControl
	{
		[Export("displaysDownloadsDirectoryControl")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysDownloadsDirectoryControlHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysDownloadsDirectoryControlHandle);
		}
		[Export("setDisplaysDownloadsDirectoryControl:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysDownloadsDirectoryControl_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysDownloadsDirectoryControl_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysPostProcessApplicationControl
	{
		[Export("displaysPostProcessApplicationControl")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysPostProcessApplicationControlHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysPostProcessApplicationControlHandle);
		}
		[Export("setDisplaysPostProcessApplicationControl:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysPostProcessApplicationControl_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysPostProcessApplicationControl_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DocumentName
	{
		[Export("documentName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl DownloadsDirectory
	{
		[Export("downloadsDirectory", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadsDirectoryHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadsDirectoryHandle));
		}
		[Export("setDownloadsDirectory:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadsDirectory_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadsDirectory_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasDisplayModeAdvanced
	{
		[Export("hasDisplayModeAdvanced")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeAdvancedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeAdvancedHandle);
		}
		[Export("setHasDisplayModeAdvanced:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeAdvanced_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeAdvanced_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasDisplayModeSimple
	{
		[Export("hasDisplayModeSimple")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeSimpleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeSimpleHandle);
		}
		[Export("setHasDisplayModeSimple:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeSimple_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeSimple_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string OverviewControlLabel
	{
		[Export("overviewControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PostProcessApplication
	{
		[Export("postProcessApplication", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selPostProcessApplicationHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPostProcessApplicationHandle));
		}
		[Export("setPostProcessApplication:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPostProcessApplication_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPostProcessApplication_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ScanControlLabel
	{
		[Export("scanControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerDevice ScannerDevice
	{
		[Export("scannerDevice", ArgumentSemantic.Assign)]
		get
		{
			ICScannerDevice iCScannerDevice = ((!base.IsDirectBinding) ? Runtime.GetNSObject<ICScannerDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScannerDeviceHandle)) : Runtime.GetNSObject<ICScannerDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selScannerDeviceHandle)));
			MarkDirty();
			__mt_ScannerDevice_var = iCScannerDevice;
			return iCScannerDevice;
		}
		[Export("setScannerDevice:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScannerDevice_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScannerDevice_Handle, value.Handle);
			}
			MarkDirty();
			__mt_ScannerDevice_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKScannerDeviceViewTransferMode TransferMode
	{
		[Export("transferMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKScannerDeviceViewTransferMode)Messaging.Int64_objc_msgSend(base.Handle, selTransferModeHandle);
			}
			return (IKScannerDeviceViewTransferMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTransferModeHandle);
		}
		[Export("setTransferMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTransferMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTransferMode_Handle, (long)value);
			}
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

	internal virtual Type GetInternalEventDelegateType => typeof(_IKScannerDeviceViewDelegate);

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

	public event EventHandler<IKScannerDeviceViewScanBandDataEventArgs> DidScanToBandData
	{
		add
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didScanToBandData = (EventHandler<IKScannerDeviceViewScanBandDataEventArgs>)System.Delegate.Combine(iKScannerDeviceViewDelegate.didScanToBandData, value);
		}
		remove
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didScanToBandData = (EventHandler<IKScannerDeviceViewScanBandDataEventArgs>)System.Delegate.Remove(iKScannerDeviceViewDelegate.didScanToBandData, value);
		}
	}

	public event EventHandler<IKScannerDeviceViewScanUrlEventArgs> DidScanToUrl
	{
		add
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didScanToUrl = (EventHandler<IKScannerDeviceViewScanUrlEventArgs>)System.Delegate.Combine(iKScannerDeviceViewDelegate.didScanToUrl, value);
		}
		remove
		{
			_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = EnsureIKScannerDeviceViewDelegate();
			iKScannerDeviceViewDelegate.didScanToUrl = (EventHandler<IKScannerDeviceViewScanUrlEventArgs>)System.Delegate.Remove(iKScannerDeviceViewDelegate.didScanToUrl, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKScannerDeviceView()
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
	public IKScannerDeviceView(NSCoder coder)
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
	protected IKScannerDeviceView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKScannerDeviceView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKScannerDeviceView(CGRect frameRect)
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

	internal virtual _IKScannerDeviceViewDelegate CreateInternalEventDelegateType()
	{
		return new _IKScannerDeviceViewDelegate();
	}

	internal _IKScannerDeviceViewDelegate EnsureIKScannerDeviceViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_IKScannerDeviceViewDelegate iKScannerDeviceViewDelegate = Delegate as _IKScannerDeviceViewDelegate;
		if (iKScannerDeviceViewDelegate == null)
		{
			iKScannerDeviceViewDelegate = (_IKScannerDeviceViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return iKScannerDeviceViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ScannerDevice_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
