using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIImageProcessorKernel", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class CIImageProcessorKernel : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyWithExtent_Inputs_Arguments_Error_ = "applyWithExtent:inputs:arguments:error:";

	private static readonly IntPtr selApplyWithExtent_Inputs_Arguments_Error_Handle = Selector.GetHandle("applyWithExtent:inputs:arguments:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatForInputAtIndex_ = "formatForInputAtIndex:";

	private static readonly IntPtr selFormatForInputAtIndex_Handle = Selector.GetHandle("formatForInputAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFormat = "outputFormat";

	private static readonly IntPtr selOutputFormatHandle = Selector.GetHandle("outputFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputIsOpaque = "outputIsOpaque";

	private static readonly IntPtr selOutputIsOpaqueHandle = Selector.GetHandle("outputIsOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessWithInputs_Arguments_Output_Error_ = "processWithInputs:arguments:output:error:";

	private static readonly IntPtr selProcessWithInputs_Arguments_Output_Error_Handle = Selector.GetHandle("processWithInputs:arguments:output:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoiForInput_Arguments_OutputRect_ = "roiForInput:arguments:outputRect:";

	private static readonly IntPtr selRoiForInput_Arguments_OutputRect_Handle = Selector.GetHandle("roiForInput:arguments:outputRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeInputs = "synchronizeInputs";

	private static readonly IntPtr selSynchronizeInputsHandle = Selector.GetHandle("synchronizeInputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIImageProcessorKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFormat OutputFormat
	{
		[Export("outputFormat")]
		get
		{
			return (CIFormat)Messaging.int_objc_msgSend(class_ptr, selOutputFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static bool OutputIsOpaque
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("outputIsOpaque")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selOutputIsOpaqueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SynchronizeInputs
	{
		[Export("synchronizeInputs")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selSynchronizeInputsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIImageProcessorKernel()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIImageProcessorKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIImageProcessorKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applyWithExtent:inputs:arguments:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage? Apply(CGRect extent, CIImage[]? inputs, NSDictionary<NSString, NSObject>? args, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = ((inputs == null) ? null : NSArray.FromNSObjects(inputs));
		CIImage nSObject = Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr_ref_IntPtr(class_ptr, selApplyWithExtent_Inputs_Arguments_Error_Handle, extent, nSArray?.Handle ?? IntPtr.Zero, args?.Handle ?? IntPtr.Zero, ref arg));
		nSArray?.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("formatForInputAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIFormat GetFormat(int input)
	{
		return (CIFormat)Messaging.int_objc_msgSend_int(class_ptr, selFormatForInputAtIndex_Handle, input);
	}

	[Export("roiForInput:arguments:outputRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CGRect GetRegionOfInterest(int input, NSDictionary<NSString, NSObject>? arguments, CGRect outputRect)
	{
		Messaging.CGRect_objc_msgSend_stret_int_IntPtr_CGRect(out var retval, class_ptr, selRoiForInput_Arguments_OutputRect_Handle, input, arguments?.Handle ?? IntPtr.Zero, outputRect);
		return retval;
	}

	[Export("processWithInputs:arguments:output:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Process(ICIImageProcessorInput[]? inputs, NSDictionary<NSString, NSObject>? arguments, ICIImageProcessorOutput output, out NSError error)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = ((inputs == null) ? null : NSArray.FromNSObjects(inputs));
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selProcessWithInputs_Arguments_Output_Error_Handle, nSArray?.Handle ?? IntPtr.Zero, arguments?.Handle ?? IntPtr.Zero, output.Handle, ref arg);
		nSArray?.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
