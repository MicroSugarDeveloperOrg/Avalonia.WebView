using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHContentEditingInputRequestOptions", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHContentEditingInputRequestOptions : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanHandleAdjustmentData = "canHandleAdjustmentData";

	private static readonly IntPtr selCanHandleAdjustmentDataHandle = Selector.GetHandle("canHandleAdjustmentData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNetworkAccessAllowed = "isNetworkAccessAllowed";

	private static readonly IntPtr selIsNetworkAccessAllowedHandle = Selector.GetHandle("isNetworkAccessAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgressHandler = "progressHandler";

	private static readonly IntPtr selProgressHandlerHandle = Selector.GetHandle("progressHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanHandleAdjustmentData_ = "setCanHandleAdjustmentData:";

	private static readonly IntPtr selSetCanHandleAdjustmentData_Handle = Selector.GetHandle("setCanHandleAdjustmentData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNetworkAccessAllowed_ = "setNetworkAccessAllowed:";

	private static readonly IntPtr selSetNetworkAccessAllowed_Handle = Selector.GetHandle("setNetworkAccessAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProgressHandler_ = "setProgressHandler:";

	private static readonly IntPtr selSetProgressHandler_Handle = Selector.GetHandle("setProgressHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHContentEditingInputRequestOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CancelledKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _InputErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ResultIsInCloudKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Func<PHAdjustmentData, bool> CanHandleAdjustmentData
	{
		[Export("canHandleAdjustmentData", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDFuncArity2V4))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCanHandleAdjustmentDataHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCanHandleAdjustmentDataHandle));
			return Trampolines.NIDFuncArity2V4.Create(block);
		}
		[Export("setCanHandleAdjustmentData:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDFuncArity2V4))]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity2V4.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCanHandleAdjustmentData_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCanHandleAdjustmentData_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
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
	public unsafe virtual PHProgressHandler? ProgressHandler
	{
		[Export("progressHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDPHProgressHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selProgressHandlerHandle));
			return Trampolines.NIDPHProgressHandler.Create(block);
		}
		[Export("setProgressHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDPHProgressHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDPHProgressHandler.Handler, value);
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

	[Field("PHContentEditingInputCancelledKey", "Photos")]
	public static NSString CancelledKey
	{
		get
		{
			if (_CancelledKey == null)
			{
				_CancelledKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHContentEditingInputCancelledKey");
			}
			return _CancelledKey;
		}
	}

	[Field("PHContentEditingInputErrorKey", "Photos")]
	public static NSString InputErrorKey
	{
		get
		{
			if (_InputErrorKey == null)
			{
				_InputErrorKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHContentEditingInputErrorKey");
			}
			return _InputErrorKey;
		}
	}

	[Field("PHContentEditingInputResultIsInCloudKey", "Photos")]
	public static NSString ResultIsInCloudKey
	{
		get
		{
			if (_ResultIsInCloudKey == null)
			{
				_ResultIsInCloudKey = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHContentEditingInputResultIsInCloudKey");
			}
			return _ResultIsInCloudKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHContentEditingInputRequestOptions()
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
	protected PHContentEditingInputRequestOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHContentEditingInputRequestOptions(IntPtr handle)
		: base(handle)
	{
	}
}
