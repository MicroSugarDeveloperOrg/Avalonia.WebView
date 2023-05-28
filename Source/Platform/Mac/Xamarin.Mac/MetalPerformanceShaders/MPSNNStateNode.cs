using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNStateNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNStateNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportFromGraph = "exportFromGraph";

	private static readonly IntPtr selExportFromGraphHandle = Selector.GetHandle("exportFromGraph");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandle = "handle";

	private static readonly IntPtr selHandleHandle = Selector.GetHandle("handle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExportFromGraph_ = "setExportFromGraph:";

	private static readonly IntPtr selSetExportFromGraph_Handle = Selector.GetHandle("setExportFromGraph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHandle_ = "setHandle:";

	private static readonly IntPtr selSetHandle_Handle = Selector.GetHandle("setHandle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSynchronizeResource_ = "setSynchronizeResource:";

	private static readonly IntPtr selSetSynchronizeResource_Handle = Selector.GetHandle("setSynchronizeResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeResource = "synchronizeResource";

	private static readonly IntPtr selSynchronizeResourceHandle = Selector.GetHandle("synchronizeResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNStateNode");

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
	protected MPSNNStateNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNStateNode(IntPtr handle)
		: base(handle)
	{
	}
}
