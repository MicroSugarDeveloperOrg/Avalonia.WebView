using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNConcatenationNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNConcatenationNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSources_ = "initWithSources:";

	private static readonly IntPtr selInitWithSources_Handle = Selector.GetHandle("initWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSources_ = "nodeWithSources:";

	private static readonly IntPtr selNodeWithSources_Handle = Selector.GetHandle("nodeWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNConcatenationNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNConcatenationNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNConcatenationNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNConcatenationNode(MPSNNImageNode[] sourceNodes)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNodes == null)
		{
			throw new ArgumentNullException("sourceNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceNodes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSources_Handle, nSArray.Handle), "initWithSources:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSources_Handle, nSArray.Handle), "initWithSources:");
		}
		nSArray.Dispose();
	}

	[Export("nodeWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNConcatenationNode Create(MPSNNImageNode[] sourceNodes)
	{
		if (sourceNodes == null)
		{
			throw new ArgumentNullException("sourceNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceNodes);
		MPSNNConcatenationNode nSObject = Runtime.GetNSObject<MPSNNConcatenationNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithSources_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
