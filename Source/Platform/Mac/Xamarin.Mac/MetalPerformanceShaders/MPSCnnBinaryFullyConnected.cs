using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBinaryFullyConnected", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnBinaryFullyConnected : MPSCnnBinaryConvolution
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ConvolutionData_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_ = "initWithDevice:convolutionData:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:";

	private static readonly IntPtr selInitWithDevice_ConvolutionData_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle = Selector.GetHandle("initWithDevice:convolutionData:outputBiasTerms:outputScaleTerms:inputBiasTerms:inputScaleTerms:type:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ConvolutionData_ScaleValue_Type_Flags_ = "initWithDevice:convolutionData:scaleValue:type:flags:";

	private static readonly IntPtr selInitWithDevice_ConvolutionData_ScaleValue_Type_Flags_Handle = Selector.GetHandle("initWithDevice:convolutionData:scaleValue:type:flags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBinaryFullyConnected");

	public override IntPtr ClassHandle => class_ptr;

	public unsafe MPSCnnBinaryFullyConnected(IMTLDevice device, IMPSCnnConvolutionDataSource convolutionData, float[] outputBiasTerms, float[] outputScaleTerms, float[] inputBiasTerms, float[] inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
		: base(NSObjectFlag.Empty)
	{
		fixed (float* ptr = outputBiasTerms)
		{
			void* ptr2 = ptr;
			fixed (float* ptr3 = outputScaleTerms)
			{
				void* ptr4 = ptr3;
				fixed (float* ptr5 = inputBiasTerms)
				{
					void* ptr6 = ptr5;
					fixed (float* ptr7 = inputScaleTerms)
					{
						void* ptr8 = ptr7;
						InitializeHandle(InitWithDevice(device, convolutionData, (IntPtr)ptr2, (IntPtr)ptr4, (IntPtr)ptr6, (IntPtr)ptr8, type, flags));
					}
				}
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnBinaryFullyConnected(NSCoder coder)
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
	protected MPSCnnBinaryFullyConnected(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBinaryFullyConnected(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:convolutionData:scaleValue:type:flags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBinaryFullyConnected(IMTLDevice device, IMPSCnnConvolutionDataSource convolutionData, float scaleValue, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (convolutionData == null)
		{
			throw new ArgumentNullException("convolutionData");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float_UInt64_UInt64(base.Handle, selInitWithDevice_ConvolutionData_ScaleValue_Type_Flags_Handle, device.Handle, convolutionData.Handle, scaleValue, (ulong)type, (ulong)flags), "initWithDevice:convolutionData:scaleValue:type:flags:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_float_UInt64_UInt64(base.SuperHandle, selInitWithDevice_ConvolutionData_ScaleValue_Type_Flags_Handle, device.Handle, convolutionData.Handle, scaleValue, (ulong)type, (ulong)flags), "initWithDevice:convolutionData:scaleValue:type:flags:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBinaryFullyConnected(NSCoder aDecoder, IMTLDevice device)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new IntPtr InitWithDevice(IMTLDevice device, IMPSCnnConvolutionDataSource convolutionData, IntPtr outputBiasTerms, IntPtr outputScaleTerms, IntPtr inputBiasTerms, IntPtr inputScaleTerms, MPSCnnBinaryConvolutionType type, MPSCnnBinaryConvolutionFlags flags)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (convolutionData == null)
		{
			throw new ArgumentNullException("convolutionData");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_UInt64_UInt64(base.Handle, selInitWithDevice_ConvolutionData_OutputBiasTerms_OutputScaleTerms_InputBiasTerms_InputScaleTerms_Type_Flags_Handle, device.Handle, convolutionData.Handle, outputBiasTerms, outputScaleTerms, inputBiasTerms, inputScaleTerms, (ulong)type, (ulong)flags);
	}
}
