using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICCameraFile", true)]
public class ICCameraFile : ICCameraItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileSize = "fileSize";

	private static readonly IntPtr selFileSizeHandle = Selector.GetHandle("fileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientation = "orientation";

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientation_ = "setOrientation:";

	private static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle("setOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSidecarFiles = "sidecarFiles";

	private static readonly IntPtr selSidecarFilesHandle = Selector.GetHandle("sidecarFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICCameraFile");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration
	{
		[Export("duration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long FileSize
	{
		[Export("fileSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFileSizeHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFileSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICExifOrientationType Orientation
	{
		[Export("orientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICExifOrientationType)Messaging.UInt64_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (ICExifOrientationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
		[Export("setOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOrientation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraItem[] SidecarFiles
	{
		[Export("sidecarFiles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ICCameraItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSidecarFilesHandle));
			}
			return NSArray.ArrayFromHandle<ICCameraItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSidecarFilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICCameraFile(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICCameraFile(IntPtr handle)
		: base(handle)
	{
	}
}
