using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Register("IKCameraDeviceView", true)]
public class IKCameraDeviceView : NSView
{
	[Register]
	internal class _IKCameraDeviceViewDelegate : NSObject, IIKCameraDeviceViewDelegate, INativeObject, IDisposable
	{
		internal EventHandler<IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs>? didDownloadFile;

		internal EventHandler<IKCameraDeviceViewNSErrorEventArgs>? didEncounterError;

		internal EventHandler? selectionDidChange;

		public _IKCameraDeviceViewDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("cameraDeviceView:didDownloadFile:location:fileData:error:")]
		public void DidDownloadFile(IKCameraDeviceView cameraDeviceView, ICCameraFile file, NSUrl url, NSData data, NSError error)
		{
			EventHandler<IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs> eventHandler = didDownloadFile;
			if (eventHandler != null)
			{
				IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs e = new IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs(file, url, data, error);
				eventHandler(cameraDeviceView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("cameraDeviceView:didEncounterError:")]
		public void DidEncounterError(IKCameraDeviceView cameraDeviceView, NSError error)
		{
			EventHandler<IKCameraDeviceViewNSErrorEventArgs> eventHandler = didEncounterError;
			if (eventHandler != null)
			{
				IKCameraDeviceViewNSErrorEventArgs e = new IKCameraDeviceViewNSErrorEventArgs(error);
				eventHandler(cameraDeviceView, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("cameraDeviceViewSelectionDidChange:")]
		public void SelectionDidChange(IKCameraDeviceView cameraDeviceView)
		{
			selectionDidChange?.Invoke(cameraDeviceView, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCameraDevice = "cameraDevice";

	private static readonly IntPtr selCameraDeviceHandle = Selector.GetHandle("cameraDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDeleteSelectedItems = "canDeleteSelectedItems";

	private static readonly IntPtr selCanDeleteSelectedItemsHandle = Selector.GetHandle("canDeleteSelectedItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanDownloadSelectedItems = "canDownloadSelectedItems";

	private static readonly IntPtr selCanDownloadSelectedItemsHandle = Selector.GetHandle("canDownloadSelectedItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanRotateSelectedItemsLeft = "canRotateSelectedItemsLeft";

	private static readonly IntPtr selCanRotateSelectedItemsLeftHandle = Selector.GetHandle("canRotateSelectedItemsLeft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanRotateSelectedItemsRight = "canRotateSelectedItemsRight";

	private static readonly IntPtr selCanRotateSelectedItemsRightHandle = Selector.GetHandle("canRotateSelectedItemsRight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSelectedItems_ = "deleteSelectedItems:";

	private static readonly IntPtr selDeleteSelectedItems_Handle = Selector.GetHandle("deleteSelectedItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysDownloadsDirectoryControl = "displaysDownloadsDirectoryControl";

	private static readonly IntPtr selDisplaysDownloadsDirectoryControlHandle = Selector.GetHandle("displaysDownloadsDirectoryControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysPostProcessApplicationControl = "displaysPostProcessApplicationControl";

	private static readonly IntPtr selDisplaysPostProcessApplicationControlHandle = Selector.GetHandle("displaysPostProcessApplicationControl");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadAllControlLabel = "downloadAllControlLabel";

	private static readonly IntPtr selDownloadAllControlLabelHandle = Selector.GetHandle("downloadAllControlLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadAllItems_ = "downloadAllItems:";

	private static readonly IntPtr selDownloadAllItems_Handle = Selector.GetHandle("downloadAllItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadSelectedControlLabel = "downloadSelectedControlLabel";

	private static readonly IntPtr selDownloadSelectedControlLabelHandle = Selector.GetHandle("downloadSelectedControlLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadSelectedItems_ = "downloadSelectedItems:";

	private static readonly IntPtr selDownloadSelectedItems_Handle = Selector.GetHandle("downloadSelectedItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadsDirectory = "downloadsDirectory";

	private static readonly IntPtr selDownloadsDirectoryHandle = Selector.GetHandle("downloadsDirectory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDisplayModeIcon = "hasDisplayModeIcon";

	private static readonly IntPtr selHasDisplayModeIconHandle = Selector.GetHandle("hasDisplayModeIcon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasDisplayModeTable = "hasDisplayModeTable";

	private static readonly IntPtr selHasDisplayModeTableHandle = Selector.GetHandle("hasDisplayModeTable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIconSize = "iconSize";

	private static readonly IntPtr selIconSizeHandle = Selector.GetHandle("iconSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostProcessApplication = "postProcessApplication";

	private static readonly IntPtr selPostProcessApplicationHandle = Selector.GetHandle("postProcessApplication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateLeft_ = "rotateLeft:";

	private static readonly IntPtr selRotateLeft_Handle = Selector.GetHandle("rotateLeft:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateRight_ = "rotateRight:";

	private static readonly IntPtr selRotateRight_Handle = Selector.GetHandle("rotateRight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectIndexes_ByExtendingSelection_ = "selectIndexes:byExtendingSelection:";

	private static readonly IntPtr selSelectIndexes_ByExtendingSelection_Handle = Selector.GetHandle("selectIndexes:byExtendingSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndexes = "selectedIndexes";

	private static readonly IntPtr selSelectedIndexesHandle = Selector.GetHandle("selectedIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCameraDevice_ = "setCameraDevice:";

	private static readonly IntPtr selSetCameraDevice_Handle = Selector.GetHandle("setCameraDevice:");

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
	private const string selSetDownloadAllControlLabel_ = "setDownloadAllControlLabel:";

	private static readonly IntPtr selSetDownloadAllControlLabel_Handle = Selector.GetHandle("setDownloadAllControlLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDownloadSelectedControlLabel_ = "setDownloadSelectedControlLabel:";

	private static readonly IntPtr selSetDownloadSelectedControlLabel_Handle = Selector.GetHandle("setDownloadSelectedControlLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDownloadsDirectory_ = "setDownloadsDirectory:";

	private static readonly IntPtr selSetDownloadsDirectory_Handle = Selector.GetHandle("setDownloadsDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasDisplayModeIcon_ = "setHasDisplayModeIcon:";

	private static readonly IntPtr selSetHasDisplayModeIcon_Handle = Selector.GetHandle("setHasDisplayModeIcon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasDisplayModeTable_ = "setHasDisplayModeTable:";

	private static readonly IntPtr selSetHasDisplayModeTable_Handle = Selector.GetHandle("setHasDisplayModeTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIconSize_ = "setIconSize:";

	private static readonly IntPtr selSetIconSize_Handle = Selector.GetHandle("setIconSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPostProcessApplication_ = "setPostProcessApplication:";

	private static readonly IntPtr selSetPostProcessApplication_Handle = Selector.GetHandle("setPostProcessApplication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransferMode_ = "setTransferMode:";

	private static readonly IntPtr selSetTransferMode_Handle = Selector.GetHandle("setTransferMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransferMode = "transferMode";

	private static readonly IntPtr selTransferModeHandle = Selector.GetHandle("transferMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKCameraDeviceView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_CameraDevice_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraDevice CameraDevice
	{
		[Export("cameraDevice", ArgumentSemantic.Assign)]
		get
		{
			ICCameraDevice iCCameraDevice = ((!base.IsDirectBinding) ? Runtime.GetNSObject<ICCameraDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCameraDeviceHandle)) : Runtime.GetNSObject<ICCameraDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selCameraDeviceHandle)));
			MarkDirty();
			__mt_CameraDevice_var = iCCameraDevice;
			return iCCameraDevice;
		}
		[Export("setCameraDevice:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCameraDevice_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCameraDevice_Handle, value.Handle);
			}
			MarkDirty();
			__mt_CameraDevice_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDeleteSelectedItems
	{
		[Export("canDeleteSelectedItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDeleteSelectedItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDeleteSelectedItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanDownloadSelectedItems
	{
		[Export("canDownloadSelectedItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDownloadSelectedItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDownloadSelectedItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanRotateSelectedItemsLeft
	{
		[Export("canRotateSelectedItemsLeft")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRotateSelectedItemsLeftHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRotateSelectedItemsLeftHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanRotateSelectedItemsRight
	{
		[Export("canRotateSelectedItemsRight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRotateSelectedItemsRightHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRotateSelectedItemsRightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IIKCameraDeviceViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IIKCameraDeviceViewDelegate;
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
	public virtual string DownloadAllControlLabel
	{
		[Export("downloadAllControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadAllControlLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadAllControlLabelHandle));
		}
		[Export("setDownloadAllControlLabel:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadAllControlLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadAllControlLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DownloadSelectedControlLabel
	{
		[Export("downloadSelectedControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadSelectedControlLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadSelectedControlLabelHandle));
		}
		[Export("setDownloadSelectedControlLabel:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDownloadSelectedControlLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDownloadSelectedControlLabel_Handle, arg);
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
	public virtual bool HasDisplayModeIcon
	{
		[Export("hasDisplayModeIcon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeIconHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeIconHandle);
		}
		[Export("setHasDisplayModeIcon:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeIcon_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeIcon_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasDisplayModeTable
	{
		[Export("hasDisplayModeTable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeTableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeTableHandle);
		}
		[Export("setHasDisplayModeTable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeTable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeTable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IconSize
	{
		[Export("iconSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selIconSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selIconSizeHandle);
		}
		[Export("setIconSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetIconSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetIconSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKCameraDeviceViewDisplayMode Mode
	{
		[Export("mode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKCameraDeviceViewDisplayMode)Messaging.Int64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (IKCameraDeviceViewDisplayMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:", ArgumentSemantic.Assign)]
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
	public virtual NSIndexSet SelectedIndexes
	{
		[Export("selectedIndexes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IKCameraDeviceViewTransferMode TransferMode
	{
		[Export("transferMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (IKCameraDeviceViewTransferMode)Messaging.Int64_objc_msgSend(base.Handle, selTransferModeHandle);
			}
			return (IKCameraDeviceViewTransferMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTransferModeHandle);
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

	internal virtual Type GetInternalEventDelegateType => typeof(_IKCameraDeviceViewDelegate);

	public event EventHandler<IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs> DidDownloadFile
	{
		add
		{
			_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = EnsureIKCameraDeviceViewDelegate();
			iKCameraDeviceViewDelegate.didDownloadFile = (EventHandler<IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs>)System.Delegate.Combine(iKCameraDeviceViewDelegate.didDownloadFile, value);
		}
		remove
		{
			_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = EnsureIKCameraDeviceViewDelegate();
			iKCameraDeviceViewDelegate.didDownloadFile = (EventHandler<IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs>)System.Delegate.Remove(iKCameraDeviceViewDelegate.didDownloadFile, value);
		}
	}

	public event EventHandler<IKCameraDeviceViewNSErrorEventArgs> DidEncounterError
	{
		add
		{
			_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = EnsureIKCameraDeviceViewDelegate();
			iKCameraDeviceViewDelegate.didEncounterError = (EventHandler<IKCameraDeviceViewNSErrorEventArgs>)System.Delegate.Combine(iKCameraDeviceViewDelegate.didEncounterError, value);
		}
		remove
		{
			_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = EnsureIKCameraDeviceViewDelegate();
			iKCameraDeviceViewDelegate.didEncounterError = (EventHandler<IKCameraDeviceViewNSErrorEventArgs>)System.Delegate.Remove(iKCameraDeviceViewDelegate.didEncounterError, value);
		}
	}

	public event EventHandler SelectionDidChange
	{
		add
		{
			_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = EnsureIKCameraDeviceViewDelegate();
			iKCameraDeviceViewDelegate.selectionDidChange = (EventHandler)System.Delegate.Combine(iKCameraDeviceViewDelegate.selectionDidChange, value);
		}
		remove
		{
			_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = EnsureIKCameraDeviceViewDelegate();
			iKCameraDeviceViewDelegate.selectionDidChange = (EventHandler)System.Delegate.Remove(iKCameraDeviceViewDelegate.selectionDidChange, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKCameraDeviceView()
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
	public IKCameraDeviceView(NSCoder coder)
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
	protected IKCameraDeviceView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKCameraDeviceView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKCameraDeviceView(CGRect frameRect)
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

	[Export("deleteSelectedItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteSelectedItems(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteSelectedItems_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteSelectedItems_Handle, sender.Handle);
		}
	}

	[Export("downloadAllItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DownloadAllItems(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDownloadAllItems_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadAllItems_Handle, sender.Handle);
		}
	}

	[Export("downloadSelectedItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DownloadSelectedItems(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDownloadSelectedItems_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadSelectedItems_Handle, sender.Handle);
		}
	}

	[Export("rotateLeft:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateLeft(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateLeft_Handle, sender.Handle);
		}
	}

	[Export("rotateRight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateRight(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateRight_Handle, sender.Handle);
		}
	}

	[Export("selectIndexes:byExtendingSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectItemsAt(NSIndexSet indexes, bool extendSelection)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectIndexes_ByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectIndexes_ByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
	}

	internal virtual _IKCameraDeviceViewDelegate CreateInternalEventDelegateType()
	{
		return new _IKCameraDeviceViewDelegate();
	}

	internal _IKCameraDeviceViewDelegate EnsureIKCameraDeviceViewDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_IKCameraDeviceViewDelegate iKCameraDeviceViewDelegate = Delegate as _IKCameraDeviceViewDelegate;
		if (iKCameraDeviceViewDelegate == null)
		{
			iKCameraDeviceViewDelegate = (_IKCameraDeviceViewDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return iKCameraDeviceViewDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CameraDevice_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
