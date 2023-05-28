using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSImageArithmetic", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSImageArithmetic : MPSBinaryImageKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBias = "bias";

	private static readonly IntPtr selBiasHandle = Selector.GetHandle("bias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumValue = "maximumValue";

	private static readonly IntPtr selMaximumValueHandle = Selector.GetHandle("maximumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumValue = "minimumValue";

	private static readonly IntPtr selMinimumValueHandle = Selector.GetHandle("minimumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryScale = "primaryScale";

	private static readonly IntPtr selPrimaryScaleHandle = Selector.GetHandle("primaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInPixels = "primaryStrideInPixels";

	private static readonly IntPtr selPrimaryStrideInPixelsHandle = Selector.GetHandle("primaryStrideInPixels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryScale = "secondaryScale";

	private static readonly IntPtr selSecondaryScaleHandle = Selector.GetHandle("secondaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixels = "secondaryStrideInPixels";

	private static readonly IntPtr selSecondaryStrideInPixelsHandle = Selector.GetHandle("secondaryStrideInPixels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBias_ = "setBias:";

	private static readonly IntPtr selSetBias_Handle = Selector.GetHandle("setBias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumValue_ = "setMaximumValue:";

	private static readonly IntPtr selSetMaximumValue_Handle = Selector.GetHandle("setMaximumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumValue_ = "setMinimumValue:";

	private static readonly IntPtr selSetMinimumValue_Handle = Selector.GetHandle("setMinimumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryScale_ = "setPrimaryScale:";

	private static readonly IntPtr selSetPrimaryScale_Handle = Selector.GetHandle("setPrimaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInPixels_ = "setPrimaryStrideInPixels:";

	private static readonly IntPtr selSetPrimaryStrideInPixels_Handle = Selector.GetHandle("setPrimaryStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryScale_ = "setSecondaryScale:";

	private static readonly IntPtr selSetSecondaryScale_Handle = Selector.GetHandle("setSecondaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixels_ = "setSecondaryStrideInPixels:";

	private static readonly IntPtr selSetSecondaryStrideInPixels_Handle = Selector.GetHandle("setSecondaryStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSImageArithmetic");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Bias
	{
		[Export("bias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBiasHandle);
		}
		[Export("setBias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual float MaximumValue
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("maximumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumValueHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setMaximumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual float MinimumValue
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("minimumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumValueHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setMinimumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PrimaryScale
	{
		[Export("primaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPrimaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPrimaryScaleHandle);
		}
		[Export("setPrimaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPrimaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPrimaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSize PrimaryStrideInPixels
	{
		[Export("primaryStrideInPixels", ArgumentSemantic.Assign)]
		get
		{
			MTLSize retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLSize_objc_msgSend_stret(out retval, base.Handle, selPrimaryStrideInPixelsHandle);
			}
			else
			{
				Messaging.MTLSize_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPrimaryStrideInPixelsHandle);
			}
			return retval;
		}
		[Export("setPrimaryStrideInPixels:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLSize(base.Handle, selSetPrimaryStrideInPixels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLSize(base.SuperHandle, selSetPrimaryStrideInPixels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SecondaryScale
	{
		[Export("secondaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSecondaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSecondaryScaleHandle);
		}
		[Export("setSecondaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSecondaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSecondaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSize SecondaryStrideInPixels
	{
		[Export("secondaryStrideInPixels", ArgumentSemantic.Assign)]
		get
		{
			MTLSize retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLSize_objc_msgSend_stret(out retval, base.Handle, selSecondaryStrideInPixelsHandle);
			}
			else
			{
				Messaging.MTLSize_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSecondaryStrideInPixelsHandle);
			}
			return retval;
		}
		[Export("setSecondaryStrideInPixels:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLSize(base.Handle, selSetSecondaryStrideInPixels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLSize(base.SuperHandle, selSetSecondaryStrideInPixels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSImageArithmetic(NSCoder coder)
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
	protected MPSImageArithmetic(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSImageArithmetic(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSImageArithmetic(NSCoder aDecoder, IMTLDevice device)
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
}
