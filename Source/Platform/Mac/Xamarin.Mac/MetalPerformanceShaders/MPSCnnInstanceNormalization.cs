using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNInstanceNormalization", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnInstanceNormalization : MPSCnnKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpsilon = "epsilon";

	private static readonly IntPtr selEpsilonHandle = Selector.GetHandle("epsilon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_DataSource_ = "initWithDevice:dataSource:";

	private static readonly IntPtr selInitWithDevice_DataSource_Handle = Selector.GetHandle("initWithDevice:dataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadDataSource_ = "reloadDataSource:";

	private static readonly IntPtr selReloadDataSource_Handle = Selector.GetHandle("reloadDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadGammaAndBetaFromDataSource = "reloadGammaAndBetaFromDataSource";

	private static readonly IntPtr selReloadGammaAndBetaFromDataSourceHandle = Selector.GetHandle("reloadGammaAndBetaFromDataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_ = "reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:";

	private static readonly IntPtr selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_Handle = Selector.GetHandle("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultStateForSourceImage_SourceStates_DestinationImage_ = "resultStateForSourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selResultStateForSourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("resultStateForSourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEpsilon_ = "setEpsilon:";

	private static readonly IntPtr selSetEpsilon_Handle = Selector.GetHandle("setEpsilon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_ = "temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:";

	private static readonly IntPtr selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle = Selector.GetHandle("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNInstanceNormalization");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnInstanceNormalizationDataSource DataSource
	{
		[Export("dataSource", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnInstanceNormalizationDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnInstanceNormalizationDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Epsilon
	{
		[Export("epsilon")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selEpsilonHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selEpsilonHandle);
		}
		[Export("setEpsilon:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetEpsilon_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetEpsilon_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnInstanceNormalization(NSCoder coder)
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
	protected MPSCnnInstanceNormalization(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnInstanceNormalization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:dataSource:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnInstanceNormalization(IMTLDevice device, IMPSCnnInstanceNormalizationDataSource dataSource)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_DataSource_Handle, device.Handle, dataSource.Handle), "initWithDevice:dataSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_DataSource_Handle, device.Handle, dataSource.Handle), "initWithDevice:dataSource:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnInstanceNormalization(NSCoder decoder, IMTLDevice device)
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

	[Export("resultStateForSourceImage:sourceStates:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnInstanceNormalizationGradientState? GetResultState(MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
	{
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSCnnInstanceNormalizationGradientState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSCnnInstanceNormalizationGradientState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResultStateForSourceImage_SourceStates_DestinationImage_Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("temporaryResultStateForCommandBuffer:sourceImage:sourceStates:destinationImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual MPSCnnInstanceNormalizationGradientState? GetTemporaryResultState(IMTLCommandBuffer commandBuffer, MPSImage sourceImage, NSArray<MPSState>? sourceStates, MPSImage destinationImage)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (destinationImage == null)
		{
			throw new ArgumentNullException("destinationImage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSCnnInstanceNormalizationGradientState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
		}
		return Runtime.GetNSObject<MPSCnnInstanceNormalizationGradientState>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTemporaryResultStateForCommandBuffer_SourceImage_SourceStates_DestinationImage_Handle, commandBuffer.Handle, sourceImage.Handle, sourceStates?.Handle ?? IntPtr.Zero, destinationImage.Handle));
	}

	[Export("reloadDataSource:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Please use 'ReloadGammaAndBetaFromDataSource' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Please use 'ReloadGammaAndBetaFromDataSource' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Please use 'ReloadGammaAndBetaFromDataSource' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadDataSource(IMPSCnnInstanceNormalizationDataSource dataSource)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadDataSource_Handle, dataSource.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadDataSource_Handle, dataSource.Handle);
		}
	}

	[Export("reloadGammaAndBetaWithCommandBuffer:gammaAndBetaState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadGammaAndBeta(IMTLCommandBuffer commandBuffer, MPSCnnNormalizationGammaAndBetaState gammaAndBetaState)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (gammaAndBetaState == null)
		{
			throw new ArgumentNullException("gammaAndBetaState");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_Handle, commandBuffer.Handle, gammaAndBetaState.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReloadGammaAndBetaWithCommandBuffer_GammaAndBetaState_Handle, commandBuffer.Handle, gammaAndBetaState.Handle);
		}
	}

	[Export("reloadGammaAndBetaFromDataSource")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadGammaAndBetaFromDataSource()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadGammaAndBetaFromDataSourceHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadGammaAndBetaFromDataSourceHandle);
		}
	}
}
