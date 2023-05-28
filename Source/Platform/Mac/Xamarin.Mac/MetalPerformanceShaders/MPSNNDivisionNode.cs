using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNDivisionNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNDivisionNode : MPSNNBinaryArithmeticNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeftSource_RightSource_ = "initWithLeftSource:rightSource:";

	private static readonly IntPtr selInitWithLeftSource_RightSource_Handle = Selector.GetHandle("initWithLeftSource:rightSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSources_ = "initWithSources:";

	private static readonly IntPtr selInitWithSources_Handle = Selector.GetHandle("initWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNDivisionNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNDivisionNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNDivisionNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNDivisionNode(MPSNNImageNode[] sourceNodes)
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

	[Export("initWithLeftSource:rightSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNDivisionNode(MPSNNImageNode left, MPSNNImageNode right)
		: base(NSObjectFlag.Empty)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithLeftSource_RightSource_Handle, left.Handle, right.Handle), "initWithLeftSource:rightSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithLeftSource_RightSource_Handle, left.Handle, right.Handle), "initWithLeftSource:rightSource:");
		}
	}
}
