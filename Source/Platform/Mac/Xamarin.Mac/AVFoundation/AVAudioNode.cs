using System.ComponentModel;
using AudioUnit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAUAudioUnit = "AUAudioUnit";

	private static readonly IntPtr selAUAudioUnitHandle = Selector.GetHandle("AUAudioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEngine = "engine";

	private static readonly IntPtr selEngineHandle = Selector.GetHandle("engine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputFormatForBus_ = "inputFormatForBus:";

	private static readonly IntPtr selInputFormatForBus_Handle = Selector.GetHandle("inputFormatForBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstallTapOnBus_BufferSize_Format_Block_ = "installTapOnBus:bufferSize:format:block:";

	private static readonly IntPtr selInstallTapOnBus_BufferSize_Format_Block_Handle = Selector.GetHandle("installTapOnBus:bufferSize:format:block:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastRenderTime = "lastRenderTime";

	private static readonly IntPtr selLastRenderTimeHandle = Selector.GetHandle("lastRenderTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLatency = "latency";

	private static readonly IntPtr selLatencyHandle = Selector.GetHandle("latency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameForInputBus_ = "nameForInputBus:";

	private static readonly IntPtr selNameForInputBus_Handle = Selector.GetHandle("nameForInputBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameForOutputBus_ = "nameForOutputBus:";

	private static readonly IntPtr selNameForOutputBus_Handle = Selector.GetHandle("nameForOutputBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfInputs = "numberOfInputs";

	private static readonly IntPtr selNumberOfInputsHandle = Selector.GetHandle("numberOfInputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfOutputs = "numberOfOutputs";

	private static readonly IntPtr selNumberOfOutputsHandle = Selector.GetHandle("numberOfOutputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFormatForBus_ = "outputFormatForBus:";

	private static readonly IntPtr selOutputFormatForBus_Handle = Selector.GetHandle("outputFormatForBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputPresentationLatency = "outputPresentationLatency";

	private static readonly IntPtr selOutputPresentationLatencyHandle = Selector.GetHandle("outputPresentationLatency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveTapOnBus_ = "removeTapOnBus:";

	private static readonly IntPtr selRemoveTapOnBus_Handle = Selector.GetHandle("removeTapOnBus:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual AUAudioUnit AUAudioUnit
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("AUAudioUnit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSend(base.Handle, selAUAudioUnitHandle));
			}
			return Runtime.GetNSObject<AUAudioUnit>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAUAudioUnitHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioEngine? Engine
	{
		[Export("engine")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioEngine>(Messaging.IntPtr_objc_msgSend(base.Handle, selEngineHandle));
			}
			return Runtime.GetNSObject<AVAudioEngine>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEngineHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioTime? LastRenderTime
	{
		[Export("lastRenderTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastRenderTimeHandle));
			}
			return Runtime.GetNSObject<AVAudioTime>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastRenderTimeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual double Latency
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("latency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selLatencyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selLatencyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfInputs
	{
		[Export("numberOfInputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfInputsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfInputsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfOutputs
	{
		[Export("numberOfOutputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfOutputsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfOutputsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual double OutputPresentationLatency
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("outputPresentationLatency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selOutputPresentationLatencyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selOutputPresentationLatencyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("inputFormatForBus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat GetBusInputFormat(nuint bus)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInputFormatForBus_Handle, bus));
		}
		return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInputFormatForBus_Handle, bus));
	}

	[Export("outputFormatForBus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat GetBusOutputFormat(nuint bus)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selOutputFormatForBus_Handle, bus));
		}
		return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selOutputFormatForBus_Handle, bus));
	}

	[Export("nameForInputBus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetNameForInputBus(nuint bus)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selNameForInputBus_Handle, bus));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selNameForInputBus_Handle, bus));
	}

	[Export("nameForOutputBus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetNameForOutputBus(nuint bus)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selNameForOutputBus_Handle, bus));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selNameForOutputBus_Handle, bus));
	}

	[Export("installTapOnBus:bufferSize:format:block:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void InstallTapOnBus(nuint bus, uint bufferSize, AVAudioFormat? format, [BlockProxy(typeof(Trampolines.NIDAVAudioNodeTapBlock))] AVAudioNodeTapBlock tapBlock)
	{
		if (tapBlock == null)
		{
			throw new ArgumentNullException("tapBlock");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVAudioNodeTapBlock.Handler, tapBlock);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_UInt32_IntPtr_IntPtr(base.Handle, selInstallTapOnBus_BufferSize_Format_Block_Handle, bus, bufferSize, (format == null) ? IntPtr.Zero : format.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_UInt32_IntPtr_IntPtr(base.SuperHandle, selInstallTapOnBus_BufferSize_Format_Block_Handle, bus, bufferSize, (format == null) ? IntPtr.Zero : format.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("removeTapOnBus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveTapOnBus(nuint bus)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selRemoveTapOnBus_Handle, bus);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selRemoveTapOnBus_Handle, bus);
		}
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}
}
