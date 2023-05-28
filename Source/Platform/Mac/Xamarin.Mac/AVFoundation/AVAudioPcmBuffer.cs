using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioPCMBuffer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioPcmBuffer : AVAudioBuffer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatChannelData = "floatChannelData";

	private static readonly IntPtr selFloatChannelDataHandle = Selector.GetHandle("floatChannelData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameCapacity = "frameCapacity";

	private static readonly IntPtr selFrameCapacityHandle = Selector.GetHandle("frameCapacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameLength = "frameLength";

	private static readonly IntPtr selFrameLengthHandle = Selector.GetHandle("frameLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPCMFormat_FrameCapacity_ = "initWithPCMFormat:frameCapacity:";

	private static readonly IntPtr selInitWithPCMFormat_FrameCapacity_Handle = Selector.GetHandle("initWithPCMFormat:frameCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInt16ChannelData = "int16ChannelData";

	private static readonly IntPtr selInt16ChannelDataHandle = Selector.GetHandle("int16ChannelData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInt32ChannelData = "int32ChannelData";

	private static readonly IntPtr selInt32ChannelDataHandle = Selector.GetHandle("int32ChannelData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameLength_ = "setFrameLength:";

	private static readonly IntPtr selSetFrameLength_Handle = Selector.GetHandle("setFrameLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStride = "stride";

	private static readonly IntPtr selStrideHandle = Selector.GetHandle("stride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioPCMBuffer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr FloatChannelData
	{
		[Export("floatChannelData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selFloatChannelDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFloatChannelDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint FrameCapacity
	{
		[Export("frameCapacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFrameCapacityHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFrameCapacityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint FrameLength
	{
		[Export("frameLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selFrameLengthHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selFrameLengthHandle);
		}
		[Export("setFrameLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetFrameLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetFrameLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Int16ChannelData
	{
		[Export("int16ChannelData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selInt16ChannelDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInt16ChannelDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Int32ChannelData
	{
		[Export("int32ChannelData")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selInt32ChannelDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInt32ChannelDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Stride
	{
		[Export("stride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioPcmBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioPcmBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPCMFormat:frameCapacity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioPcmBuffer(AVAudioFormat format, uint frameCapacity)
		: base(NSObjectFlag.Empty)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt32(base.Handle, selInitWithPCMFormat_FrameCapacity_Handle, format.Handle, frameCapacity), "initWithPCMFormat:frameCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selInitWithPCMFormat_FrameCapacity_Handle, format.Handle, frameCapacity), "initWithPCMFormat:frameCapacity:");
		}
	}
}
