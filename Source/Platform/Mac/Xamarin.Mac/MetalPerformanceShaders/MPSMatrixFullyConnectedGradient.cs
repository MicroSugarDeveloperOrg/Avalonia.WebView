using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixFullyConnectedGradient", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSMatrixFullyConnectedGradient : MPSMatrixBinaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeGradientForDataToCommandBuffer_GradientMatrix_WeightMatrix_ResultGradientForDataMatrix_ = "encodeGradientForDataToCommandBuffer:gradientMatrix:weightMatrix:resultGradientForDataMatrix:";

	private static readonly IntPtr selEncodeGradientForDataToCommandBuffer_GradientMatrix_WeightMatrix_ResultGradientForDataMatrix_Handle = Selector.GetHandle("encodeGradientForDataToCommandBuffer:gradientMatrix:weightMatrix:resultGradientForDataMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeGradientForWeightsAndBiasToCommandBuffer_GradientMatrix_InputMatrix_ResultGradientForWeightMatrix_ResultGradientForBiasVector_ = "encodeGradientForWeightsAndBiasToCommandBuffer:gradientMatrix:inputMatrix:resultGradientForWeightMatrix:resultGradientForBiasVector:";

	private static readonly IntPtr selEncodeGradientForWeightsAndBiasToCommandBuffer_GradientMatrix_InputMatrix_ResultGradientForWeightMatrix_ResultGradientForBiasVector_Handle = Selector.GetHandle("encodeGradientForWeightsAndBiasToCommandBuffer:gradientMatrix:inputMatrix:resultGradientForWeightMatrix:resultGradientForBiasVector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceInputFeatureChannels_ = "setSourceInputFeatureChannels:";

	private static readonly IntPtr selSetSourceInputFeatureChannels_Handle = Selector.GetHandle("setSourceInputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceNumberOfFeatureVectors_ = "setSourceNumberOfFeatureVectors:";

	private static readonly IntPtr selSetSourceNumberOfFeatureVectors_Handle = Selector.GetHandle("setSourceNumberOfFeatureVectors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceOutputFeatureChannels_ = "setSourceOutputFeatureChannels:";

	private static readonly IntPtr selSetSourceOutputFeatureChannels_Handle = Selector.GetHandle("setSourceOutputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceInputFeatureChannels = "sourceInputFeatureChannels";

	private static readonly IntPtr selSourceInputFeatureChannelsHandle = Selector.GetHandle("sourceInputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceNumberOfFeatureVectors = "sourceNumberOfFeatureVectors";

	private static readonly IntPtr selSourceNumberOfFeatureVectorsHandle = Selector.GetHandle("sourceNumberOfFeatureVectors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceOutputFeatureChannels = "sourceOutputFeatureChannels";

	private static readonly IntPtr selSourceOutputFeatureChannelsHandle = Selector.GetHandle("sourceOutputFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixFullyConnectedGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Alpha
	{
		[Export("alpha")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceInputFeatureChannels
	{
		[Export("sourceInputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceInputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceInputFeatureChannelsHandle);
		}
		[Export("setSourceInputFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceInputFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceInputFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceNumberOfFeatureVectors
	{
		[Export("sourceNumberOfFeatureVectors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceNumberOfFeatureVectorsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceNumberOfFeatureVectorsHandle);
		}
		[Export("setSourceNumberOfFeatureVectors:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceNumberOfFeatureVectors_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceNumberOfFeatureVectors_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceOutputFeatureChannels
	{
		[Export("sourceOutputFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceOutputFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceOutputFeatureChannelsHandle);
		}
		[Export("setSourceOutputFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceOutputFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceOutputFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixFullyConnectedGradient(NSCoder coder)
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
	protected MPSMatrixFullyConnectedGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixFullyConnectedGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixFullyConnectedGradient(IMTLDevice device)
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

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixFullyConnectedGradient(NSCoder aDecoder, IMTLDevice device)
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

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSMatrixFullyConnectedGradient Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSMatrixFullyConnectedGradient mPSMatrixFullyConnectedGradient = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSMatrixFullyConnectedGradient>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSMatrixFullyConnectedGradient>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSMatrixFullyConnectedGradient != null)
		{
			Messaging.void_objc_msgSend(mPSMatrixFullyConnectedGradient.Handle, Selector.GetHandle("release"));
		}
		return mPSMatrixFullyConnectedGradient;
	}

	[Export("encodeGradientForDataToCommandBuffer:gradientMatrix:weightMatrix:resultGradientForDataMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeGradientForData(IMTLCommandBuffer commandBuffer, MPSMatrix gradientMatrix, MPSMatrix weightMatrix, MPSMatrix resultGradientForDataMatrix)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (gradientMatrix == null)
		{
			throw new ArgumentNullException("gradientMatrix");
		}
		if (weightMatrix == null)
		{
			throw new ArgumentNullException("weightMatrix");
		}
		if (resultGradientForDataMatrix == null)
		{
			throw new ArgumentNullException("resultGradientForDataMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeGradientForDataToCommandBuffer_GradientMatrix_WeightMatrix_ResultGradientForDataMatrix_Handle, commandBuffer.Handle, gradientMatrix.Handle, weightMatrix.Handle, resultGradientForDataMatrix.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeGradientForDataToCommandBuffer_GradientMatrix_WeightMatrix_ResultGradientForDataMatrix_Handle, commandBuffer.Handle, gradientMatrix.Handle, weightMatrix.Handle, resultGradientForDataMatrix.Handle);
		}
	}

	[Export("encodeGradientForWeightsAndBiasToCommandBuffer:gradientMatrix:inputMatrix:resultGradientForWeightMatrix:resultGradientForBiasVector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeGradientForWeightsAndBias(IMTLCommandBuffer commandBuffer, MPSMatrix gradientMatrix, MPSMatrix inputMatrix, MPSMatrix resultGradientForWeightMatrix, MPSVector? resultGradientForBiasVector)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (gradientMatrix == null)
		{
			throw new ArgumentNullException("gradientMatrix");
		}
		if (inputMatrix == null)
		{
			throw new ArgumentNullException("inputMatrix");
		}
		if (resultGradientForWeightMatrix == null)
		{
			throw new ArgumentNullException("resultGradientForWeightMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeGradientForWeightsAndBiasToCommandBuffer_GradientMatrix_InputMatrix_ResultGradientForWeightMatrix_ResultGradientForBiasVector_Handle, commandBuffer.Handle, gradientMatrix.Handle, inputMatrix.Handle, resultGradientForWeightMatrix.Handle, resultGradientForBiasVector?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeGradientForWeightsAndBiasToCommandBuffer_GradientMatrix_InputMatrix_ResultGradientForWeightMatrix_ResultGradientForBiasVector_Handle, commandBuffer.Handle, gradientMatrix.Handle, inputMatrix.Handle, resultGradientForWeightMatrix.Handle, resultGradientForBiasVector?.Handle ?? IntPtr.Zero);
		}
	}
}
