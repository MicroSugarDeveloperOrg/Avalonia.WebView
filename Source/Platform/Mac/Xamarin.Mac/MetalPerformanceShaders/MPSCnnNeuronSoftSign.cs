using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNeuronSoftSign", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnNeuronSoftSign : MPSCnnNeuron
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_NeuronDescriptor_ = "initWithDevice:neuronDescriptor:";

	private static readonly IntPtr selInitWithDevice_NeuronDescriptor_Handle = Selector.GetHandle("initWithDevice:neuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNeuronSoftSign");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnNeuronSoftSign(NSCoder coder)
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
	protected MPSCnnNeuronSoftSign(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNeuronSoftSign(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Please use '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Please use '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Please use '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronSoftSign(IMTLDevice device)
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

	[Export("initWithDevice:neuronDescriptor:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronSoftSign(IMTLDevice device, MPSNNNeuronDescriptor neuronDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (neuronDescriptor == null)
		{
			throw new ArgumentNullException("neuronDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_NeuronDescriptor_Handle, device.Handle, neuronDescriptor.Handle), "initWithDevice:neuronDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_NeuronDescriptor_Handle, device.Handle, neuronDescriptor.Handle), "initWithDevice:neuronDescriptor:");
		}
	}
}
