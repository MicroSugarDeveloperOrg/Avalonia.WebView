using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixBinaryKernel", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSMatrixBinaryKernel : MPSKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchSize = "batchSize";

	private static readonly IntPtr selBatchSizeHandle = Selector.GetHandle("batchSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBatchStart = "batchStart";

	private static readonly IntPtr selBatchStartHandle = Selector.GetHandle("batchStart");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimarySourceMatrixOrigin = "primarySourceMatrixOrigin";

	private static readonly IntPtr selPrimarySourceMatrixOriginHandle = Selector.GetHandle("primarySourceMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultMatrixOrigin = "resultMatrixOrigin";

	private static readonly IntPtr selResultMatrixOriginHandle = Selector.GetHandle("resultMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondarySourceMatrixOrigin = "secondarySourceMatrixOrigin";

	private static readonly IntPtr selSecondarySourceMatrixOriginHandle = Selector.GetHandle("secondarySourceMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchSize_ = "setBatchSize:";

	private static readonly IntPtr selSetBatchSize_Handle = Selector.GetHandle("setBatchSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchStart_ = "setBatchStart:";

	private static readonly IntPtr selSetBatchStart_Handle = Selector.GetHandle("setBatchStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimarySourceMatrixOrigin_ = "setPrimarySourceMatrixOrigin:";

	private static readonly IntPtr selSetPrimarySourceMatrixOrigin_Handle = Selector.GetHandle("setPrimarySourceMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultMatrixOrigin_ = "setResultMatrixOrigin:";

	private static readonly IntPtr selSetResultMatrixOrigin_Handle = Selector.GetHandle("setResultMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondarySourceMatrixOrigin_ = "setSecondarySourceMatrixOrigin:";

	private static readonly IntPtr selSetSecondarySourceMatrixOrigin_Handle = Selector.GetHandle("setSecondarySourceMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixBinaryKernel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BatchSize
	{
		[Export("batchSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatchSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatchSizeHandle);
		}
		[Export("setBatchSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBatchSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBatchSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BatchStart
	{
		[Export("batchStart")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBatchStartHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBatchStartHandle);
		}
		[Export("setBatchStart:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetBatchStart_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetBatchStart_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin PrimarySourceMatrixOrigin
	{
		[Export("primarySourceMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selPrimarySourceMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPrimarySourceMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setPrimarySourceMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetPrimarySourceMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetPrimarySourceMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin ResultMatrixOrigin
	{
		[Export("resultMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selResultMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selResultMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setResultMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetResultMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetResultMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLOrigin SecondarySourceMatrixOrigin
	{
		[Export("secondarySourceMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selSecondarySourceMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSecondarySourceMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setSecondarySourceMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetSecondarySourceMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetSecondarySourceMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixBinaryKernel(NSCoder coder)
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
	protected MPSMatrixBinaryKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixBinaryKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixBinaryKernel(IMTLDevice device)
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

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixBinaryKernel(NSCoder aDecoder, IMTLDevice device)
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
