using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNNeuronGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnNeuronGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptor = "descriptor";

	private static readonly IntPtr selDescriptorHandle = Selector.GetHandle("descriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_Descriptor_ = "initWithSourceGradient:sourceImage:gradientState:descriptor:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_Descriptor_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_Descriptor_ = "nodeWithSourceGradient:sourceImage:gradientState:descriptor:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_Descriptor_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNNeuronGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNNeuronDescriptor Descriptor
	{
		[Export("descriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDescriptorHandle));
			}
			return Runtime.GetNSObject<MPSNNNeuronDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnNeuronGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnNeuronGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:descriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnNeuronGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, MPSNNNeuronDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_Descriptor_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, descriptor.Handle), "initWithSourceGradient:sourceImage:gradientState:descriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_Descriptor_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, descriptor.Handle), "initWithSourceGradient:sourceImage:gradientState:descriptor:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:descriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnNeuronGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, MPSNNNeuronDescriptor descriptor)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSCnnNeuronGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_Descriptor_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, descriptor.Handle));
	}
}
