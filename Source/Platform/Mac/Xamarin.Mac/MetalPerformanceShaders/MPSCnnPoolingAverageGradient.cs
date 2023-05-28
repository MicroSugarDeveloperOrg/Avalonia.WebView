using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNPoolingAverageGradient", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnPoolingAverageGradient : MPSCnnPoolingGradient
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_ = "initWithDevice:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:";

	private static readonly IntPtr selInitWithDevice_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_Handle = Selector.GetHandle("initWithDevice:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZeroPadSizeX_ = "setZeroPadSizeX:";

	private static readonly IntPtr selSetZeroPadSizeX_Handle = Selector.GetHandle("setZeroPadSizeX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZeroPadSizeY_ = "setZeroPadSizeY:";

	private static readonly IntPtr selSetZeroPadSizeY_Handle = Selector.GetHandle("setZeroPadSizeY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZeroPadSizeX = "zeroPadSizeX";

	private static readonly IntPtr selZeroPadSizeXHandle = Selector.GetHandle("zeroPadSizeX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZeroPadSizeY = "zeroPadSizeY";

	private static readonly IntPtr selZeroPadSizeYHandle = Selector.GetHandle("zeroPadSizeY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNPoolingAverageGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ZeroPadSizeX
	{
		[Export("zeroPadSizeX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selZeroPadSizeXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selZeroPadSizeXHandle);
		}
		[Export("setZeroPadSizeX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetZeroPadSizeX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetZeroPadSizeX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ZeroPadSizeY
	{
		[Export("zeroPadSizeY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selZeroPadSizeYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selZeroPadSizeYHandle);
		}
		[Export("setZeroPadSizeY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetZeroPadSizeY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetZeroPadSizeY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnPoolingAverageGradient(NSCoder coder)
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
	protected MPSCnnPoolingAverageGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnPoolingAverageGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingAverageGradient(IMTLDevice device, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint_nuint(base.Handle, selInitWithDevice_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_Handle, device.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY), "initWithDevice:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_nuint(base.SuperHandle, selInitWithDevice_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_Handle, device.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY), "initWithDevice:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingAverageGradient(NSCoder decoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (decoder == null)
		{
			throw new ArgumentNullException("decoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, decoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}
}
