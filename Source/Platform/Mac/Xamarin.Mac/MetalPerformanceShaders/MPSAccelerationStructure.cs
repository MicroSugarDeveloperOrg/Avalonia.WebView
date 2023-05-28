using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSAccelerationStructure", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSAccelerationStructure : MPSKernel, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBox = "boundingBox";

	private static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle("boundingBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Group_ = "copyWithZone:group:";

	private static readonly IntPtr selCopyWithZone_Group_Handle = Selector.GetHandle("copyWithZone:group:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRefitToCommandBuffer_ = "encodeRefitToCommandBuffer:";

	private static readonly IntPtr selEncodeRefitToCommandBuffer_Handle = Selector.GetHandle("encodeRefitToCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroup = "group";

	private static readonly IntPtr selGroupHandle = Selector.GetHandle("group");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Group_ = "initWithCoder:group:";

	private static readonly IntPtr selInitWithCoder_Group_Handle = Selector.GetHandle("initWithCoder:group:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGroup_ = "initWithGroup:";

	private static readonly IntPtr selInitWithGroup_Handle = Selector.GetHandle("initWithGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRebuild = "rebuild";

	private static readonly IntPtr selRebuildHandle = Selector.GetHandle("rebuild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRebuildWithCompletionHandler_ = "rebuildWithCompletionHandler:";

	private static readonly IntPtr selRebuildWithCompletionHandler_Handle = Selector.GetHandle("rebuildWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsage_ = "setUsage:";

	private static readonly IntPtr selSetUsage_Handle = Selector.GetHandle("setUsage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsage = "usage";

	private static readonly IntPtr selUsageHandle = Selector.GetHandle("usage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSAccelerationStructure");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSAxisAlignedBoundingBox BoundingBox
	{
		[Export("boundingBox")]
		get
		{
			MPSAxisAlignedBoundingBox retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__MPSAxisAlignedBoundingBox_objc_msgSend_stret(out retval, base.Handle, selBoundingBoxHandle);
			}
			else
			{
				Messaging.xamarin_simd__MPSAxisAlignedBoundingBox_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingBoxHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSAccelerationStructureGroup Group
	{
		[Export("group")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSAccelerationStructureGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupHandle));
			}
			return Runtime.GetNSObject<MPSAccelerationStructureGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSAccelerationStructureStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSAccelerationStructureStatus)Messaging.UInt64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (MPSAccelerationStructureStatus)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSAccelerationStructureUsage Usage
	{
		[Export("usage", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSAccelerationStructureUsage)Messaging.UInt64_objc_msgSend(base.Handle, selUsageHandle);
			}
			return (MPSAccelerationStructureUsage)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUsageHandle);
		}
		[Export("setUsage:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetUsage_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetUsage_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSAccelerationStructure(NSCoder coder)
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
	protected MPSAccelerationStructure(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSAccelerationStructure(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSAccelerationStructure(IMTLDevice device)
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
	public MPSAccelerationStructure(NSCoder aDecoder, IMTLDevice device)
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

	[Export("initWithGroup:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSAccelerationStructure(MPSAccelerationStructureGroup group)
		: base(NSObjectFlag.Empty)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithGroup_Handle, group.Handle), "initWithGroup:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithGroup_Handle, group.Handle), "initWithGroup:");
		}
	}

	[Export("initWithCoder:group:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSAccelerationStructure(NSCoder aDecoder, MPSAccelerationStructureGroup group)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Group_Handle, aDecoder.Handle, group.Handle), "initWithCoder:group:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Group_Handle, aDecoder.Handle, group.Handle), "initWithCoder:group:");
		}
	}

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSAccelerationStructure Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSAccelerationStructure mPSAccelerationStructure = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSAccelerationStructure>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSAccelerationStructure>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSAccelerationStructure != null)
		{
			Messaging.void_objc_msgSend(mPSAccelerationStructure.Handle, Selector.GetHandle("release"));
		}
		return mPSAccelerationStructure;
	}

	[Export("copyWithZone:group:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSAccelerationStructure Copy(NSZone? zone, MPSAccelerationStructureGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		MPSAccelerationStructure mPSAccelerationStructure = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSAccelerationStructure>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Group_Handle, zone?.Handle ?? IntPtr.Zero, group.Handle)) : Runtime.GetNSObject<MPSAccelerationStructure>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Group_Handle, zone?.Handle ?? IntPtr.Zero, group.Handle)));
		if (mPSAccelerationStructure != null)
		{
			Messaging.void_objc_msgSend(mPSAccelerationStructure.Handle, Selector.GetHandle("release"));
		}
		return mPSAccelerationStructure;
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Encode(NSCoder coder)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, coder.Handle);
		}
	}

	[Export("encodeRefitToCommandBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRefit(IMTLCommandBuffer commandBuffer)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRefitToCommandBuffer_Handle, commandBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRefitToCommandBuffer_Handle, commandBuffer.Handle);
		}
	}

	[Export("rebuild")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Rebuild()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRebuildHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRebuildHandle);
		}
	}

	[Export("rebuildWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Rebuild([BlockProxy(typeof(Trampolines.NIDMPSAccelerationStructureCompletionHandler))] MPSAccelerationStructureCompletionHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMPSAccelerationStructureCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRebuildWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRebuildWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<MPSAccelerationStructure> RebuildAsync()
	{
		TaskCompletionSource<MPSAccelerationStructure> tcs = new TaskCompletionSource<MPSAccelerationStructure>();
		Rebuild(delegate(MPSAccelerationStructure? structure_)
		{
			tcs.SetResult(structure_);
		});
		return tcs.Task;
	}
}
