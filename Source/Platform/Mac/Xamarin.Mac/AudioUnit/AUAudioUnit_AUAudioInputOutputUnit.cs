using System;
using Foundation;
using ObjCRuntime;

namespace AudioUnit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class AUAudioUnit_AUAudioInputOutputUnit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformInput = "canPerformInput";

	private static readonly IntPtr selCanPerformInputHandle = Selector.GetHandle("canPerformInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPerformOutput = "canPerformOutput";

	private static readonly IntPtr selCanPerformOutputHandle = Selector.GetHandle("canPerformOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceID = "deviceID";

	private static readonly IntPtr selDeviceIDHandle = Selector.GetHandle("deviceID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceInputLatency = "deviceInputLatency";

	private static readonly IntPtr selDeviceInputLatencyHandle = Selector.GetHandle("deviceInputLatency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceOutputLatency = "deviceOutputLatency";

	private static readonly IntPtr selDeviceOutputLatencyHandle = Selector.GetHandle("deviceOutputLatency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputHandler = "inputHandler";

	private static readonly IntPtr selInputHandlerHandle = Selector.GetHandle("inputHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInputEnabled = "isInputEnabled";

	private static readonly IntPtr selIsInputEnabledHandle = Selector.GetHandle("isInputEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOutputEnabled = "isOutputEnabled";

	private static readonly IntPtr selIsOutputEnabledHandle = Selector.GetHandle("isOutputEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputProvider = "outputProvider";

	private static readonly IntPtr selOutputProviderHandle = Selector.GetHandle("outputProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunning = "running";

	private static readonly IntPtr selRunningHandle = Selector.GetHandle("running");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDeviceID_Error_ = "setDeviceID:error:";

	private static readonly IntPtr selSetDeviceID_Error_Handle = Selector.GetHandle("setDeviceID:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputEnabled_ = "setInputEnabled:";

	private static readonly IntPtr selSetInputEnabled_Handle = Selector.GetHandle("setInputEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputHandler_ = "setInputHandler:";

	private static readonly IntPtr selSetInputHandler_Handle = Selector.GetHandle("setInputHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputEnabled_ = "setOutputEnabled:";

	private static readonly IntPtr selSetOutputEnabled_Handle = Selector.GetHandle("setOutputEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputProvider_ = "setOutputProvider:";

	private static readonly IntPtr selSetOutputProvider_Handle = Selector.GetHandle("setOutputProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartHardwareAndReturnError_ = "startHardwareAndReturnError:";

	private static readonly IntPtr selStartHardwareAndReturnError_Handle = Selector.GetHandle("startHardwareAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopHardware = "stopHardware";

	private static readonly IntPtr selStopHardwareHandle = Selector.GetHandle("stopHardware");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AUAudioUnit");

	[Export("canPerformOutput")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanPerformOutput(this AUAudioUnit This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selCanPerformOutputHandle);
	}

	[Export("canPerformInput")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetCanPerformInput(this AUAudioUnit This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selCanPerformInputHandle);
	}

	[Export("deviceID")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static uint GetDeviceId(this AUAudioUnit This)
	{
		return Messaging.UInt32_objc_msgSend(This.Handle, selDeviceIDHandle);
	}

	[Export("deviceInputLatency")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetDeviceInputLatency(this AUAudioUnit This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, selDeviceInputLatencyHandle);
	}

	[Export("deviceOutputLatency")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetDeviceOutputLatency(this AUAudioUnit This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, selDeviceOutputLatencyHandle);
	}

	[Export("inputHandler")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: DelegateProxy(typeof(Trampolines.SDAUInputHandler))]
	public static AUInputHandler? GetInputHandler(this AUAudioUnit This)
	{
		IntPtr block = Messaging.IntPtr_objc_msgSend(This.Handle, selInputHandlerHandle);
		return Trampolines.NIDAUInputHandler.Create(block);
	}

	[Export("outputProvider")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: DelegateProxy(typeof(Trampolines.SDAURenderPullInputBlock))]
	public static AURenderPullInputBlock? GetOutputProvider(this AUAudioUnit This)
	{
		IntPtr block = Messaging.IntPtr_objc_msgSend(This.Handle, selOutputProviderHandle);
		return Trampolines.NIDAURenderPullInputBlock.Create(block);
	}

	[Export("isInputEnabled")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsInputEnabled(this AUAudioUnit This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selIsInputEnabledHandle);
	}

	[Export("isOutputEnabled")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsOutputEnabled(this AUAudioUnit This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selIsOutputEnabledHandle);
	}

	[Export("running")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsRunning(this AUAudioUnit This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, selRunningHandle);
	}

	[Export("setDeviceID:error:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SetDeviceId(this AUAudioUnit This, uint deviceID, out NSError outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_UInt32_ref_IntPtr(This.Handle, selSetDeviceID_Error_Handle, deviceID, ref arg);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setInputEnabled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SetInputEnabled(this AUAudioUnit This, bool enabled)
	{
		return Messaging.bool_objc_msgSend_bool(This.Handle, selSetInputEnabled_Handle, enabled);
	}

	[Export("setInputHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void SetInputHandler(this AUAudioUnit This, [BlockProxy(typeof(Trampolines.NIDAUInputHandler))] AUInputHandler? handler)
	{
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAUInputHandler.Handler, handler);
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSetInputHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("setOutputEnabled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SetOutputEnabled(this AUAudioUnit This, bool enabled)
	{
		return Messaging.bool_objc_msgSend_bool(This.Handle, selSetOutputEnabled_Handle, enabled);
	}

	[Export("setOutputProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void SetOutputProvider(this AUAudioUnit This, [BlockProxy(typeof(Trampolines.NIDAURenderPullInputBlock))] AURenderPullInputBlock? provider)
	{
		BlockLiteral* ptr;
		if (provider == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAURenderPullInputBlock.Handler, provider);
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSetOutputProvider_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("startHardwareAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool StartHardware(this AUAudioUnit This, out NSError? outError)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_ref_IntPtr(This.Handle, selStartHardwareAndReturnError_Handle, ref arg);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("stopHardware")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void StopHardware(this AUAudioUnit This)
	{
		Messaging.void_objc_msgSend(This.Handle, selStopHardwareHandle);
	}
}
