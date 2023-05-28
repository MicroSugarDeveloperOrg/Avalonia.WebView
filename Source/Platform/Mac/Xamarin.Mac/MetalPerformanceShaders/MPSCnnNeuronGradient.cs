using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNeuronGradient", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnNeuronGradient : MPSCnnGradientKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selA = "a";

	private static readonly IntPtr selAHandle = Selector.GetHandle("a");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selB = "b";

	private static readonly IntPtr selBHandle = Selector.GetHandle("b");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selC = "c";

	private static readonly IntPtr selCHandle = Selector.GetHandle("c");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_NeuronDescriptor_ = "initWithDevice:neuronDescriptor:";

	private static readonly IntPtr selInitWithDevice_NeuronDescriptor_Handle = Selector.GetHandle("initWithDevice:neuronDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeuronType = "neuronType";

	private static readonly IntPtr selNeuronTypeHandle = Selector.GetHandle("neuronType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNeuronGradient");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float A
	{
		[Export("a")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float B
	{
		[Export("b")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float C
	{
		[Export("c")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selCHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selCHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Data
	{
		[Export("data", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnNeuronType NeuronType
	{
		[Export("neuronType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnNeuronType)Messaging.int_objc_msgSend(base.Handle, selNeuronTypeHandle);
			}
			return (MPSCnnNeuronType)Messaging.int_objc_msgSendSuper(base.SuperHandle, selNeuronTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnNeuronGradient(NSCoder coder)
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
	protected MPSCnnNeuronGradient(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNeuronGradient(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:neuronDescriptor:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronGradient(IMTLDevice device, MPSNNNeuronDescriptor neuronDescriptor)
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
	public MPSCnnNeuronGradient(NSCoder decoder, IMTLDevice device)
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
