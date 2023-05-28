using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixUnaryKernel", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSMatrixUnaryKernel : MPSKernel
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
	private const string selResultMatrixOrigin = "resultMatrixOrigin";

	private static readonly IntPtr selResultMatrixOriginHandle = Selector.GetHandle("resultMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchSize_ = "setBatchSize:";

	private static readonly IntPtr selSetBatchSize_Handle = Selector.GetHandle("setBatchSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBatchStart_ = "setBatchStart:";

	private static readonly IntPtr selSetBatchStart_Handle = Selector.GetHandle("setBatchStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResultMatrixOrigin_ = "setResultMatrixOrigin:";

	private static readonly IntPtr selSetResultMatrixOrigin_Handle = Selector.GetHandle("setResultMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceMatrixOrigin_ = "setSourceMatrixOrigin:";

	private static readonly IntPtr selSetSourceMatrixOrigin_Handle = Selector.GetHandle("setSourceMatrixOrigin:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceMatrixOrigin = "sourceMatrixOrigin";

	private static readonly IntPtr selSourceMatrixOriginHandle = Selector.GetHandle("sourceMatrixOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixUnaryKernel");

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
	public virtual MTLOrigin SourceMatrixOrigin
	{
		[Export("sourceMatrixOrigin", ArgumentSemantic.Assign)]
		get
		{
			MTLOrigin retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLOrigin_objc_msgSend_stret(out retval, base.Handle, selSourceMatrixOriginHandle);
			}
			else
			{
				Messaging.MTLOrigin_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSourceMatrixOriginHandle);
			}
			return retval;
		}
		[Export("setSourceMatrixOrigin:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_MTLOrigin(base.Handle, selSetSourceMatrixOrigin_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_MTLOrigin(base.SuperHandle, selSetSourceMatrixOrigin_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixUnaryKernel(NSCoder coder)
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
	protected MPSMatrixUnaryKernel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixUnaryKernel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixUnaryKernel(IMTLDevice device)
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
	public MPSMatrixUnaryKernel(NSCoder aDecoder, IMTLDevice device)
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
