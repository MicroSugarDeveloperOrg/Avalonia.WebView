using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNUpsamplingBilinear", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnUpsamplingBilinear : MPSCnnUpsampling
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_ = "initWithDevice:integerScaleFactorX:integerScaleFactorY:";

	private static readonly IntPtr selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_Handle = Selector.GetHandle("initWithDevice:integerScaleFactorX:integerScaleFactorY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_ = "initWithDevice:integerScaleFactorX:integerScaleFactorY:alignCorners:";

	private static readonly IntPtr selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle = Selector.GetHandle("initWithDevice:integerScaleFactorX:integerScaleFactorY:alignCorners:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNUpsamplingBilinear");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSCnnUpsamplingBilinear(NSCoder coder)
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
	protected MPSCnnUpsamplingBilinear(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnUpsamplingBilinear(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:integerScaleFactorX:integerScaleFactorY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnUpsamplingBilinear(IMTLDevice device, nuint integerScaleFactorX, nuint integerScaleFactorY)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(base.Handle, selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_Handle, device.Handle, integerScaleFactorX, integerScaleFactorY), "initWithDevice:integerScaleFactorX:integerScaleFactorY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint(base.SuperHandle, selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_Handle, device.Handle, integerScaleFactorX, integerScaleFactorY), "initWithDevice:integerScaleFactorX:integerScaleFactorY:");
		}
	}

	[Export("initWithDevice:integerScaleFactorX:integerScaleFactorY:alignCorners:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnUpsamplingBilinear(IMTLDevice device, nuint integerScaleFactorX, nuint integerScaleFactorY, bool alignCorners)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_bool(base.Handle, selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle, device.Handle, integerScaleFactorX, integerScaleFactorY, alignCorners), "initWithDevice:integerScaleFactorX:integerScaleFactorY:alignCorners:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_bool(base.SuperHandle, selInitWithDevice_IntegerScaleFactorX_IntegerScaleFactorY_AlignCorners_Handle, device.Handle, integerScaleFactorX, integerScaleFactorY, alignCorners), "initWithDevice:integerScaleFactorX:integerScaleFactorY:alignCorners:");
		}
	}
}
