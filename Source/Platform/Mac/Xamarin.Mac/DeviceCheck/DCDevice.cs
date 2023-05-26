using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace DeviceCheck;

[Register("DCDevice", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class DCDevice : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDevice = "currentDevice";

	private static readonly IntPtr selCurrentDeviceHandle = Selector.GetHandle("currentDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateTokenWithCompletionHandler_ = "generateTokenWithCompletionHandler:";

	private static readonly IntPtr selGenerateTokenWithCompletionHandler_Handle = Selector.GetHandle("generateTokenWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSupported = "isSupported";

	private static readonly IntPtr selIsSupportedHandle = Selector.GetHandle("isSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DCDevice");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static DCDevice CurrentDevice
	{
		[Export("currentDevice")]
		get
		{
			return Runtime.GetNSObject<DCDevice>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentDeviceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Supported
	{
		[Export("isSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSupportedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DCDevice(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DCDevice(IntPtr handle)
		: base(handle)
	{
	}

	[Export("generateTokenWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GenerateToken([BlockProxy(typeof(Trampolines.NIDDCDeviceGenerateTokenCompletionHandler))] DCDeviceGenerateTokenCompletionHandler completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDDCDeviceGenerateTokenCompletionHandler.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGenerateTokenWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGenerateTokenWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> GenerateTokenAsync()
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		GenerateToken(delegate(NSData? token_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(token_);
			}
		});
		return tcs.Task;
	}
}
