using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNImageNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNImageNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportFromGraph = "exportFromGraph";

	private static readonly IntPtr selExportFromGraphHandle = Selector.GetHandle("exportFromGraph");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportedNodeWithHandle_ = "exportedNodeWithHandle:";

	private static readonly IntPtr selExportedNodeWithHandle_Handle = Selector.GetHandle("exportedNodeWithHandle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormat = "format";

	private static readonly IntPtr selFormatHandle = Selector.GetHandle("format");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandle = "handle";

	private static readonly IntPtr selHandleHandle = Selector.GetHandle("handle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageAllocator = "imageAllocator";

	private static readonly IntPtr selImageAllocatorHandle = Selector.GetHandle("imageAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithHandle_ = "initWithHandle:";

	private static readonly IntPtr selInitWithHandle_Handle = Selector.GetHandle("initWithHandle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithHandle_ = "nodeWithHandle:";

	private static readonly IntPtr selNodeWithHandle_Handle = Selector.GetHandle("nodeWithHandle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExportFromGraph_ = "setExportFromGraph:";

	private static readonly IntPtr selSetExportFromGraph_Handle = Selector.GetHandle("setExportFromGraph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFormat_ = "setFormat:";

	private static readonly IntPtr selSetFormat_Handle = Selector.GetHandle("setFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHandle_ = "setHandle:";

	private static readonly IntPtr selSetHandle_Handle = Selector.GetHandle("setHandle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageAllocator_ = "setImageAllocator:";

	private static readonly IntPtr selSetImageAllocator_Handle = Selector.GetHandle("setImageAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStopGradient_ = "setStopGradient:";

	private static readonly IntPtr selSetStopGradient_Handle = Selector.GetHandle("setStopGradient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSynchronizeResource_ = "setSynchronizeResource:";

	private static readonly IntPtr selSetSynchronizeResource_Handle = Selector.GetHandle("setSynchronizeResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopGradient = "stopGradient";

	private static readonly IntPtr selStopGradientHandle = Selector.GetHandle("stopGradient");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeResource = "synchronizeResource";

	private static readonly IntPtr selSynchronizeResourceHandle = Selector.GetHandle("synchronizeResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNImageNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExportFromGraph
	{
		[Export("exportFromGraph")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selExportFromGraphHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selExportFromGraphHandle);
		}
		[Export("setExportFromGraph:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExportFromGraph_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExportFromGraph_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImageFeatureChannelFormat Format
	{
		[Export("format", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selFormatHandle);
			}
			return (MPSImageFeatureChannelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFormatHandle);
		}
		[Export("setFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSImageAllocator ImageAllocator
	{
		[Export("imageAllocator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageAllocatorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSImageAllocator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageAllocatorHandle), owns: false);
		}
		[Export("setImageAllocator:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageAllocator_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageAllocator_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSHandle? MPSHandle
	{
		[Export("handle", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selHandleHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHandleHandle), owns: false);
		}
		[Export("setHandle:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHandle_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHandle_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual bool StopGradient
	{
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("stopGradient")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selStopGradientHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStopGradientHandle);
		}
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("setStopGradient:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStopGradient_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStopGradient_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual bool SynchronizeResource
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("synchronizeResource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSynchronizeResourceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSynchronizeResourceHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("setSynchronizeResource:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSynchronizeResource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSynchronizeResource_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNImageNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNImageNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithHandle:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNImageNode(IMPSHandle? handle)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithHandle_Handle, handle?.Handle ?? IntPtr.Zero), "initWithHandle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithHandle_Handle, handle?.Handle ?? IntPtr.Zero), "initWithHandle:");
		}
	}

	[Export("nodeWithHandle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNImageNode Create(IMPSHandle? handle)
	{
		return Runtime.GetNSObject<MPSNNImageNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithHandle_Handle, handle?.Handle ?? IntPtr.Zero));
	}

	[Export("exportedNodeWithHandle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNImageNode GetExportedNode(IMPSHandle? handle)
	{
		return Runtime.GetNSObject<MPSNNImageNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selExportedNodeWithHandle_Handle, handle?.Handle ?? IntPtr.Zero));
	}
}
