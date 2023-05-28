using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNeuronPReLU", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnNeuronPReLU : MPSCnnNeuron
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_A_Count_ = "initWithDevice:a:count:";

	private static readonly IntPtr selInitWithDevice_A_Count_Handle = Selector.GetHandle("initWithDevice:a:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_NeuronDescriptor_ = "initWithDevice:neuronDescriptor:";

	private static readonly IntPtr selInitWithDevice_NeuronDescriptor_Handle = Selector.GetHandle("initWithDevice:neuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNeuronPReLU");

	public override IntPtr ClassHandle => class_ptr;

	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Please use '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Please use '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Please use '.ctor (IMTLDevice, MPSNNNeuronDescriptor)' overload instead.")]
	public unsafe MPSCnnNeuronPReLU(IMTLDevice device, float[] a)
		: this(NSObjectFlag.Empty)
	{
		fixed (float* ptr = a)
		{
			void* ptr2 = ptr;
			InitializeHandle(InitWithDevice(device, (IntPtr)ptr2, (nuint)a.Length));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnNeuronPReLU(NSCoder coder)
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
	protected MPSCnnNeuronPReLU(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNeuronPReLU(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:neuronDescriptor:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronPReLU(IMTLDevice device, MPSNNNeuronDescriptor neuronDescriptor)
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

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronPReLU(NSCoder aDecoder, IMTLDevice device)
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
	internal IntPtr InitWithDevice(IMTLDevice device, IntPtr a, nuint count)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selInitWithDevice_A_Count_Handle, device.Handle, a, count);
	}
}
