using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHImageRequestOptions", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHImageRequestOptions : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeliveryMode = "deliveryMode";

	private static readonly IntPtr selDeliveryModeHandle = Selector.GetHandle("deliveryMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNetworkAccessAllowed = "isNetworkAccessAllowed";

	private static readonly IntPtr selIsNetworkAccessAllowedHandle = Selector.GetHandle("isNetworkAccessAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSynchronous = "isSynchronous";

	private static readonly IntPtr selIsSynchronousHandle = Selector.GetHandle("isSynchronous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalizedCropRect = "normalizedCropRect";

	private static readonly IntPtr selNormalizedCropRectHandle = Selector.GetHandle("normalizedCropRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgressHandler = "progressHandler";

	private static readonly IntPtr selProgressHandlerHandle = Selector.GetHandle("progressHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizeMode = "resizeMode";

	private static readonly IntPtr selResizeModeHandle = Selector.GetHandle("resizeMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeliveryMode_ = "setDeliveryMode:";

	private static readonly IntPtr selSetDeliveryMode_Handle = Selector.GetHandle("setDeliveryMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNetworkAccessAllowed_ = "setNetworkAccessAllowed:";

	private static readonly IntPtr selSetNetworkAccessAllowed_Handle = Selector.GetHandle("setNetworkAccessAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNormalizedCropRect_ = "setNormalizedCropRect:";

	private static readonly IntPtr selSetNormalizedCropRect_Handle = Selector.GetHandle("setNormalizedCropRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProgressHandler_ = "setProgressHandler:";

	private static readonly IntPtr selSetProgressHandler_Handle = Selector.GetHandle("setProgressHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResizeMode_ = "setResizeMode:";

	private static readonly IntPtr selSetResizeMode_Handle = Selector.GetHandle("setResizeMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSynchronous_ = "setSynchronous:";

	private static readonly IntPtr selSetSynchronous_Handle = Selector.GetHandle("setSynchronous:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVersion_ = "setVersion:";

	private static readonly IntPtr selSetVersion_Handle = Selector.GetHandle("setVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersion = "version";

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHImageRequestOptions");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHImageRequestOptionsDeliveryMode DeliveryMode
	{
		[Export("deliveryMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHImageRequestOptionsDeliveryMode)Messaging.Int64_objc_msgSend(base.Handle, selDeliveryModeHandle);
			}
			return (PHImageRequestOptionsDeliveryMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDeliveryModeHandle);
		}
		[Export("setDeliveryMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDeliveryMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDeliveryMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool NetworkAccessAllowed
	{
		[Export("isNetworkAccessAllowed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsNetworkAccessAllowedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsNetworkAccessAllowedHandle);
		}
		[Export("setNetworkAccessAllowed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNetworkAccessAllowed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNetworkAccessAllowed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect NormalizedCropRect
	{
		[Export("normalizedCropRect", ArgumentSemantic.Assign)]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selNormalizedCropRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selNormalizedCropRectHandle);
			}
			return retval;
		}
		[Export("setNormalizedCropRect:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetNormalizedCropRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetNormalizedCropRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual PHAssetImageProgressHandler? ProgressHandler
	{
		[Export("progressHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDPHAssetImageProgressHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selProgressHandlerHandle));
			return Trampolines.NIDPHAssetImageProgressHandler.Create(block);
		}
		[Export("setProgressHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDPHAssetImageProgressHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDPHAssetImageProgressHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProgressHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProgressHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHImageRequestOptionsResizeMode ResizeMode
	{
		[Export("resizeMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHImageRequestOptionsResizeMode)Messaging.Int64_objc_msgSend(base.Handle, selResizeModeHandle);
			}
			return (PHImageRequestOptionsResizeMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selResizeModeHandle);
		}
		[Export("setResizeMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetResizeMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetResizeMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Synchronous
	{
		[Export("isSynchronous")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSynchronousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSynchronousHandle);
		}
		[Export("setSynchronous:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSynchronous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSynchronous_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHImageRequestOptionsVersion Version
	{
		[Export("version", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHImageRequestOptionsVersion)Messaging.Int64_objc_msgSend(base.Handle, selVersionHandle);
			}
			return (PHImageRequestOptionsVersion)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
		}
		[Export("setVersion:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetVersion_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetVersion_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHImageRequestOptions()
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
	protected PHImageRequestOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHImageRequestOptions(IntPtr handle)
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
}
