using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageConversion", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSImageConversion : MPSUnaryImageKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationAlpha = "destinationAlpha";

	private static readonly IntPtr selDestinationAlphaHandle = Selector.GetHandle("destinationAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_SrcAlpha_DestAlpha_BackgroundColor_ConversionInfo_ = "initWithDevice:srcAlpha:destAlpha:backgroundColor:conversionInfo:";

	private static readonly IntPtr selInitWithDevice_SrcAlpha_DestAlpha_BackgroundColor_ConversionInfo_Handle = Selector.GetHandle("initWithDevice:srcAlpha:destAlpha:backgroundColor:conversionInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceAlpha = "sourceAlpha";

	private static readonly IntPtr selSourceAlphaHandle = Selector.GetHandle("sourceAlpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageConversion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSAlphaType DestinationAlpha
	{
		[Export("destinationAlpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSAlphaType)Messaging.UInt64_objc_msgSend(base.Handle, selDestinationAlphaHandle);
			}
			return (MPSAlphaType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDestinationAlphaHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSAlphaType SourceAlpha
	{
		[Export("sourceAlpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSAlphaType)Messaging.UInt64_objc_msgSend(base.Handle, selSourceAlphaHandle);
			}
			return (MPSAlphaType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSourceAlphaHandle);
		}
	}

	public unsafe MPSImageConversion(IMTLDevice device, MPSAlphaType srcAlpha, MPSAlphaType destAlpha, nfloat[] backgroundColor, CGColorConversionInfo conversionInfo)
		: base(NSObjectFlag.Empty)
	{
		fixed (nfloat* ptr = backgroundColor)
		{
			InitializeHandle(InitWithDevice(device, srcAlpha, destAlpha, (IntPtr)ptr, conversionInfo), "initWithDevice:srcAlpha:destAlpha:backgroundColor:conversionInfo:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageConversion(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSImageConversion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageConversion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageConversion(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("initWithDevice:srcAlpha:destAlpha:backgroundColor:conversionInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithDevice(IMTLDevice device, MPSAlphaType srcAlpha, MPSAlphaType destAlpha, IntPtr backgroundColor, CGColorConversionInfo? conversionInfo)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr_IntPtr(base.Handle, selInitWithDevice_SrcAlpha_DestAlpha_BackgroundColor_ConversionInfo_Handle, device.Handle, (ulong)srcAlpha, (ulong)destAlpha, backgroundColor, conversionInfo?.Handle ?? IntPtr.Zero);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_SrcAlpha_DestAlpha_BackgroundColor_ConversionInfo_Handle, device.Handle, (ulong)srcAlpha, (ulong)destAlpha, backgroundColor, conversionInfo?.Handle ?? IntPtr.Zero);
	}
}
