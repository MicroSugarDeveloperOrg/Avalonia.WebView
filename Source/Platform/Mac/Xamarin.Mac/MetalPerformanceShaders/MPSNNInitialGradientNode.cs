using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNInitialGradientNode", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSNNInitialGradientNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_ = "nodeWithSource:";

	private static readonly IntPtr selNodeWithSource_Handle = Selector.GetHandle("nodeWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNInitialGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNInitialGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNInitialGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNInitialGradientNode(MPSNNImageNode source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, source.Handle), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, source.Handle), "initWithSource:");
		}
	}

	[Export("nodeWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNInitialGradientNode Create(MPSNNImageNode source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<MPSNNInitialGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithSource_Handle, source.Handle));
	}
}
