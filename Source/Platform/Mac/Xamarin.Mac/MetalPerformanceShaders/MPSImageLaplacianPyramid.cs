using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSImageLaplacianPyramid", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSImageLaplacianPyramid : MPSImagePyramid
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetLaplacianBias = "getLaplacianBias";

	private static readonly IntPtr selGetLaplacianBiasHandle = Selector.GetHandle("getLaplacianBias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetLaplacianScale = "getLaplacianScale";

	private static readonly IntPtr selGetLaplacianScaleHandle = Selector.GetHandle("getLaplacianScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_CenterWeight_ = "initWithDevice:centerWeight:";

	private static readonly IntPtr selInitWithDevice_CenterWeight_Handle = Selector.GetHandle("initWithDevice:centerWeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_KernelWidth_KernelHeight_Weights_ = "initWithDevice:kernelWidth:kernelHeight:weights:";

	private static readonly IntPtr selInitWithDevice_KernelWidth_KernelHeight_Weights_Handle = Selector.GetHandle("initWithDevice:kernelWidth:kernelHeight:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLaplacianBias_ = "setLaplacianBias:";

	private static readonly IntPtr selSetLaplacianBias_Handle = Selector.GetHandle("setLaplacianBias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLaplacianScale_ = "setLaplacianScale:";

	private static readonly IntPtr selSetLaplacianScale_Handle = Selector.GetHandle("setLaplacianScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageLaplacianPyramid");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LaplacianBias
	{
		[Export("getLaplacianBias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGetLaplacianBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGetLaplacianBiasHandle);
		}
		[Export("setLaplacianBias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLaplacianBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLaplacianBias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LaplacianScale
	{
		[Export("getLaplacianScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selGetLaplacianScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selGetLaplacianScaleHandle);
		}
		[Export("setLaplacianScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLaplacianScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLaplacianScale_Handle, value);
			}
		}
	}

	[DesignatedInitializer]
	public unsafe MPSImageLaplacianPyramid(IMTLDevice device, nuint kernelWidth, nuint kernelHeight, float[] kernelWeights)
		: base(NSObjectFlag.Empty)
	{
		if (kernelWeights == null)
		{
			throw new ArgumentNullException("kernelWeights");
		}
		if ((nuint)kernelWeights.Length < kernelWidth * kernelHeight)
		{
			throw new ArgumentException("'kernelWeights' size must be at least 'kernelWidth' * 'kernelHeight'.");
		}
		fixed (float* ptr = kernelWeights)
		{
			InitializeHandle(InitWithDevice(device, kernelWidth, kernelHeight, (IntPtr)ptr), "initWithDevice:kernelWidth:kernelHeight:weights:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageLaplacianPyramid(NSCoder coder)
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
	protected MPSImageLaplacianPyramid(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageLaplacianPyramid(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageLaplacianPyramid(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageLaplacianPyramid(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("initWithDevice:centerWeight:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageLaplacianPyramid(IMTLDevice device, float centerWeight)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float(base.Handle, selInitWithDevice_CenterWeight_Handle, device.Handle, centerWeight), "initWithDevice:centerWeight:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selInitWithDevice_CenterWeight_Handle, device.Handle, centerWeight), "initWithDevice:centerWeight:");
		}
	}

	[Export("initWithDevice:kernelWidth:kernelHeight:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual IntPtr InitWithDevice(IMTLDevice device, nuint kernelWidth, nuint kernelHeight, IntPtr kernelWeights)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_IntPtr(base.Handle, selInitWithDevice_KernelWidth_KernelHeight_Weights_Handle, device.Handle, kernelWidth, kernelHeight, kernelWeights);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_IntPtr(base.SuperHandle, selInitWithDevice_KernelWidth_KernelHeight_Weights_Handle, device.Handle, kernelWidth, kernelHeight, kernelWeights);
	}
}
