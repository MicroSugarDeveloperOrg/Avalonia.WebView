using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICCameraDevice", true)]
public class ICCameraDevice : ICDevice
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatteryLevel = "batteryLevel";

	private static readonly IntPtr selBatteryLevelHandle = Selector.GetHandle("batteryLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatteryLevelAvailable = "batteryLevelAvailable";

	private static readonly IntPtr selBatteryLevelAvailableHandle = Selector.GetHandle("batteryLevelAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelDelete = "cancelDelete";

	private static readonly IntPtr selCancelDeleteHandle = Selector.GetHandle("cancelDelete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelDownload = "cancelDownload";

	private static readonly IntPtr selCancelDownloadHandle = Selector.GetHandle("cancelDownload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentCatalogPercentCompleted = "contentCatalogPercentCompleted";

	private static readonly IntPtr selContentCatalogPercentCompletedHandle = Selector.GetHandle("contentCatalogPercentCompleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContents = "contents";

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilesOfType_ = "filesOfType:";

	private static readonly IntPtr selFilesOfType_Handle = Selector.GetHandle("filesOfType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAccessRestrictedAppleDevice = "isAccessRestrictedAppleDevice";

	private static readonly IntPtr selIsAccessRestrictedAppleDeviceHandle = Selector.GetHandle("isAccessRestrictedAppleDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaFiles = "mediaFiles";

	private static readonly IntPtr selMediaFilesHandle = Selector.GetHandle("mediaFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMountPoint = "mountPoint";

	private static readonly IntPtr selMountPointHandle = Selector.GetHandle("mountPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestDeleteFiles_ = "requestDeleteFiles:";

	private static readonly IntPtr selRequestDeleteFiles_Handle = Selector.GetHandle("requestDeleteFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestDisableTethering = "requestDisableTethering";

	private static readonly IntPtr selRequestDisableTetheringHandle = Selector.GetHandle("requestDisableTethering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_ = "requestDownloadFile:options:downloadDelegate:didDownloadSelector:contextInfo:";

	private static readonly IntPtr selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_Handle = Selector.GetHandle("requestDownloadFile:options:downloadDelegate:didDownloadSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestEnableTethering = "requestEnableTethering";

	private static readonly IntPtr selRequestEnableTetheringHandle = Selector.GetHandle("requestEnableTethering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_ = "requestReadDataFromFile:atOffset:length:readDelegate:didReadDataSelector:contextInfo:";

	private static readonly IntPtr selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_Handle = Selector.GetHandle("requestReadDataFromFile:atOffset:length:readDelegate:didReadDataSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_ = "requestSendPTPCommand:outData:sendCommandDelegate:didSendCommandSelector:contextInfo:";

	private static readonly IntPtr selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_Handle = Selector.GetHandle("requestSendPTPCommand:outData:sendCommandDelegate:didSendCommandSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestSyncClock = "requestSyncClock";

	private static readonly IntPtr selRequestSyncClockHandle = Selector.GetHandle("requestSyncClock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestTakePicture = "requestTakePicture";

	private static readonly IntPtr selRequestTakePictureHandle = Selector.GetHandle("requestTakePicture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_ = "requestUploadFile:options:uploadDelegate:didUploadSelector:contextInfo:";

	private static readonly IntPtr selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_Handle = Selector.GetHandle("requestUploadFile:options:uploadDelegate:didUploadSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTetheredCaptureEnabled = "tetheredCaptureEnabled";

	private static readonly IntPtr selTetheredCaptureEnabledHandle = Selector.GetHandle("tetheredCaptureEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeOffset = "timeOffset";

	private static readonly IntPtr selTimeOffsetHandle = Selector.GetHandle("timeOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICCameraDevice");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BatteryLevel
	{
		[Export("batteryLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatteryLevelHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatteryLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BatteryLevelAvailable
	{
		[Export("batteryLevelAvailable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBatteryLevelAvailableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBatteryLevelAvailableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ContentCatalogPercentCompleted
	{
		[Export("contentCatalogPercentCompleted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selContentCatalogPercentCompletedHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selContentCatalogPercentCompletedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraItem[]? Contents
	{
		[Export("contents")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ICCameraItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentsHandle));
			}
			return NSArray.ArrayFromHandle<ICCameraItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAccessRestrictedAppleDevice
	{
		[Export("isAccessRestrictedAppleDevice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAccessRestrictedAppleDeviceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAccessRestrictedAppleDeviceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraItem[]? MediaFiles
	{
		[Export("mediaFiles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ICCameraItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaFilesHandle));
			}
			return NSArray.ArrayFromHandle<ICCameraItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaFilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? MountPoint
	{
		[Export("mountPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMountPointHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMountPointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TetheredCaptureEnabled
	{
		[Export("tetheredCaptureEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTetheredCaptureEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTetheredCaptureEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeOffset
	{
		[Export("timeOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICCameraDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICCameraDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelDelete")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelDelete()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelDeleteHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelDeleteHandle);
		}
	}

	[Export("cancelDownload")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelDownload()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelDownloadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelDownloadHandle);
		}
	}

	[Export("filesOfType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? GetFiles(string fileUTType)
	{
		if (fileUTType == null)
		{
			throw new ArgumentNullException("fileUTType");
		}
		IntPtr arg = NSString.CreateNative(fileUTType);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFilesOfType_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFilesOfType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("requestDeleteFiles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestDeleteFiles(ICCameraItem[] files)
	{
		if (files == null)
		{
			throw new ArgumentNullException("files");
		}
		NSArray nSArray = NSArray.FromNSObjects(files);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRequestDeleteFiles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRequestDeleteFiles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("requestDisableTethering")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestDisableTethering()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestDisableTetheringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestDisableTetheringHandle);
		}
	}

	[Export("requestDownloadFile:options:downloadDelegate:didDownloadSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestDownloadFile(ICCameraFile file, NSDictionary<NSString, NSObject>? options, IICCameraDeviceDownloadDelegate downloadDelegate, Selector didDownloadSelector, IntPtr contextInfo)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		if (downloadDelegate == null)
		{
			throw new ArgumentNullException("downloadDelegate");
		}
		if (didDownloadSelector == null)
		{
			throw new ArgumentNullException("didDownloadSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_Handle, file.Handle, options?.Handle ?? IntPtr.Zero, downloadDelegate.Handle, didDownloadSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestDownloadFile_Options_DownloadDelegate_DidDownloadSelector_ContextInfo_Handle, file.Handle, options?.Handle ?? IntPtr.Zero, downloadDelegate.Handle, didDownloadSelector.Handle, contextInfo);
		}
	}

	[Export("requestEnableTethering")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestEnableTethering()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestEnableTetheringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestEnableTetheringHandle);
		}
	}

	[Export("requestReadDataFromFile:atOffset:length:readDelegate:didReadDataSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestReadDataFromFile(ICCameraFile file, long offset, long length, NSObject readDelegate, Selector didReadDataSelector, IntPtr contextInfo)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		if (readDelegate == null)
		{
			throw new ArgumentNullException("readDelegate");
		}
		if (didReadDataSelector == null)
		{
			throw new ArgumentNullException("didReadDataSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_Handle, file.Handle, offset, length, readDelegate.Handle, didReadDataSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestReadDataFromFile_AtOffset_Length_ReadDelegate_DidReadDataSelector_ContextInfo_Handle, file.Handle, offset, length, readDelegate.Handle, didReadDataSelector.Handle, contextInfo);
		}
	}

	[Export("requestSendPTPCommand:outData:sendCommandDelegate:didSendCommandSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestSendPtpCommand(NSData command, NSData outData, NSObject sendCommandDelegate, Selector didSendCommandSelector, IntPtr contextInfo)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		if (outData == null)
		{
			throw new ArgumentNullException("outData");
		}
		if (sendCommandDelegate == null)
		{
			throw new ArgumentNullException("sendCommandDelegate");
		}
		if (didSendCommandSelector == null)
		{
			throw new ArgumentNullException("didSendCommandSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_Handle, command.Handle, outData.Handle, sendCommandDelegate.Handle, didSendCommandSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestSendPTPCommand_OutData_SendCommandDelegate_DidSendCommandSelector_ContextInfo_Handle, command.Handle, outData.Handle, sendCommandDelegate.Handle, didSendCommandSelector.Handle, contextInfo);
		}
	}

	[Export("requestSyncClock")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestSyncClock()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestSyncClockHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestSyncClockHandle);
		}
	}

	[Export("requestTakePicture")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestTakePicture()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRequestTakePictureHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRequestTakePictureHandle);
		}
	}

	[Export("requestUploadFile:options:uploadDelegate:didUploadSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RequestUploadFile(NSUrl fileUrl, NSDictionary<NSString, NSObject>? options, NSObject uploadDelegate, Selector didUploadSelector, IntPtr contextInfo)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (uploadDelegate == null)
		{
			throw new ArgumentNullException("uploadDelegate");
		}
		if (didUploadSelector == null)
		{
			throw new ArgumentNullException("didUploadSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_Handle, fileUrl.Handle, options?.Handle ?? IntPtr.Zero, uploadDelegate.Handle, didUploadSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestUploadFile_Options_UploadDelegate_DidUploadSelector_ContextInfo_Handle, fileUrl.Handle, options?.Handle ?? IntPtr.Zero, uploadDelegate.Handle, didUploadSelector.Handle, contextInfo);
		}
	}
}
