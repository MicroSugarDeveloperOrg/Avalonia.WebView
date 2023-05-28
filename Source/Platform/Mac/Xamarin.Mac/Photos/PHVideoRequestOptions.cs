using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHVideoRequestOptions", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHVideoRequestOptions : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeliveryMode = "deliveryMode";

	private static readonly IntPtr selDeliveryModeHandle = Selector.GetHandle("deliveryMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNetworkAccessAllowed = "isNetworkAccessAllowed";

	private static readonly IntPtr selIsNetworkAccessAllowedHandle = Selector.GetHandle("isNetworkAccessAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgressHandler = "progressHandler";

	private static readonly IntPtr selProgressHandlerHandle = Selector.GetHandle("progressHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeliveryMode_ = "setDeliveryMode:";

	private static readonly IntPtr selSetDeliveryMode_Handle = Selector.GetHandle("setDeliveryMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNetworkAccessAllowed_ = "setNetworkAccessAllowed:";

	private static readonly IntPtr selSetNetworkAccessAllowed_Handle = Selector.GetHandle("setNetworkAccessAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProgressHandler_ = "setProgressHandler:";

	private static readonly IntPtr selSetProgressHandler_Handle = Selector.GetHandle("setProgressHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVersion_ = "setVersion:";

	private static readonly IntPtr selSetVersion_Handle = Selector.GetHandle("setVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVersion = "version";

	private static readonly IntPtr selVersionHandle = Selector.GetHandle("version");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHVideoRequestOptions");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHVideoRequestOptionsDeliveryMode DeliveryMode
	{
		[Export("deliveryMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHVideoRequestOptionsDeliveryMode)Messaging.Int64_objc_msgSend(base.Handle, selDeliveryModeHandle);
			}
			return (PHVideoRequestOptionsDeliveryMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDeliveryModeHandle);
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
	public unsafe virtual PHAssetVideoProgressHandler? ProgressHandler
	{
		[Export("progressHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDPHAssetVideoProgressHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selProgressHandlerHandle));
			return Trampolines.NIDPHAssetVideoProgressHandler.Create(block);
		}
		[Export("setProgressHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDPHAssetVideoProgressHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDPHAssetVideoProgressHandler.Handler, value);
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
	public virtual PHVideoRequestOptionsVersion Version
	{
		[Export("version", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHVideoRequestOptionsVersion)Messaging.Int64_objc_msgSend(base.Handle, selVersionHandle);
			}
			return (PHVideoRequestOptionsVersion)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selVersionHandle);
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
	public PHVideoRequestOptions()
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
	protected PHVideoRequestOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHVideoRequestOptions(IntPtr handle)
		: base(handle)
	{
	}
}
