using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNInstanceNormalizationNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnInstanceNormalizationNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_DataSource_ = "initWithSource:dataSource:";

	private static readonly IntPtr selInitWithSource_DataSource_Handle = Selector.GetHandle("initWithSource:dataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_DataSource_ = "nodeWithSource:dataSource:";

	private static readonly IntPtr selNodeWithSource_DataSource_Handle = Selector.GetHandle("nodeWithSource:dataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNInstanceNormalizationNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnInstanceNormalizationNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnInstanceNormalizationNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:dataSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnInstanceNormalizationNode(MPSNNImageNode source, IMPSCnnInstanceNormalizationDataSource dataSource)
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
	public static MPSCnnInstanceNormalizationNode Create(MPSNNImageNode source, IMPSCnnInstanceNormalizationDataSource dataSource)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		return Runtime.GetNSObject<MPSCnnInstanceNormalizationNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithSource_DataSource_Handle, source.Handle, dataSource.Handle));
	}
}
