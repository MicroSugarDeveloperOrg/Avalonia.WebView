using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKCameraDeviceView", true)]
public class IKCameraDeviceView : NSView
{
	[Register]
	private sealed class _IKCameraDeviceViewDelegate : IKCameraDeviceViewDelegate
	{
		internal EventHandler selectionDidChange;

		internal EventHandler<IKCameraDeviceViewNSErrorEventArgs> didEncounterError;

		[Preserve(Conditional = true)]
		public override void SelectionDidChange(IKCameraDeviceView cameraDeviceView)
		{
			selectionDidChange?.Invoke(cameraDeviceView, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void DidEncounterError(IKCameraDeviceView cameraDeviceView, NSError error)
		{
			EventHandler<IKCameraDeviceViewNSErrorEventArgs> eventHandler = didEncounterError;
			if (eventHandler != null)
			{
				IKCameraDeviceViewNSErrorEventArgs e = new IKCameraDeviceViewNSErrorEventArgs(error);
				eventHandler(cameraDeviceView, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selHasDisplayModeTableHandle = Selector.GetHandle("hasDisplayModeTable");

	private static readonly IntPtr selSetHasDisplayModeTable_Handle = Selector.GetHandle("setHasDisplayModeTable:");

	private static readonly IntPtr selHasDisplayModeIconHandle = Selector.GetHandle("hasDisplayModeIcon");

	private static readonly IntPtr selSetHasDisplayModeIcon_Handle = Selector.GetHandle("setHasDisplayModeIcon:");

	private static readonly IntPtr selDownloadAllControlLabelHandle = Selector.GetHandle("downloadAllControlLabel");

	private static readonly IntPtr selSetDownloadAllControlLabel_Handle = Selector.GetHandle("setDownloadAllControlLabel:");

	private static readonly IntPtr selDownloadSelectedControlLabelHandle = Selector.GetHandle("downloadSelectedControlLabel");

	private static readonly IntPtr selSetDownloadSelectedControlLabel_Handle = Selector.GetHandle("setDownloadSelectedControlLabel:");

	private static readonly IntPtr selIconSizeHandle = Selector.GetHandle("iconSize");

	private static readonly IntPtr selSetIconSize_Handle = Selector.GetHandle("setIconSize:");

	private static readonly IntPtr selTransferModeHandle = Selector.GetHandle("transferMode");

	private static readonly IntPtr selSetTransferMode_Handle = Selector.GetHandle("setTransferMode:");

	private static readonly IntPtr selDisplaysDownloadsDirectoryControlHandle = Selector.GetHandle("displaysDownloadsDirectoryControl");

	private static readonly IntPtr selSetDisplaysDownloadsDirectoryControl_Handle = Selector.GetHandle("setDisplaysDownloadsDirectoryControl:");

	private static readonly IntPtr selDownloadsDirectoryHandle = Selector.GetHandle("downloadsDirectory");

	private static readonly IntPtr selSetDownloadsDirectory_Handle = Selector.GetHandle("setDownloadsDirectory:");

	private static readonly IntPtr selDisplaysPostProcessApplicationControlHandle = Selector.GetHandle("displaysPostProcessApplicationControl");

	private static readonly IntPtr selSetDisplaysPostProcessApplicationControl_Handle = Selector.GetHandle("setDisplaysPostProcessApplicationControl:");

	private static readonly IntPtr selPostProcessApplicationHandle = Selector.GetHandle("postProcessApplication");

	private static readonly IntPtr selSetPostProcessApplication_Handle = Selector.GetHandle("setPostProcessApplication:");

	private static readonly IntPtr selCanRotateSelectedItemsLeftHandle = Selector.GetHandle("canRotateSelectedItemsLeft");

	private static readonly IntPtr selCanRotateSelectedItemsRightHandle = Selector.GetHandle("canRotateSelectedItemsRight");

	private static readonly IntPtr selCanDeleteSelectedItemsHandle = Selector.GetHandle("canDeleteSelectedItems");

	private static readonly IntPtr selCanDownloadSelectedItemsHandle = Selector.GetHandle("canDownloadSelectedItems");

	private static readonly IntPtr selSelectedIndexesHandle = Selector.GetHandle("selectedIndexes");

	private static readonly IntPtr selSelectIndexesByExtendingSelection_Handle = Selector.GetHandle("selectIndexes:byExtendingSelection:");

	private static readonly IntPtr selRotateLeft_Handle = Selector.GetHandle("rotateLeft:");

	private static readonly IntPtr selRotateRight_Handle = Selector.GetHandle("rotateRight:");

	private static readonly IntPtr selDeleteSelectedItems_Handle = Selector.GetHandle("deleteSelectedItems:");

	private static readonly IntPtr selDownloadSelectedItems_Handle = Selector.GetHandle("downloadSelectedItems:");

	private static readonly IntPtr selDownloadAllItems_Handle = Selector.GetHandle("downloadAllItems:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKCameraDeviceView");

	private object __mt_WeakDelegate_var;

	private object __mt_DownloadsDirectory_var;

	private object __mt_PostProcessApplication_var;

	private object __mt_SelectedIndexes_var;

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

	public IKCameraDeviceViewDelegate Delegate
	{
		get
		{
			return WeakDelegate as IKCameraDeviceViewDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool HasDisplayModeTable
	{
		[Export("hasDisplayModeTable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeTableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeTableHandle);
		}
		[Export("setHasDisplayModeTable:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeTable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeTable_Handle, value);
			}
		}
	}

	public virtual bool HasDisplayModeIcon
	{
		[Export("hasDisplayModeIcon")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasDisplayModeIconHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasDisplayModeIconHandle);
		}
		[Export("setHasDisplayModeIcon:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasDisplayModeIcon_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasDisplayModeIcon_Handle, value);
			}
		}
	}

	public virtual string DownloadAllControlLabel
	{
		[Export("downloadAllControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string DownloadSelectedControlLabel
	{
		[Export("downloadSelectedControlLabel", ArgumentSemantic.Copy)]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual int IconSize
	{
		[Export("iconSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIconSizeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIconSizeHandle);
		}
		[Export("setIconSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetIconSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetIconSize_Handle, value);
			}
		}
	}

	public virtual IKCameraDeviceViewTransferMode TransferMode
	{
		[Export("transferMode")]
		get
		{
			if (IsDirectBinding)
			{
				return (IKCameraDeviceViewTransferMode)Messaging.int_objc_msgSend(base.Handle, selTransferModeHandle);
			}
			return (IKCameraDeviceViewTransferMode)Messaging.int_objc_msgSendSuper(base.SuperHandle, selTransferModeHandle);
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

	public virtual bool CanRotateSelectedItemsLeft
	{
		[Export("canRotateSelectedItemsLeft")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRotateSelectedItemsLeftHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRotateSelectedItemsLeftHandle);
		}
	}

	public virtual bool CanRotateSelectedItemsRight
	{
		[Export("canRotateSelectedItemsRight")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRotateSelectedItemsRightHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRotateSelectedItemsRightHandle);
		}
	}

	public virtual bool CanDeleteSelectedItems
	{
		[Export("canDeleteSelectedItems")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDeleteSelectedItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDeleteSelectedItemsHandle);
		}
	}

	public virtual bool CanDownloadSelectedItems
	{
		[Export("canDownloadSelectedItems")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanDownloadSelectedItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanDownloadSelectedItemsHandle);
		}
	}

	public virtual NSIndexSet SelectedIndexes
	{
		[Export("selectedIndexes")]
		get
		{
			return (NSIndexSet)(__mt_SelectedIndexes_var = ((!IsDirectBinding) ? ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedIndexesHandle))) : ((NSIndexSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedIndexesHandle)))));
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKCameraDeviceView()
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
	public IKCameraDeviceView(NSCoder coder)
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
	public IKCameraDeviceView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKCameraDeviceView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("selectIndexes:byExtendingSelection:")]
	public virtual void SelectItemsAt(NSIndexSet indexes, bool extendSelection)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSelectIndexesByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSelectIndexesByExtendingSelection_Handle, indexes.Handle, extendSelection);
		}
	}

	[Export("rotateLeft:")]
	public virtual void RotateLeft(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateLeft_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateLeft_Handle, sender.Handle);
		}
	}

	[Export("rotateRight:")]
	public virtual void RotateRight(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateRight_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateRight_Handle, sender.Handle);
		}
	}

	[Export("deleteSelectedItems:")]
	public virtual void DeleteSelectedItems(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteSelectedItems_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteSelectedItems_Handle, sender.Handle);
		}
	}

	[Export("downloadSelectedItems:")]
	public virtual void DownloadSelectedItems(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDownloadSelectedItems_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadSelectedItems_Handle, sender.Handle);
		}
	}

	[Export("downloadAllItems:")]
	public virtual void DownloadAllItems(NSObject sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDownloadAllItems_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadAllItems_Handle, sender.Handle);
		}
	}

	private _IKCameraDeviceViewDelegate EnsureIKCameraDeviceViewDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _IKCameraDeviceViewDelegate))
		{
			nSObject = (WeakDelegate = new _IKCameraDeviceViewDelegate());
		}
		return (_IKCameraDeviceViewDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_DownloadsDirectory_var = null;
			__mt_PostProcessApplication_var = null;
			__mt_SelectedIndexes_var = null;
		}
	}
}
