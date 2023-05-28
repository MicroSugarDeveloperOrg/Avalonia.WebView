using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLookThumbnailing;

[Register("QLFileThumbnailRequest", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class QLFileThumbnailRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURL = "fileURL";

	private static readonly IntPtr selFileURLHandle = Selector.GetHandle("fileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumSize = "maximumSize";

	private static readonly IntPtr selMaximumSizeHandle = Selector.GetHandle("maximumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumSize = "minimumSize";

	private static readonly IntPtr selMinimumSizeHandle = Selector.GetHandle("minimumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScale = "scale";

	private static readonly IntPtr selScaleHandle = Selector.GetHandle("scale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QLFileThumbnailRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl FileUrl
	{
		[Export("fileURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MaximumSize
	{
		[Export("maximumSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MinimumSize
	{
		[Export("minimumSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinimumSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinimumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Scale
	{
		[Export("scale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selScaleHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScaleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QLFileThumbnailRequest()
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
	protected QLFileThumbnailRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLFileThumbnailRequest(IntPtr handle)
		: base(handle)
	{
	}
}
