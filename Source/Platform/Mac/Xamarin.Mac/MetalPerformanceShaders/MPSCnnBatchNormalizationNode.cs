using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNBatchNormalizationNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnBatchNormalizationNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlags = "flags";

	private static readonly IntPtr selFlagsHandle = Selector.GetHandle("flags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_DataSource_ = "initWithSource:dataSource:";

	private static readonly IntPtr selInitWithSource_DataSource_Handle = Selector.GetHandle("initWithSource:dataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_DataSource_ = "nodeWithSource:dataSource:";

	private static readonly IntPtr selNodeWithSource_DataSource_Handle = Selector.GetHandle("nodeWithSource:dataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlags_ = "setFlags:";

	private static readonly IntPtr selSetFlags_Handle = Selector.GetHandle("setFlags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNBatchNormalizationNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnBatchNormalizationFlags Flags
	{
		[Export("flags", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSCnnBatchNormalizationFlags)Messaging.UInt64_objc_msgSend(base.Handle, selFlagsHandle);
			}
			return (MPSCnnBatchNormalizationFlags)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selFlagsHandle);
		}
		[Export("setFlags:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetFlags_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetFlags_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnBatchNormalizationNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnBatchNormalizationNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:dataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnBatchNormalizationNode(MPSNNImageNode source, IMPSCnnBatchNormalizationDataSource dataSource)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSource_DataSource_Handle, source.Handle, dataSource.Handle), "initWithSource:dataSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_DataSource_Handle, source.Handle, dataSource.Handle), "initWithSource:dataSource:");
		}
	}

	[Export("nodeWithSource:dataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnBatchNormalizationNode Create(MPSNNImageNode source, IMPSCnnBatchNormalizationDataSource dataSource)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		return Runtime.GetNSObject<MPSCnnBatchNormalizationNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSource_DataSource_Handle, source.Handle, dataSource.Handle));
	}
}
