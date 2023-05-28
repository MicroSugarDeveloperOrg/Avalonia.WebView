using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNDefaultPadding", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNDefaultPadding : NSObject, IMPSNNPadding, INativeObject, IDisposable, INSCoding, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_ = "destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:";

	private static readonly IntPtr selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_Handle = Selector.GetHandle("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInverse = "inverse";

	private static readonly IntPtr selInverseHandle = Selector.GetHandle("inverse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingForTensorflowAveragePooling = "paddingForTensorflowAveragePooling";

	private static readonly IntPtr selPaddingForTensorflowAveragePoolingHandle = Selector.GetHandle("paddingForTensorflowAveragePooling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingForTensorflowAveragePoolingValidOnly = "paddingForTensorflowAveragePoolingValidOnly";

	private static readonly IntPtr selPaddingForTensorflowAveragePoolingValidOnlyHandle = Selector.GetHandle("paddingForTensorflowAveragePoolingValidOnly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingMethod = "paddingMethod";

	private static readonly IntPtr selPaddingMethodHandle = Selector.GetHandle("paddingMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaddingWithMethod_ = "paddingWithMethod:";

	private static readonly IntPtr selPaddingWithMethod_Handle = Selector.GetHandle("paddingWithMethod:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNDefaultPadding");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual MPSNNPaddingMethod PaddingMethod
	{
		[Export("paddingMethod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNPaddingMethod)Messaging.UInt64_objc_msgSend(base.Handle, selPaddingMethodHandle);
			}
			return (MPSNNPaddingMethod)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPaddingMethodHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNDefaultPadding(NSCoder coder)
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
	protected MPSNNDefaultPadding(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNDefaultPadding(IntPtr handle)
		: base(handle)
	{
	}

	[Export("paddingWithMethod:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNDefaultPadding Create(MPSNNPaddingMethod method)
	{
		return Runtime.GetNSObject<MPSNNDefaultPadding>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selPaddingWithMethod_Handle, (ulong)method));
	}

	[Export("paddingForTensorflowAveragePooling")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNDefaultPadding CreatePaddingForTensorflowAveragePooling()
	{
		return Runtime.GetNSObject<MPSNNDefaultPadding>(Messaging.IntPtr_objc_msgSend(class_ptr, selPaddingForTensorflowAveragePoolingHandle));
	}

	[Export("paddingForTensorflowAveragePoolingValidOnly")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNDefaultPadding CreatePaddingForTensorflowAveragePoolingValidOnly()
	{
		return Runtime.GetNSObject<MPSNNDefaultPadding>(Messaging.IntPtr_objc_msgSend(class_ptr, selPaddingForTensorflowAveragePoolingValidOnlyHandle));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageDescriptor GetDestinationImageDescriptor(MPSImage[] sourceImages, MPSState[]? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
	{
		if (sourceImages == null)
		{
			throw new ArgumentNullException("sourceImages");
		}
		if (kernel == null)
		{
			throw new ArgumentNullException("kernel");
		}
		if (inDescriptor == null)
		{
			throw new ArgumentNullException("inDescriptor");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceImages);
		NSArray nSArray2 = ((sourceStates == null) ? null : NSArray.FromNSObjects(sourceStates));
		MPSImageDescriptor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, kernel.Handle, inDescriptor.Handle)) : Runtime.GetNSObject<MPSImageDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, kernel.Handle, inDescriptor.Handle)));
		nSArray.Dispose();
		nSArray2?.Dispose();
		return result;
	}

	[Export("inverse")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSNNPadding? GetInverse()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSend(base.Handle, selInverseHandle), owns: false);
		}
		return Runtime.GetINativeObject<IMPSNNPadding>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInverseHandle), owns: false);
	}

	[Export("label")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLabel()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
	}
}
