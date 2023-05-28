using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAsynchronousCIImageFilteringRequest", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVAsynchronousCIImageFilteringRequest : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionTime = "compositionTime";

	private static readonly IntPtr selCompositionTimeHandle = Selector.GetHandle("compositionTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishWithError_ = "finishWithError:";

	private static readonly IntPtr selFinishWithError_Handle = Selector.GetHandle("finishWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishWithImage_Context_ = "finishWithImage:context:";

	private static readonly IntPtr selFinishWithImage_Context_Handle = Selector.GetHandle("finishWithImage:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderSize = "renderSize";

	private static readonly IntPtr selRenderSizeHandle = Selector.GetHandle("renderSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceImage = "sourceImage";

	private static readonly IntPtr selSourceImageHandle = Selector.GetHandle("sourceImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAsynchronousCIImageFilteringRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime CompositionTime
	{
		[Export("compositionTime")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCompositionTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCompositionTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize RenderSize
	{
		[Export("renderSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selRenderSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selRenderSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage SourceImage
	{
		[Export("sourceImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceImageHandle));
			}
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAsynchronousCIImageFilteringRequest()
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
	protected AVAsynchronousCIImageFilteringRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAsynchronousCIImageFilteringRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("finishWithImage:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finish(CIImage filteredImage, CIContext? context)
	{
		if (filteredImage == null)
		{
			throw new ArgumentNullException("filteredImage");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFinishWithImage_Context_Handle, filteredImage.Handle, context?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFinishWithImage_Context_Handle, filteredImage.Handle, context?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("finishWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finish(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishWithError_Handle, error.Handle);
		}
	}
}
