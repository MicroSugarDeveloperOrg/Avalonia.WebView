using System.ComponentModel;
using AudioToolbox;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVAudioCompressedBuffer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVAudioCompressedBuffer : AVAudioBuffer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selByteCapacity = "byteCapacity";

	private static readonly IntPtr selByteCapacityHandle = Selector.GetHandle("byteCapacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selByteLength = "byteLength";

	private static readonly IntPtr selByteLengthHandle = Selector.GetHandle("byteLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFormat_PacketCapacity_ = "initWithFormat:packetCapacity:";

	private static readonly IntPtr selInitWithFormat_PacketCapacity_Handle = Selector.GetHandle("initWithFormat:packetCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFormat_PacketCapacity_MaximumPacketSize_ = "initWithFormat:packetCapacity:maximumPacketSize:";

	private static readonly IntPtr selInitWithFormat_PacketCapacity_MaximumPacketSize_Handle = Selector.GetHandle("initWithFormat:packetCapacity:maximumPacketSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumPacketSize = "maximumPacketSize";

	private static readonly IntPtr selMaximumPacketSizeHandle = Selector.GetHandle("maximumPacketSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPacketCapacity = "packetCapacity";

	private static readonly IntPtr selPacketCapacityHandle = Selector.GetHandle("packetCapacity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPacketCount = "packetCount";

	private static readonly IntPtr selPacketCountHandle = Selector.GetHandle("packetCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPacketDescriptions = "packetDescriptions";

	private static readonly IntPtr selPacketDescriptionsHandle = Selector.GetHandle("packetDescriptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetByteLength_ = "setByteLength:";

	private static readonly IntPtr selSetByteLength_Handle = Selector.GetHandle("setByteLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPacketCount_ = "setPacketCount:";

	private static readonly IntPtr selSetPacketCount_Handle = Selector.GetHandle("setPacketCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioCompressedBuffer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual uint ByteCapacity
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("byteCapacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selByteCapacityHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selByteCapacityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual uint ByteLength
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("byteLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selByteLengthHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selByteLengthHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setByteLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetByteLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetByteLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumPacketSize
	{
		[Export("maximumPacketSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumPacketSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumPacketSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint PacketCapacity
	{
		[Export("packetCapacity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selPacketCapacityHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selPacketCapacityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint PacketCount
	{
		[Export("packetCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selPacketCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selPacketCountHandle);
		}
		[Export("setPacketCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetPacketCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetPacketCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AudioStreamPacketDescription PacketDescriptions
	{
		[Export("packetDescriptions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AudioStreamPacketDescription_objc_msgSend(base.Handle, selPacketDescriptionsHandle);
			}
			return Messaging.AudioStreamPacketDescription_objc_msgSendSuper(base.SuperHandle, selPacketDescriptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioCompressedBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioCompressedBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFormat:packetCapacity:maximumPacketSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioCompressedBuffer(AVAudioFormat format, uint packetCapacity, nint maximumPacketSize)
		: base(NSObjectFlag.Empty)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_nint(base.Handle, selInitWithFormat_PacketCapacity_MaximumPacketSize_Handle, format.Handle, packetCapacity, maximumPacketSize), "initWithFormat:packetCapacity:maximumPacketSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_nint(base.SuperHandle, selInitWithFormat_PacketCapacity_MaximumPacketSize_Handle, format.Handle, packetCapacity, maximumPacketSize), "initWithFormat:packetCapacity:maximumPacketSize:");
		}
	}

	[Export("initWithFormat:packetCapacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioCompressedBuffer(AVAudioFormat format, uint packetCapacity)
		: base(NSObjectFlag.Empty)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt32(base.Handle, selInitWithFormat_PacketCapacity_Handle, format.Handle, packetCapacity), "initWithFormat:packetCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selInitWithFormat_PacketCapacity_Handle, format.Handle, packetCapacity), "initWithFormat:packetCapacity:");
		}
	}
}
