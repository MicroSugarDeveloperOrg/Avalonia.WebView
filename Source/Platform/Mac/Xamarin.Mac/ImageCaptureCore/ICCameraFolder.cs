using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICCameraFolder", true)]
public class ICCameraFolder : ICCameraItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContents = "contents";

	private static readonly IntPtr selContentsHandle = Selector.GetHandle("contents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICCameraFolder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICCameraItem[] Contents
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICCameraFolder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICCameraFolder(IntPtr handle)
		: base(handle)
	{
	}
}
