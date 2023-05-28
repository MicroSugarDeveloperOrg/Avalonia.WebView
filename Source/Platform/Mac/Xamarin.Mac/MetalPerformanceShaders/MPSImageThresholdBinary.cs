using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageThresholdBinary", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSImageThresholdBinary : MPSUnaryImageKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ThresholdValue_MaximumValue_LinearGrayColorTransform_ = "initWithDevice:thresholdValue:maximumValue:linearGrayColorTransform:";

	private static readonly IntPtr selInitWithDevice_ThresholdValue_MaximumValue_LinearGrayColorTransform_Handle = Selector.GetHandle("initWithDevice:thresholdValue:maximumValue:linearGrayColorTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumValue = "maximumValue";

	private static readonly IntPtr selMaximumValueHandle = Selector.GetHandle("maximumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThresholdValue = "thresholdValue";

	private static readonly IntPtr selThresholdValueHandle = Selector.GetHandle("thresholdValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransform = "transform";

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageThresholdBinary");

	public float[] Transform => MPSKernel.GetTransform(_Transform);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumValue
	{
		[Export("maximumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ThresholdValue
	{
		[Export("thresholdValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selThresholdValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selThresholdValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Transform
	{
		[Export("transform")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selTransformHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransformHandle);
		}
	}

	public unsafe MPSImageThresholdBinary(IMTLDevice device, float thresholdValue, float maximumValue, float[] transform)
		: base(NSObjectFlag.Empty)
	{
		fixed (float* ptr = transform)
		{
			InitializeHandle(InitWithDevice(device, thresholdValue, maximumValue, (IntPtr)ptr), "initWithDevice:thresholdValue:maximumValue:linearGrayColorTransform:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageThresholdBinary(NSCoder coder)
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
	protected MPSImageThresholdBinary(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageThresholdBinary(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageThresholdBinary(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithDevice:thresholdValue:maximumValue:linearGrayColorTransform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithDevice(IMTLDevice device, float thresholdValue, float maximumValue, IntPtr transform)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_float_float_IntPtr(base.Handle, selInitWithDevice_ThresholdValue_MaximumValue_LinearGrayColorTransform_Handle, device.Handle, thresholdValue, maximumValue, transform);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_float_IntPtr(base.SuperHandle, selInitWithDevice_ThresholdValue_MaximumValue_LinearGrayColorTransform_Handle, device.Handle, thresholdValue, maximumValue, transform);
	}
}
