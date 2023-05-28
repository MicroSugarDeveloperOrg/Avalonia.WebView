using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCapturePhotoOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
public class AVCapturePhotoOutput : AVCaptureOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailablePhotoCodecTypes = "availablePhotoCodecTypes";

	private static readonly IntPtr selAvailablePhotoCodecTypesHandle = Selector.GetHandle("availablePhotoCodecTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailablePhotoFileTypes = "availablePhotoFileTypes";

	private static readonly IntPtr selAvailablePhotoFileTypesHandle = Selector.GetHandle("availablePhotoFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailablePhotoPixelFormatTypes = "availablePhotoPixelFormatTypes";

	private static readonly IntPtr selAvailablePhotoPixelFormatTypesHandle = Selector.GetHandle("availablePhotoPixelFormatTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapturePhotoWithSettings_Delegate_ = "capturePhotoWithSettings:delegate:";

	private static readonly IntPtr selCapturePhotoWithSettings_Delegate_Handle = Selector.GetHandle("capturePhotoWithSettings:delegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedPhotoCodecTypesForFileType_ = "supportedPhotoCodecTypesForFileType:";

	private static readonly IntPtr selSupportedPhotoCodecTypesForFileType_Handle = Selector.GetHandle("supportedPhotoCodecTypesForFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedPhotoPixelFormatTypesForFileType_ = "supportedPhotoPixelFormatTypesForFileType:";

	private static readonly IntPtr selSupportedPhotoPixelFormatTypesForFileType_Handle = Selector.GetHandle("supportedPhotoPixelFormatTypesForFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCapturePhotoOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailablePhotoCodecTypes
	{
		[Export("availablePhotoCodecTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailablePhotoCodecTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailablePhotoCodecTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] AvailablePhotoPixelFormatTypes
	{
		[Export("availablePhotoPixelFormatTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailablePhotoPixelFormatTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailablePhotoPixelFormatTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public AVFileTypes[] GetAvailablePhotoFileTypes
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		get
		{
			return Array.ConvertAll(_GetAvailablePhotoFileTypes, (NSString s) => AVFileTypesExtensions.GetValue(s));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSString[] _GetAvailablePhotoFileTypes
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("availablePhotoFileTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailablePhotoFileTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailablePhotoFileTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCapturePhotoOutput()
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
	protected AVCapturePhotoOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCapturePhotoOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("capturePhotoWithSettings:delegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CapturePhoto(AVCapturePhotoSettings settings, IAVCapturePhotoCaptureDelegate cb)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (cb == null)
		{
			throw new ArgumentNullException("cb");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selCapturePhotoWithSettings_Delegate_Handle, settings.Handle, cb.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCapturePhotoWithSettings_Delegate_Handle, settings.Handle, cb.Handle);
		}
	}

	[Export("supportedPhotoPixelFormatTypesForFileType:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] GetSupportedPhotoPixelFormatTypesForFileType(string fileType)
	{
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr arg = NSString.CreateNative(fileType);
		NSNumber[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSupportedPhotoPixelFormatTypesForFileType_Handle, arg)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSupportedPhotoPixelFormatTypesForFileType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("supportedPhotoCodecTypesForFileType:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString[] _GetSupportedPhotoCodecTypesForFileType(string fileType)
	{
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		IntPtr arg = NSString.CreateNative(fileType);
		NSString[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSupportedPhotoCodecTypesForFileType_Handle, arg)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSupportedPhotoCodecTypesForFileType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
